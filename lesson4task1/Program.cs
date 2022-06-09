using System;

namespace lesson4task1
{
    public abstract class Figure
    {
        protected string _name;
        protected string _description;

        public Figure(string _name, string _description)
        {
            this._name = _name;
            this._description = _description;
        }
        public abstract double Area();
        public abstract double Perimeter();

        public override string ToString()
        {
            return $"Название фигуры: {_name}" +
                $"\nОписание фигуры: {_description}";
        }
    }

    public sealed class Triangle : Figure
    {
        int sideA;
        int sideB;
        int sideC;

        public Triangle(string _name, string _description, int sideA, int sideB, int sideC) 
            : base(_name, _description)
        {
            this.sideA = sideA;
            this.sideB = sideB;
            this.sideC = sideC;
        }
        public override double Area()
        {
            return sideA * sideB * sideC;
        }
        public override double Perimeter()
        {
            return sideA + sideB + sideC;
        }

        public override string ToString()
        {
            return base.ToString() + 
                $"\nСторона А: {sideA}" +
                $"\nСторона В: {sideB}" +
                $"\nСторона С: {sideC}" +
                $"\nПлощадь треугольника: {Area()}" +
                $"\nПериметр треугольника: {Perimeter()}\n";
        }
    }

    public sealed class Square : Figure
    {
        int side;

        public Square(string _name, string _description, int side) : base(_name, _description)
        {
            this.side = side;
        }

        public override double Area()
        {
            return side * side;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        public override string ToString()
        {
            return base.ToString() + 
                $"\nСторона квадрата: {side}" +
                $"\nПлощадь квадрата: {Area()}" +
                $"\nПериметр квадрата: {Perimeter()}\n";
        }
    }

    public sealed class Rhombus : Figure
    {
        int side;
        int diagonalA;
        int diagonalB;

        public Rhombus(string _name, string _description, int side, int diagonalA, int diagonalB)
            : base(_name, _description)
        {
            this.side = side;
            this.diagonalA = diagonalA;
            this.diagonalB = diagonalB;
        }
        public override double Area()
        {
            return (diagonalA * diagonalB) / 2;
        }
        public override double Perimeter()
        {
            return 4 * side;
        }
        public override string ToString()
        {
            return base.ToString() + 
                $"Сторона ромба: {side}" +
                $"\nДиагональ ромба А: {diagonalA}" +
                $"\nДиагональ ромба В: {diagonalB}" +
                $"\nПлощадь ромба: {Area()}" +
                $"\nПериметр ромба: {Perimeter()}\n";
        }
    }
    public class Rectangle : Figure
    {
        int rectangleSideA;
        int rectangleSideB;

        public Rectangle(string _name, string _description, int rectangleSideA, int rectangleSideB)
            : base(_name, _description)
        {
            this.rectangleSideA = rectangleSideA;
            this.rectangleSideB = rectangleSideB;
        }

        public override double Area()
        {
            return rectangleSideA * rectangleSideB;
        }
        public override double Perimeter()
        {
            return 2 * (rectangleSideA + rectangleSideB);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nСторона прямоугольника А: {rectangleSideA}" +
                $"\nСторона прямоугольника В: {rectangleSideB}" +
                $"\nПлощадь прямоугольника: {Area()}" +
                $"\nПериметр прямоугольника: {Perimeter()}\n";
        }

    }

    public sealed class Parallelogram : Rectangle
    {
        int high;
        int sideA;

        public Parallelogram(string _name, string _description, int high, int sideA, int sideB)
            : base(_name, _description, sideA, sideB)
        {
            this.high = high;
            this.sideA = sideA;
        }

        public override double Area()
        {
            return sideA * high;
        }

        public override double Perimeter()
        {
            return base.Perimeter();
        }
        public override string ToString()
        {
            return $"Название фигуры: {_name}" +
                $"\nОписание фигуры: {_description}" +
                $"\nСторона параллелограмма: {sideA}" +
                $"\nВысота параллелограмма: {high}" +
                $"\nПлощадь параллелограмма: {Area()}" +
                $"\nПериметр параллелограмма: {Perimeter()}\n";
        }
    }

    public sealed class Trapezoid : Figure
    {
        int trapezoidSideA;
        int trapezoidSideB;
        int trapezoidSideC;
        int trapezoidHigh;

