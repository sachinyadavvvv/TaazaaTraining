using System;
using day4a.study;
using day4a.movie;

namespace day4a
{
    class Program
    {
        static void Main(string[] args)
        {
            Define obj = new Define();
            int temp= obj.study();
            string temp1= obj.movie();
            Console.WriteLine(temp);
            Console.WriteLine(temp1);
        }
    }
    public class Define
    {
        public int study()
        {
            return 2;
        }
        public string movie()
        {
            return "this is movie";
        }
    }

}
