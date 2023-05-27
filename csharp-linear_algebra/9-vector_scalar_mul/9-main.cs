using System;

class Program
{
    static void Main(string[] args)
    {
        double[] vector = { 1.5, 2.0, 3.5 }; // Example vector
        double scalar = 2.0; // Example scalar

        double[] result = VectorMath.Multiply(vector, scalar);

        Console.WriteLine("Original vector: [{0}]", string.Join(", ", vector));
        Console.WriteLine("Scalar: {0}", scalar);

        if (result.Length == 1 && result[0] == -1)
        {
            Console.WriteLine("Invalid vector size. Please provide a vector with 2 or 3 elements.");
        }
        else
        {
            Console.WriteLine("Result: [{0}]", string.Join(", ", result));
        }
    }
}
