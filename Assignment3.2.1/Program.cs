/*
3.2.1
Create a 2D array to store integers and print them in matrix format with proper formatting.
e. g:
| 2 | 3 | 4 |
| 1 | 4 | 6 |
*/

int[,] myMatrix = //2d int array
{
    {2, 3, 4},
    {1, 4, 6}
};

for (int row = 0 ; row < myMatrix.GetLength(0) ; row++) //.GetLength(0) gets length of the '0' dimension, in this case should be 2
{
    for (int column = 0 ; column < myMatrix.GetLength(1) ; column++)
    {
        Console.Write($" | {myMatrix[row, column]}");
    }
    Console.WriteLine(" |"); //newline between rows
}
