using System;

namespace SwitchAssignment
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("select create/update/delete/exit");
            string input =Console.ReadLine();
            
            switch(input.ToLower())
            {
                case "create":
                Console.WriteLine("employee created");
                break;
                case "update":
                Console.WriteLine("employee updated");
                break;
                case "delete":
                Console.WriteLine("employee deleted");
                break;
                case "exit":
                Console.WriteLine("exited");
                break;
            }
        }
    }
}
