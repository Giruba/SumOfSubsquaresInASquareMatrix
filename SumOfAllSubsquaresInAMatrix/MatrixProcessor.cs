using System;
using System.Collections.Generic;
using System.Text;

namespace SumOfAllSubsquaresInAMatrix
{
    class MatrixProcessor
    {
        int[,] matrix;

        public MatrixProcessor(int[,] matrix) {
            this.matrix = matrix;
        }

        public void GetSumOfSubsquaresInSquareMatrix(int subSquareSize) {

            Console.WriteLine("-----------The Input Matrix---------------------");
            PrintMatrix(matrix);

            int dimension = matrix.GetLength(0);
            int[,] subSquareMatrix = new int[subSquareSize, subSquareSize];

            for (int i = 0; i < subSquareSize; i++) {
                for (int j = 0; j < subSquareSize; j++) {
                    subSquareMatrix[i, j] = GetSubSquareMatrixSum(i,j,subSquareSize);
                }
            }

            Console.WriteLine("-------------The SubSquare Sum Matrix-----------");
            PrintMatrix(subSquareMatrix);
        }

        private int GetSubSquareMatrixSum(int i, int j, int SubSquareSize) {

            int subSquareSum = 0;

            int rows = i + SubSquareSize;
            int columns = j + SubSquareSize;

            for (int index = i; index < rows; index++) {
                for (int secondIndex = j; secondIndex < columns; secondIndex++) {
                    subSquareSum += matrix[index, secondIndex];
                }
            }

            return subSquareSum;
        }


        private void PrintMatrix(int[,] incomingMatrix) {

            for (int i = 0; i < incomingMatrix.GetLength(0); i++) {
                for (int j = 0; j < incomingMatrix.GetLength(1); j++) {
                    Console.Write(incomingMatrix[i,j]+" ");
                }
                Console.WriteLine();
            }

            Console.WriteLine("--------------------------------------");
        }
    }
}
