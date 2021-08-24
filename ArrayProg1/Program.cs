using System;  
namespace arrayAssignment
{
public class Program
{  
    static void Main() 
    {
        int i,n;
        int[] a= new int[100];
        Console.Write("IEnter number of elements:");
        n = Convert.ToInt32(Console.ReadLine());    
   
        Console.Write("number of elements in the array are:\n",n);
        for(i=0;i<n;i++)
        {
	        Console.Write("element - {0} : ",i);
	        a[i] = Convert.ToInt32(Console.ReadLine()); 
	    }
      
        Console.Write("Your array: \n");
        for(i=0;i<n;i++)
        {
	        Console.Write("{0}  ",a[i]);
	    }
 
        Console.Write("\n\nYour array in reverse:\n");
        for(i=n-1;i>=0;i--)
        {
	        Console.Write("{0} ",a[i]);
	    }
        Console.Write("\n\n");
    } 
} 
}