using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OPPMinggu2Vol2
{
    internal class LinQ
    {
       public static void IntroLinq()
        {
            int[] number = new int[] { 98, 99, 200, 95, 97, 95, 80, 28, 23, 99 ,2019};
            var sum = number.Sum(x => x++);
            Console.WriteLine($" Sum :{sum}");

            var min = number.Min();
            Console.WriteLine($"MIN : {min}");
            var max = number.Max();
            Console.WriteLine($"MAX : {max}");

            var duplicatest = number.Distinct();
            foreach (var item in duplicatest)
            {
                Console.WriteLine(item);
            }
        }
        
    }
}
