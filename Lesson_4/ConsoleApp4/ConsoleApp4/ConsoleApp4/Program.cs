using System;
using System.Collections.Generic;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
           List<string> l = new List<string>() { "Programming" };
            l.Add("Sport");
            l.Add("Learn language");
            l.Add("Play computer games");
            foreach(string s in l)
            {
                Console.WriteLine(s);
            }
            Console.WriteLine(l.Count);
            l.Clear();
            Console.ReadKey();
            
        }
    }
}
