using System;
public class AreaOfRectangle
{
    public static void Main()
    {
        Console.WriteLine("Enter the Length of a Rectangle: ");
        int Length = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter the Width of a Rectangle: ");
        int Width = Convert.ToInt32(Console.ReadLine());

        int Area = Length * Width;
        Console.WriteLine($"Area of Length {Length} and Width {Width} Rectangle is {Area}");
        Console.ReadKey();
    }
}