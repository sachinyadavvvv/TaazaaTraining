using System;
using mlab;
namespace day1
{
    class Program
    {
        static void Main(string[] args)
        {
            calculus obj=new calculus();
            string temp=obj.limits();
            Console.WriteLine(temp);
        }
    }
}