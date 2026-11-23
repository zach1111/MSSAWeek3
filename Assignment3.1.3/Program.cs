/*
3. Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
Test Data :
Please input a string : This is a test string.
Expected Output :
"This is a test string." contains 4 spaces
*/


//string testString = "This is a test string.";

Console.Write("Please input a string:");
string stringToTest = Console.ReadLine();
int numSpaces = NumberOfSpaces(stringToTest);
Console.WriteLine($"\"{stringToTest}\" contains {numSpaces} spaces.");




int NumberOfSpaces(string InputString)
{
    int numSpaces = 0;
    foreach (char c in InputString)
    {
        if (c == ' ')
        {
            numSpaces++ ; 
        }
    }
    return numSpaces;
}