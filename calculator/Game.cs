using System;
using System.Collections.Generic;
using System.Text;

namespace calculator
{
    class Game
    {
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

        // Takes two floats, Devides them than returns the solution 
        float Devide ( float x, float y)
        {
            return (x / y);
        }
        

        void MainOporations()
        {
            string decision = "NO";
            
            while (decision != "yes")
            {
                Console.WriteLine("This is a Calculator, Add(1), Subtract(2), Multipuly(3), Devide(4)");
                decision = Console.ReadLine();

                Console.WriteLine("Input First Argument");
                string stringNum1 = Console.ReadLine();

                Console.WriteLine("Input Next Argument");
                string stringNum2 = Console.ReadLine();

                float input1 = float.Parse(stringNum1);

                float input2 = float.Parse(stringNum2);


                if (decision == "Add" || decision == "1")
                    Console.WriteLine("Answer: " + Add(input1, input2));

                else if (decision == "Subtract" || decision == "2")
                    Console.WriteLine("Answer: " + Subtract(input1, input2));

                else if (decision == "Multipul" || decision == "3")
                    Console.WriteLine("Answer: " + Multipul(input1, input2));

                else if (decision == "Devide" || decision == "4")
                    Console.WriteLine("Answer: " + Devide(input1, input2));
                else
                    Console.WriteLine("Encorrect Appication");



                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("Task Complete? ");
                decision = Console.ReadLine();

            }
        }
    }
}