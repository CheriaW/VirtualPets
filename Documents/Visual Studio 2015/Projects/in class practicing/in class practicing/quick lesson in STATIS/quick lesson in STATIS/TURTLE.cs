using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_lesson_in_STATIS
{
    class TURTLE
    {
        //this static variablle belongs to the CLASS
        //it is shared among all instances
        //this also means we can use the variable without creating instances first

        static int turtleCount; //because its static it doesnt need a property

        public TURTLE()
        {
            turtleCount++;
        }

        //this static method belongs to the class
        //its shared amonth all instances
        //it means we can use the method without creating any instances first
        public static void WarCry() // using static as a modifier for the field and the method
        {
            Console.WriteLine("we are an army of " + turtleCount + "turtles.");
        }

    }
}
