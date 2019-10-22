using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab3
{
    class Triangle : Point 
    {

        // coordinates for point B;
        private double x1;
        private double y1;

        // coordinates for point C;
        private double x2;
        private double y2;

        public double X1
        {
            get
            {
                return x1;
            }
            set
            {
                if(value >= 0)
                {
                    x1 = value;
                }
            }
        }

        public double Y1
        {
            get
            {
                return y1;
            }
            set
            {
                if (value >= 0)
                {
                    y1 = value;
                }
            }
        }

        public double X2
        {
            get
            {
                return x2;
            }
            set
            {
                if (value >= 0)
                {
                    x2 = value;
                }
            }
        }

        public double Y2
        {
            get
            {
                return y2;
            }
            set
            {
                if (value >= 0)
                {
                    y2 = value;
                }
            }
        }


        public Triangle() { }
        public Triangle(string name)
        {
            Name = name;
        }




        // length of sides;

        public double side_A()
        {
            double a = Math.Sqrt((Math.Pow ( (X1 - X), 2) ) + (Math.Pow((Y1 - Y), 2))   );
            return a;
        }

        public double side_B()
        {
            double b = Math.Sqrt((Math.Pow((X2 - X), 2)) + (Math.Pow((Y2 - Y), 2)));
            return b;
        }

        public double side_C()
        {
            double c = Math.Sqrt((Math.Pow((X2 - X1), 2)) + (Math.Pow((Y2 - Y1), 2)));
            return c;
        }


        // метод который перемещает фигуру по плоскости;
        public override void move(double i, double j)
        {
            if ((X+i) >= 0 && (X1+i) >= 0 && (X2+i) >= 0)
            {
                this.X += i;
                this.X1 += i;
                this.X2 += i;
            }
            else
                Console.WriteLine("Negative value;");

            if ((Y + j) >= 0 && (Y1 + j) >= 0 && (Y2 + j) >= 0)
            {
                this.Y += j;
                this.Y1 += j;
                this.Y2 += j;
            }
            else
                Console.WriteLine("Negative value;");

            Console.WriteLine("                  ==> X1: " + X + " " +  " Y1: " + Y);
            Console.WriteLine("Triangle moved to ==> X2: " + X1 + " " + " Y2: " + Y1);
            Console.WriteLine("                  ==> X3: " + X2 + " " + " Y3: " + Y2);
        }



        // метод возвращаeт площадь
        public double area()
        {
            double a = side_A();
            double b = side_B();
            double c = side_C();

            double p = 0.5 * (a+b+c);

            double trArea = Math.Sqrt(  (   p*(p-a) * (p-b) * (p-c)    ) );

            return trArea;
        }



        // метод возвращаeт периметр
        public double perimetr()
        {
            return side_A() + side_B() + side_C();
        }



    }
}
