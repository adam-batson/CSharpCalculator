using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    public class Operations
    {
        /*
        This class takes two numbers as inputs, then asks which of
        four math operations the user would like to perform:
        add, subtract, multiply, or divide.

        It validates that input is one of those four operations, then
        performs the chosen operation. It will repeatedly ask if an
        invalid input is given, but also accepts some input that exits
        the program.

        Then, the result is calculated based on the chosen operation.
        The program will catch DivideByZeroException and ask for a
        different, valid operation for the given numbers.

        When it performs an operation, it prints the result to the console.
        */
        public static void DoMath(decimal num1, decimal num2)
        {
            var possibleOperators = new Dictionary<string, int>()
            {
                {"add", 0}, {"addition", 0}, {"+", 0}, {"plus", 0},
                {"subtract", 1}, {"minus", 1}, {"-", 1}, {"subtraction", 1},
                {"multiply", 2}, {"times", 2}, {"multiplication", 2}, {"x", 2}, {"*", 2 },
                {"divide", 3}, {"\u00F7", 3}, {"/", 3}, {"\\", 3}, {"division", 3},
                {"quit", 4}, {"q", 4}, {"stop", 4}, {"exit", 4}
            };

            var operationPerformed = new string[4] { "added to", "minus", "times", "divided by" };

            var result = 0m;
            var input = "";
            var whichOperator = 0;
            var operationFound = false;        
            
            while(operationFound == false)
            {
                Console.WriteLine("Would you like to add, subtract, multiply, or divide?\nType your choice:");
                input = Console.ReadLine().ToLower();

                if (possibleOperators.TryGetValue(input, out whichOperator))
                {
                    operationFound = true;
                    switch(whichOperator)
                    {
                        case 0:
                            result = num1 + num2;
                            break;
                        case 1:
                            result = num1 - num2;
                            break;
                        case 2:
                            result = num1 * num2;
                            break;
                        case 3:
                            try
                            {
                                result = num1 / num2;
                            }
                            catch(DivideByZeroException)
                            {
                                Console.WriteLine("You can't divide by zero. Try a different operator.");
                                DoMath(num1, num2);
                            }
                            break;
                        case 4:
                            Console.WriteLine("Exiting program...");
                            Environment.Exit(0);
                            break;
                        default:
                            break;

                    }

                    Console.WriteLine($"{num1} {operationPerformed[whichOperator]} {num2} equals {result}.");
                }
                else
                {
                    Console.WriteLine("That's not a valid operation for this program.");
                }
            }
        }
    }
}
