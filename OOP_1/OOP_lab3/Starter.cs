using System;
/**
  3 НАСЛЕДОВАНИЕ
Варианты систем классов (выбор – номер по журналу разделить на 7, взять остаток от деления).
Объемные фигуры задаются  добавлением  плоским   фигурам   высоты:
        (6. "Точка, треугольник, треугольная пирамида")
    а) Наследование. Определите иерархию  классов (см. варианты), 
    связанных отношением наследования. Определите в этих классах
        методы: - которые перемещает фигуру по плоскости;
                - возвращают ее площадь, 
                - периметр (для объемных  фигур – периметр основания)
    и строку символов, отражающую имя класса и состояние объекта.  Продемонстрируйте  работу   с классами.
 */
namespace OOP_lab3
{
    class Starter
    {
        static void Main(string[] args)
        {
            // выбор – номер по журналу разделить на 7, взять остаток от деления;
            int number = 13;                        
            int var = number % 7;
            Console.WriteLine("Variant: " + var);   // 6. "Точка, треугольник, треугольная пирамида"

            // --------------------------------------------------------------------------------------


            Point pointX = new Point(2,5);
            Console.WriteLine(pointX.Name);
            pointX.move(3, 0);


            Console.WriteLine("");



            Triangle triangle = new Triangle("TRIANGLE");
            Console.WriteLine(triangle.Name);
            // A
            triangle.X = 2;
            triangle.Y = 3;
            // B
            triangle.X1 = 3;
            triangle.Y1 = 1;
            // C
            triangle.X2 = 5;
            triangle.Y2 = 4;

            Console.WriteLine("a:" + triangle.side_A());
            Console.WriteLine("b:" + triangle.side_B());
            Console.WriteLine("c:" + triangle.side_C());
            Console.WriteLine("Area: " + triangle.area());
            Console.WriteLine("Perimetr: " + triangle.perimetr());
            triangle.move(5, 10);


            Console.WriteLine("");


            Pyramid pyramid = new Pyramid("Pyramid_1");
            Console.WriteLine(pyramid.Name);
            // A
            pyramid.X = 0;
            pyramid.Y = 0;
            // B
            pyramid.X1 = 3;
            pyramid.Y1 = 3;
            //C
            pyramid.X2 = 6;
            pyramid.Y2 = 0;

            pyramid.Height = 3;

            Console.WriteLine("a: " + pyramid.side_A());
            Console.WriteLine("b: " + pyramid.side_B());
            Console.WriteLine("c: " + pyramid.side_C());
            Console.WriteLine("Area: " + pyramid.area());
            Console.WriteLine("Perimetr: " + pyramid.perimetr());
            pyramid.move(5, 5);


            Console.WriteLine("");

            //---------------------------------------------------------------------------------




            Figure[] figures = new Figure[3];

            Circle circle = new Circle("circ.");
            Rectangle rectangle = new Rectangle("rect.");
            Square square = new Square("sqr.");

            figures[0] = circle;
            figures[1] = rectangle;
            figures[2] = square;

            // Circle
            circle.Xcenter = 10;
            circle.Ycenter = 10;
            circle.Rx = 5;
            circle.Ry = 5;
            Console.WriteLine("");
            //figures[0].move(-2, 0);


            // Rectangle
            rectangle.X1 = 2;
            rectangle.Y1 = 5;
            rectangle.X2 = 8;
            rectangle.Y2 = 5;
            rectangle.X3 = 8;
            rectangle.Y3 = 2;
            rectangle.X4 = 2;
            rectangle.Y4 = 2;

            // Square
            square.X1 = 3;
            square.Y1 = 8;
            square.X2 = 8;
            square.Y2 = 8;
            square.X3 = 8;
            square.Y3 = 3;
            square.X4 = 3;
            square.Y4 = 3;

            for (int i = 0; i < figures.Length; i++)
            {
                Console.WriteLine(figures[i].Info);
                Console.WriteLine("Area:" + figures[i].area());
                Console.WriteLine("Perimetr: " + figures[i].perimetr());
                Console.WriteLine("");

            }


        }
    }
}
