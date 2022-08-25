namespace Day01
{
    class Iterator
    {
        //01
        public static void ShowOddEventNumber()
        {
            for (int i = 1; i < 11; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine($"{i} adlaah bilangan Genap");
                }
                else
                {
                    Console.WriteLine($"{i} adlaah bilangan Genap");
                }
            }
        }

        public static void ShowBox()
        {
            //cetak baris
            for (int i = 0; i < 5; i++)
            {
                //cetak kolom
                for (int j = 0; j < 5; j++)
                {
                    Console.Write($"{i}\t");
                }
                Console.WriteLine();
            }
        }
        public static void showLeftTriangle()
        {
            for (int i = 0; i <=5; i++)
            {
                for (int j  = 0; j  < i; j ++)
                {
                    Console.Write((i + j) + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void showRightTriangle()
        {
            int n = 5;
            for (int i = 0; i < n; i++)
            {
                for (int j = i; j < n-1; j++)
                {
                    Console.Write("\t");

                }
                for (int j = 1; j <=i; j++)
                {
                    Console.Write((i + 1) + "\t");
                }
                Console.WriteLine();
            }
        }

        public static void showContinueStat()
        {
            for (int i = 0; i < 10; i++)
            {
                if (i%2==0)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
        }

        public static void ShowWhileDo()
        {
            int i = 0;
            while (i <= 20)
            {
                Console.WriteLine("Iteration : " + i);
                i++;
                if (i == 10)
                    break;
            }
        }

        public static void showDoWhile()
        {
            int i = 0;
            do
            {
                Console.WriteLine($"{i}");
                i++;
            } while (i <= 10);
        }
    }
}

