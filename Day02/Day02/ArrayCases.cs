using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day02
{
    internal class ArrayCases
    {
        public static void IntroArray()
        {
            //Deklarasi Array dengana tipe integer
            int[] arr;
            int[] arrInt = new int[5];
            arrInt[0] = 12;
            arrInt[1] = 13;
            arrInt[2] = 14;
            arrInt[3] = 15;
            arrInt[4] = 16;
            //arrInt[5] = 17;


            // int Array with String data type
            string[] listOfGirl = new string[] { "Yuli", "Rini", "Widi" };

            //Display Array
            foreach (var item in listOfGirl)
            {
                Console.WriteLine($"{item}");
            }


            for (int i = 0; i < listOfGirl.Length; i++)
            {
                Console.WriteLine(listOfGirl[i]);
            }
        }


        //Method return or fucntion untuk memasukkan array int 

        public  static int[] IntArrayInt(int[] arr)
        {

            int[] array = arr;

            return array;
        }

        //Menampilkan Array
        public static void TamppilArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }

        //initial value with random
        public static int[] InitialArrayRandom(int n)
        {
            int [] arr =new int[n];
            Random rend = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rend.Next(0,50);
            }

            return arr;

        }
        //Sum all Array Element
        public static double SumNumber(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum+= arr[i];
            }

            return sum;
        }

        public static int FindLargesElement (int [] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    max = arr[i];
                }
            }

            return max;
        }
        
    }

}
