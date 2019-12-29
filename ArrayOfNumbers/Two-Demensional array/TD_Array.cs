using System;

namespace ArrayOfNumbers.Two_Demensional_array
{
    public static class TD_Array
    {
        /// <summary>
        /// Two-demensional array.
        /// </summary>
        private static int[,] td_array;

        /// <summary>
        /// A row of the array.
        /// </summary>
        private static int row;
        
        /// <summary>
        /// User's row.
        /// </summary>
        private static int selectedRow;

        /// <summary>
        /// User's column.
        /// </summary>
        private static int selectedColumn;
        /// <summary>
        /// A column of the array
        /// </summary>
        private static int column;

        /// <summary>
        /// The method allows to enter the size of the two-demensional array.
        /// </summary>
        public static void EnterSizeTDArray()
        {
            bool isCorrect = true;
            bool isCorrect_row = true;
            bool isCorrect_column = true;

            while (isCorrect)
            {
                Console.WriteLine("Enter size of array.");

                while (isCorrect_row)
                {
                    Console.Write("count of rows - ");

                    if (isCorrect_row = !Int32.TryParse(Console.ReadLine(), out row))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong format! Use integer numbers. Try again.\n");
                        Console.ResetColor();
                    }
                    else if (row < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong format! The lengt cannot be negative. Try again.\n");
                        Console.ResetColor();

                        isCorrect_row = true;
                    }
                }

                while (isCorrect_column)
                {
                    Console.Write("count of columns - ");

                    if (isCorrect_column = !Int32.TryParse(Console.ReadLine(), out column))
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong format! Use integer numbers. Try again.\n");
                        Console.ResetColor();
                    }
                    else if (column < 0)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Wrong format! The lengt cannot be negative. Try again.\n");
                        Console.ResetColor();

                        isCorrect_column = true;
                    }
                }

