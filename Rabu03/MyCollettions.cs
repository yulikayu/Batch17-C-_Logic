using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Fundamental.Rabu03
{
    internal class MyCollettions
    {
        public static void IntList()
        {
            var alfabeth = new List<string> { "A", "B", "C", "D", "E" };
            alfabeth.Add("F");
            alfabeth.AddRange(new[] { "G", "H", "I" });
            alfabeth.Insert(0, "J");
            alfabeth.InsertRange(3, new[] { "X", "Y" });

            foreach(var item in alfabeth)
            {
                Console.Write($"{item} ");
            }

            //remove elemet from list<T>

            alfabeth.Remove("x");
            alfabeth.RemoveRange(4, 6);


            //deklarasi List<int>

            var number = new List<int> { 2, 3, 4, 6, 11, 23, 43, 56, 12, 45 };
            number.Add(68);
            number.Remove(23);
            number.RemoveAll(v => v >= 7);

            //find element dalam list
            var a = number.Find(e => e < 10);
            var B= number.FindLast(e => e < 11);

        }

        public static void InitStack()
        {
            var numbers = new Stack<int>(new int[] { 1, 2, 3, 4, 5, 6 });
            numbers.Push(5);
            numbers.Push(7);


            //remove pop
            numbers.Pop();
            var n = numbers.Peek();
            numbers.Clear();
        }

        public static void InitDuctionary()
        {
            var pl=new Dictionary<int, string >();
            pl.Add(1, "#C");
            pl.Add(2, "Java");

            var p12 = new Dictionary<int, string>
            {
                {1,"#C" },
                {2,"Java" },
                {3,"Python" }

            };


            // add new elemenr
            p12.Add(4, "Golang");
            p12.Add(5, "SQL");


            Console.WriteLine();


            foreach (var item in p12)
            {
                Console.WriteLine($"{item.Key } {item.Value}");    
            }

            Console.WriteLine();
        }


        public static void IntHashSet()
        {
            HashSet<int> numbers = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, };
            numbers.Add(18);
            numbers.Add(90);
            numbers.Add(28);

            var hs1 = new HashSet<int>() { 1, 2, 3, 4, 5, 6, 9 };
            var hs2 = new HashSet<int>() { 1, 2, 3, 4 };
            var result1 = new HashSet<int>(hs1);
            result1.IntersectWith(hs2); //inner join 

            var result2 = new HashSet<int>(hs1);
            result2.UnionWith(hs2);

            var result3 = new HashSet<int>(hs1);
            result3.ExceptWith(hs2);

            var result4= new HashSet<int>(hs1);
            result4.SymmetricExceptWith(hs2);


            //conversi hashset to list
            var myNumber = result4.ToList();


            Console.WriteLine();
        }

        public static void IntQueue()
        {
            var queue = new Queue<string>();
            queue.Enqueue("assepp");
            queue.Enqueue("Budi");
            queue.Enqueue("Chaelie");

            Console.WriteLine($"  Queue from front yo back");
            foreach(var item in queue)
            {
                Console.WriteLine();
            }
            string served = queue.Dequeue();

            Console.WriteLine($" Served : {served}");
        }


        //return List <T>


        public static List<T> GetStudent<T>(ref List <T> list)
        {
            var myList = new List<T>();
            foreach(var item in list)
            {
                myList.Add(item);
            }

            return myList;
        
        }

       

    }
}
