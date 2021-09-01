using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    class Game
    {
        /// <summary>
        ///  Takes user choose of Add, Subtract, Multiply and  Divide then takes two inputs. 
        ///  Than does the operation returns the result. 
        ///  If user wants to continue they can do so. 
        /// </summary>
        public void Run()
        {
            MainOporations();
        }

        // Takes two floats, adds them than returns the solution 
        float Add (float x, float y)
        {
            return (x + y);
        }

        // Takes two floats, subtracts them than returns the solution 
        float Subtract (float x, float y)
        {
            return (x - y); 
        }

        // Takes two floats, Multyplies them than returns the solution 
        float Multipul (float x, float y)
        {
            return (x * y);
        }

        // Takes two floats, Divide them than returns the solution 
        float Divide( float x, float y)
        {
            return (x / y);
        }
        
        /// <summary>
        /// Meant to take user input 
        /// </summary>
        void MainOporations()
        {
            string decision = "NO";
            
            //if user types Yes it will start all over
            while (decision != "yes")
            {
                Console.WriteLine("This is a Calculator, Add(1), Subtract(2), Multiply(3), Divide(4)");
                decision = Console.ReadLine();

                Console.WriteLine("Input First Argument");
                string stringNum1 = Console.ReadLine();

                Console.WriteLine("Input Next Argument");
                string stringNum2 = Console.ReadLine();

                float input1 = 0, input2 = 0;

                //Checks to see if its a valied numerator if not returns false 
                if (float.TryParse(stringNum1, out input1) || float.TryParse(stringNum2, out input2))
                {
                    // Decides what kinds of oporation the user wants to use
                    if (decision == "Add" || decision == "1")
                        Console.WriteLine("Answer: " + Add(input1, input2));

                    else if (decision == "Subtract" || decision == "2")
                        Console.WriteLine("Answer: " + Subtract(input1, input2));

                    else if (decision == "Multiply" || decision == "3")
                        Console.WriteLine("Answer: " + Multipul(input1, input2));

                    else if (decision == "Divide" || decision == "4")
                        Console.WriteLine("Answer: " + Divide(input1, input2));
                    else
                        Console.WriteLine("Encorrect Application");
                }
                else
                    Console.WriteLine("Invaled Numerator");
                
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Task Complete? yes/no ");
                decision = Console.ReadLine();

            }
        }
    }
}