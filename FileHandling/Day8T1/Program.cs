using System;
using Day8T1.FileHandling;

namespace Day8T1
{
    public class Program
    {
        public static void Main()
        {
            FileHandler fileHandler = new FileHandler();
            //fileHandler.writeToFile("I am Sachin. I am doing training for betterment");
            fileHandler.readFromFile();
        }
    }
}
