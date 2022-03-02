using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class list
    {
        static void Main(string[] args)
        {
            var first = new List<string>();
            first.Add("red");
            first.Add("pink");
            first.Add("green");
            first.Add("yellow");
            first.Add("purple");
            first.Remove("green");
            first.Insert(2, "orange");
            foreach(string st in first)
            {
                Console.WriteLine(st);
                Console.ReadLine();
            }

        }
    }
}
