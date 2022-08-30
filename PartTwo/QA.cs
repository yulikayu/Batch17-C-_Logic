using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingguKe4OOP.PartTwo
{
    internal class QA : Employee
    {
        private decimal makan = 0M;


        public QA(int empID, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city ,decimal makan) 
            : base(empID, firstName, lastName, joinDate, basicSalary, city)
        {
            this.makan = makan;
            TotalSalary1 = basicSalary + makan;
            this.Role = "QA";
        }

        public decimal Makan { get => makan; set => makan = value; }
        public override string ToString()
        {
            return $"{base.ToString()} | Makan  = {this.makan.ToString("C", new CultureInfo("id-ID"))} ";
        }
    }
}
