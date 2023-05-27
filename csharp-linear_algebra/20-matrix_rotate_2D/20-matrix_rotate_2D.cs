﻿using System;

/// <summary>
/// MatrixMath main class.
/// </summary>
class MatrixMath
{
    /// <summary>
    /// Method that multiplies two matrices and returns the resulting matrix.
    /// </summary>
    /// <param name="matrix1">Matrix 1</param>
    /// <param name="matrix2">Matrix 2</param>
    /// <returns>Returns the new matrix</returns>
    public static double[,] Multiply(double[,] matrix1, double[,] matrix2)
    {
        if (matrix1.Length == 0 ||
            matrix2.Length == 0 ||
            matrix1.GetLength(1) != matrix2.GetLength(0))
        {
            return new double[,] { { -1 } };
        }

        var res = new double[matrix1.GetLength(0), matrix2.GetLength(1)];

        for (int y = 0; y < matrix1.GetLength(0); y++)
        {
            for (int x2 = 0; x2 < matrix2.GetLength(1); x2++)
            {
                double sum = 0;
                for (int x = 0; x < matrix1.GetLength(1); x++)
                {
                    sum += matrix1[y, x] * matrix2[x, x2];
                }
                res[y, x2] = Math.Round(sum, 2);
            }
        }

        return res;
    }

    /// <summary>
    /// Method that rotates a square 2D matrix by a given angle in radians
    /// </summary>
    /// <param name="matrix">Matrix to rotate</param>
    /// <param name="angle">New angle</param>
    /// <returns>Returns the resulting matrix.</returns>
    public static double[,] Rotate2D(double[,] matrix, double angle)
    {
        double cosAngle = Math.Cos(angle);
        double sinAngle = Math.Sin(angle);
        var rotation = new double[2, 2] { { cosAngle, sinAngle }, { -sinAngle, cosAngle } };
        var res = Multiply(matrix, rotation);
        return res;
    }
}
