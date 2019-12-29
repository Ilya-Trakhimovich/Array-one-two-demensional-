using System;
using System.Collections.Generic;
using System.Text;

namespace ArrayOfNumbers.One_Demensional_array
{
    /// <summary>
    /// The class for work with one demensional array
    /// </summary>
    public static class OD_Array
    {
        /// <summary>
        /// Length of array.
        /// </summary>
        private static int lenght;

        /// <summary>
        /// One demensional array
        /// </summary>
        private static int[] od_array;

        /// <summary>
        /// The method allows to enter a length of the array.
        /// </summary>
        public static void EnterLenghtArray()
        {
            bool isCorrect = true; // flag for "while" 

            while (isCorrect)
            {
                Console.Write("Enter length of array: ");

                if (isCorrect = !Int32.TryParse(Console.ReadLine(), out lenght))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong format! Use integer numbers. Try again.\n");
                    Console.ResetColor();
                }
                else if (lenght < 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Wrong format! The lengt cannot be negative. Try again.\n");
                    Console.ResetColor();
                    isCorrect = true;
                }
                else
                {
                    od_array = new int[lenght];
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method allows to enter manually values of elements in the array.
        /// </summary>
        public static void EnterNumbersOfArrayManually()
        {
            bool isCorrect = true; // flag for "while"

            while (isCorrect)
            {
                Console.WriteLine("Enter values of the elemetnts in the array: ");

                for (int i = 0; i < od_array.Length; i++)
                {
                    bool flag = true; //flag for "while"

                    while (flag)
                    {
                        Console.Write($"[{i + 1}] - ");

                        if (isCorrect = !Int32.TryParse(Console.ReadLine(), out int num))
                        {
                            Console.ForegroundColor = ConsoleColor.Red;
                            Console.WriteLine("Wrong format! Try again.");
                            Console.ResetColor();
                        }
                        else
                        {
                            od_array[i] = num;
                            flag = false;
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// The method allows to fill the array random numbers in range 0..99.
        /// </summary>
        public static void RandomNumbersOfArray()
        {
            Random rnd = new Random();

            for (int i = 0; i < od_array.Length; i++)
            {
                od_array[i] = rnd.Next(100);
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method shows values of the elements fo the array.
        /// </summary>
        public static void Show()
        {
            Console.WriteLine("Your array: ");
            Console.ForegroundColor = ConsoleColor.DarkCyan;

            foreach (var i in od_array)
            {
                Console.Write($"{i} ");
            }
            Console.ResetColor();
            Console.WriteLine("\n");
        }

        /// <summary>
        /// The method sorts the array by ascending.
        /// </summary>
        public static void SortAscending()
        {
            for (int i = 0; i < od_array.Length-1; i++)
            {
                for (int j = i; j < od_array.Length; j++)
                {
                    if (od_array[i] > od_array[j])
                    {
                        int temp = od_array[i];
                        od_array[i] = od_array[j];
                        od_array[j] = temp;
                    }
                }
            }
        }

        /// <summary>
        /// The method sorst the array by descending.
        /// </summary>
        public static void SortDescending()
        {
            for (int i = 0; i < od_array.Length - 1; i++)
            {
                for (int j = i; j < od_array.Length; j++)
                {
                    if (od_array[i] < od_array[j])
                    {
                        int temp = od_array[i];
                        od_array[i] = od_array[j];
                        od_array[j] = temp;
                    }
                }
            }
        }

        public static void ReverseArray()
        {
            for (int i = 0, a = od_array.Length-1; i < od_array.Length/2; i++, a--)
            {
                int temp = od_array[i];
                od_array[i] = od_array[a];
                od_array[a] = temp;
            }
        }
    }
}
