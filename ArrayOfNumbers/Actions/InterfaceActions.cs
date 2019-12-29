using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOfNumbers.Actions
{
    public static class InterfaceActions
    {
        /// <summary>
        /// Flag for "while"
        /// </summary>
        private static bool isChoice = true;

        /// <summary>
        /// Result of the method "MakeChoice"
        /// </summary>
        private static int result;

        /// <summary>
        /// Result of "TryParse();"
        /// </summary>
        private static int choice;

        public static int MakeChoice(string message)
        {
            isChoice = true;

            while (isChoice)
            {
                Console.WriteLine(message);

                if (isChoice = !Int32.TryParse(Console.ReadLine(), out choice))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong format! Try again.\n");
                    Console.ResetColor();
                }
                else if (choice != 1 && choice != 2 && choice != 3)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong format! Try again.\n");
                    Console.ResetColor();

                    isChoice = true;
                }
            }

            if (choice == 1)
            {
                result = 1;
            }
            else if (choice == 2)
            {
                result = 2;
            }
            else if (choice == 3)
            {
                result = 3;
            }

            Console.WriteLine();
            return result;
        }
    }
}
