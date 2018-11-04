#Author : Giruba Beulah SE

# SumOfSubsquaresInASquareMatrix
C# program to print a sub-square matrix formed by the sums of the sub-squares in a Square matrix

For Example: Given a Square matrix (5*5) 

1 1 1 1 1
2 2 2 2 2 
3 3 3 3 3
4 4 4 4 4 
5 5 5 5 5

If a sub-square size specified is 4, then the following will be the result

40 40 30 20
56 56 42 28
48 48 36 24
36 36 27 18



Basically from every cell, the sub-square matrix is calculated.

For example: Consider (0,0) in the matrix -> The Element is 1
              The Sub-square matrix size is 4
              So the matrix extends from (0, 0) to (0,3) and (3,0) to (3,)
              
              The sume of all the entries in this sub-square matrix is [1+1+1+1+2+2+2+2+3+3+3+3+4+4+4+4 => 40 which is the first
              entry in the resultant matrix
              
              When the sub-square matrix' ends extend beyond the original matrix's ends, the corresponding elements are intuitively be zero
              
              That is for (3,3) the sub-square matrix will be only (3,3) to (3,4) and (4,3) to (4,4)
              So, the sum is 4+4+5+5 => 18
