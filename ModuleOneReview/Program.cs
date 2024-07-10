namespace ModuleOneReview;

class Program
{
    //For the AreaCircle class I got the formula how to find the radius of a circle and I will return it to main class.
    public static double AreaCircle(double radius)
    {
        double formula = Math.PI * Math.Pow(radius, 2);
        return formula;
        
    }
    //Found the formula for area of a triangle and will return it back to main class
    public static double AreaTriangle(double baseLength, double height)
    {
        double formula = baseLength * height / 2;
        return formula;
    }
    //Found formula for area of a rectangle then will return it back to main class
    public static double AreaRectangle(double length, double width)
    {
        double formula = length * width;
        return formula;
    }
    //Found the formula for area of a square and will return it back to main
    public static double AreaSquare(double side)
    {
        double formula = Math.Pow(side, 2);
        return formula;
    }
    static void Main(string[] args)
    {
        //Here I asked user input for each shape then I called the method then output it out to the user.
        Console.WriteLine("Please enter your number to find the radius of the circle" );
        double radius = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your radius is {radius} which then converts to " + AreaCircle(radius));
        Console.WriteLine("\nEnter the number you want for your base length to find the radius of the triangle");
        double baseLength = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the number you want for your height to find the radius of the triangle");
        double height = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your base length is {baseLength} and height is {height}, so the area of your triangle is "+ AreaTriangle(baseLength,height));
        Console.WriteLine("\nEnter the number you want for your length to find the radius of the rectangle");
        double length = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Enter the number you want for your width to find the radius of the rectangle");
        double width = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your length is {length} and width is {width}, so the area of your rectangle is "+ AreaRectangle(length,width));
        Console.WriteLine("\nEnter the number you want for the side to find the radius of the square");
        double side = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine($"Your side is {side}, so the area of your square is "+ AreaSquare(side));
    
    }
}