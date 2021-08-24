using System;
using PartialClassimpl;
namespace PartialClassimpl
{
    class Program
    {
        static void Main()
        {
            Person person=new Person(101);
            int a=person.getId();
            Console.WriteLine(a);
        }
    }
}
