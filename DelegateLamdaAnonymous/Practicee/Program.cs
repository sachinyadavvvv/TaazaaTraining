using System;
using Airth;
delegate void Cal(double x, double y);
namespace AdvanceDelegate
{
    class Program
    {
        public static void Main()
        {
            Cal obj = new Cal(Airthmetic.Addition);
            obj.Invoke(10,20.5);                        //normal delegate
            

            Cal mycal=(double d1,double d2)=>//lamda function
            {
                Console.WriteLine(d1+d2);
            };
            Cal div=delegate(double d1,double d2)//anonynous function
            {
                Console.WriteLine(d1/d2);
            };
            mycal(10,20);
            div(10,2);
        }
    }
}
