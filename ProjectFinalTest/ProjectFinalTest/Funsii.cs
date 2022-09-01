namespace ProjectFinalTest
{
    class Funsii
    {
        public static void InisoalNosatu()
        {
            Console.Write("Masukkan Posisi Kata sekarang \t:");
            int x= Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Jarak Yang bisa ditempuh katak dalam satu lompatan  :");
            int k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Masukkan Jarak Yang ingin dilalui Katak   :");
            int y = Convert.ToInt32(Console.ReadLine());
       
            int jlhLompat = 0;
            int f = x;

            while (f<y)
            {
                f += k;  
                jlhLompat++;
            }
            Console.WriteLine($"Jumlah Lompatah  ' {jlhLompat}' untuk menuju ke  {y}");

        }
        // Belum
        public static int Faktorial( int n)
        {
            int k = n;
            int jumlah = 1;
            int i = 1;

            while (i <= k)
            {
                jumlah = jumlah * n;
                i++;
                n--;
               
            }

            return jumlah;
        }

        public static int IniNomorTiga(int n)
        {
            int jumlah = 0;
            int i=1;
            while (i <= n)
            {
                jumlah += i;
                i++;
            }
            
            return jumlah;
        }

        public static int fibbonanci(int n)
        {

            int  jumlah =1, f, i = 0;
            while (i <= n)
            {
                f = jumlah + i;
                i = jumlah;
                jumlah = f;

            }

            return i;
        }

        public static void ShowFibboNanci(int n)
        {
            fibbonanci(n);
            for(int i = 0; i < n; i++)
            {
                Console.WriteLine($"{fibbonanci(i)}");
            }
        }
        public static int UbahKeAscii(string kata)
        {
            int j = 0;
            string beda;
            beda=kata.ToLower();

            foreach (var item in beda)
            {
                j += System.Convert.ToInt32(item);
            }
            return j;
        }

        public static bool IsAnagram(string satu,string dua)
        {
            // bool n=false;
            int s, d;
            s= UbahKeAscii(satu);
            d= UbahKeAscii(dua);
            if (s == d)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static bool KurungKurawal( string satu)
        {
            int f = (satu.Length)%2;
            int m = (satu.Length) / 2;
            int k;
            int kurung = 248;
            k=UbahKeAscii(satu);

            if(f % 2 == 1)
            {
                return false;
            }
            else
            {
               if(m * kurung == k)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            

            return true;
        }


        public static int[,] NosepiluhBagiansatu(int n)
        {
            int[,] arr = new int[n, n];

            for (int i = 0; i <arr.GetLength(0); i++)
            {
                int k = 10;
                for (int j = i; j < arr.GetLength(1); j++)
                {
                    arr[i, j] = k;
                    k--;
                }
               
            }
            return arr;

            
        }

        public static void tampilMatriks(int[,] arr)
        {
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    Console.Write($"{arr[i, j]}\t");
                }
                Console.WriteLine();
            }
        }
    }
}

