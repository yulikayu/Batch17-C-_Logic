using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingguKe4OOP.PartOne
{
    internal class Programmer :Employee
    {
        private decimal transportasi;

        public Programmer(int empID, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, 
            decimal transportasi) : base(empID, firstName, lastName, joinDate, basicSalary, city)
        {
            this.Transportasi = transportasi;
            this.Role = "Programmer";
            TotalSalary1 = basicSalary + transportasi;
            
        }



        public decimal Transportasi { get => transportasi; set => transportasi = value; }


        
        public override string ToString()
        {
            return $"{base.ToString()} | TJ Transportasi  = {this.transportasi.ToString("C",new CultureInfo("id-ID"))} ";
        }
    }
}
