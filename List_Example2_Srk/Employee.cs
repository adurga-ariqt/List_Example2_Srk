using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace List_Example2_Srk
{
    public class Employee
    {


        public Employee() { }

        public int EmployeeID { get; set; }
        public string? EmployeeName { get; set; }
        public double Salary { get; set; }
        //public string a { get; set; }

        public void AddNewEmployee()
        {
            Console.WriteLine("Enter Employee ID");
            this.EmployeeID = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Employee Name");
            this.EmployeeName = Console.ReadLine();

            Console.WriteLine("Enter Employee Salary");
            this.Salary = double.Parse(Console.ReadLine());
        }
        public void ShowEmployee()
        {
            Console.WriteLine("Employee ID : {0}" + Environment.NewLine + "Employee Name : {1}" + Environment.NewLine + "Salary : {2}", this.EmployeeID, this.EmployeeName, this.Salary);
            Console.WriteLine("-------------------------------------------");
            
        }


    }
}





