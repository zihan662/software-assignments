namespace homework1
{
    public abstract class Shape
    {
        public abstract double GetArea();
        public abstract bool IsLegal();
    }
    class Rectangle : Shape
    {
        private double length;
        private double width;
        public Rectangle(double length, double width)
        {
            this.length = length;
            this.width = width;
        }
        public double Length
        {
            get { return length; }
            set { length = value; }
        }
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        public override double GetArea() {
            if (IsLegal())
            {
                return length * width;
            }
            else { throw new ArgumentException("not legal shape"); }
        }
        public override bool IsLegal()
        {
            return length>0&& width > 0;
        }
    }
    class Square : Shape
    {
        private double side;
        public Square(double side) { this.side = side; }
        public double Side
        {
            get { return side; }
            set { side = value; }
        }
        public override double GetArea()
        {
            if (IsLegal())
            {
                return side * side;
            }
            else { throw new ArgumentException("not legal shape"); }
        }
        public override bool IsLegal()
        {
            return side > 0;
        }
    }
    class Triangle : Shape
    {
        private double side1,side2,side3;
        public Triangle(double side1, double side2, double side3)
        {
            this.side1 = side1;
            this.side2 = side2;
            this.side3 = side3;
        }
        public override double GetArea()
        {
            if (IsLegal())
            {
                double r = (side1 + side2 + side3) / 2;
                return Math.Sqrt(r*(r-side1)*(r-side2)*(r-side3));
            }
            else { throw new ArgumentException("not legal shape"); }
        }
        public override bool IsLegal()
        {
            return side1>0&&side2>0&&side3>0
                  &&side1+side2>side3&&side1+side3>side2&&side2+side3>side1;
        }
    }
    class Circle : Shape
    {
        private const double PI = 3.1415926;
        private double radius;
        public Circle(double  r) {radius = r;}
        public override double GetArea()
        {
            if (IsLegal())
            {
                return PI*radius*radius;
            }
            else { throw new ArgumentException("not legal shape"); }
        }
        public override bool IsLegal()
        {
            return radius > 0;
        }
    }
    public static class ShapeFactory
    {
        public static Shape CreateShape(string myshape,double item)
        {
            switch(myshape)
            {
                case "Square":
                    {
                        Shape s = new Square(item);
                        return s;
                    }
                case "Circle":
                    {
                        Shape s = new Circle(item);
                        return s;
                    }
                default:
                    throw new ArgumentException("error shape name");
                    break;
            }
        }
        public static Shape CreateShape(string myshape,double length,double width)
        {
            if (myshape == "Rectangle")
            {
                Shape shape = new Rectangle(length, width);
                return shape;
            }
            else throw new ArgumentException("error shape name");
        }
        public static Shape CreateShape(string myshape, double side1, double side2, double side3)
        {
            if (myshape == "Triangle")
            {
                Shape shape = new Triangle(side1, side2, side3);
                return shape;
            }
            else throw new ArgumentException("error shape name");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Shape[] shapes =
            {
                ShapeFactory.CreateShape("Square",1),
                ShapeFactory.CreateShape("Square",2),
                ShapeFactory.CreateShape("Circle",1),
                ShapeFactory.CreateShape("Circle",2),
                ShapeFactory.CreateShape("Rectangle",1,2),
                ShapeFactory.CreateShape("Rectangle",2,3),
                ShapeFactory.CreateShape("Rectangle",5,7),
                ShapeFactory.CreateShape("Triangle",2,2,3),
                ShapeFactory.CreateShape("Triangle",3,4,5),
                ShapeFactory.CreateShape("Triangle",6,6,6)
            };
            double sum = 0;
            foreach(Shape shape in shapes)
            {
                sum += shape.GetArea();
            }
            sum=Math.Round(sum, 3);
            Console.WriteLine($"the area of ten shapes is {sum}");
        }
    }
}
