using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hero
{
    class Program
    {
        static void Main(string[] args)
        {
            Hero superMan = new Hero();
            superMan.Strong = "Can lift a hundred trains.";
            superMan.Courage = "Bravely face any villian.";
            superMan.Weight = 180;
            superMan.Speed = 100;

            superMan.Bananas();
            Console.WriteLine("Bananas make it so that Superman " + superMan.Strong);
            Console.WriteLine(superMan.Strong);

            superMan.Puppies();
            Console.WriteLine("Puppies give Superman the courage to " + superMan.Strong);
            Console.WriteLine(superMan.Courage);


            //need this to run program v
            

            Hero secondHero = new Hero("Fit and active", 4.04d);
            Console.WriteLine(secondHero.Weight);

            secondHero.Groom();
            Console.WriteLine(secondHero.Weight);

            secondHero.Weight = "faster than lightening.";
            Console.WriteLine(secondHero.Weight);
            secondHero.Run();
            Console.WriteLine(secondHero.Weight);
            //>
            secondHero.Weight = 78.9;
            Console.WriteLine(secondHero.Weight);

            secondHero.Potty();
            Console.WriteLine(secondHero.Weight);

        }
    }
    }
}
