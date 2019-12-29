using ArrayOfNumbers.Actions;
using ArrayOfNumbers.One_Demensional_array;
using ArrayOfNumbers.Two_Demensional_array;
using System;

namespace ArrayOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                int choice = 0;//the variable is mean: 1 - one demensional array, 2 - two demensional array, 3 - exit from app
                choice = InterfaceActions.MakeChoice("Select: \n1 - one demensional array \n2 - two demensional array \n3 - Exit");

                if (choice == 1) // work with one demensional array
                {
                    int choice_1;// the variable is mean: 1 - manually, 2 - automatically 
                    int choice_2; // the variable is mean: 1 - sort by ascending, 2 - by descending

                    OD_Array.EnterLenghtArray();

                    choice_1 = InterfaceActions.MakeChoice("Enter data \n1 - manually \n2 - automatically \n3 - Exit");

                    if (choice_1 == 1) //manually enter numbers
                    {
                        OD_Array.EnterNumbersOfArrayManually();
                    }
                    else if (choice_1 == 2) //automatically enter numbers
                    {
                        OD_Array.RandomNumbersOfArray();
                    }
                    else if (choice_1 == 3)
                    {
                        Environment.Exit(0);
                    }

                    OD_Array.Show();

                    choice_2 = InterfaceActions.MakeChoice("\n1- sort by ascending \n2 - sort by descending \n3 - reverse array");

                    if (choice_2 == 1) // sort by ascending
                    {
                        OD_Array.SortAscending();
                        OD_Array.Show();
                    }
                    else if (choice_2 == 2) // sort by descending
                    {
                        OD_Array.SortDescending();
                        OD_Array.Show();
                    }
                    else if (choice_2 == 3)
                    {
                        OD_Array.ReverseArray();
                        OD_Array.Show();
                    }
                }

                if (choice == 2)
                {
                    TD_Array.EnterSizeTDArray();

                    choice = InterfaceActions.MakeChoice("1 - input manually \n2 - automatically random input \n3- exit");

                    switch (choice)
                    {
                        case 1:
                            TD_Array.EnterNumbersOfTDArrayManually();
                            TD_Array.Show();

                            choice = InterfaceActions.MakeChoice("1 - sort a row \n2 - sort a column \n3 - exit");

                            switch (choice)
                            {
                                case 1:
                                    choice = InterfaceActions.MakeChoice("1 - by ascending \n2 - by descending \n3 - exit");
                                    switch (choice)
                                    {
                                        case 1:
                                            TD_Array.SortAscendingRow();
                                            TD_Array.ShowSortedRow();
                                            TD_Array.GetNegativeNumbers();
                                            break;
                                        case 2:
                                            TD_Array.SortDescendingRow();
                                            TD_Array.ShowSortedRow();
                                            TD_Array.GetNegativeNumbers();
                                            break;
                                        case 3:
                                            Environment.Exit(0);
                                            break;
                                    }
                                    break;
                                case 2:
                                    choice = InterfaceActions.MakeChoice("1 - by ascending \n2 - by descending \n3 - exit");
                                    switch (choice)
                                    {
                                        case 1:
                                            TD_Array.SortAscendingColumn();
                                            TD_Array.ShowSortedColumn();
                                            TD_Array.GetNegativeNumbers();
                                            break;
                                        case 2:
                                            TD_Array.SortDescendingColumn();
                                            TD_Array.ShowSortedColumn();
                                            TD_Array.GetNegativeNumbers();
                                            break;
                                        case 3:
                                            Environment.Exit(0);
                                            break;
                                    }
                                    break;
                                case 3:
                                    Environment.Exit(0);
                                    break;
                            }
                            break;
                        case 2:
                            {
                                TD_Array.RandomNumbersOfTDArray();
                                TD_Array.Show();

                                choice = InterfaceActions.MakeChoice("1 - sort a row \n2 - sort a column \n3 - exit");

                                switch (choice)
                                {
                                    case 1:
                                        choice = InterfaceActions.MakeChoice("1 - by ascending \n2 - by descending \n3 - exit");

                                        switch (choice)
                                        {
                                            case 1:
                                                TD_Array.SortAscendingRow();
                                                TD_Array.ShowSortedRow();
                                                TD_Array.GetNegativeNumbers();
                                                break;
                                            case 2:
                                                TD_Array.SortDescendingRow();
                                                TD_Array.ShowSortedRow();
                                                TD_Array.GetNegativeNumbers();
                                                break;
                                            case 3:
                                                Environment.Exit(0);
                                                break;
                                        }
                                        break;
                                    case 2:
                                        choice = InterfaceActions.MakeChoice("1 - by ascending \n2 - by descending \n3 - exit");
                                        switch (choice)
                                        {
                                            case 1:
                                                TD_Array.SortAscendingColumn();
                                                TD_Array.ShowSortedColumn();
                                                TD_Array.GetNegativeNumbers();
                                                break;

                                            case 2:
                                                TD_Array.SortDescendingColumn();
                                                TD_Array.ShowSortedColumn();
                                                TD_Array.GetNegativeNumbers();
                                                break;

                                            case 3:
                                                Environment.Exit(0);
                                                break;
                                        }
                                        break;
                                    case 3:
                                        Environment.Exit(0);
                                        break;
                                }
                            }

                            break;
                        case 3:
                            Environment.Exit(0);
                            break;
                    }
                }

                if (choice == 3)
                {
                    Environment.Exit(0);
                }
            }

        }
    }
}
