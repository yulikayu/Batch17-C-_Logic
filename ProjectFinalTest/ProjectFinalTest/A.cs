using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalTest
{
    internal class A
    {
        string a = null;

        public A(string a)
        {
            this.a = a;
        }

        public string Aa { get => a; set => a = value; }

        public override string? ToString()
        {
            return $"A says {this.a}";
        }

       
    }
}
