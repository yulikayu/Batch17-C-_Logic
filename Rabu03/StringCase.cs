using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fundamental.Rabu03
{
    internal class StringCase
    {
        public static void StringsCase()
        {
            //substring
            string word = "Code Academy bootcamp";
            string cutWord=word.Substring(5, 7);
            Console.WriteLine(cutWord);
            Console.WriteLine($"{word} lenght ={word.Length}");
            Console.WriteLine($"{word.Replace("Code", "Codeid")}");

            String cutAcademy = word.Substring(word.IndexOf("bootcamp"), 7);
            Console.WriteLine($"cutAcademy :{cutAcademy}");
        }

        public static string ReversesString(string word)
        {
            string reverse = "";
            char[] chars = word.ToCharArray();
            reverse = reverse + chars.ElementAt(1);
            reverse += reverse + chars.ElementAt(2);
            //reverse += reverse + chars.ElementAt(3);

            return reverse;
        }

        public static StringBuilder ReverseStringBuilder(string word)
        {
            StringBuilder sb = new StringBuilder();
            char[] chars = word.ToCharArray();
            sb.Append(chars.ElementAt(2));
            sb.Append(chars.ElementAt(1));
            sb.Append(chars.ElementAt(0));

            return sb;
        }
    }
}
