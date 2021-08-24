using System;

namespace SpecialTopic
{
    class Program
    {
        static void Main(string[] args)
        {
            Program pObj = new Program();
            pObj.Paramss(3,4,12,56,2);
            pObj.Opt(4);
        }
        public void Paramss(params int[] n)
        {
            for(int i=0;i<n.Length;i++)

            {
                Console.WriteLine(n[i]);
            }
        }
        public void Opt(int first, int last=2)
        {
            Console.WriteLine(first*2);
        }
    }
}
