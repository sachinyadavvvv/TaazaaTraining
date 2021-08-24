using System;
using Day8t.AdvDelegate;
//delegate string NameDelegate(string N);
// delegate void PhoneDelegate();
// delegate bool StudyDelegate();
namespace Day8t
{
    class Program
    {
        static void Main()
        {
            Study sObj = new Study();
            // NameDelegate nameDelegate = new NameDelegate(sObj.Name);
            // var n=nameDelegate("Sachin");
            // Console.WriteLine(n);

            Func<string,string> func = sObj.Name;
            string fob=func("sachin");
            Console.WriteLine(fob);

            Action Obj= sObj.PhoneNo;
            Obj();

            Predicate<string> pObj = sObj.StudyStatus;
            bool pob = pObj("sachin");
            Console.WriteLine(pob);
        }
    }
}
