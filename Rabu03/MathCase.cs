using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fundamental.Rabu03
{
    internal class MathCase
    {
        /* 
         Case 1: input bulangan 3 digit lalu konversi ke dolar
        input : 75000, out punt : Rp 50 = 10, Rp 10=0, Rp 5=1
         */

        public static void ATM()
        {
            int digit1, digit2, digit3, sisa;
            Console.Write("Enter Money :");
            int number = Convert.ToInt32(Console.ReadLine());
            digit1 = number / 50_000;
            sisa = number % 50_000;
            digit2 = sisa / 10_0000;
            sisa = sisa % 10_000;
            digit3 = sisa / 5_000;
            sisa = sisa % 5_000;

            Console.WriteLine($"Rp 50rb ={digit1}, Rp 10rb{digit2},Rp 5rb {sisa}");
        }

        public static void sumDigit()
        {
            int d1, d2, d3, r;
            Console.Write("Masukkan 4 digit angka :");
            int number = Convert.ToInt32(Console.ReadLine());

            d1 = number / 1000;
            r = number % 1000;
            d2 = r / 100;
            r = r % 100;
            d3 = r / 10;
            r = r % 10;

            int sum = d1 + d2 + d3 + r;
            Console.WriteLine("Total Sum :"+sum);
        }

        public static void reverseDigit()
        {
            int d1, d2, d3, r;
            Console.Write("Masukkan 4 digit angka :");
            int number = Convert.ToInt32(Console.ReadLine());

            d1 = number / 1000;
            r = number % 1000;
            d2 = r / 100;
            r = r % 100;
            d3 = r / 10;
            r = r % 10;

            string reverse = r + "" + d3 + "" + d2 + "" + d1;
            Console.WriteLine("Reverse" + reverse);
            Console.WriteLine($"Reverse {reverse}");
            Console.WriteLine($"{r} {d3} {d2} {d1}");
        }

        /*
         Fizzbuzz
        kelipatan 3 dan 5 uotput Fizzbuzz
        kelipatan 3 output fizz
        kelipatan 5 output buzz
        not 3&5 output number
         */

        public static void Fizzbuzz(int n)
        {
            for (int i = 1; i <=n; i++)
            {
                if ((i % 3 == 0) && (i % 5 == 0))
                    Console.WriteLine("Fizzbuzz");
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else
                    Console.WriteLine($"{i}");

            }
        }   

        public static int Prima(int n)
        {

            for (int i = 2; i < n/2; i++)
            {

                if (n % i == 0)

                    return 0;
            }
            return n;

        }


        public static bool isPrima(int n)
        {
            for (int i = 2; i <= n/2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }




    }
}
