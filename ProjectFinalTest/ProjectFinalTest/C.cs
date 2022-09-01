using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalTest
{
    internal class C :B
    {
        string c = null;

        public C(string a, string b, string c) : base(a, b)
        {
            this.c = c;
        }

        public string Cc { get => c; set => c = value; }

        

        void doC()
        {
            Console.WriteLine($"C sayas {Aa}  {Bb}  {Cc}");
        }
    }
}
