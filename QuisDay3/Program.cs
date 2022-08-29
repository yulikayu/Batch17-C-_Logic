using System;

namespace QuisDay3// Note: actual namespace depends on the project name.
{


    internal class Program
    {
        public static void Tampil(int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine(i);
            }
        }

        public static void priima(int n)
        {
            for (int i = 2; i < n / 2; i++)
            {
                if (i % 2 == 0)
                    Console.Write("");
                else
                    Console.Write(i);

            }
        }

        public static int isPrima(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return 0;
            }
            return n;
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
            Console.WriteLine("Total Sum :" + sum);
        }
        //udah
        public static void SumNilai()
        {
            int d1, r;
            Console.Write("Masukkan Angka  :");
            int number = Convert.ToInt32(Console.ReadLine());
            var temp = number.ToString();
            int jumlah = 0;

            for (int i = 0; i < temp.Length; i++)
            {

                //Console.WriteLine(temp[i]);
                var k = (int)temp[i];
                jumlah += k;
            }
            Console.WriteLine($"Hasil {jumlah}");
        }

        //udah
        public static void jumlahNilai()
        {
            int j = 0;
            Console.Write("Masukkan Angka  :");
            int number = Convert.ToInt32(Console.ReadLine());
            while (number != 0)
            {
                j = j + number % 10;
                number = number / 10;
            }
            Console.WriteLine($"Hasil {j}");

        }

       
        //udah
        public static void JumlahDigit()
        {
            int d1, r=0;
            Console.Write("Masukkan Angka  :");
            int number = Convert.ToInt32(Console.ReadLine());
            
            while(number != 0)
            {
                number = number / 10;
                r += 1;
            }
            Console.Write($"Count : {r}");
        }
       

        public static bool iniPrima(int n)
        {
            for (int i = 2; i <= n / 2; i++)
            {
                if (n % i == 0)
                    return false;
            }
            return true;
        }


        public static void Balikk()
        {
            int d1, r = 0;
            Console.Write("Masukkan Angka  :");
            int number = Convert.ToInt32(Console.ReadLine());
            var temp = ((char)number);
            var tm = new char[100];
    
            while (number != 0)
            {
                number = number / 10;
                r += 1;
            }

            for (int i = 0; i < r; i++)
            {
                tm[i] = temp;
                r--;
            }
            Console.WriteLine($"Hasil {tm} ");

        }
        //udah
        public static void DeretPrima()
        {
            int  ul, sisa, jumlah;
            
            Console.Write("Bilangan :");
            int bil= Convert.ToInt32(Console.ReadLine());
            for(int i = 0; i < bil; i++)
            {
                jumlah = 0;
                for (int j = 1; j<=i; j++)
                {
                    if (i % j == 0)
                    {
                        jumlah++;
                    }

                }
                if (jumlah == 2)
                    Console.Write($"{i}  ");
            }

        }
        //udah
        public static void FaktorisasiBil()
        {
            Console.Write("Masukkan Nilai\t=");
            int nilai = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= nilai/2; i++)
            {
                if (nilai % i == 0)
                    Console.Write($" {i}");
            }
        }
        //udah
        public static void CheckParlindom()
        {
            string kata;
            int n, i;
            Console.WriteLine("Masukkan Kata\t :");
            kata = Console.ReadLine();
            n = kata.Length;

            for (i = 0; i < n; i++)
            {
                if (kata[i] == kata[n - i - 1])
                {
                    Console.WriteLine("Parlindom");
        
                }
                else
                    Console.WriteLine("Bukan");

            }

            
        }
        //udah
        public static void TerbesarKeDua()
        {

            int jumlah = 0;
            Console.Write("Masukkan Angka \t:");
            int angka = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < angka - 1; i++)
            {
                jumlah++;
            }

            Console.Write($"Keluar {jumlah}");
        }
        //udah
        public static void GuessNumbers()
        {
            Console.WriteLine("Guess magic number between 0-20 : ");

            Random random = new Random();
            int number = random.Next(0, 20);

            int guess = -1;

            while (guess != number)
            {
                Console.WriteLine("Enter your guess ?");
                var input = Console.ReadLine();
                int.TryParse(input, out guess);

                // cek kondisi
                if (guess == number)
                {
                    Console.WriteLine($"Tebakan kamu benar, angka yang ditebak {guess}");
                    Console.WriteLine($"Tebak lagi?");
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.Y)
                    {
                        Console.WriteLine("\n");
                        GuessNumbers();
                    }
                    else if (key.Key == ConsoleKey.N)
                    {
                        Console.WriteLine("\n");
                        Console.WriteLine("Your Quit");
                        break;
                    }
                }
                else if (
                    guess > number)
                {
                    Console.WriteLine($"Your guess is too high");
                }
                else
                {
                    Console.WriteLine($"Your guess is too low");
                }



            }
        }
        //udah
        public static void TekanNolJikaIngiKeluar()
        {
            int max, n , numb;
            max = 0;
            //Console.WriteLine("Masukkan banyak nomor");
            //n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i <= 5; i++)
            {
                Console.Write("Masukkan Nilai [Ketik 0 untuk keluar]  ");
                numb = Convert.ToInt32(Console.ReadLine());

                if (numb > max)
                {
                    max = numb;
                }
                else if (numb  == 0)
                {
                    Console.Write($" Nilai terbesar {max}");
                    break;
                }
            }
        }
        //udah
        public static void KonsonanVokal()
        {
            string nama;
            Console.Write("Masukkan Kalimat\t");
            nama = Console.ReadLine();
            string tmp = nama.ToLower();
            int jln = 0, km = 0;

            string klll;
            for (int i = 0; i < nama.Length; i++)
            {
                klll = tmp[i].ToString();
                if (klll == "a" || klll == "i" || klll == "u" || klll == "e" || klll == "o")
                {
                    jln++;
                }
                else
                    km++;
            }

            Console.WriteLine($"Jumlah huruf Vokal = {jln}  Jumlah Huruf Konsonan ={km}");
        }
        public static void Vowel()
        {
            Console.Write("Enter string : ");
            string kalimat = Console.ReadLine();
            kalimat.ToLower();
            int jumlahKata = 1;
            string kata = "";

            for (int i = 0; i < kalimat.Length; i++)
            {
                kata = kalimat[i].ToString();
                if (kata == "")
                {
                    jumlahKata++;
                }
                Console.WriteLine($"Total Words : {jumlahKata}");
            }
        }

        public static void tanggal()
        {
            DateTime now = DateTime.Now;

            int day = now.Day;
            int month = now.Month;
            int year = now.Year;
            int hour = now.Hour;
            int minute = now.Minute;
            int second = now.Second;
            DateTime tomorrow = now;
            TimeSpan dateDifference = tomorrow - now;
            int daysRemaining = dateDifference.Days;


            Console.WriteLine($" Sekarang {DateTime.Now.ToShortDateString()}");
            Console.WriteLine($"selisih : {daysRemaining}");


        }

        public static void nomorLimaBelas()
        {
            int max, n=0, numb;
            max = 0;
            //Console.WriteLine("Masukkan banyak nomor");
            //n = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i >= 5; i++)
            {
                Console.Write("Masukkan Nilai [Ketik 0 untuk keluar]  ");
                numb = Convert.ToInt32(Console.ReadLine());
                if (numb > max)
                {
                    n = max;
                    max = numb;

                }
                else if (numb < n)
                {

                    if (numb < max)
                    {
                        n = numb;

                    }
                    else
                    {
                        n = n;
                    }
                    max = max;
                }
                
            }
            Console.WriteLine($"Nilai terbesar kedua :\t{n}:");
        }
    

        static void Main(string[] args)
        {
            FaktorisasiBil();
            Console.ReadKey();
           
        }
    }
}