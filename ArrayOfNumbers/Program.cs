using ArrayOfNumbers.Actions;
using ArrayOfNumbers.One_Demensional_array;
using System;

namespace ArrayOfNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {              
                int choice;//the variable is mean: 1 - one demensional array, 2 - two demensional array.
                choice = InterfaceActions.MakeChoice("Select: \n1 - one demensional array \n2 - two demensional array");

                if (choice == 1) // work with one demensional array
                {
                    int choice_1;// the variable is mean: 1 - manually, 2 - automatically 
                    int choice_2; // the variable is mean: 1 - sort by ascending, 2 - by descending

                    OD_Array.EnterLenghtArray();

                    choice_1 = InterfaceActions.MakeChoice("Enter data \n1 - manually \n2 - automatically\n");
                    
                    if (choice_1 == 1) //manually enter numbers
                    {
                        OD_Array.EnterNumbersOfArray();
                    }
                    else if (choice_1 == 2) //automatically enter numbers
                    {
                        OD_Array.RandomNumbersOfArray();
                    }

                    OD_Array.Show();

                    choice_2 = InterfaceActions.MakeChoice("Sort: \n1 - ascending\n2 - descending");                    

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
                }
            }

        }
    }
}
