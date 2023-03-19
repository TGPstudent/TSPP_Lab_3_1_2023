//TSPP_Lab_3_1_2023 Робота з текстом.
using System;
using System.Text;

namespace TSPP_Lab_3_1_2023
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.InputEncoding = System.Text.Encoding.Unicode;

            Console.Write("\nВведiть текстовий рядок: ");
            string Text = Console.ReadLine();
            string[] words = Text.Split(new Char[] { ' ', ',', '.', ':', ';', '-' });

            Console.Clear();

            Console.WriteLine("\n Ви задали наступний текстовий рядок: ");
            Console.WriteLine(" " + Text);
            Console.WriteLine("\n Завдання а) помiняти мiсцями першу i останню лiтери кожного слова;");
            Console.WriteLine("\n УВАГА! Цифри, розділові знаки та однобуквові сполучники видалені з тексту \n до його опрацювання. Їх не можливо перетворити за заданим правилом");

            StringBuilder Rez_a = new StringBuilder();
            foreach (string s in words)
            {
                if (s.Trim() != "" && char.IsLetter(s[0]) && s.Length > 1)
                {
                    char Let1 = s[0];
                    char Let2 = s[(s.Length - 1)];
                    Rez_a.Append(Let2 + s.Substring(1, s.Length - 2) + Let1 + " ");
                }
            }
            Console.Write("\n Пiсля опрацювання слова тексту мають наступний вигляд:\n ");
            Console.WriteLine(Rez_a + "\n");

            Console.WriteLine("\n Завдання б) видалити всi слова, що починаються з малої лiтери.\n");
            Console.Write(" Вилучено слова: ");

            StringBuilder Rez_b = new StringBuilder(Text);
            foreach (string s in words)
            {
                if (s.Trim() != "" && char.IsLetter(s[0]) && char.IsLower(s[0]))
                {
                    if (s.Length > 1) Rez_b.Replace(s, "");
                    else Rez_b.Replace((" " + s + " "), "");
                    if (s.Trim() != "" && char.IsLower(s[0])) Console.Write(s + "; ");
                }
            }
            Console.Write("\n Пiсля перетворення рядок має вигляд: ");
            Console.WriteLine(Rez_b);
            Console.ReadLine();
        }
    }
}
