using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingguKe4OOP.PartTwo
{
    internal class EmployeeImpl : IEmployee
    {
        public Employee FindEmployeeById(List<Employee> list, int id)
        {
            Employee em=null; 
            foreach (var item in list)
            {
                if(item.EmpID == id)
                {
                    em = item;
                }
            }
            return em;
            //throw new NotImplementedException();
        }

        public List<Employee> FindSalaryRange(List<Employee> list, decimal startFrom, decimal endTo)
        {
           var emRange = new List<Employee>();

            foreach (var item in list)
            {
                if(item.TotalSalary1 >= startFrom && item.TotalSalary1 <= endTo)
                {
                    emRange.Add(item);
                }
            }

            return emRange;
            //throw new NotImplementedException();
        }
        public Dictionary<string,int> GetTotalEmployeByRole(List<Employee> list)
        {
            var dict = new Dictionary<string,int>();
            int totProg =0;
            int totSal = 0;
            int totQA=0;

            foreach (var item in list)
            {
                if(item.Role == "Programmer")
                {
                    totProg  ++;
                }
                else if (item.Role == "Sales")
                {
                    totSal ++;
                }
                else if (item.Role == "QA")
                {
                    totQA++;
                }
            }
            dict.Add("Programmer", totProg);
            dict.Add("Sales", totSal);
            dict.Add("QA", totQA);


            return dict;

        }
        public void ShowEmployeByRole(Dictionary<string,int> dict)
        {
            foreach (var item in dict)
            {   
                Console.WriteLine($"Role : {item.Key}\n Total Employe : {item.Value}");
            }

           
        }

        public decimal GetTotalSalary<T>(ref List<T> list)
        {
            
            var total = 0M;
            foreach (var item in list.OfType<Employee>())
            {
                total += item.TotalSalary1;
            }
            //throw new NotImplementedException();
            return total;
        }

        public List<Employee> InitDataEmployee()
        {
            Employee emp1 = new Employee();
            emp1.EmpID = 1001;
            emp1.FirstName = "Musa";
            emp1.LastName = "Silaban";
            emp1.JoinDate = DateTime.Now;
            emp1.BasicSalary = 8_000_000;
            emp1.City = "Medan";



            //create object Employee with paramerter constuktor
            Employee emp2 = new Employee(1001, "Code", "Academy", new DateTime(), 5_000_000, "Jakarta", "Sales");

            //menggunakan overload construktor
            Employee emp3 = new Employee(1002, "Yuli", "Ayu", new DateTime(2022, 07, 29), 5_000_000, "Siborong borong", "QA");

            Employee emp4 = new Employee(1004, "Michael", "ButarButar", new DateTime(), 5_000_000, "Medan", "QA"); 
            //throw new NotImplementedException();
            Programmer prog1 = new Programmer(1005, "Putra", "Siallagan", new DateTime(2019, 01, 23), 5_500_000, "Medan", 500_000);
            Programmer prog2 = new Programmer(120, "Anton", "Pratama", new DateTime(2016, 08, 15), 6_000_000, "Jakarta", 5_000_000);
            Programmer prog3 = new Programmer(121, "Budi", "Junaidi", new DateTime(2017, 09, 05), 6_000_000, "Jakarta", 5_000_000);
            Programmer prog4 = new Programmer(122, "Charlie", "van Djik", new DateTime(2015, 03, 03), 6_000_000, "Jakarta", 5_000_000);
            Sales sl = new Sales(1007, "Hevander", "Silaban", new DateTime(2019, 01, 13), 5_000_000, "Medan", 5_000_000, 30_000_000);
            Sales sl1 = new Sales(123, "Dian", "Permana", new DateTime(2017, 10, 12), 3_000_000, "Medan", 500_000, 200_000);
            Sales sl2 = new Sales(124, "Fatur", "Rohman", new DateTime(2019, 01, 13), 3_000_000, "Medan", 500_000, 200_000);
            Sales sl3 = new Sales(125, "Fajar", "Silaban", new DateTime(2019, 01, 13), 5_000_000, "Medan", 500_000, 300_000);
            QA QWA = new QA(1008, "Thalia", "Sianturi", new DateTime(2018, 09, 09), 5_000_000, "Medan", 500_000);
            QA QWA1 = new QA(127, "Elise", "Erika", new DateTime(2018, 09, 09), 5_000_000, "Medan", 500_000);
            QA QWA2 = new QA(128, "Gutawa", "Gerhana", new DateTime(2018, 09, 09), 5_000_000, "Medan", 500_000);


            //store to list
           // List<Employee> listempl = new List<Employee> { emp1, emp2, emp3, emp4, prog1, prog2, prog3, prog4, sl, sl1, sl2, sl3, QWA, QWA1, QWA2 };


            //direct return without variabel
            return new List<Employee> { emp1, emp2, emp3, emp4, prog1, prog2, prog3, prog4, sl, sl1, sl2, sl3, QWA, QWA1, QWA2 };

        }

        public void showList<T>(ref List<T> list)
        {
            foreach (T item in list)
            {
                Console.WriteLine($"{item}");
            }

           
        }

        
    }
}
