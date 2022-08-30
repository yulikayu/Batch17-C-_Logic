using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingguKe4OOP.PartTwo
{
    internal class Employee
    {   
        //instan variabel >> bisa kita isi kalau uda run
        private int empID;
        private string firstName;
        private string lastName;
        private DateTime joinDate;
        private Decimal basicSalary;
        private string city;
        private string role;
        private decimal TotalSalary;
        //Static variable
        public static int totalEmployee =0M;
        public static decimal totalbasicSalary = 0M;
        // ini milik sebuah kelas bukan variable manapun bukan juga milik objek, bisa juga disebut sebagai global variabel
        // yang ruang lingkupnya didalam kelas

        //empty /default construktor
        public Employee()
        {
            totalEmployee++;
            totalbasicSalary += this.basicSalary;
            this.TotalSalary= this.basicSalary;
        }

        //construktor parameter
        public Employee(int empID, string firstName, string lastName, DateTime joinDate, decimal basicSalary)
        {
           /* "this" mengarak kepada  instan variabel, this.empId mengarah kepada 
            instan variable, sedangkan empID ke pada konstruktor para meter
            */
            this.empID = empID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            totalEmployee++;
            this.TotalSalary = this.basicSalary;
            totalbasicSalary += this.basicSalary;

        }

        //overload Construktor
        public Employee(int empID, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city)
        {
            this.empID = empID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            this.city = city;
            totalEmployee++;
            this.TotalSalary = this.basicSalary;
            totalbasicSalary += this.basicSalary;
        }
        public Employee(int empID, string firstName, string lastName, DateTime joinDate, decimal basicSalary, string city, string role)
        {
            this.empID = empID;
            this.firstName = firstName;
            this.lastName = lastName;
            this.joinDate = joinDate;
            this.basicSalary = basicSalary;
            this.city = city;
            this.role = role;
            totalEmployee++;
            this.TotalSalary = this.basicSalary;
            totalbasicSalary += this.basicSalary;

        }


        public override string? ToString()
        {
            return $"Employee\t={this.empID } | {this.firstName} | {this.LastName} | {this.basicSalary} |{this.Role} | Ttl salary = {TotalSalary1.ToString("C", new CultureInfo("id-ID"))}  ";
        }




        //get set
        public int EmpID { get => empID; set => empID = value; }
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public DateTime JoinDate { get => joinDate; set => joinDate = value; }
        public decimal BasicSalary { get => basicSalary;
            set
            {
                basicSalary = value;
                TotalSalary= basicSalary; }
            }
        public string City { get => city; set => city = value; }
        public string Role { get => role; set => role = value; }
        public decimal TotalSalary1 { get => TotalSalary; set => TotalSalary = value; }
    }

   
}