        public Trapezoid(string _name, string _description, int trapezoidSideA, int trapezoidSideB, 
            int trapezoidSideC, int trapezoidHigh) : base(_name, _description)
        {
            this.trapezoidSideA = trapezoidSideA;
            this.trapezoidSideB = trapezoidSideB;
            this.trapezoidSideC = trapezoidSideC;
            this.trapezoidHigh = trapezoidHigh;
        }
        public override double Area()
        {
            return ((trapezoidSideA + trapezoidSideB) / 2) * trapezoidHigh;
        }
        public override double Perimeter()
        {
            return trapezoidSideA + trapezoidSideB + (2 * trapezoidSideC);
        }

        public override string ToString()
        {
            return base.ToString() +
                $"\nСторона трапеции А: {trapezoidSideA}" +
                $"\nСторона трапеции В: {trapezoidSideB}" +
                $"\nСторона трапеции С: {trapezoidSideC}" +
                $"\nВысота трапеции: {trapezoidHigh}" +
                $"\nПлощадь трапеции: {Area()}" +
                $"\nПериметр трапеции: {Perimeter()}\n";
        }
    }

    public sealed class Circle : Figure
    {
        double radius;

        public Circle(string _name, string _description, double radius) : base(_name, _description)
        {
            this.radius = radius;
        }
        public override double Area()
        {
            return Math.PI * (radius * radius);
        }
        public override double Perimeter()
        {
            return 2 * Math.PI * radius; 
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nРадиус круга: {radius}" +
                $"\nПлощадь круга: {Area()}" +
                $"\nПериметр круга: {Perimeter()}\n";
        }
    }
    public sealed class Ellipse : Figure
    {
        double chordA;
        double chordB;

        public Ellipse(string _name, string _description, double chordA, double chordB) : base(_name, _description)
        {
            this.chordA = chordA;
            this.chordB = chordB;
        }

        public override double Area()
        {
            return Math.PI * chordA * chordB;
        }
        public override double Perimeter()
        {
            return 4 * (Math.PI * chordA * chordB + ((chordA - chordB) * (chordA - chordB)) / (chordB + chordA));
        }
        public override string ToString()
        {
            return base.ToString() +
                $"\nХорда эллипса А: {chordA}" +
                $"\nХорда эллипса В: {chordB}" +
                $"\nПлощадь эллипса: {Area()}" +
                $"\nПериметр эллипса: {Perimeter()}\n";
        }
    }

    public class CompoundFigure
    {
        static double generalArea;
        Figure[] arrayOfFigures;

        public CompoundFigure()
        {
            arrayOfFigures = new Figure[0];
        }
        public double AddFigure(Figure figure)
        {
            Array.Resize(ref arrayOfFigures, arrayOfFigures.Length + 1);
            arrayOfFigures[arrayOfFigures.Length - 1] = figure;
            generalArea += figure.Area();
            return generalArea;
        }
    }

    public class Program
    {
        public static void Main()
        {
            Figure[] figures =
            {
                new Triangle("Треугольник",
                "Образован тремя отрезками, которые соединяют три точки не лежащтие на одной прямой",
                12, 14, 18),

                new Square("Квадрат",
                "Все стороны квадрата равны", 10),

                new Rhombus("Ромб" , "У ромба противолежащие стороны равны и попарно параллельны",
                12, 24, 6),

                new Rectangle("Прямоугольник",
                "Четырехугольник, у которого все углы прямые (равны 90 градусам)", 20, 10),

                new Parallelogram("Параллелограмм",
                "Четырехугольник, у которого параллельные стороны попарно параллельны и равны",
                6, 20, 8),

                new Trapezoid("Трапеция",
                "Выпуклый четырехугольник, у которого две стороны параллельны, а две другие стороны нет",
                6, 12, 8, 5),

                new Circle("Круг",
                "Часть плоскости, которая лежит внутри окружности", 15),

                new Ellipse("Эллипс",
                "Замкнутая кривая на плоскости, которая может быть получена как пересечение плоскости и кругового цилиндра",
                28, 14)
            };
            CompoundFigure areasOfFigures = new CompoundFigure();

            foreach(Figure items in figures)
            {
                Console.WriteLine(items.ToString());
                Console.WriteLine(areasOfFigures.AddFigure(items));
            }

           
        }
    }
}