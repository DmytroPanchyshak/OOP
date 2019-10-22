using System;
using System.Collections.Generic;
using System.Text;

namespace OOP_lab3
{
    class Point
    {

        private double x;
        private double y;
        private string name = "Dot";

        public double X
        {
            get
            {
                return x;
            }
            set
            {
                if (value >= 0)
                {
                    x = value;
                }
            }
        }

        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                if (value >= 0)
                {
                    y = value;
                }
            }
        }

        // строкa символов, отражающая имя класса и состояние объекта;
        public string Name
        {
            get
            {
                return "Class: " + this.GetType().Name + "\nObject condition: " + name;
            }
            set
            {
                name = value;
            }
        }

        public Point() { }
        public Point(double x1, double y1)
        {
            this.x = x1;
            this.y = y1;
        }


        // метод который перемещает фигуру по плоскости;
        public virtual void move(double i, double j)
        {
            if (x + i >= 0)
            {
                this.x += i;
            }
            else
                Console.WriteLine("Negative value;");

            if (y + j >= 0)
            {
                this.y += j;
            }
            else
                Console.WriteLine("Negative value;");

            Console.WriteLine("Point moved to ==> X: " + x + " " + " Y: " + y);
        }


      
    }
}
