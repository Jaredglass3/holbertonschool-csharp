using System;

class VectorMath
{
    public static double[] Multiply(double[] vector, double scalar)
    {
        double[] fail = new double[] {-1}; 
        if (vector.Length > 3 || vector.Length < 2)
            return fail;

        double[] new_vect = new double[vector.Length];
        for (int i = 0; i < vector.Length; i++)
            new_vect[i] = vector[i] * scalar;

        return new_vect;
    }

    static void Main(string[] args)
    {
        // Test the Multiply method here
        double[] vector = { 1.5, 2.5, 3.5 }; // Example vector
        double scalar = 2.0; // Example scalar value

        double[] result = Multiply(vector, scalar);

        Console.WriteLine("Original vector: [{0}]", string.Join(", ", vector));
        Console.WriteLine("Scalar: {0}", scalar);
        Console.WriteLine("Result: [{0}]", string.Join(", ", result));
    }
}
