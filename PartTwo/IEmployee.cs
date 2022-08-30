using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MingguKe4OOP.PartTwo
{
    internal interface IEmployee
    {
        public List<Employee> InitDataEmployee();
        public void showList<T>( ref List<T> list);

        public Employee FindEmployeeById(List<Employee> list,int id);
       
        //method return  wuth generic datatype
        public decimal GetTotalSalary<T>(ref List<T> list);

        public List<Employee> FindSalaryRange(List<Employee> list,decimal startFrom, decimal endTo);

        public Dictionary<string, int> GetTotalEmployeByRole(List<Employee> list);
    
        public void ShowEmployeByRole(Dictionary<string, int> dict);
       
    }
}
