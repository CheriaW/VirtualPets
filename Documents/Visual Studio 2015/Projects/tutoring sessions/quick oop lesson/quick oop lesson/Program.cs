using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_oop_lesson
{
    class Program
    {
        static void Main(string[] args)
        { 
        {
                //this produces a random number between 5 and 15
            Random rando = new Random();
            Console.WriteLine(rando.Next(5,15));

        }
       //{
    //        {
    //            Random rand = new Random();
    //            for (int number = 1; number <= 6; number++)
    //            {
    //                int randomNumber = rand.Next(49) + 1;
    //                Console.Write("{0} ", randomNumber);
    //            }
    //        }

        }
    }
}
