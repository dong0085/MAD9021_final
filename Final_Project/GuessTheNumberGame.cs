using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_Project
{
    internal class GuessTheNumberGame
    {

        // Fields
        private int guessCount = 0;
        private string input;
        private const int MAX_MENU = 3;
        private const int MIN_MENU = 0;
        private RangedRandomInteger secretNumberGenerator;

        public GuessTheNumberGame() { }

        public void start()
        {
            do
            {
                int userChoice = ShowMenu();

                if (userChoice == 0)
                {
                    break;
                }
            } while (input != "n");
        }

        private int ShowMenu()
        {
            Console.Clear();
            Console.WriteLine("______________________________________________________");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|         Welcome to the Number Guessing Game!       |");
            Console.WriteLine("|____________________________________________________|");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  1: Easy : Guess a number between 1 and 20         |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  2: Normal : Guess a number between 1 and 100      |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  3: Hard : Guess a number between 1 and 1000       |");
            Console.WriteLine("|                                                    |");
            Console.WriteLine("|  0: Exit Game                                      |");
            Console.WriteLine("|____________________________________________________|");
            // do... while
                int userChoice = Convert.ToInt32(input);
                bool validInput = false;
            do
            {
                try
                {
                    Console.Write("Enter your choice: ");
                    input = Console.ReadLine();
                }
                catch (Exception e)
                {
                    if (e is FormatException || e is OverflowException)
                    {
                        Console.WriteLine("Invalid input. Please enter a number between 0 and 3.");
                    }
                }
                if (userChoice >= MIN_MENU && userChoice <= MAX_MENU)
                {
                    validInput = true;
                }
                else
                {
                    Console.WriteLine("Enter a valid number between 0 to 3");
                }
            } while (!validInput);

            return 0;
        }

    }
}
