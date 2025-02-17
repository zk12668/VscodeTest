using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateDemo
{
    public delegate void DelValue();
    class Program
    {
        
        static void Main(string[] args)
        {
           
           DelValue delValue = Play;
            delValue();
        }

      
        public static void Play()
        {
            Console.WriteLine("we are play");
        }
    }
}