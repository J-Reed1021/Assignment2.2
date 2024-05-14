namespace Assignment2._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
                Console.WriteLine("Please enter your shape");
                Console.WriteLine("Enter S for square");
                Console.WriteLine("Enter C for circle");
                Console.WriteLine("Enter R for rectangle");
                Console.WriteLine("Press X to exit the program");
                string readResult = Console.ReadLine();
                Console.WriteLine();

                switch (readResult)
                {
                    case "S":
                    case "s":
                        Console.WriteLine("You have chosen square. Please enter the length");
                        double lengthOfSide = Convert.ToDouble(Console.ReadLine());
                        Square mySquare = new Square();
                        mySquare.CalculateArea(lengthOfSide);
                        Console.WriteLine();
                        break;
                    case "C":
                    case "c":
                        Console.WriteLine("You have chosen circle. Please enter the radius");
                        double radius = Convert.ToDouble(Console.ReadLine());
                        Circle myCircle = new Circle();
                        myCircle.CalculateArea(radius);
                        Console.WriteLine();
                        break;
                    case "R":
                    case "r":
                        Console.WriteLine("You have chosen rectangle. Please enter the height");
                        double height = Convert.ToDouble(Console.ReadLine());
                        Console.WriteLine("Please enter the width");
                        double width = Convert.ToDouble(Console.ReadLine());
                        Rectangle myRectangle = new Rectangle();
                        myRectangle.CalculateArea( width, height);
                        Console.WriteLine();
                        break;
                    case "X":
                    case "x":
                        Console.WriteLine("You want to exit the program");
                        break;
                    default:
                        Console.WriteLine("Invalid input");
                        break;

                }
            


        }
    }

    public enum ColorValues { Red, Blue, Green}


    public abstract class Shape
    {
        public string ShapeId { get; set; }
        public string ShapeName { get; set; }
        public string ShapeDescription { get; set; }
        public ColorValues Color { get; set; }
        public virtual void CalculateArea()
        {
            Console.WriteLine("The shape has an area.");
        }

    }

    public class Square : Shape
    {
        public double LengthOfSide { get; set; }

        public void CalculateArea(double lengthOfSide) 
        { 
            Console.WriteLine("The area of a square is: " + Math.Pow(lengthOfSide, 2));
        }

    }

    public class Circle : Shape
    {

        public double Radius { get; set; }
        public void CalculateArea(double radius)
        {
            Console.WriteLine("The area of a circle is: " + Math.PI * Math.Pow(radius, 2));
        }
    }

    public class Rectangle : Shape 
    { 
       public double Width { get; set; }
       public double Height { get; set; }

        public void CalculateArea(double width, double height)
        {
            Console.WriteLine("The area of a rectanlge is: " + width * height);
        }

    }

}
