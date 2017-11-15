using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace group_work_in_lists
{
    class Program
    {
        static void Main(string[] args)
        {
        //    List<string> animals = new List<string>();
        //    animals.Add("puppy");
        //    animals.Add("kitty");
        //    animals.Add("fish");
        //    animals.Add("giraffe");
        //    animals.Add("elephant");

        //    foreach (string animal in animals) ;
        //}



        List<bool> answers = new List<bool>() { true, false, false, true, false };
            foreach (bool ans in answers)
            {
                if (ans)
                {
                    Console.WriteLine("Better bring an umbrella.");
                }
                else
                {
                    Console.WriteLine("No rain today. Enjoy the sun!");
                }

            }
        }
    }
}
