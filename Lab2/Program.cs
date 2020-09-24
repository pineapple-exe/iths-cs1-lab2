using System;
using System.Collections.Generic;
using Lab2.Shapes;

namespace Lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> twentyShapes = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                twentyShapes.Add(Shape.GenerateShape());
            }

            float trianglesCircum = 0;
            float areas = 0;
            Shape3D voluminous = null;

            for (int j = 0; j < twentyShapes.Count; j++)
            {
                areas += twentyShapes[j].Area;

                if (twentyShapes[j] is Triangle tri)
                {
                    trianglesCircum += tri.Circumference;
                }

                else if (twentyShapes[j] is Shape3D threeD)
                {
                    if (voluminous == null)
                    {
                        voluminous = threeD;
                    }
                    else if (voluminous.Volume < threeD.Volume)
                    {
                        voluminous = threeD;
                    }
                }

                Console.WriteLine(twentyShapes[j]);
                Console.WriteLine();
            }

            Console.WriteLine($"Summan av trianglarnas omkrets: {Shape.FormatFloat(trianglesCircum)}");
            Console.WriteLine($"Den genomsnittliga arean av samtliga figurer: {Shape.FormatFloat(areas / 20)}");
            Console.WriteLine($"Den Shape3D med störst volym: {voluminous}");
        }
    }
}
