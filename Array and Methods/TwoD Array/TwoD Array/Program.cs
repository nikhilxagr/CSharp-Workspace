using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoD_Array
{
    internal class Program
    {
        static void Main(string[] args)
    {
        Console.Write("Enter number of rows: ");
        int rows = Convert.ToInt32(Console.ReadLine());

        Console.Write("Enter number of columns: ");
        int cols = Convert.ToInt32(Console.ReadLine());

        int matrix1 = new int[rows, cols];
        int matrix2 = new int[rows, cols];
        int sum = new int[rows, cols];

        Console.WriteLine("\nEnter elements for Matrix 1:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        Console.WriteLine("\nEnter elements for Matrix 2:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                matrix2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }

        // Adding matrices
        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                sum[i, j] = matrix1[i, j] + matrix2[i, j];
            }
        }

        // Display
        Console.WriteLine("\nSum of Matrices:");

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(sum[i, j] + " ");
            }
            Console.WriteLine();

            Console.ReadLine();
        }
    }
}