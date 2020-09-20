using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace Lab2.Shapes
{
    //Konstruktorn tar tre parameterar p1, p2, p3 av typ Vector2, som beskriver de tre
    //punkter som utgör triangeln.Tänk på att Center också behöver beräknas.
    //ToString() => “triangle @(3.0, 1.0): p1(0.0, 0.0), p2(3.0, 3.0), p3(6.0. 0.0)” 

    public class Triangle : Shape2D
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private Vector2 center;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            Vector2 cntr = new Vector2((p1.X + p2.X + p3.X) / 3f, (p1.Y + p2.Y + p3.Y) / 3f);
            center = cntr;
        }

        public override Vector3 Center
        {
            get { return new Vector3(center.X, center.Y, 0); }
        }

        public override float Area
        {
            get 
            {
                double side = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
                Vector2 middlepoint = new Vector2(p1.X + p2.X / 2, p1.Y + p2.Y / 2);
                double height = Math.Sqrt(Math.Pow(p3.X - middlepoint.X, 2) + Math.Pow(p3.Y - middlepoint.Y, 2));
                return (float)(side * height / 2);
            }
        }

        public override float Circumference
        {
            get 
            { 
                double s1 = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
                double s2 = Math.Sqrt(Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.X - p3.X, 2));
                double s3 = Math.Sqrt(Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2));
                return (float)(s1 + s2 + s3);
            }
        }

        public override string ToString()
        {
            return $"triangle @({center}): p1({p1.X}, {p1.Y}), p2({p2.X}, {p2.Y}), p3({p3.X}, {p3.Y})";
        }
    }
}
