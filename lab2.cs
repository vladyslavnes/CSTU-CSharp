using System;

public class MathWrapper
{
    // Calculate the area of a circle given its radius
    public double CalculateArea(double radius)
    {
        return Math.PI * radius * radius;
    }

    // Calculate the area of a rectangle given its length and width
    public double CalculateArea(double length, double width)
    {
        return length * width;
    }

    // Calculate the area of a triangle given its base and height
    public double CalculateArea(double baseLength, double height, bool isTriangle)
    {
        if (isTriangle)
        {
            return 0.5 * baseLength * height;
        }
        // Default to 0 if not correctly specified as a triangle, though this parameter setup is a bit unconventional
        return 0;
    }

    // Overloaded method for calculating the area of a triangle using Heron's formula given all three sides
    public double CalculateArea(double a, double b, double c)
    {
        double s = (a + b + c) / 2;
        return Math.Sqrt(s * (s - a) * (s - b) * (s - c));
    }

    // Example usage
    public static void Main(string[] args)
    {
        MathWrapper mathWrapper = new MathWrapper();
        Console.WriteLine("Select the calculation you want to perform:");
        Console.WriteLine("1. Area of a circle");
        Console.WriteLine("2. Area of a rectangle");
        Console.WriteLine("3. Area of a triangle (using base and height)");
        Console.WriteLine("4. Area of a triangle (using Heron's formula)");

        switch (Console.ReadLine())
        {
            case "1":
                Console.WriteLine("Enter the radius of the circle:");
                double radius = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of circle: {mathWrapper.CalculateArea(radius)}");
                break;
            case "2":
                Console.WriteLine("Enter the length of the rectangle:");
                double length = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the width of the rectangle:");
                double width = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of rectangle: {mathWrapper.CalculateArea(length, width)}");
                break;
            case "3":
                Console.WriteLine("Enter the base of the triangle:");
                double baseLength = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter the height of the triangle:");
                double height = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of triangle: {mathWrapper.CalculateArea(baseLength, height, true)}");
                break;
            case "4":
                Console.WriteLine("Enter side a of the triangle:");
                double a = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side b of the triangle:");
                double b = double.Parse(Console.ReadLine());
                Console.WriteLine("Enter side c of the triangle:");
                double c = double.Parse(Console.ReadLine());
                Console.WriteLine($"Area of triangle: {mathWrapper.CalculateArea(a, b, c)}");
                break;
            default:
                Console.WriteLine("Invalid selection. Please restart the program and select a valid option.");
                break;
        }
    }
}
