using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab3
{
    class Figure
    {
        private string info;
        // строкa символов, отражающая имя класса и состояние объекта;
        public string Info
        {
            get
            {
                return "Class: " + this.GetType().Name + "\nObject condition: " + info;
            }
            set
            {
                info = value;
            }
        }

        // метод который перемещает фигуру по плоскости;
        public virtual void move(double i, double j)
        {

        }
        // метод возвращаeт площадь
        public virtual double area()
        {
            return 0;
        }
        // метод возвращаeт периметр
        public virtual double perimetr()
        {
            return 0;
        }


    }






    class Circle: Figure
    {
        private double xCenter;
        private double yCenter;
        private double rX;
        private double rY;

        public double Xcenter { get; set; }
        public double Ycenter { get; set; }
        public double Rx { get; set; }
        public double Ry { get; set; }

        public Circle() { }
        public Circle(string condition)
        {
            Info = condition;
        }
        
        // метод который перемещает фигуру по плоскости;
        public override void move(double x, double y)
        {
            if ((Xcenter + x >= 0) && (Rx + x >= 0))
            {
                Xcenter += x;
                Rx += x;
            }
            else
                Console.WriteLine("Negative value;");

            if ((Ycenter + y >= 0) && (Ry + y >= 0))
            {
                Ycenter += y;
                Ry += y;
            }
            else
                Console.WriteLine("Negative value;");

            Console.WriteLine("Center of circle moved to ==> X: " + Xcenter + " Y: " + Ycenter);
        }

        // метод возвращаeт площадь
        public override double area()
        {
            double radius = Math.Sqrt((Math.Pow((Xcenter - Rx), 2) + Math.Pow((Ycenter - Ry), 2)));
            return Math.PI * Math.Pow(radius, 2); 
        }

        // метод возвращаeт периметр
        public override double perimetr()
        {
            double radius = Math.Sqrt((Math.Pow((Xcenter - Rx), 2) + Math.Pow((Ycenter - Ry), 2)));
            return 2*Math.PI*radius;
        }

    }



    class Rectangle: Figure
    {
        // A
        private double x1;
        private double y1;
        // B
        private double x2;
        private double y2;
        // C
        private double x3;
        private double y3;
        // D
        private double x4;
        private double y4;

        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }

        public Rectangle() { }
        public Rectangle(string condition)
        {
            Info = condition;
        }

        // метод который перемещает фигуру по плоскости;
        public override void move(double i, double j)
        {
            if ((X1 + i) >= 0 && (X2 + i) >= 0 && (X3 + i) >= 0 && (X4 + i) >= 0)
            {
                X1 += i;
                X2 += i;
                X3 += i;
                X4 += i;
            }
            else
                Console.WriteLine("Negative value;");

            if ((Y1 + j) >= 0 && (Y2 + j) >= 0 && (Y3 + j) >= 0 && (Y4 + j) >= 0)
            {
                Y1 += j;
                Y2 += j;
                Y3 += j;
                Y4 += j;
            }
            else
                Console.WriteLine("Negative value;");

            Console.WriteLine("Triangle moved to ==> X1: " + X1 + " " + " Y1: " + Y1);
            Console.WriteLine("Triangle moved to ==> X2: " + X2 + " " + " Y2: " + Y2);
            Console.WriteLine("Triangle moved to ==> X3: " + X3 + " " + " Y3: " + Y3);
            Console.WriteLine("Triangle moved to ==> X4: " + X4 + " " + " Y4: " + Y4);
        }

        // метод возвращаeт площадь
        public override double area()
        {
            double ab = Math.Sqrt(   (Math.Pow((X2-X1),2) + Math.Pow((Y2 - Y1), 2))   );
            double bc = Math.Sqrt(   (Math.Pow((X3-X2),2) + Math.Pow((Y3 - Y2), 2))   );
            return ab*bc;
        }

        // метод возвращаeт периметр
        public override double perimetr()
        {
            double ab = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
            double bc = Math.Sqrt((Math.Pow((X3 - X2), 2) + Math.Pow((Y3 - Y2), 2)));
            return (ab+bc)*2;
        }

    }





    class Square: Figure
    {
        // A
        private double x1;
        private double y1;
        // B
        private double x2;
        private double y2;
        // C
        private double x3;
        private double y3;
        // D
        private double x4;
        private double y4;

        public double X1 { get; set; }
        public double Y1 { get; set; }
        public double X2 { get; set; }
        public double Y2 { get; set; }
        public double X3 { get; set; }
        public double Y3 { get; set; }
        public double X4 { get; set; }
        public double Y4 { get; set; }

        public Square() { }
        public Square(string condition)
        {
            Info = condition;
        }

        // метод который перемещает фигуру по плоскости;
        public override void move(double i, double j)
        {
            if ((X1 + i) >= 0 && (X2 + i) >= 0 && (X3 + i) >= 0 && (X4 + i) >= 0)
            {
                X1 += i;
                X2 += i;
                X3 += i;
                X4 += i;
            }
            else
                Console.WriteLine("Negative value;");

            if ((Y1 + j) >= 0 && (Y2 + j) >= 0 && (Y3 + j) >= 0 && (Y4 + j) >= 0)
            {
                Y1 += j;
                Y2 += j;
                Y3 += j;
                Y4 += j;
            }
            else
                Console.WriteLine("Negative value;");

            Console.WriteLine("Triangle moved to ==> X1: " + X1 + " " + " Y1: " + Y1);
            Console.WriteLine("Triangle moved to ==> X2: " + X2 + " " + " Y2: " + Y2);
            Console.WriteLine("Triangle moved to ==> X3: " + X3 + " " + " Y3: " + Y3);
            Console.WriteLine("Triangle moved to ==> X4: " + X4 + " " + " Y4: " + Y4);
        }

        // метод возвращаeт площадь
        public override double area()
        {
            double ab = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
            return ab * ab;
        }

        // метод возвращаeт периметр
        public override double perimetr()
        {
            double ab = Math.Sqrt((Math.Pow((X2 - X1), 2) + Math.Pow((Y2 - Y1), 2)));
            return ab * 4;
        }

    }
}
