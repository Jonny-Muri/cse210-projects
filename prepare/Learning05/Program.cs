using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Square sq = new Square("Green", 5);
        Rectangle rec = new Rectangle("Red", 4, 7);
        Circle cir = new Circle("Orange", 6);
        
        // Displaying the Color and Area of the Shapes 
        // Console.WriteLine($"The color of the square is {sq.GetColor()}\nThe area of the square is {sq.GetArea()}\n");
        // Console.WriteLine($"The color of the rectangle is {rec.GetColor()}.\nThe area of the rectangle is {rec.GetArea()}\n");
        // Console.WriteLine($"The color of the circle is {cir.GetColor()}.\nThe area of the circle is {cir.GetArea()}");
        
        List<Shape> shapes = new List<Shape>();
        shapes.Add(sq);
        shapes.Add(rec);
        shapes.Add(cir);

        foreach (Shape shp in shapes)
        {
            string clr = shp.GetColor();
            double area = shp.GetArea();
            Console.WriteLine($"The color of the {shp} is {clr}. The area of the {shp} is {area}");
        }
        
    }
}