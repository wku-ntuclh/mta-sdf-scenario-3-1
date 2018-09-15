using System;

namespace Scenario_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] array = new int[4, 5]; //creates a 2-d array of 4 rows and 5 columns

            generateArrayValues(array);
            printArray(array);
            printLargestInRow(array);
        }

        static void generateArrayValues(int[,] a)
        {
            Random r = new Random();

            int numRows = a.GetLength(0);
            int numCols = a.GetLength(1);

            for (int i = 0; i < numRows; i++)
            {
                for (int j = 0; j < numCols; j++)
                {
                    a[i, j] = r.Next(1, 100);
                }

            }
        }

        static void printArray(int[,] a)
        {
            int numRows = a.GetLength(0);
            int numCols = a.GetLength(1);

            for (int i = 0; i < numRows; i++)
            {
                for(int j = 0; j < numCols; j++)
                {
                    Console.Write("{0} ", a[i, j]);
                }

                Console.WriteLine(); //newline
            }
        }
        
        static void printLargestInRow(int[,] a)
        {
            int numRows = a.GetLength(0);
            int numCols = a.GetLength(1);

            // for each row, determine the largest
            for (int i = 0; i < numRows; i++)
            {
                int largest = a[i, 0]; // first set the first row element to be the largest
                for (int j = 1; j < numCols; j++) // compare the rest of array elements
                {
                    if(a[i,j] > largest) // if larger than current largest
                    {
                        largest = a[i, j]; // set it to be the new largest
                    }
                }

                Console.WriteLine(largest); 
            }
        }
    }
}
