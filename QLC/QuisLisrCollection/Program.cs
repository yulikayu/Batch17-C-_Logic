using System;
using System.Collections;

namespace QuisArrayCollection // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public static void TampilhashSet(HashSet<int> satu)
        {
            foreach (int i in satu)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void TampilhashString(HashSet<string> satu)
        {
            foreach (string i in satu)
            {
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
        public static void  JoinNilaiYangsama(HashSet<int > satu, HashSet<int> dua)
        {
            HashSet<int> hasil= new HashSet<int>(satu);
            hasil.IntersectWith(dua);
            Console.WriteLine("Ini adalah Irisan Dua Buah array");

            TampilhashSet(hasil);
            
        }

        public static void MergeDuaHashSet(HashSet<int> satu, HashSet<int> dua)
        {
            HashSet<int> hasil = new HashSet<int>(satu);
            hasil.UnionWith(dua);
            Console.WriteLine("Ini Adalah Penggabuang dua HashSet");
            TampilhashSet(hasil);
            

        }

        public static void IsiYangTidaksama(HashSet<int> satu, HashSet<int> dua)
        {
            HashSet<int> hasil = new HashSet<int>(satu);
            hasil.ExceptWith(dua);
            Console.WriteLine("Ini Adalah isi Nilai Yang tidak sama");

            TampilhashSet(hasil);
        }

        public static void IsiYangDan(HashSet<int> satu, HashSet<int> dua)
        {
            HashSet<int> hasil = new HashSet<int>(satu);
            hasil.SymmetricExceptWith(dua);
            Console.WriteLine("Ini Adalah isi Nilai Tidak sama A dan B");

            TampilhashSet(hasil);
        }
        public static void tampilListString (List <string> list)
        {
            foreach (string s in list)
            {
                Console.Write($"{s} ");
            }
        }
        public static void tampilListIntK(List<int> list)
        {
            
            Console.WriteLine(String.Join(' ', list));
        }

        public static List<T> kebalikan<T>(List<T> list)
        {
            var myList = new List<T>();
            myList.Reverse();
           
            return myList;

        }
        public static string Reverse(string text)
        {
            char[] cArray = text.ToCharArray();
            string reverse = String.Empty;
            for (int i = cArray.Length - 1; i > -1; i--)
            {
                reverse += cArray[i];
            }
            return reverse;
        }
        //bagian nomor 6 dan 7
        public static List<int> MasukJasilist(string nama)
        {
            List<int> lt = new List<int>();
            //Reverse(nama);
            int n =int.Parse(Reverse(nama));
            int d1, d2, d3, r = 0;
        
            d1 = n / 1000;
            r = n % 1000;
            d2 = r / 100;
            r = r % 100;
            d3 = r / 10;
            r = r % 10;

            lt.Add(d1);
            lt.Add(d2);
            lt.Add(d3);
            lt.Add(r);


            return lt;
        }
        public static List<T> RemoveDuplicate<T>(List<T> list)
        {
            List<T> lt = new List<T>();

            Console.WriteLine(String.Join(' ', list));

            for (int i = 0; i < list.Count; i++)
            {
                if (lt.Contains(list[i]) == false)
                {
                    lt.Add(list[i]);
                }

            }

            return lt;

        }

        public static void SatukanList(List<string> satu, List<string> dua)
        {
            List<string> hasil=new List<string>(satu);
            hasil.Union(dua);
            Console.WriteLine();
            tampilListString(hasil);

        }
        public static void YangBedaDariList(List<string> satu, List<string> dua)
        {
            List<string> hasil = new List<string>(satu);
            hasil.Except(dua);
            Console.WriteLine();
            tampilListString(hasil);

        }
        public static void JoinDuaList(List<string> satu, List<string> dua)
        {
            List<string> hasil = new List<string>(satu);
            hasil.Intersect(dua);
            Console.WriteLine();
            tampilListString(hasil);

        }

        public static void SymentrikWithList(List<string> satu, List<string> dua)
        {
            var hasil = satu.ToHashSet();
            hasil.SymmetricExceptWith(dua);
            Console.WriteLine();
            TampilhashString(hasil);

            
        }
        //bagian nomor 6 dan 7
        public static List<int> ListAdidition(List<int> var1, List<int> var2)
        {
            List<int> lt = new List<int>();
            //var s = var1.ConvertAll(x=>x.);
            for (int i = 0; i < var2.Count; i++)
            {
                lt.Add(var1[i]+var2[i]);
            }


            return lt;
        }
        public static void sumDigit()
        {
            int d1, d2, d3, r=0;
            Console.Write("Masukkan 4 digit angka :");
            int number = Convert.ToInt32(Console.ReadLine());

            d1 = number / 1000;
            r = number % 1000;
            d2 = r / 100;
            r = r % 100;
            d3 = r / 10;
            r = r % 10;

            int sum = d1 + d2 + d3 + r;
            Console.WriteLine($"{d1},{d2},{d3},{r}");
        }
       



        static void Main(string[] args)
        {
           /* var hs1 = new HashSet<int>() { 1,2,5,6,9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var result1 = new HashSet<int>(hs1);
            Console.WriteLine("Ini Array Pertama");
            TampilhashSet(hs1);
            Console.WriteLine("\nIni Array Kedua");
            TampilhashSet(hs2);
            JoinNilaiYangsama(hs1, hs2);
            MergeDuaHashSet(hs1, hs2);
            IsiYangTidaksama(hs1, hs2);
            IsiYangDan(hs1, hs2);
            var alfabeth = new List<string> { "A", "B", "C", "D", "E","C","A","B"};

            Console.WriteLine("Ini adalah kebalikan");
            var Number = new List<int>() { 1,2,3,4,5};

           Console.WriteLine();
         
            Number.Reverse();
           // tampilListInt(Number);*/

            List<int> list = new List<int> { 7,2,7,1,2,5,7,1};
            //Console.WriteLine($" Ini apa coba :{list.Count}");
            //list.Sort();
            List<int> lt = new List<int>();
            List<int> lt2 = new List<int>();

            List<int> Noem = new List<int> { 7, 2, 7, 1, 2, 5, 7, 1 };

            /*

                        Console.WriteLine(String.Join(' ', list));

                        for (int i = 0; i < list.Count; i++)
                        {
                            if (lt.Contains(list[i]) == false)
                            {
                                lt.Add(list[i]);
                            }

                        }
                        Console.WriteLine(String.Join(' ', lt));

            */
            //tampilListIntK(RemoveDuplicate(list));
            //list.Sort();
            /*
                        for (int i = 0; i < Noem.Count; i++)
                        {
                            if (lt.Contains(Noem[i]) == false)
                            {
                                lt.Add(Noem[i]);
                            }
                            else
                            {
                                lt2.Add(Noem[i]);
                            }
                        }
                        lt2.Sort();
                        Console.WriteLine(String.Join(' ', lt2));
            */
            /*
                        List<string> a1 = new List<string> { "Mangga", "Aple", "Melon", "Pisang", "Sirsak", "Tomat", "Nanas", "Nangka", "Timun", "Mangga" };
                        List<string> a2 = new List<string> { "Bayam", "Wortel", "Kangkung", "Mangga", "Tomat", "Kembang Kol", "Nangka", "Timun" };
                           string[] apa;
                        List<string> a3 = new List<string>(a1);

                        foreach (var item in a1)
                        {
                            Console.Write($"{item}\t");
                        }
                        Console.WriteLine();
                        foreach (var item in a2)
                        {
                            Console.Write($"{item}\t");
                        }
                        Console.WriteLine();


                        *//*      
                              a3.Intersect(a2);
                              foreach (var item in a3)
                              {
                                  Console.Write($"{item}\t");
                              }*//*
                        Console.WriteLine("\nSysmensss");
                        SymentrikWithList(a1, a2);
                        Console.WriteLine("\nSatukan");
                        SatukanList(a1, a2);
                        Console.WriteLine("\nJoin");
                        JoinDuaList(a1, a2);
                        Console.WriteLine("\nYang beda");
                        YangBedaDariList(a1, a2);*/


            //sumDigit();

            List<int> lt3 = new List<int>();

            /* sumDigit();
             Console.Write("String\t");
             string nama=Console.ReadLine();
             Console.WriteLine(Reverse(nama));*/

            /* int d1, d2, d3, r = 0;
             Console.Write("Masukkan 4 digit angka :");
             int number = Convert.ToInt32(Console.ReadLine());

             d1 = number / 1000;
             r = number % 1000;
             d2 = r / 100;
             r = r % 100;
             d3 = r / 10;
             r = r % 10;

             int sum = d1 + d2 + d3 + r;*/


            //int n=int.Parse(nama);

            //Console.WriteLine($"{n +1}");
            /*Console.WriteLine("Ini adalah list");
            tampilListIntK(lt3);
*/


            //Ini nomor 6 dan 7
            /* Console.Write("Masukkan 4 digit angka\t");
             string nama = Console.ReadLine();
             Console.Write("Masukkan 4 digit angka\t");
             string nama1 = Console.ReadLine();

             Console.WriteLine("LIst satu");
             MasukJasilist(nama);
             lt3= MasukJasilist(nama);
             tampilListIntK(lt3);

             Console.WriteLine("LIst dua");
             MasukJasilist(nama1);
             lt = MasukJasilist(nama1);
             tampilListIntK(lt);


             ListAdidition(lt3, lt);
             Console.WriteLine("Hasil");
             tampilListIntK(ListAdidition(lt3, lt));
 */
            List<int> SoalNo6 = new List<int>() { 1,1,1,2,2,2,3,3,3,4,4 };

            List<string> str = new List<string>();
            



        }

        
    }
}