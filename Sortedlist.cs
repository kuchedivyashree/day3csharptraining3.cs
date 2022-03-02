using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class Sortedlist
    {
        public static void Main()
        {
            var value = new SortedList<string, int>();
            value.Add("divya", 3);
            value.Add("divyashree", 4);
            value.Add("sushmita", 5);
            value.Add("priya", 40);
            value.Add("geetha", 57);
            value.Clear();

            foreach(var pair in value)
            {
                Console.WriteLine(pair);
                Console.ReadLine();
            }
        }
    }
}
