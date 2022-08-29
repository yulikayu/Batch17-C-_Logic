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


            /*      
                  a3.Intersect(a2);
                  foreach (var item in a3)
                  {
                      Console.Write($"{item}\t");
                  }*/
            Console.WriteLine("\nSysmensss");
            SymentrikWithList(a1, a2);
            Console.WriteLine("\nSatukan");
            SatukanList(a1, a2);
            Console.WriteLine("\nJoin");
            JoinDuaList(a1, a2);
            Console.WriteLine("\nYang beda");
            YangBedaDariList(a1, a2);



        }
    }
}