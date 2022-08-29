using System;

namespace QuisDay3Array // Note: actual namespace depends on the project name.
{
    internal class Program
    {

        public static int[] BuatArray(int k)
        {
            
            int[] arr = new int[k];


            Random random = new Random();
            for (int i = 0; i < k; i++)
            {
                arr[i] = random.Next(0, 11);
            }
            return arr;

        }
        public static void TamppilArray(int[] arr)
        {
            foreach (var item in arr)
            {
                Console.Write($"{item} ");
            }
        }
        //dua Array satu dimensi
        public static int[] IniNomorDua(int[] arr)
        {
            int[] arr1 = new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (i < arr.Length - 1)
                {
                    arr1[i + 1] = arr[i];
                }
                else
                {
                    arr1[0] = arr[i];
                }


            }

            return arr1;
        }
        //Satu Array satu dimensi
        public static int[] iniNomorsatu(int[] n)
        {
           

            int[] arr = new int[n.Length];
            int[] arr1 = n;

            Random random = new Random();
            for (int i = 0; i < n.Length; i++)
            {
                /*int j = random.Next(0, 40);
                int temp = arr1[i];
                arr1[i] = arr[j];
                arr[j] = temp;*/

                arr[i]=n[random.Next(0, n.Length)-1];
            }




            return arr;
        }
        //tiga Array satu dimensi
        public static int[] IniNomorTiga(int [] arr)
        {
            int []arr1=new int[arr.Length];
            for (int l = 0; l < arr.Length; l++)
            {
                arr[l] = arr1[l];
                arr1[l] = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    if (i < arr.Length - 1)
                    {
                        arr1[i + 1] = arr[i];
                    }
                    else
                    {
                        arr1[0] = arr[i];
                    }
                   

                }


            }
            return arr1;
        }
        //nomor tujuh
        public static int[] HapusDuplicate(int[] arr)
        {
            int count = 0;
            int[] hasil=new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (hasil.Contains(arr[i]) == false)
                {
                    hasil[i] = arr[i];

                }
                else
                {
                    count++;
                }
              
            }
            Array.Resize(ref hasil, hasil.Length - count);
            return hasil;

        }
        //nomor enam
        public static int[] MinusUntukDuplikat(int[] arr)
        {
            int[] hasil = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                if (hasil.Contains(arr[i]) == false)
                {
                    hasil[i] = arr[i];
                }
                else
                {
                    hasil[i] = -1;
                }

            }
            
            return hasil;

        }

        public static void TampilDoang(int[,] mate)
        {
            int[,] mat = new int[mate.GetLength(0), mate.GetLength(1)];

            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    if (i == j)
                    {
                        mat[i, j] = 5 - i;
                    }
                    else if (i > j)
                    {
                        mat[i, j] = 10;
                    }
                    else
                    {
                        mat[i, j] = 20;
                    }

                }

            }
            Matrix.DisplayMatriks(mat);


        }

        public static void SumDiagonal(int[,] mat, int[,] mate)
        {
            int[,] sum = new int[mat.Length,mat.Length ];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLongLength(1); j++)
                {
                    if (i == j)
                    {
                        sum [i, j] = mat[i,j]+mate[i,j];
                    }
                    else if (i > j)
                    {
                        mat[i, j] = 10;
                    }
                    else
                    {
                        mat[i, j] = 20;
                    }

                }

            }
            Matrix.DisplayMatriks(sum);

        }

        public static int SumAjalahYul(int[,] mat)
        {
            int sum=0;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i == j)
                    {
                       sum +=mat[i,j];
                    }
                    

                }

            }
            return sum;
        }
        //Nomor 11
        public static int[,] JumlahIndeks(int[,] mat)
        {
            int k = mat.GetLength(1) - 1;
            int[,] baru=new int[mat.GetLength(0), mat.GetLength(1)];
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {

                    if (i == 0 || j == 0|| j == k  || i ==k )
                    {
                        baru[i, j] = i + j;
                    }

                }

            }
            return baru;
        }
        //nomor 12
        public static int[,] IniNomorDuaBelas(int[,] mat)
        {
            int k = mat.GetLength(0) - 1;
            int sum = 0;
            int s = 0;
            int[,] baru = new int[mat.GetLength(0), mat.GetLength(1)];
            int[,] bar = new int[mat.GetLength(0), mat.GetLength(1)];

            for (int i = 0; i < mat.GetLength(0); i++)
            {
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if(i<k && j < k)
                    {
                        baru[i, j] = i + j;
                    }
                   
                }

            }
            bar = baru;
            for (int i = 0; i < mat.GetLength(0); i++)
            {
                //sum = 0;
                for (int j = 0; j < mat.GetLength(1); j++)
                {
                    if (i != k && j != k)
                    {
                        sum += baru[i, j];
                        bar[k,i] = bar[i, k] = sum;
                        if (i == j)
                        {
                            s += baru[i, j];
                            bar[k, k] = s;
                        }
                        if (j == k - 1)
                        {
                            sum = 0;
                        }
                        


                    }
                    /*else
                    {
                        // sum = 0;
                        s += baru[i, j];
                        bar[k, k] = s;

                    }*/
                    /*if (i == j)
                    {
                        sum += baru[i, j];
                        bar[k, k] = sum;
                    }
                    else if (j == k || i == k)
                    {
                        sum += baru[i, j];
                        baru[i, j] = sum;
                    }*/

                }

            }
            return bar;
        }

        public static void IniNomorLima()
        {
            int[] arr = { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };
            Array.Sort(arr);
            int hitung = 0;
            int[] dua= new int[arr.Length];

            for (int i = 0; i < arr.Length; i++)
            {
                if (dua.Contains(arr[i]) == true)
                {
                    hitung ++;
                    Console.WriteLine($"Angka {arr[i]} muncul {hitung} kali");
                }
            }
        }

        
        static void Main(string[] args)
        {
           /* Console.Write("Masukkan panjang array 2 dimensi \t");
            int p=Convert.ToInt32(Console.ReadLine());
            int[,] satu = Matrix.FillRandomMatrix(p, p);*/

            /*var Mymatrikss = Matrix.FillRandomMatrix(5, 5);
            Matrix.DisplayMatriks(Mymatrikss);

            //Matrix.MatrixDiagonal(Mymatrikss);
            //Matrix.MatrixDiagonal(5,5);

            Console.WriteLine();
            var Mymat = Matrix.MatrixDiagonal(5, 5);
            Matrix.DisplayMatriks(Mymat);


               Console.WriteLine();*/
            /*
            int[,] satu = Matrix.FillRandomMatrix(5, 5);
            int [,]dua=Matrix.FillRandomMatrix(5, 5);

            Matrix.DisplayMatriks(satu);
            Console.WriteLine("Ini \n");
            Matrix.DisplayMatriks(dua);
            Console.WriteLine("Ini \n");
            SumDiagonal(satu, dua);
            */


            //Matrix.DisplayMatriks(satu);

            // Console.WriteLine();
            //Console.WriteLine($"ini adalah jumlah { SumAjalahYul(satu)}");

            //JumlahIndeks(satu);
            // Console.WriteLine();
             //Matrix.DisplayMatriks(JumlahIndeks(satu));


            //TampilDoang();


            // Matrix.DisplayMatriks(IniNomorDuaBelas(satu));

            int[] arr = { 1,2,3,2,7,7,1,6,3,4,5,2,3,6,8,9 };
            //HapusDuplicate(arr);
            /*  var tmp = MinusUntukDuplikat(arr);
              TamppilArray(tmp);*/

            //int [] dua = new int[arr.Length];
            //int[] arr = { 1, 2, 3, 2, 7, 7, 1, 6, 3, 4, 5, 2, 3, 6, 8, 9 };
            


            Console.ReadKey();

            
        }
    }
}