using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingguKe4OOP.PartOne
{
    internal class Sales : Employee
    {
        
        private decimal bonus;
        private decimal commision;

        public Sales(int empID, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, decimal bonus, decimal commision) : base(empID, firstName, lastName, joinDate, basicSalary, city)
        {
            this.bonus = bonus;
            this.commision = commision;
            this.Role = "SALES";
            TotalSalary1 = basicSalary + commision + bonus;
        }

        public decimal Bonus { get => bonus; set => bonus = value; }
        public decimal Commision { get => commision; set => commision = value; }


        public override string ToString()
        {
            return $"{base.ToString()}| Bonus = {this.bonus.ToString("C", new CultureInfo("id-ID"))}| Commisi = {this.commision.ToString("C", new CultureInfo("id-ID"))} ";
        }
    }
}
