using System;
using System.Globalization;
using System.Numerics;

namespace Lab2.Shapes
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }

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
                        Vector2 trianglePoint3 = new Vector2((center2D.X * 3) - trianglePoint1.X - trianglePoint2.X, (center2D.Y * 3) - trianglePoint1.Y - trianglePoint2.Y);

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

        private static Vector3 GenVector3(Random rndm)
        {
            return new Vector3(GenNum(rndm), GenNum(rndm), GenNum(rndm));
        }

        private static Vector2 GenVector2(Random rndm)
        {
            return new Vector2(GenNum(rndm), GenNum(rndm));
        }

        private static float GenNum(Random rndm)
        {
            return (float)rndm.NextDouble() * 10f + 1f;
        }

        public static string FormatFloat(float input)
        {
            FormattableString f = $"{input:0.0}";
            return f.ToString(new CultureInfo("en-US"));
        }

        internal static string FormatVector(Vector2 v2)
        {
            FormattableString f = $"{v2.X:0.0}, {v2.Y:0.0}";
            return f.ToString(new CultureInfo("en-US"));
        }

        internal static string FormatVector(Vector3 v3)
        {
            FormattableString f = $"{v3.X:0.0}, {v3.Y:0.0}, {v3.Z:0.0}";
            return f.ToString(new CultureInfo("en-US"));
        }
    }
}
