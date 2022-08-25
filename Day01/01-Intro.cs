namespace Day01
{
    class Intro
    {
        public static void showConsole()
        {
            Console.WriteLine("Hello, World!");
            //1. create normal text
            Console.WriteLine("Yuli Ayu Cantik");
            //2. concat
            Console.WriteLine("Code Academy" + "Bootcamp NET");
            // 3. 
            Console.WriteLine("Code Academi \n Cool .Net");

            //4
            Console.WriteLine("I love Programing \"C#\"");
            //5 
            Console.WriteLine("Greek alphabeth for B :\u30B2");
            //6
            Console.WriteLine("D:\\yuli\\C#\\01-Fundamental\\");

            //7 Verbatin
            Console.WriteLine(@" Bootcam .NET with CodeID Academy
Location Sentul City
Bogor
");
            /* Dengan adanya simbol @ membuat kita tidak membutuhkan yang namanya \n */
            Console.WriteLine("a) Java");
            Console.WriteLine("b) C#");
            Console.WriteLine("c) golang");

            //9 formatted number
            Console.WriteLine("Temperatur on {0:D} is {1}C ", DateTime.Today, 36.5);
        }
    }

}
