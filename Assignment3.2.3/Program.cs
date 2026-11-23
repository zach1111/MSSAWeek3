/*
3.2.3.
 Create a console application to overload “+” and “-“ operator for adding the areas of 2 circles and getting their area difference respectively.
*/

using System.Formats.Asn1;

Console.WriteLine("Hello, World!");

Circle firstCircle = new(2);
Circle secondCircle = new(3);

Console.WriteLine($"{firstCircle.Area} + {secondCircle.Area} = {firstCircle + secondCircle}");

Console.WriteLine($"{firstCircle.Area} - {secondCircle.Area} = {firstCircle - secondCircle}");

class Circle
{

    public double Radius { get; set; }
    public double Area { get; set;}
    public Circle(double radius)
    {
        Radius = radius;
        Area = Math.PI * Radius * Radius;
    }

    public static double operator +(Circle FirstCircle, Circle SecondCircle) //add 2 circle's areas
    {
        return FirstCircle.Area + SecondCircle.Area;
    }
    public static double operator -(Circle FirstCircle, Circle SecondCircle) //subtract 2 circle's areas
    {
        return FirstCircle.Area - SecondCircle.Area;
    }

}