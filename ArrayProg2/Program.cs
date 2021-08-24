using System;  
namespace ArrayAssignment1
{
    public class Program  
    {  
        public static void Main() 
        {
            int[] a= new int[100];
            int i, n, sum=0;

            Console.Write("Enter the number of elements :");
	        n = Convert.ToInt32(Console.ReadLine()); 
   
            Console.Write("Input elements :\n",n);
            for(i=0;i<n;i++)
            {
	            Console.Write("element - {0} : ",i);
		        a[i] = Convert.ToInt32(Console.ReadLine()); 
	        }

            for(i=0; i<n; i++)
            {
                sum += a[i];
            }

            Console.Write("Sum of all elements stored in the array is : {0}\n\n", sum);
        }
    }
}