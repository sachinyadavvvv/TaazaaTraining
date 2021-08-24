using System;
namespace ExceptionHandling.Customer
{
    //Exception class in c# is a base class in exception handling which can handle all the exceptions
    //AirthmeticException is a base classof DivideByZeroException that's why base class can handle derived class exception
    public class Customers
    {
        int result;
        public Customers()
        {
            result=0;
        }
        public void Data(int n1,int n2)
        {
            try
            {
                int result=n1/n2;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Exception handled");
            }
            finally
            {
            Console.WriteLine("result done");
            }
            }
    }
}