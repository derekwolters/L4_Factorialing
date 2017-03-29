using System;
///-----------------------------------------------------------------------------
///   Namespace:    L4_Factoraling
///   Description:  Input a number to get its factorial
///   Author:       Derek Wolters                
///   Date:         3.29.17
///   Revision History:
///   Name:           Date:        Description:
///-----------------------------------------------------------------------------

namespace L4_Factorialing
{
    class Factorialing
    {
        static void Main(string[] args)
        {
            //initialize variables
            bool keepGoing = true;

            Console.WriteLine("This program will give the factorial a given " +
                "number");

            while (keepGoing)
            {
                //get input, calculate and display the results
                Console.WriteLine(CalcFactorial(GetInput()));

                //exit program               
                if (ExitProgram()) break;
            }
        }
        //get the user's number
        public static int GetInput()
        {
            string input = "";
            int temp;

            Console.WriteLine("Enter a whole number from 1 to 10:");
            input = Console.ReadLine();

            if (!int.TryParse(input, out temp))
            {
                //check that input is an integer & ask for reentry if not
                Console.WriteLine("Input should be a whole number. " +
                    "Try again.");
                return GetInput();
            }
            else if (temp < 1 || temp > 10)
            {
                //check that input is withing range & ask for reentry if not
                Console.WriteLine("Input should be greater than 1 or less " +
                     " than 10. Try again.");
                return GetInput();
            }
            else { return temp; }
        }

        //calculate the results
        public static int CalcFactorial(int num)
        {
            if (num == 0)
            {
                return 1;
            }

            return num * CalcFactorial(num - 1);
        }

        //exit the program when the user wants to
        public static Boolean ExitProgram()
        {
            string xitChoice = "";

            Console.WriteLine("Do you want to continue? Enter Y or N.");

            xitChoice = Console.ReadLine().ToUpper();

            while (xitChoice != "N" && xitChoice != "Y")
            {
                Console.WriteLine("Not a vaid answer. Do you want to " +
                    "continue? Enter Y or N.");
                xitChoice = Console.ReadLine().ToUpper();
            }

            return xitChoice == "N" ? true : false;
        }
    }
}
