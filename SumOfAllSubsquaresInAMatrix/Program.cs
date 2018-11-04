using System;

namespace SumOfAllSubsquaresInAMatrix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum of all sub-squares of size K in a Square matrix!");
            Console.WriteLine("----------------------------------------------------");

            int[,] squareMatrix = GetMatrix();
            Console.WriteLine("Enter the sub-square matrix size");
            try
            {
                int subSquareSize = int.Parse(Console.ReadLine());
                MatrixProcessor matrixProcessor = new MatrixProcessor(squareMatrix);
                matrixProcessor.GetSumOfSubsquaresInSquareMatrix(subSquareSize);
            }
            catch (Exception exception) {
                Console.WriteLine("The thrown exception is"+exception.Message);
            }

            Console.ReadLine();
        }

        private static int[,] GetMatrix() {
            int[,] squareMatrix = null;
            Console.WriteLine("Enter the dimension of the square matrix");
            try
            {
                int dimension = int.Parse(Console.ReadLine());
                squareMatrix = new int[dimension, dimension];
                for (int i = 0; i < dimension; i++)
                {                    
                    Console.WriteLine("Enter the elements of the row:" + i + "" +
                        " separated by space");
                    String allElementString = Console.ReadLine();
                    String[] elements = allElementString.Split(' ');
                    for (int j = 0; j < elements.Length; j++) {
                        squareMatrix[i, j] = int.Parse(elements[j]);
                    }
                }
            }
            catch (Exception exception) {
                Console.WriteLine("The thrown exception is"+exception.Message);
            }
            return squareMatrix;
        }
    }
}
