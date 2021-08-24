using System;

// class Taazaa
// {
//     string empdes;

//     void assign() //member function
//     {
//         empdes="programmer 1";
//         Console.WriteLine(empdes);
//     }
    
//         public static void Main()
//     {
//         Taazaa obj=new Taazaa();
//         obj.empdes = "programmer";//1.calling by object
//         Console.WriteLine(obj.empdes);
//         obj.assign();//2.calling the function
//     }
// }

class Taazaa
{
    static void Main(string[] args)
    {
        int[] numbers = new int[]{1,2,3,4,5,6};
        for(int x=0; x<6; x++)
        {
            Console.WriteLine("{0} element is {1}",x+1,numbers[x]);
        }

        int[,] arr = new int[3,3]{
            {0, 1,2},
            {4,5,6},
            {8,9,10}
        };
        for(int i=0; i<3; i++)
        {
            for(int j=0; j<3; j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();
        }
    }
    
}


