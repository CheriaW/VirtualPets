using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace in_class_practicing
{
    class Program
    {
        static void Main(string[] args)
        {

            // readlines go under "main"
            //all you want the calculator to do is calculate, not ask questions
            Console.WriteLine(wageCalc(7, 8.89));
            //    //string firstName = ("Cheria");
            //    //Console.WriteLine(firstName.Length);

            //    //string lastName = ("White");
            //    //Console.WriteLine(lastName.Length);

            //    //if (firstName.Length > lastName.Length)

            //    //{
            //    //    Console.WriteLine("First name is longer.");
            //    //}

            //    //else
            //    //{
            //    //    Console.WriteLine("Last name is longer.");
            //    //}

            //    ////in class practice with METHODS- no one getrs it
            //    //Console.WriteLine("Please enter a name");
            //    //string name = Console.ReadLine();

            //    //Console.WriteLine("Please enter the best food ever!");
            //    //string food = Console.ReadLine();
            //    //FavFood(name, food);

            //    ////different strategy, breaking up lines
            //    //FavFood("Cheria", "steak!");
            //    //FavFood("Isaiah", "cookies!");
            //    //FavFood("Zayria", "everything.");



            //    RetirementCalculator(90);
            //    //if someone types in a number greater than 65 the output number would be negative
            //    //if this happens we could use conditionals, use if-else?
            //    //possible solution to the aboive scenario...


            //}

            ////new method? do different methods have specific names?

            //    public static void RetirementCalculator( int age)
            //{


            //    //possible solution to abouve scenario
            //    int retirementAge = Math.Max(0, 65 - age);
            //    Console.WriteLine("The user will retire in " + retirementAge + "years!");
            //    //int retirementAge = 65 - age;
            //    //Console.WriteLine("The user will retire in " + retirementAge + "years.");

            //}

            ////method header, void specifies what the return type is

            //public static void FavFood(string name, string food)
            //{
            //    //different strategy, breaking up lines (50 & 52)
            //    Console.WriteLine(" ");
            //    Console.WriteLine(name + "'s favorite food is " + food);
            //    Console.WriteLine();


        }
       

        public static double wageCalc(double hoursWorked, double hourlyWage)
        {
          
            double wageCalc = (hoursWorked * hourlyWage);

            return wageCalc;


        }

        }


        }
       

     
    

