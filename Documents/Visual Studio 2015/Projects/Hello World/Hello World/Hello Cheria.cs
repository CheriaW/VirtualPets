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

            // this is where user inputs would be 
          //  int favoriteNumber = int.Parse(Console.ReadLine());

          //  Console.WriteLine("My favorite number is " + favoriteNumber + "." );

            // this is a single line comment
            //int favoriteNumber = int.Parse(Console.Readline());

            /*
             this
             is
             a
             block
             comment
             */

            Console.WriteLine("Please enter a number");
            int firstNumber = int.Parse(Console.ReadLine());

            Console.WriteLine("Please enter a second number");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = firstNumber + secondNumber;
            Console.WriteLine("The sum is " + sum);
            
        }
    }
}
