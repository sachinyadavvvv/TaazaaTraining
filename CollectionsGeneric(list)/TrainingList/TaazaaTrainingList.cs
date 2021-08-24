using System.Collections.Generic;
using day6.Models;
namespace day6.TrainingList
{
    public class TaazaaTrainingList
    {
        public List<Details> TrainingList()
        {
            List<Details> obj= new List<Details>();
            obj.Add(new Details{
                Email="ksdb@josd",
                PhoneNumber=93857
            });
            obj.Add(new Details{
                Email="kjdn@kd",
                PhoneNumber=987
            });
            return obj;
        }
    }
}