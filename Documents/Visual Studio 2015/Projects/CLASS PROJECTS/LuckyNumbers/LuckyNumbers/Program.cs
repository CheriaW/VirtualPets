using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lucky_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            string playAgain;
            do

            {//part 1
                Console.WriteLine("Wanna play a sketchy lottery game?");
                Console.WriteLine("If you guess all numbers correctly and win this lottery you will win $100,000.");
                Console.WriteLine("Please choose the lowest value in the number range.");
                int userLowNum = int.Parse(Console.ReadLine());
                Console.WriteLine("Please choose the highest value in the number range.");
                int userHighNum = int.Parse(Console.ReadLine());
                int[] userGuess = new int[6];

                for (int i = 0; i < userGuess.Length; i++)
                {
                    Console.WriteLine("Please enter a whole number between " + userLowNum + " and " + userHighNum + ".");
                    userGuess[i] = int.Parse(Console.ReadLine());

                }



                ////PART 2
                Console.WriteLine("Here are the lucky lotto numbers!");

                Random randoNumGen = new Random();
                int[] LuckyNumbers = new int[6];
                {
                    Random rand = new Random();
                    for (int n = 0; n < 6; n++)
                    {
                        Console.Write("Lucky number:");

                        int randomNumber = rand.Next(userHighNum);
                        Console.WriteLine("{0}", randomNumber);
                    }
                }


                ////PART 3
                int correctAnswers = 0;

                for (int i = 0; i < userGuess.Length; i++)
                {
                    for (int j = 0; j < LuckyNumbers.Length; j++)
                    {

                        if (userGuess[i] == LuckyNumbers[j])
                        {
                            correctAnswers++;
                        }
                    }
                }


                Console.WriteLine("You guessed " + correctAnswers + " correctly.");

                int lottoTotal = 100000;
                // int winners = int.Parse(Console.ReadLine());

                switch (correctAnswers)
                {
                    case 0:
                        Console.WriteLine("You win $" + lottoTotal * 0 + ".");
                        break;

                    case 1:
                        Console.WriteLine("You win $" + lottoTotal * .1 + ".");
                        break;

                    case 2:
                        Console.WriteLine("You win $" + lottoTotal * .3 + ".");
                        break;

                    case 3:
                        Console.WriteLine("You win $" + lottoTotal * .5 + ".");
                        break;

                    case 4:
                        Console.WriteLine("You win $" + lottoTotal * .7 + ".");
                        break;

                    case 5:
                        Console.WriteLine("You win $" + lottoTotal * .9 + ".");
                        break;
                    case 6:
                        Console.WriteLine("You win $" + lottoTotal + ".");
                        break;
                    default:
                        Console.WriteLine("How did you even.... What....?");
                        break;
                }

                // if (userGuess == LuckyNumbers);



                //PART 4


                Console.WriteLine("Great game!");
                Console.WriteLine("Do you want to play the game? (YES/NO)");

                //Console.WriteLine("Do you want to play again?");
                playAgain = Console.ReadLine().ToUpper();
            }
            while (playAgain == "YES");

            Console.WriteLine("Thanks for playing.");
        }

    }
}