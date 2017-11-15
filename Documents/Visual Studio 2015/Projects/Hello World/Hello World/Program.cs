using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_World
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello Cheria!");

            int age = 21;

            Console.WriteLine("My age is " + age);

            int favoriteNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("My favorite number is " + favoriteNumber + ".");

        }
    }
}
