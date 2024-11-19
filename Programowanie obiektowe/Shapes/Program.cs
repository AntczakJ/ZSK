namespace Shapes
{
    public abstract class Shape()
    {
        public virtual double CalculateArea()
        {
            return 0;
        }

        public virtual double CalculatePermieter() 
        {
            return 0;
        }
    }

    public class Geometry()
    {
        public List<Shape> Shapes = new List<Shape>();
        public void AddShape(Shape shape)
        {
            Shapes.Add(shape);
        }
        public void RemoveShape(Shape shape)
        {
            Shapes.Remove(shape);
        }
        public void CalculateTotalArea()
        {
            double value = 0;
            foreach (Shape shape in Shapes)
            {
                value += shape.CalculateArea();
            }
            Console.WriteLine($"Całkowite pole: {value}");
        }

        public void CalculateTotalPermieter() 
        {
            double value = 0;

            foreach (Shape shape in Shapes)
            {
                value += shape.CalculatePermieter();
            }
            Console.WriteLine($"Calkowity obwód: {value}");
        }

    }
   

    public class Circle : Shape
    {
        public double Radius { get; set; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public override double CalculateArea()
        {
            return Math.PI * (Radius * Radius);
        }
        public override double CalculatePermieter()
        {
            return 2*(Math.PI) * Radius;
        }
    }
    public class Rectangle : Shape
    {
        public double A {  get; set; }
        public double B { get; set; }
        public Rectangle(double a, double b)
        {
            A = a; 
            B = b;
        }
        public override double CalculateArea()
        {
            return A * B;
        }
        public override double CalculatePermieter()
        {
            return 2*(A+B);
        }
    }
    public class Square : Shape
    {
        public double A { get; set; }
        public Square(double a)
        {
            A = a;
        }
        public override double CalculateArea()
        {
            return Math.Pow(A, 2);
        }
        public override double CalculatePermieter()
        {
            return 4 * A;
        }
    }
    public class Triangle : Shape
    {
        public double A { get; set; }
        public double B { get; set; }
        public double C { get; set; }
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        public override double CalculateArea()
        {
            double p = (A + B + C)/2;
            return Math.Sqrt(p*(p-A)*(p-B)*(p-C));
        }
        public override double CalculatePermieter()
        {
            return A + B + C;
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Geometry geometry = new Geometry();
            geometry.AddShape(new Circle(5));
            geometry.AddShape(new Square(4));
            geometry.AddShape(new Rectangle(3, 7));
            geometry.AddShape(new Triangle(3, 4, 3));
            geometry.CalculateTotalArea();
            geometry.CalculateTotalPermieter();
            
        }
    }
}
/*Zadanie: Obliczanie Pola i Obwodu Figur Geometrycznych
Cel:
Stwórz aplikację konsolową w języku C#, która oblicza pola i obwody różnych figur geometrycznych, takich jak koło, kwadrat, prostokąt i trójkąt. Aplikacja powinna korzystać z abstrakcji, dziedziczenia i kompozycji.

Wymagania:
Klasa abstrakcyjna Shape:

Utwórz abstrakcyjną klasę Shape, która będzie zawierać abstrakcyjne metody CalculateArea() i CalculatePerimeter().

Dziedziczenie:

Utwórz klasy Circle, Square, Rectangle i Triangle, które dziedziczą po klasie Shape i implementują abstrakcyjne metody CalculateArea() i CalculatePerimeter().

Kompozycja:

Utwórz klasę Geometry, która będzie zawierać listę obiektów Shape i metody do dodawania figur oraz obliczania całkowitego pola i obwodu wszystkich figur.


Testowanie:

Utwórz instancje różnych figur, dodaj je do listy w klasie Geometry i wyświetl obliczenia pola i obwodu każdej figury.

					  geometry.AddShape(new Circle(5));
            geometry.AddShape(new Square(4));
            geometry.AddShape(new Rectangle(3, 7));
            geometry.AddShape(new Triangle(3, 4, 3, 4, 5));*/
