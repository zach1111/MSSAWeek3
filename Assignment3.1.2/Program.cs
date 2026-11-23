/*
2. If year is leap

Given a year as integer, write a method that checks if year is leap.

Expected input and output

IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false

background: leap years are years where
• Divisible by 4: Usually a leap year (e.g., 2024, 2028).
• Divisible by 100: Not a leap year (e.g., 1700, 1800, 1900, 2100).
• Divisible by 400: Leap year (e.g., 1600, 2000, 2400)
*/

Console.WriteLine(IsLeapYear(2016)); //expected true

Console.WriteLine(IsLeapYear(2018)); //expected false

Console.WriteLine(IsLeapYear(1600)); //expected true

Console.WriteLine(IsLeapYear(1700)); //expected false

bool IsLeapYear(int Year)
{
    if (Year % 400 == 0) //must go before the % 100 check
    {
        return true;
    }
    else if ( Year % 100 == 0)
    {
        return false;
    }
    else if ( Year % 4 == 0 )
    {
        return true;
    }

    return false;
}