                if (isCorrect)
                {
                    td_array = new int[row, column];
                    isCorrect = false;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method allows to fill the array random numbers in range 0..99.
        /// </summary>
        public static void RandomNumbersOfTDArray()
        {
            Random rnd = new Random();

            for (int i = 0; i < row; i++)
            {
                for (int j = 0; j < column; j++)
                {
                    td_array[i, j] = rnd.Next(-100, 100);
                }
            }
        }

        /// <summary>
        /// The method allows to enter manually values of elements in the array.
        /// </summary>
        public static void EnterNumbersOfTDArrayManually()
        {
            bool isCorrect = true; // flag for "while"

            while (isCorrect)
            {
                Console.WriteLine("Enter values of the elemetnts in the array: ");

                for (int i = 0; i < row; i++)
                {
                    for (int j = 0; j < column; j++)
                    {
                        bool flag = true; //flag for "while"

                        while (flag)
                        {
                            Console.Write($"[{i},{j}] - ");

                            if (isCorrect = !Int32.TryParse(Console.ReadLine(), out int num))
                            {
                                Console.ForegroundColor = ConsoleColor.Red;
                                Console.WriteLine("Wrong format! Try again.");
                                Console.ResetColor();
                            }
                            else
                            {
                                td_array[i, j] = num;
                                flag = false;
                            }
                        }
                    }
                }
                Console.WriteLine();
            }
        }

        /// <summary>
        /// The method sorts the array's rows by ascending.
        /// </summary>
        /// <param name="row">User's row</param>
        public static void SortAscendingRow()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Choose a row");

                bool isCorrect = Int32.TryParse(Console.ReadLine(), out selectedRow);

                if (!isCorrect || (selectedRow >= td_array.GetLength(0) || selectedRow < 0))
                {
                    Console.WriteLine("Wrong format. Try again.");
                    flag = true;
                }
                else
                {
                    int[] tempArray = new int[td_array.GetLength(0)]; // temporary one-demnsional array

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        tempArray[i] = td_array[selectedRow, i];
                    }

                    for (int i = 0; i < tempArray.Length - 1; i++) //sort by ascending
                    {
                        for (int j = i; j < tempArray.Length; j++)
                        {
                            if (tempArray[i] > tempArray[j])
                            {
                                int temp = tempArray[i];
                                tempArray[i] = tempArray[j];
                                tempArray[j] = temp;
                            }
                        }
                    }

                    for (int i = 0; i < tempArray.Length; i++) //import row in the two-demensional array
                    {
                        td_array[selectedRow, i] = tempArray[i];
                    }

                    flag = false;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method sorts the array's row by descending. 
        /// </summary>
        /// <param name="row">User's row</param>
        public static void SortDescendingRow()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Choose a row");

                bool isCorrect = Int32.TryParse(Console.ReadLine(), out selectedRow);

                if (!isCorrect || (selectedRow >= td_array.GetLength(0) || selectedRow < 0))
                {
                    Console.WriteLine("Wrong format. Try again.");
                    flag = true;
                }
                else
                {
                    int[] tempArray = new int[td_array.GetLength(0)]; // temporary one-demnsional array

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        tempArray[i] = td_array[selectedRow, i];
                    }

                    for (int i = 0; i < tempArray.Length - 1; i++) //sort by descending
                    {
                        for (int j = i; j < tempArray.Length; j++)
                        {
                            if (tempArray[i] < tempArray[j])
                            {
                                int temp = tempArray[i];
                                tempArray[i] = tempArray[j];
                                tempArray[j] = temp;
                            }
                        }
                    }

                    for (int i = 0; i < tempArray.Length; i++) //import row in the two-demensional array
                    {
                        td_array[selectedRow, i] = tempArray[i];
                    }

                    flag = false;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method sorts the array's column by ascending.
        /// </summary>
        /// <param name="column"></param>
        public static void SortAscendingColumn()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Choose a column");

                bool isCorrect = Int32.TryParse(Console.ReadLine(), out selectedColumn);

                if (!isCorrect || (selectedColumn >= td_array.GetLength(1) || selectedColumn < 0))
                {
                    Console.WriteLine("Wrong format. Try again.");
                    flag = true;
                }
                else
                {
                    int[] tempArray = new int[td_array.GetLength(1)]; // temporary one-demnsional array

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        tempArray[i] = td_array[i, selectedColumn];
                    }

                    for (int i = 0; i < tempArray.Length - 1; i++) //sort by ascending
                    {
                        for (int j = i; j < tempArray.Length; j++)
                        {
                            if (tempArray[i] > tempArray[j])
                            {
                                int temp = tempArray[i];
                                tempArray[i] = tempArray[j];
                                tempArray[j] = temp;
                            }
                        }
                    }

                    for (int i = 0; i < tempArray.Length; i++) //import row in the two-demensional array
                    {
                        td_array[i, selectedColumn] = tempArray[i];
                    }

                    flag = false;
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method sorts the array's column by descending
        /// </summary>
        /// <param name="column"></param>
        public static void SortDescendingColumn()
        {
            bool flag = true;

            while (flag)
            {
                Console.WriteLine("Choose a column");

                bool isCorrect = Int32.TryParse(Console.ReadLine(), out selectedColumn);

                if (!isCorrect || (selectedColumn >= td_array.GetLength(1) || selectedColumn < 0))
                {
                    Console.WriteLine("Wrong format. Try again.");
                    flag = true;
                }
                else
                {
                    int[] tempArray = new int[td_array.GetLength(1)]; // temporary one-demnsional array

                    for (int i = 0; i < tempArray.Length; i++)
                    {
                        tempArray[i] = td_array[i, selectedColumn];
                    }

                    for (int i = 0; i < tempArray.Length - 1; i++) //sort by ascending
                    {
                        for (int j = i; j < tempArray.Length; j++)
                        {
                            if (tempArray[i] < tempArray[j])
                            {
                                int temp = tempArray[i];
                                tempArray[i] = tempArray[j];
                                tempArray[j] = temp;
                            }
                        }
                    }

                    for (int i = 0; i < tempArray.Length; i++) //import row in the two-demensional array
                    {
                        td_array[i, selectedColumn] = tempArray[i];
                    }

                    flag = false;
                }
            }
            Console.WriteLine();
        }

        public static void GetNegativeNumbers()
        {
            int count = 0;

            for (int i = 0; i < td_array.GetLength(0); i++)
            {
                for (int j = 0; j < td_array.GetLength(1)-1; j++)
                {
                    if (td_array[i, j] < 0)
                        count++;
                }
            }

            Console.WriteLine($"Count of negative numbers: {count}\n");
        }

        /// <summary>
        /// The method shows array
        /// </summary>
        public static void Show()
        {
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < column; j++)
                {
                    Console.Write($"{td_array[i, j]}\t");
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method shows row of the array sorted by asecending. 
        /// </summary>
        /// <param name="selectedRow">User's row</param>
        public static void ShowSortedRow()
        {
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < column; j++)
                {
                    if (!(i == selectedRow))
                    {
                        Console.Write($"{td_array[i, j]}\t");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{td_array[i, j]}\t");
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine();
        }

        /// <summary>
        /// The method shows column of the arra sorted by ascending.
        /// </summary>
        /// <param name="selectedColumn">User's column</param>
        public static void ShowSortedColumn()
        {
            for (int i = 0; i < row; i++)
            {
                Console.WriteLine();

                for (int j = 0; j < column; j++)
                {
                    if (!(j == selectedColumn))
                    {
                        Console.Write($"{td_array[i, j]}\t");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write($"{td_array[i, j]}\t");
                        Console.ResetColor();
                    }
                }
            }
            Console.WriteLine();
        }
    }
}
