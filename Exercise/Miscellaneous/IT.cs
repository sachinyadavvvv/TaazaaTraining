using System;
namespace AdvanceTraining.Miscellaneous
{
    public class Taazaa
    {
        double Salary;
        readonly int Empid;
        static string Cafetaria;
        public Taazaa(int employeeid,double sal)
        {
            Salary=sal;
            Empid=employeeid;
        }
        static Taazaa()
        {
            Cafetaria="100 sqft";
        }
        public int Employeeid()
        {
            return Empid;
        }
        public static string Coffee()
        {
            return Cafetaria;
        }
        public double EmployeeSalary()
        {
            return Salary;
        }
    }
}