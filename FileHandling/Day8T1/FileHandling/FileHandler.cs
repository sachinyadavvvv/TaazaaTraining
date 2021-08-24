using System;
using System.IO;
namespace Day8T1.FileHandling
{
    public class FileHandler
    {
        public void writeToFile(string name)
        {
            FileStream f=new FileStream("training.txt",FileMode.Create);
            StreamWriter s = new StreamWriter(f);
            s.WriteLine(name);
            s.Close();
            f.Close();
        }
        public void readFromFile()
        {
            FileStream f=new FileStream("training.txt",FileMode.Open);
            StreamReader reader = new StreamReader(f);
            string fileData= reader.ReadLine();
            Console.WriteLine(fileData);
            reader.Close();
            f.Close();
            Console.WriteLine("file read successful");
        }
    }
}