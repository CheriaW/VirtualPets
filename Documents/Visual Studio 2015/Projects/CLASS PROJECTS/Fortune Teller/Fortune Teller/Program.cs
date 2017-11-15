using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fortune_Teller
{
    class Program
    {
        static void Main(string[] args)
        {
            //asking user for name
            Console.WriteLine("Hey, there. I sense you came to me because you want to know your\n fortune... With my crystal ball I can foresee your future. Let's get started.\nWhat is your full name?");


            string userFirst = Console.ReadLine();
            string userLast = Console.ReadLine();

            Console.WriteLine(" ");

            Console.WriteLine(" ");

            //finding users birth month
            Console.WriteLine("Interesting. Out of the 12 months in a year which number represents the\nmonth you were born in?");
            string bankTotal;
            int birthMonth = int.Parse(Console.ReadLine());


            if (birthMonth >= 1 && birthMonth <= 4)
            {
                bankTotal = "$300,000";
            }
            else if (birthMonth >= 5 && birthMonth <= 8)
            {
                bankTotal = "7 trillion dollars which was illegally obtained through a series of bank roberies";
            }
            else if (birthMonth >= 9 && birthMonth <= 12)
            {
                bankTotal = "no outstanding loans, no children to suck up\n all your money, and 15 million dollars";
            }
            else
            {
                bankTotal = "$0.00";
            }
            Console.WriteLine(" ");

            Console.WriteLine(" ");


            ////is their age odd or even?
            ////COME BACK TO (look up moduls, dont use case)
            //asking user for age- deciding fortunes based of age # even or odd
            Console.WriteLine("Tell me... How old are you?");
            string yearsToRetirement;
            int userAge = int.Parse(Console.ReadLine());


            if (userAge % 2 == 0)
            {
                yearsToRetirement = "6";
            }

            else
            {
                yearsToRetirement = "18";
            }
            Console.WriteLine(" ");

            // finding out the number of user siblings and where users vacation home will be
            Console.WriteLine("How many siblings do you have?");
            string sibNum;
            int userSib = int.Parse(Console.ReadLine());

            if (userSib <= 0)
            {
                sibNum = "Fiji BUT it gets infested with rats. \n The local teens use it for parties and vandalize every inch of your property. \n Your home smells like poo and eventually gets torn down while you're away \n because the rancid odor takes over the town.\n The townsfolk gather around your burning vacation home and sing campfire songs in celebration.";
            }


            else if (userSib == 1)

            {
                sibNum = "Paris! Bon jour, amirite??";
            }

            else if (userSib == 2)
            {
                sibNum = "Peru and have your own alpaca farm! Cute!";
            }

            else if (userSib == 3)

            {
                sibNum = "Tokyo! Konnichiwa, amirite???";
            }

            else

            {
                sibNum = "Hawaii. Aloha, amirite?";
            }


            Console.WriteLine(" ");

            Console.WriteLine(" ");



            //finding users favorite ROYGBIV color
            Console.WriteLine("This might be weird but a persons favorite color from the ROYGBIV spectrum\nreally helps me better understand their fortune. If you don't know\nwhat ROYGBIV IS, enter 'Help' and I'll tell you.");
            string favColor = Console.ReadLine();
            string roygbiv;

            roygbiv = "";
            if (favColor == "help")
            {
                Console.WriteLine("ROYGBIV is an acronym for the colors red, orange, yellow, blue, green, indigo,\n and violet. If you ever forget you can just think of the colors of the rainbow!");
                Console.WriteLine("What is your favorite ROYGBIV color?");
                favColor = Console.ReadLine();
                if (favColor == "red")
                {
                    roygbiv = "the rapid";
                }
                else if (favColor == "orange")
                {
                    roygbiv = "on Usain Bolt's back";
                }
                else if (favColor == "yellow")
                {
                    roygbiv = "on a massive army of ants";
                }
                else if (favColor == "green")
                {
                    roygbiv = "in a brand new BMW";
                }
                else if (favColor == "blue")
                {
                    roygbiv = "a shiny new Farari";
                }
                else if (favColor == "indigo")
                {
                    roygbiv = "in your own private jet";
                }
                else if (favColor == "violet")
                {
                    roygbiv = "in the Batmobile";
                }
                else
                {
                    roygbiv = "in a rainbow patteren Mystery Van";
                }

            }

            else if (favColor == "red")
            {
                roygbiv = "the rapid";
            }
            else if (favColor == "orange")
            {
                roygbiv = "on Usain Bolt's back";
            }
            else if (favColor == "yellow")
            {
                roygbiv = "on a massive army of ants";
            }
            else if (favColor == "green")
            {
                roygbiv = "in a brand new BMW";
            }
            else if (favColor == "blue")
            {
                roygbiv = "a shiny new Farari";
            }
            else if (favColor == "indigo")
            {
                roygbiv = "in your own private jet";
            }
            else if (favColor == "violet")
            {
                roygbiv = "in the Batmobile";
            }
            else
            {
                roygbiv = "in a rainbow patteren Mystery Van";
            }

            Console.WriteLine(" ");


            //final fotrune telling
            Console.WriteLine("Alright, I'm able to tell you your fortune... If you're not happy\n with it then oh well. This was a free reading.");
            Console.WriteLine("My crystal ball sees that " + userFirst + userLast);
            Console.WriteLine("will retire in " + yearsToRetirement + ("years with " + bankTotal));
            Console.WriteLine("in the bank. \n You'll also have a vacation home in " + sibNum);
            Console.WriteLine("Finally, you will ride " + roygbiv + " everywhere you go!");
        }
    }
}
