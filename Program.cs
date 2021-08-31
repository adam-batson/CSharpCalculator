using System;

namespace Calculator
{
    class Program
    {
        /*
        This program will ask for two numbers. Each time it will validate the given
        input is a number. It will ask again until two numbers are provided.
        Next, it will ask which operation to perform, and accepts several inputs for
        addition, subtraction, multiplication, and division. It checks that a valid
        operation is chosen and asks until one is provided.
        Last, the program asks if the user wants to run it again with two more numbers.
        If the user does not, it will exit, otherwise it begins again with number prompts.
        */

        static void Main(string[] args)
        {
            var finished = false;

            Console.WriteLine("This program will add, subtract, multiply, or divide two numbers you will enter.");

            while (finished == false)
            {
                var times = new string[2] { "1st", "2nd" };
                var firstNumber = TakeInput.GetNumber(times[0]);
                var secondNumber = TakeInput.GetNumber(times[1]);

                Operations.DoMath(firstNumber, secondNumber);
            

                Console.WriteLine("Would you like to repeat the process? (Y/N)");
                var input = Console.ReadLine().ToLower();

                if (input.StartsWith('n')) finished = true;

            }
        }        
    }
}
