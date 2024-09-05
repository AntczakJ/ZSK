namespace _1_Dziedziczenie
{
    internal class Program
    {

        class Shape
        {
            public virtual float CalculateArea()
            {
                return 0;
            }

            public virtual float CalculatePerimeter()
            {
                return 0;
            }

        }

        class Rectangle : Shape
        {
            private float width;
            private float height;

            public void SetDimensions(float w, float h)
            {
                width = w;
                height = h;
            }

            public override float CalculateArea()
            {
                return width * height;
            }

            public override float CalculatePerimeter()
            {
                return 2 * width + 2 * height;
            }
        }

        class Circle : Shape 
        {
            private float radius;

            public void SetRadius(float r)
            {
                radius = r;
            }
            public override float CalculateArea()
            {
                return (float)Math.Round((Math.PI * radius * radius),2);
            }

            public override float CalculatePerimeter()
            {
                return (float)Math.Round((2 * Math.PI * radius),2);   
            }
        }

        class Triangle : Shape
        {
            private float height;
            private float tbase;
            public void SetDimensions(float h, float tb)
            {
                height = h;
                tbase = tb;
            }

            public override float CalculateArea()
            {
                return (height * tbase)/2;
            }

        }



        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Wybierz kształt");
                Console.WriteLine("1 - prostokąt");
                Console.WriteLine("2 - koło");
                Console.WriteLine("3 - trójkąt");
                Console.WriteLine("4 - trapez");
                Console.WriteLine("5 - Kula");
                Console.WriteLine("6 - wyjście");

                int choice = int.Parse(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Rectangle rect = new Rectangle();
                        float rectWidth = GetValidInput("Podaj szerokość: ");
                        float rectHeight = GetValidInput("Podaj wysokość: ");
                        rect.SetDimensions(rectWidth, rectHeight);
                        Console.WriteLine($"Pole wynosi: {rect.CalculateArea()}");
                        Console.WriteLine($"Obwód wynosi: {rect.CalculatePerimeter()}");
                        Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 2:
                        Circle circ = new Circle();
                        float circRadius = GetValidInput("Podaj promień: ");
                        circ.SetRadius(circRadius);
                        Console.WriteLine($"Pole wynosi: {circ.CalculateArea()}");
                        Console.WriteLine($"Obwód wynosi: {circ.CalculatePerimeter()}");
                        Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 3:
                        Triangle triangle = new Triangle();
                        float triangleHeight = GetValidInput("Podaj wysokość trójkąta");
                        float traingleBase = GetValidInput("Podaj długość podstawy trójkąta");
                        triangle.SetDimensions(triangleHeight, traingleBase);
                        Console.WriteLine($"Pole trójkąta wynosi {triangle.CalculateArea()}");
                        Console.WriteLine("Naciśnij dowolny klawisz aby wrócić do menu");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case 6:
                        return;
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Błędne dane :(");
                        Console.ResetColor();
                        Console.ReadKey();
                        Console.Clear();
                        break;
                }
            }

            
        }
        public static float GetValidInput(string prompt)
        {
            float result;
            while (true)
            {
                Console.Write(prompt);
                if (float.TryParse(Console.ReadLine(), out result))
                {
                    return result;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Błędne dane :(");
                    Console.ResetColor();
                }

            }
        }

    }
}
