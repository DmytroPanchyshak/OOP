using System;

/**
 *
 *    1 СОЗДАНИЕ КЛАССОВ. КОНСТРУКТОРЫ.  МЕТОДЫ. 
В соответствии с последней цифрой в списке по журналу, выбрать вариант задачи из таблицы 1.1,
    написать и отладить соответствующую программу.

  #3
    Создать класс Triangle, разработав следующие элементы класса:
    a. Поля:
    • double a, b, c; // стороны треугольника
    b. Конструктор, позволяющий создать экземпляр класса:
        ◦ с заданными длинами сторон;
        ◦ с одним параметром, задающим  дину равностороннего треугольника;
    c. Методы, позволяющие:
        ◦ вывести длины сторон треугольника на экран;
        ◦ получить периметр треугольника;
        ◦ получить площадь треугольника.

    2 КЛАССЫ. ИНДЕКСАТОРЫ. СВОЙСТВА
    В класс Triangle добавить:
    a. Свойства:
        ◦ позволяющие получить-установить длины сторон треугольника (доступные для чтения и записи);
        ◦ позволяющее установить, существует ли треугольник с данными длинами сторон (доступное только для чтения).
    b. Индексатор, позволяющий по индексу 0 получить значение  угла,  противостоящего  стороне а, по индексу 1 – значение угла, 
    противостоящего  стороне b и по индексу 2 – значение угла,  противостоящего  стороне c (только для чтения).
    При других  значениях  индекса выдавать «-1».
 */

namespace OOP_1
{
    class Triangle
    {
        // стороны треугольника;
        private double a, b, c;

        //  Конструктор, позволяющий создать экземпляр класса: с заданными длинами сторон;
        public Triangle(double a, double b, double c)
        {
            A = a;
            B = b;
            C = c;
        }

        //  Конструктор, позволяющий создать экземпляр класса: с одним параметром, задающим  дину равностороннего треугольника;
        public Triangle(double a)
        {
            A = a;
            B = a;
            C = a;
        }

        // Метод, позволяющий: вывести длины сторон треугольника;
        public void lengthOfSides()
        {
            Console.WriteLine("Length of side a: " + a);
            Console.WriteLine("Length of side b: " + b);
            Console.WriteLine("Length of side c: " + c);
        }

        //  Метод позволяющий получить периметр треугольника;
        public void perimeter()
        {
            Console.WriteLine("Perimeter of triangle: " + (a + b + c));
        }

        //Метод  позволяющий получить площадь треугольника;
        public void area()
        {
            double p = 0.5 * (a + b + c);
            double var = Math.Sqrt(     ( p*(p-a)*(p-b)*(p-c) )      );
            Console.WriteLine("Area of triangle: " + var);
        }
        // Свойства позволяющие получить-установить длины сторон треугольника(доступные для чтения и записи);
        public double A
        {
            get
            {
                return a;
            }
            set
            {
                if (value >= 0)
                {
                    a = value;
                }
            }
        }

        public double B
        {
            get
            {
                return b;
            }
            set
            {
                if (value >= 0)
                {
                    b = value;
                }
            }
        }

        public double C
        {
            get
            {
                return c;
            }
            set
            {
                if (value >= 0)
                {
                    c = value;
                }
            }
        }

        // Свойство позволяющее установить, существует ли треугольник с данными длинами сторон(доступное только для чтения).
        public bool isTriangleExists
        {
            get
            {
                if (a + b > c && a + c > b && b + c > a)
                    return true;
                return false;
            }
        }

        // Индексатор, позволяющий по индексу 0 получить значение  угла,  противостоящего  стороне а, по индексу 1 – значение угла, 
        // противостоящего стороне b и по индексу 2 – значение угла, противостоящего  стороне c(только для чтения).
        // При других  значениях индекса выдавать «-1».
        public double this[int index]
        {
            get
            {
                if(index == 0)
                {
                    double alfa = Math.Acos(((Math.Pow(b, 2) + Math.Pow(c, 2)) - Math.Pow(a, 2) ) / (2 * b * c));
                    double alfaToGrdus = (alfa * 180) / Math.PI;
                    Console.Write("Value of angle of opposing side a: ");
                    return alfaToGrdus;
                }
                else if (index == 1)
                {
                    double alfa = Math.Acos(((Math.Pow(a, 2) + Math.Pow(c, 2)) - Math.Pow(b, 2)) / (2 * a * c));
                    double alfaToGrdus = (alfa * 180) / Math.PI;
                    Console.Write("Value of angle of opposing side b: ");
                    return alfaToGrdus;
                }
                else if (index == 2)
                {
                    double alfa = Math.Acos(((Math.Pow(a, 2) + Math.Pow(b, 2)) - Math.Pow(c, 2)) / (2 * a * b));
                    double alfaToGrdus = (alfa * 180) / Math.PI;
                    Console.Write("Value of angle of opposing side c: ");
                    return alfaToGrdus;
                }
                else
                {
                    return -1;
                }
            }
        }

       

    }
}
