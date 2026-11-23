/*
4. Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.

For e.g: Input : [0,2,1,1,9,1,1]

Output: [0,2,0,0,9,1,1]
*/


int[] myArray = { 0, 2, 1, 1, 9, 1, 1 };


Console.WriteLine(string.Join(", ", myArray));
ArrayModifier(myArray);
Console.WriteLine(string.Join(", ", myArray));




void ArrayModifier(int[] ArrayToModify)
{
    for ( int i = 0 ; i < (ArrayToModify.Length - 1) ; i ++ ) // .Length-1 prevents crash when no double 1 is present and the last entry is 1 (index out of range exception)
    {
        if (ArrayToModify[i] == 1)
        {
            if (ArrayToModify[i+1] == 1)
            {
                ArrayToModify[i] = 0;
                ArrayToModify[i+1] = 0;
                break;
            }
        }
    }
    return;
}
