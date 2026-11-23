/*
5. Create a function that finds the index of a given item in the array
Examples
Search([1, 5, 3], 5) ➞ 1
Search([9, 8, 3], 3) ➞ 2
Search([1, 2, 3], 4) ➞ -1
Notes
If the item is not present, return -1.
*/



int[] arrayToCheck = { 1, 5, 3 };
int numberToFind = 3;

Console.WriteLine($"Search {string.Join(", ", arrayToCheck)}, for {numberToFind}");
Console.WriteLine($"Found at index: {IndexFinder(arrayToCheck, numberToFind)}");


int IndexFinder(int[] ArrayToCheck, int NumberToFind)
{
    for ( int i = 0 ; i < ArrayToCheck.Length ; i++ )
    {
        if ( ArrayToCheck[i] == NumberToFind ) 
        {
            return i;
        }
    }
    return -1;
}