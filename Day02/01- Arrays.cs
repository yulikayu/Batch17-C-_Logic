namespace Day02
{
    class Arrays
    {
        // initial array
        public static void InitialArrays()
        {
            int[] arr = new int[2];
            arr[0] = 1;
            arr[1] = 2;

            int[] arr2 = new int[] {2,4,5,7};
            int[] arr3 = { 10, 12, 45, 55 };

            double[] arr4 = new double[2];
            arr4[0] = 34.5;

            string[] arr5 = { "fatur", "Nova", "Yuli", "Jeremy" };

            DisplayArrayInt(arr2);
            Console.WriteLine();
            DisplayArrayString(arr5);
            Console.WriteLine();
            var sum =SumAllElement(arr3);
            Console.WriteLine($"Total Array : {sum}");

            //Find Largest
            var arr6 = new[] { 1, 54, 78, 90, 3, 56, 79 };
            var besar = BilanganPalingBesar(arr6);
            Console.WriteLine($"Bilangan Paling besar {besar}");
            var kecil = BilanganPalingKecil(arr6);
           // Console.WriteLine($"Bilangan Paling kecil {kecil}");
        }

        //copy array 
        public static void CopyingArray()
        {
            int[] sourceArray = { 1, 2, 4, 5, 11, 13 };
            int[] targetArray = new int[sourceArray.Length];

            //copy array by looping
            //targetArray[i]=sourceArray[i]; dengan cara ini mengubah ke memory juga
            /*  for (int i = 0; i < sourceArray.Length; i++)
              {
                  targetArray[i]=sourceArray[i];
              }*/
            //cara 2
            Array.Copy(sourceArray, targetArray, sourceArray.Length); 
            DisplayArrayInt(targetArray);
           // diaplay
           Array.Sort(targetArray);
           
        }

        //fill element array dengan menggunakan nilai random
        public static void FillRandomArray()
        {
            Random random = new Random();
            // mengisi dengan nilai int
            var listint = new int[100];
            for (int i = 0; i < listint.Length; i++)
            {
                listint[i] = random.Next(0,100);
            }
            //DisplayArrayInt(listint);

            // fill random with char 'a' -'z'
            char[] charArray = new char[100];
            for (int i = 0; i < charArray.Length; i++)
            {
                charArray[i] = (char)random.Next('a','z');
            }
            DisplayArrayChar(charArray);
            
 

        }

        public static int BilanganPalingKecil(int[] arr)
        {
            int kecil=0;
            for (int i = 0; i < arr.Length; i++)
            {
             
            }

            return kecil;

        }

        //finding larges element
        public static int BilanganPalingBesar(int[] arr)
        {
            int besar = 0;
            for (int i = 0; i < arr.Length; i++)
            {   
                //melakukan pengechekan
                if(arr[i] > besar)
                {
                    besar = arr[i]; 
                }
            }

            return besar;

        }


        //sum all element array
        public static Double SumAllElement(int[] arr)
        {
            double sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }


            return sum;
        }

        public static void DisplayArrayInt(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");


            }
        }

        public static void DisplayArrayString(string[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");


            }
        }
        public static void DisplayArrayChar(char[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write($"{arr[i]} ");


            }
        }




    }
}