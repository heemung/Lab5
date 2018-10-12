using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vars
            bool userCont = true;
            long factorialNum;
            long userNumber;

            //Does the user want to continue loop
            while (userCont)
            {
                //reset usernumber on Continue Loop
                userNumber = -1;

                //Largest Number ammount for factorial is 20. Loops to make sure number is 1-20.
                while(userNumber < 0 || userNumber >= 21)
                {
                    Console.Write("Enter an Integer from 1 to 20: ");
                    userNumber = int.Parse(Console.ReadLine());
                }

                factorialNum = userNumber;

                //Prints Recursion method for the answer.
                Console.WriteLine("{0} {1}", "Recursion", Recursion(userNumber));

                //Runs and Prints for loop for factorial. Deincrements userNumber not i.
                for (int i = 1; i < userNumber; userNumber--)
                {
                    //factorial
                    factorialNum *= (userNumber - 1);
                    Console.WriteLine("The Factorial of {0} is {1}", userNumber, factorialNum);
                }

                //User input for continue. will return userCont true or false.
                Console.WriteLine("Do You Wish To Continue");
                userCont = Console.ReadLine().ToLower() == "y";
            }
            Console.WriteLine("The program will now exit. Press Enter");
            Console.ReadLine();
        }

        //Method for Recursion
        static long Recursion(long temp)
        {

            if (temp == 1)
            {
                return 1;
            }
            return temp * Recursion(temp - 1);

        }
    }

}


