using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics;
using Lab2.Shapes;

namespace Lab2
{
    class Program
    {
//        Skapa ett projekt i samma solution som använder sig av ert class library
//Detta projekt ska skapa en lista med 20 random shapes, genom att anropa
//GenerateShape(). Loopa sedan igenom listan och skriv ut alla shapes till konsollen.
//Räkna samtidigt ut summan av omkretserna på alla trianglar i listan,
//den genomsnittliga arean av alla Shapes i listan,
//samt hitta den Shape3D som har störst volym av alla i listan.
//Presentera detta snyggt och tydligt på konsollen när loopen är klar.
        static void Main(string[] args)
        {
            //Vector2 p1 = new Vector2();
            //Vector2 p2 = new Vector2();
            //Vector2 p3 = new Vector2();
            //Triangle tri = new Triangle();


            List<Shape> twentyShapes = new List<Shape>();

            for (int i = 0; i < 20; i++)
            {
                twentyShapes.Add(GenerateShape());
            }

            float trianglesCircum = 0;
            float areas = 0;
            Shape3D voluminous = null;

            for (int j = 0; j < twentyShapes.Count; j++)
            {
                if (twentyShapes[j] is Triangle tri)
                {
                    trianglesCircum = tri.Circumference;
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

            Console.WriteLine($"Summan av trianglarnas omkrets: {trianglesCircum}");
            Console.WriteLine($"Den genomsnittliga arean av samtliga figurer: {}");
            Console.WriteLine($"Den Shape3D med störst volym: {voluminous}");
        }

        public static Shape GenerateShape()
        {
            Random rndm = new Random();
            int randomNumber = rndm.Next(0, 7);
            switch (randomNumber)
            {
                case 0:
                    {
                        Vector2 circleCenter = GenVector2(rndm);
                        float circleRadius = GenNum(rndm);

                        Circle circle = new Circle(circleCenter, circleRadius);
                        return circle;
                    }
                case 1:
                    {
                        Vector2 rectCenter = GenVector2(rndm);
                        Vector2 rectSize = GenVector2(rndm);

                        Rectangle rectangle = new Rectangle(rectCenter, rectSize);
                        return rectangle;
                    }
                case 2:
                    {
                        Vector2 squareCenter = GenVector2(rndm);
                        float squareWidth = GenNum(rndm);

                        Rectangle square = new Rectangle(squareCenter, squareWidth);
                        return square;
                    }
                case 3:
                    {
                        Vector2 trianglePoint1 = GenVector2(rndm);
                        Vector2 trianglePoint2 = GenVector2(rndm);
                        Vector2 trianglePoint3 = GenVector2(rndm);

                        Triangle triangle = new Triangle(trianglePoint1, trianglePoint2, trianglePoint3);
                        return triangle;
                    }
                case 4:
                    {
                        Vector3 cuboidCenter = GenVector3(rndm);
                        Vector3 cuboidSize = GenVector3(rndm);

                        Cuboid cuboid = new Cuboid(cuboidCenter, cuboidSize);
                        return cuboid;
                    }
                case 5:
                    {
                        Vector3 cubeCenter = GenVector3(rndm);
                        float cubeSize = GenNum(rndm);

                        Cuboid cube = new Cuboid(cubeCenter, cubeSize);
                        return cube;
                    }
                default:
                    {
                        Vector3 sphereCenter = GenVector3(rndm);
                        float sphereRadius = GenNum(rndm);

                        Sphere sphere = new Sphere(sphereCenter, sphereRadius);
                        return sphere;
                    }
            }
        }

        public static Shape GenerateShape(Vector3 center)
        {
            Vector2 center2D = new Vector2(center.X, center.Y);
            Random rndm = new Random();
            int randomNumber = rndm.Next(0, 7);
            switch (randomNumber)
            {
                case 0:
                    {
                        float circleRadius = GenNum(rndm);

                        Circle circle = new Circle(center2D, circleRadius);
                        return circle;
                    }
                case 1:
                    {
                        Vector2 rectSize = GenVector2(rndm);

                        Rectangle rectangle = new Rectangle(center2D, rectSize);
                        return rectangle;
                    }
                case 2:
                    {
                        float squareWidth = GenNum(rndm);

                        Rectangle square = new Rectangle(center2D, squareWidth);
                        return square;
                    }
                case 3:
                    {
                        Vector2 trianglePoint1 = GenVector2(rndm);
                        Vector2 trianglePoint2 = GenVector2(rndm);
                        //Bestäm Vector2 trianglePoint3 så att mittpunkten stämmer.

                        Triangle triangle = new Triangle(trianglePoint1, trianglePoint2, trianglePoint3);
                        return triangle;
                    }
                case 4:
                    {
                        Vector3 cuboidSize = GenVector3(rndm);

                        Cuboid cuboid = new Cuboid(center, cuboidSize);
                        return cuboid;
                    }
                case 5:
                    {
                        float cubeSize = GenNum(rndm);

                        Cuboid cube = new Cuboid(center, cubeSize);
                        return cube;
                    }
                default:
                    {
                        float sphereRadius = GenNum(rndm);

                        Sphere sphere = new Sphere(center, sphereRadius);
                        return sphere;
                    }
            }
        }

        public static Vector3 GenVector3(Random rndm)
        {
            return new Vector3(GenNum(rndm), GenNum(rndm), GenNum(rndm));
        }

        public static Vector2 GenVector2(Random rndm)
        {
            return new Vector2(GenNum(rndm), GenNum(rndm));
        }

        public static float GenNum(Random rndm)
        {
            return (float)rndm.NextDouble() * 10f + 1f;
        }
    }
}
