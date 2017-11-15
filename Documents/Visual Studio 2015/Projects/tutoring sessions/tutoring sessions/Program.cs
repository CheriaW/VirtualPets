using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tutoring_sessions
{
    class Program
    {
        static void Main(string[] args)
        {
            // referencing homework first day?

            int initialNumber = 72;
            int dividedByThree = initialNumber / 3;
            int incrementedNumber = dividedByThree + 1;
            int decrementedNumber = dividedByThree - 1;

            int total = dividedByThree + incrementedNumber + decrementedNumber;
            Console.WriteLine("The total is: " + total);

            Console.WriteLine(dividedByThree);
            Console.WriteLine(incrementedNumber);
            Console.WriteLine(decrementedNumber);



            // seperate problem, string comparison

            Console.WriteLine("Enter secret passcode");
            string userInput = Console.ReadLine().ToUpper();

            // another way
            // userInput = userInput.ToUpper();

            //use trim?

            string secretPasscode = "OREOS";

            if (userInput == secretPasscode)
            {
                Console.WriteLine("Welcome to the club!");
            }
            else
            {
                Console.WriteLine("Please try again.");
            }

            Console.WriteLine("Please enter a number to be divided by 2.");
            int number = int.Parse(Console.ReadLine());

            Console.WriteLine("Reminder: " + number % 2d);

            if (number % 2 == 0)
            {
                Console.WriteLine("The number is even.");

            }
            else
            {
                Console.WriteLine("The number is odd.");
            }


            //tutoring with methods 10/5

            string[] favoriteHolidays = { "Halloween", "Thanksgiving", "New Years", "Valentine's Day" };
            foreach (string holiday in favoriteHolidays)
            {
                Console.WriteLine(holiday);
            }

            for (int i = 0; i < favoriteHolidays.Length; i++)
            {
                Console.WriteLine(favoriteHolidays[i]);
            }

            int[] multiplesOfThree = { 3, 6, 9, 12, 15, 18 };
            int sum = 0;
            //foreach (int multiple in multiplesOfThree)
            //{
            //    sum += multiple;
            //    //+= mean "sum" now equals whatever it was before plus the "multiple"
            //}

            for (int i = 0; i < multiplesOfThree.Length; i++)
            {
                sum += multiplesOfThree[i];
            }
            Console.WriteLine(sum);



            //do while loops
            string playAgain = "";
            do
            {
                Console.WriteLine("I Love this game! WHat do you think?");
                string userOpinion = Console.ReadLine();

                Console.WriteLine("It was really fun to hang out, don't you agree?");
                string userSatisfaction = Console.ReadLine();

                Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine().ToLower();

            }
            while (playAgain == "yes");
            
        }


    }
}
