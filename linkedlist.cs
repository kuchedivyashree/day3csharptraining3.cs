using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    internal class linkedlist
    {
        public static void Main()
        {
            LinkedList<int> myList = new LinkedList<int>();

            myList.AddLast(2);
            myList.AddLast(4);
            myList.AddLast(6);
            myList.AddLast(8);

            Console.WriteLine("total nodes in myList are:" + myList.Count);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
            }
            myList.Remove(myList.First);

            Console.WriteLine("total nodes in myList are:" + myList.Count);
            foreach (int i in myList)
            {
                Console.WriteLine(i);
                Console.ReadLine();
            }
        }
    }
}
