using System;

class Program
{
    static void Main(string[] args)
    {
        double[,] matrix1 = { { 1, 2 }, { 3, 4 } }; // Example matrix 1
        double[,] matrix2 = { { 5, 6 }, { 7, 8 } }; // Example matrix 2
        double[,] result;

        Console.WriteLine("Matrix 1:");
        PrintMatrix(matrix1);

        Console.WriteLine("Matrix 2:");
        PrintMatrix(matrix2);

        result = MatrixMath.Multiply(matrix1, matrix2);

        Console.WriteLine("Matrix Multiplication Result:");
        if (result.GetLength(0) == 1 && result.GetLength(1) == 1 && result[0, 0] == -1)
        {
            Console.WriteLine("Invalid matrix sizes. Please provide matrices with compatible dimensions.");
        }
        else
        {
            PrintMatrix(result);
        }

        double angle = Math.PI / 4; // Example angle in radians
        result = MatrixMath.Rotate2D(matrix1, angle);

        Console.WriteLine("Matrix Rotation Result:");
        PrintMatrix(result);
    }

    static void PrintMatrix(double[,] matrix)
    {
        int rows = matrix.GetLength(0);
        int cols = matrix.GetLength(1);

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < cols; j++)
            {
                Console.Write(matrix[i, j] + " ");
            }
            Console.WriteLine();
        }

        Console.WriteLine();
    }
}
