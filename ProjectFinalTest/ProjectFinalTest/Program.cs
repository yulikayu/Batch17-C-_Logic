using System;

namespace ProjectFinalTest // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ProjectFinalTest.Funsii.InisoalNosatu();
            //Console.WriteLine(ProjectFinalTest.Funsii.Faktorial(5));
            //Console.WriteLine(ProjectFinalTest.Funsii.IniNomorTiga(8));
            //Console.WriteLine(ProjectFinalTest.Funsii.KurungKurawal(k));
            string satu;
            string dua;

            

             //Console.WriteLine(ProjectFinalTest.Funsii.KurungKurawal(k));

            Console.WriteLine(ProjectFinalTest.Funsii.fibbonanci(9));


            //ProjectFinalTest.Funsii.ShowFibboNanci(5);






            //Bagian Nomor 10

            /*   A a = new A();
               B b=new B();
               C c=new C();*/

            for (int i = 0; i < 5; i++)
            {
                int n = 10;
                for (int j = i; j < 5; j++)
                {
                    Console.Write($"{n}\t");
                    n--;

                }
                Console.WriteLine();
            }

            Console.WriteLine();


            ProjectFinalTest.Funsii.NosepiluhBagiansatu(5);
            int[,] arr = new int[5, 5];
            arr = ProjectFinalTest.Funsii.NosepiluhBagiansatu(5);
            ProjectFinalTest.Funsii.tampilMatriks(arr);



            Console.ReadKey();
        }
    }
}