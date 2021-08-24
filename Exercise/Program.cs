using System;
using AdvanceTraining.Miscellaneous;
namespace AdvanceTraining
{
    class Program
    {
        static void Main()
        {
            var Mohan= new Taazaa(101,1000);
            var temp=Mohan.EmployeeSalary();
            Console.WriteLine("Salary of mohan is"+temp);

            var Sachin = new Taazaa(102,2000);
            var temp1=Sachin.EmployeeSalary();
            Console.WriteLine("Salary of sachin is"+temp1);

            var caf=Taazaa.Coffee();
            Console.WriteLine(caf);
            

        }
    }
}
