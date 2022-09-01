using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectFinalTest
{
    internal class B :A
    {
        string b = null;

        public B(string a, string b) : base(a)
        {
            this.b = b;
        }

        public string Bb { get => b; set => b = value; }

        public override string? ToString()
        {
            return $"B says {this.b}";
        }
    }
}
