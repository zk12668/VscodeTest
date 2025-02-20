using System;

namespace MyConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
           if(!File.Exists(@"C:\Users\newsupercc\Desktop\111.txt"))
           {
              using(
                StreamWriter sw = File.CreateText(@"C:\Users\newsupercc\Desktop\111.txt")
              )
              {
                sw.Write("hahaha");
              }
           }
           string text=File.ReadAllText(@"C:\Users\newsupercc\Desktop\111.txt");
           Console.WriteLine(text);
         //  Console.ReadKey(); 

        
        }
    }
}