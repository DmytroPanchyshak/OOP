using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab3
{
    class Pyramid : Triangle
    {
        private double height;
        public double Height
        {
            get
            {
                return height;
            }
            set
            {
                if(value >= 0)
                {
                    height = value;
                }
            }
        }

        public Pyramid() { }
        public Pyramid(string name)
        {
            Name = name;
        }

        // метод который перемещает фигуру по плоскости;
        public override void move(double i, double j)
        {
            if ((X + i) >= 0 && (X1 + i) >= 0 && (X2 + i) >= 0)
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

            Console.WriteLine("                 ==> X1: " + X + " " + " Y1: " + Y);
            Console.WriteLine("Pyramid moved to ==> X2: " + X1 + " " + " Y2: " + Y1);
            Console.WriteLine("                 ==> X3: " + X2 + " " + " Y3: " + Y2);
        }
    }
}
