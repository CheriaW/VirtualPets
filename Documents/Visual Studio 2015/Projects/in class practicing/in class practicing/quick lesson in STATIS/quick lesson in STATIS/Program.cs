using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace quick_lesson_in_STATIS
{
    class Program
    {
        static void Main(string[] args)
        {
            //we can create a collection of objects
            List<CAT> catArmy = new List<CAT>();
            List<TURTLE> turtleArmy = new List<TURTLE>();

            Random rand = new Random(); //just calling the new random object "rand"

            //Let's create our armies!!
            for (int i = 0; i < 100; i++)
            {
                if (rand.NextDouble() >= 0.5) //having fun with the generationn of army sizes
                {
                    catArmy.Add(new CAT());
                }
                else
                {
                    turtleArmy.Add(new TURTLE());
                }

            }
            //code to tell each cat how many cats there are
            //need to run all this code nytime we add a cat
            int totalCats = catArmy.Count;

            foreach(CAT cat in catArmy)
            {
                cat.CatCount = totalCats;
            }
            catArmy[0].WarCry();


            //code to tell each turtle how many thurtles there are
            //we put in the turtle count to go UP in the constructor so we dont need to hard code (like we did with cats) 
            //we can just vv
            TURTLE.WarCry();

            //benefits of statis
            //if we are making fields that are going to be available to every (class?)?
            //static lets you share the (methods?)?


        }
    }
}
