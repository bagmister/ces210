using System;

class Program
{
    static void Main(string[] args)
    {
        var square = new Square();
        var circle = new Circle();
        var rectangle = new Rectangle();
        Console.WriteLine("We are going to calculate the area of some different shapes.");
        Console.WriteLine("Calculating the area of a square. What is the length as an int.");
        square.SetSide(int.Parse(Console.ReadLine()));
        var squareArea = square.GetArea();
        Console.WriteLine($"The area of the square is: {squareArea}");
        
        Console.WriteLine("Now, Let's get the area of a rectangle.");
        Console.WriteLine("What is the length?");
        rectangle.SetLength(double.Parse(Console.ReadLine()));
        Console.WriteLine("What is the width?");
        rectangle.SetWidth(double.Parse(Console.ReadLine()));
        var rectangleArea = rectangle.GetArea();
        Console.WriteLine($"The Area of the rectange is: {rectangleArea}");

        Console.WriteLine("Now lets calculate the area of a Circle.");
        Console.WriteLine("What is the radius of the circle?");
        circle.SetRadius(double.Parse(Console.ReadLine()));
        var circleArea = circle.GetArea();
        Console.WriteLine($"The area of the circle is: {circleArea}");

    }
}