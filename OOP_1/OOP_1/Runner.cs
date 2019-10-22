using System;

namespace OOP_1
{
    class Runner
    {
        static void Main(string[] args)
        {
            Triangle tr = new Triangle(12,10,8);
            
            tr.lengthOfSides();
            tr.perimeter();
            tr.area();

            tr.A = 20;
            tr.B = 15;
            tr.lengthOfSides();
            tr.area();

            Console.WriteLine("Is triangle exists: " + tr.isTriangleExists);

            Console.WriteLine(tr[0]);                           // Индексатор, позволяющий по индексу 0,1,2 получить значение  угла a,b,c
            Console.WriteLine(tr[1]);
            Console.WriteLine(tr[2]);
            Console.WriteLine(tr[128]);                         // waiting for: -1;


            Console.WriteLine("");

            Triangle tr2 = new Triangle(3);
            Console.WriteLine("Is triangle exists: " + tr.isTriangleExists);
            tr2.lengthOfSides();
            tr2.perimeter();
            tr2.area();
            Console.WriteLine(tr2[0]);

            tr2.A = 5;
            tr2.lengthOfSides();
            tr2.area();

        }


    }
}
