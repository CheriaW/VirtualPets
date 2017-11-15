using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Out_of_Class_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            ////several different approaches
            //Console.WriteLine("how much did each person pay?");
            //int mikePaid = 13;
            //int friends = 3;
            //Console.WriteLine((mikePaid * friends) + mikePaid);

            ////int billPortion =13
            //Console.WriteLine("How much did each person pay?");
            //int billportion = int.Parse(Console.ReadLine());

            //// int dinnerNumber = 4
            //Console.WriteLine("How many diners are there?");
            //int dinnerNumber = int.Parse(Console.ReadLine());

            //int billTotal = billportion + dinnerNumber;
            ////Console.WriteLine(billTotal);
            //double newBill;
            //if (billTotal >= 50)
            //{
            //    newBill = billTotal * .1;
            //    Console.WriteLine("Your discounted total is now $" + newBill);
            //}
            //else
            //{
            //    newBill = billTotal * .05;
            //    Console.WriteLine("Your discounted total is now $" + newBill);
            //}


            //int needed = 7;
            //int used = 2;
            //Console.WriteLine(needed - used);

            //int money = 40;
            //int cost = 8;
            //Console.WriteLine(money / cost);

            //int newTotal = 41;
            //int prevTotal = 29;
            //Console.WriteLine(newTotal - prevTotal);

            //int juliaRan = 47;
            //int moreThan = 30;
            //Console.WriteLine(juliaRan - moreThan);

            //int envelope = 12;
            //int costOf = 3;
            //Console.WriteLine(envelope / costOf);

            //float salad = 5.12f;
            //float current = 27.10f;
            //Console.WriteLine(salad + current);

            //int totalStudents = 331;
            //int inCars = 7;
            //int busses = 6;
            //Console.WriteLine((totalStudents - inCars) / busses);

            //int spendable = 24;
            //int remaining = 10;
            //int pencils = 7;
            //Console.WriteLine((spendable - remaining) / pencils);

            ////HW FOR 9 / 27

            //int firstNumber = 16;
            //int secondNumber = 18;

            //Console.WriteLine("Numbers are not equal.");

            ////problem 4 reviewed/ explained in class

            //Console.WriteLine("Please enter a letter.");
            //char yourLetter = char.Parse(Console.ReadLine());


            ////code wont account for capital letters

            string userLetter = Console.ReadLine().ToLower();
            char userR = char.Parse(userLetter);

            //if (yourLetter == 'a' || yourLetter == 'e') ;
            //else if (yourLetter == 'i' || yourLetter == 'o') ;
            //else if (yourLetter == 'u') ;
            //else

            //    Console.WriteLine("Please enter a whole number.");
            //int firstValue = int.Parse(Console.ReadLine());

            //Console.WriteLine("Please enter a second whole number.");
            //int secondValue = int.Parse(Console.ReadLine());

            //if (firstValue > secondValue)
            //{
            //    Console.WriteLine(firstValue + " is the larger value.");
            //}
            //else if (secondValue > firstValue)
            //{
            //    Console.WriteLine(secondValue + " is the larger value.");
            //}
            //else
            //{
            //    Console.WriteLine()
            //}



            ////what even part are we doing?
            //Console.WriteLine("Please enter four whole numbers.");
            //int firstNum = int.Parse(Console.ReadLine());
            //int secondNum = int.Parse(Console.ReadLine());
            //int thirdNum = int.Parse(Console.ReadLine());
            //int fourthNum = int.Parse(Console.ReadLine());

            ////below commented out for extended purposes
            //double sum = firstNum + secondNum + thirdNum + fourthNum;
            //Console.WriteLine("The average is " + (sum / 4));

            ////i dont like the method below
            //int sum = firstNum + secondNum + thirdNum + fourthNum;
            //double mean = sum / 4d;


            //Console.WriteLine("");
            //int pointsEarned = int.Parse(Console.ReadLine());

            //switch (pointsEarned)
            //{
            //    case 0:
            //        Console.WriteLine("0");
            //        break;

            //    case 1:
            //    Console.WriteLine("Needs practice :/");
            //    break;

            //case 2:
            //    Console.WriteLine("On target.");
            //    break;

            //case 3:
            //    Console.WriteLine("Superstar!");
            //    break;

            //case 4:
            //    Console.WriteLine("Overachiever! :D");
            //    break;

            //case 5:
            //    Console.WriteLine("You cheated >:O");
            //    break;

            //default:
            //    Console.WriteLine("Invalid score enterd. Please check answer provided.");
            //    break;


            Console.WriteLine("");

                    int userInputs = int.Parse(Console.ReadLine());

                    switch (userInputs)
                    {
                        case 1:
                            Console.WriteLine("You entered '1.'");
                            break;
                        case 2:
                            Console.WriteLine("You entered '2.'");
                            break;
                        case 3:
                            Console.WriteLine("You entered '3.'");
                            break;
                        case 4:
                            Console.WriteLine("You entered '4,'");
                            break;
                        case 5:
                            Console.WriteLine("You entered '5,'");
                            break;
                        case 6:
                            Console.WriteLine("You entered '6.'");
                            break;
                    }

        }
    }
}
