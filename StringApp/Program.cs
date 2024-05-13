using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringApp
{
    public class Program
    {
        static void Main(string[] args)
        {
            string input = "Hello IT maintainance class !";
            Console.WriteLine("Original string: " + input);
            Console.WriteLine("After..");
            Console.WriteLine("First character of each word removed: " + Methods.RemoveFirstChar(input));
            Console.WriteLine("Last character of each word removed: " + Methods.RemoveLastChar(input));

        }
    }
}
