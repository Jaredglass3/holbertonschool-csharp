using System;

class VectorMath
{
    public static double DotProduct(double[] vector1, double[] vector2)
    {
        if (vector1.Length != vector2.Length)
            return -1;

        if (vector1.Length > 3 || vector1.Length < 2)
            return -1;

        double[] new_vect = new double[vector1.Length];
        double result = 0;

        for (int i = 0; i < vector1.Length; i++)
            new_vect[i] = vector1[i] * vector2[i];

        for (int i = 0; i < vector1.Length; i++)
            result += new_vect[i];

        return result;
    }

    static void Main(string[] args)
    {
        // Test the DotProduct method here
        double[] vector1 = { 1.5, 2.5, 3.5 }; // Example vector 1
        double[] vector2 = { 2.0, 3.0, 4.0 }; // Example vector 2

        double dotProduct = DotProduct(vector1, vector2);

        Console.WriteLine("Vector 1: [{0}]", string.Join(", ", vector1));
        Console.WriteLine("Vector 2: [{0}]", string.Join(", ", vector2));
        Console.WriteLine("Dot Product: {0}", dotProduct);
    }
}
