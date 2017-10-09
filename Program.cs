using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabNumber9
{
    class Program
    {
        static void Main(string[] args)
        {
            bool ContinueProgram = true;
            while (ContinueProgram == true)
            {

                double radius;
                Circle RadiusCalc = new Circle();

                Console.WriteLine("Welcome to the Circle Tester");
                Console.WriteLine("Enter radius:");
                radius = double.Parse(Console.ReadLine());
                while (!double.TryParse(Console.ReadLine(), out radius))
                {
                    {
                        Console.WriteLine("Please enter a valid number");
                    }

                }

                string userChoice;
                Console.WriteLine("Continue? (y/n)");
                userChoice = Console.ReadLine();

                if (userChoice == "n")
                {
                    ContinueProgram = false;
                    Console.WriteLine("Goodbye. You created two circle object(s).");

                }

                Console.ReadKey();


            }
        }
    }
}