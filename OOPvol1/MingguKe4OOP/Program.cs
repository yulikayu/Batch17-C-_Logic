using static System.Console;
using System.Globalization;
// call class employee
using MingguKe4OOP.PartOne;
using MingguKe4OOP.PartTwo;

// See https://aka.ms/new-console-template for more information

//setiap create object instance, gunakan operator new
// menggunakan getset, liat variabelnya
/*Employee emp1 =new Employee();
emp1.EmpID = 1001;
emp1.FirstName = "Musa";
emp1.LastName = "Silaban";
emp1.JoinDate= DateTime.Now;
emp1.BasicSalary = 8_000_000;
emp1.City = "Medan";

    

//create object Employee with paramerter constuktor
Employee emp2 =new Employee(1001,"Code","Academy",new DateTime(),5_000_000,"Jakarta","Sales");

//menggunakan overload construktor
Employee emp3 = new Employee(1002, "Yuli", "Ayu", new DateTime(2022,07,29), 5_000_000,"Siborong borong","QA");

Employee emp4 = new Employee(1004, "Michael", "ButarButar", new DateTime(), 5_000_000, "Medan", "QA");

emp3.BasicSalary = 6_000_000;
//Gunakan encapsulation untuk manipulasi atribute object
WriteLine(emp1.ToString());
WriteLine(emp2.ToString());
WriteLine(emp3.ToString());
WriteLine(emp4.ToString());
WriteLine($"Total Employe : {Employee.totalEmployee}");
WriteLine($"Total Basic Salary : {Employee.totalbasicSalary}");

//Create object Programmer

WriteLine("===================================LIST EMPLOYEE=======================================================================");
Programmer prog1 = new Programmer(1005, "Putra", "Siallagan",new DateTime(2019, 01, 23), 5_500_000, "Medan", 500_000);
Programmer prog2 = new Programmer(120, "Anton", "Pratama", new DateTime(2016, 08, 15), 6_000_000, "Jakarta", 5_000_000);
Programmer prog3 = new Programmer(121, "Budi", "Junaidi", new DateTime(2017, 09, 05), 6_000_000, "Jakarta", 5_000_000);
Programmer prog4 = new Programmer(122, "Charlie", "van Djik", new DateTime(2015, 03, 03), 6_000_000, "Jakarta", 5_000_000);
Sales sl = new Sales(1007,"Hevander","Silaban",new DateTime(2019,01,13),5_000_000,"Medan",5_000_000,30_000_000);
Sales sl1 = new Sales(123, "Dian", "Permana", new DateTime(2017, 10, 12), 3_000_000, "Medan", 500_000,200_000);
Sales sl2 = new Sales(124, "Fatur", "Rohman", new DateTime(2019, 01, 13), 3_000_000, "Medan", 500_000, 200_000);
Sales sl3 = new Sales(125, "Fajar", "Silaban", new DateTime(2019, 01, 13), 5_000_000, "Medan", 500_000, 300_000);
QA QWA = new QA(1008, "Thalia", "Sianturi", new DateTime(2018, 09, 09), 5_000_000, "Medan", 500_000);
QA QWA1 = new QA(127, "Elise", "Erika", new DateTime(2018, 09, 09), 5_000_000, "Medan", 500_000);
QA QWA2 = new QA(128, "Gutawa", "Gerhana", new DateTime(2018, 09, 09), 5_000_000, "Medan", 500_000);

//store list
List<Employee> listempl=new List<Employee> { emp1,emp2, emp3,emp4, prog1,prog2,prog3,prog4,sl,sl1,sl2,sl3,QWA,QWA1,QWA2};

foreach (var item in listempl)
{
    WriteLine(item.ToString());
}*/


WriteLine("============================================== Implementation Interface ===========================================================");
IEmployee empInf = new EmployeeImpl();

var listOfEmps = empInf.InitDataEmployee();
WriteLine("========== LIST OF EMPLOYEE ================");
empInf.showList(ref listOfEmps);
var em = empInf.FindEmployeeById(listOfEmps, 1002);
WriteLine();

WriteLine();
WriteLine($"Ketemu :{em}");

var total= empInf.GetTotalSalary(ref listOfEmps);
WriteLine($"Total Salary : {total.ToString("C", new CultureInfo("id-ID"))}");

WriteLine("------Salary Range--------");
var empsSalaryRange = empInf.FindSalaryRange(listOfEmps, 2_000_000, 4_500_000);
empInf.showList( ref empsSalaryRange);
WriteLine("======== Total Employe by Role===============");
var emRole = empInf.GetTotalEmployeByRole(listOfEmps);
empInf.ShowEmployeByRole(emRole);








ReadLine();


