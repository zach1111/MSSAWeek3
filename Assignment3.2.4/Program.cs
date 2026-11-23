/*
3.2.4.
 Write a function that takes 4 numbers as input to calculate the total and average.
(Make use of params array to pass arguments and out parameters to return both total and average to main method).
Test Data:
Enter the First number: 10
Enter the Second number: 15
Enter the third number: 20
Enter the fourth number: 30

Expected Output:
The average of 10 , 15 , 20 , 30 is: 18.75
The total is 75
*/



TotalAndAverage(out double total, out double average, 10, 15, 20, 30);
Console.WriteLine($"total = {total}, avg = {average}");

void TotalAndAverage(out double total, out double average, params double[] numbers)
{
    total = 0;
    foreach (double d in numbers)
    {
        total += d;
    } 

    average = total / numbers.Length;
    return; 
}