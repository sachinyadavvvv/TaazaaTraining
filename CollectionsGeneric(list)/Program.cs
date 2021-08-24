using System;
using day6.TrainingList;
using day6.Models;
using System.Collections.Generic;
namespace day6
{
    class Program
    {
        static void Main()
        {
            var obj=new TaazaaTrainingList();
            List<Details> temp =obj.TrainingList();
            int t=temp.Count;
            for(int i=0;i<t;i++)
            {
                Console.WriteLine(temp[i].Email=" "+temp[i].PhoneNumber);

            }
        }
    }
}
