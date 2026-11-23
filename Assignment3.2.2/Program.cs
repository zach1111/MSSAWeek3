/*
2. Write a program in C# Sharp for addition of two Matrices of same size.
Test Data :
Input the size of the square matrix (less than 5): 2
Input elements in the first matrix :
element - [0],[0] : 1
element - [0],[1] : 2
element - [1],[0] : 3
element - [1],[1] : 4
Input elements in the second matrix :
element - [0],[0] : 5
element - [0],[1] : 6
element - [1],[0] : 7
element - [1],[1] : 8
Expected Output:
The First matrix is:
1 2
3 4
The Second matrix is :
5 6
7 8
The Addition of two matrix is :
6 8
10 12
*/

Console.Write("Input the size of the square matrix (< 5): ");
if (!int.TryParse(Console.ReadLine(), out int matrixSideLength)) //returns false then we need to exit out
{
    return;
}

int[,] firstMatrix = new int[matrixSideLength, matrixSideLength]; 

int[,] secondMatrix = new int[matrixSideLength, matrixSideLength];

int[,] outputMatrix = new int[matrixSideLength, matrixSideLength];

Console.WriteLine("Input elements for the first matrix:");
MatrixBuilder(firstMatrix);

Console.WriteLine("Input elements for the second matrix:");
MatrixBuilder(secondMatrix);

Console.WriteLine("The first Matrix is:");
MatrixPrinter(firstMatrix);
Console.WriteLine("The second Matrix is:");
MatrixPrinter(secondMatrix);

MatrixAdder(firstMatrix, secondMatrix, outputMatrix);

Console.WriteLine("The sum of the two matrices is:");
MatrixPrinter(outputMatrix);



void MatrixAdder(int[,] FirstMatrix, int[,] SecondMatrix, int[,] OutputMatrix) //adds two matrices together and writes results to OutputMatrix
{
    for (int row = 0 ; row < OutputMatrix.GetLength(0) ; row++) //.GetLength(0) gets length of the '0' dimension, in this case should be 2
    {
        for (int column = 0 ; column < OutputMatrix.GetLength(1) ; column++)
        {
            OutputMatrix[row, column] = FirstMatrix[row, column] + SecondMatrix[row, column];
        }
    }
    return;
}    
    


void MatrixBuilder(int[,] MatrixToBuild) //builds an empty 2d matrix using user input
{

    for (int row = 0 ; row < MatrixToBuild.GetLength(0) ; row++) //.GetLength(0) gets length of the '0' dimension, in this case should be 2
    {
        for (int column = 0 ; column < MatrixToBuild.GetLength(1) ; column++)
        {
        Console.Write($"Element [{row}],[{column}]: ");
        if (!int.TryParse(Console.ReadLine(), out int valueToInsert))
            {
                Console.WriteLine("Must enter integer, try again!");
                column--;
                continue;  
            }
            MatrixToBuild[row, column] = valueToInsert; 
        }
    }


    return;
}

void MatrixPrinter(int[,] MatrixToPrint) //writes matrix to stdout using normal formatting
{
    for (int row = 0 ; row < MatrixToPrint.GetLength(0) ; row++) //.GetLength(0) gets length of the '0' dimension, in this case should be 2
    {
        for (int column = 0 ; column < MatrixToPrint.GetLength(1) ; column++)
        {
            Console.Write($" | {MatrixToPrint[row, column]}");
        }
        Console.WriteLine(" |"); //newline between rows
    }
}