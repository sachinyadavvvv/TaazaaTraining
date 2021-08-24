using System;
using day3.night;
using day3.Person_son;
namespace day3
{
    class Program
    {
    static void Main(string[] args)
    {
        INight obj=new Person();
        int temp= obj.study();
        Console.WriteLine(temp);
    }
    }

}
