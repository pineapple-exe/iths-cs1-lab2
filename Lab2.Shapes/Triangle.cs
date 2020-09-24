using System;
using System.Numerics;
using System.Collections;

namespace Lab2.Shapes
{
    public class Triangle : Shape2D, IEnumerator, IEnumerable
    {
        private Vector2 p1;
        private Vector2 p2;
        private Vector2 p3;
        private Vector2 center;
        Vector2[] triPoints;

        public Triangle(Vector2 p1, Vector2 p2, Vector2 p3)
        {
            this.p1 = p1;
            this.p2 = p2;
            this.p3 = p3;
            center = new Vector2((p1.X + p2.X + p3.X) / 3f, (p1.Y + p2.Y + p3.Y) / 3f);
            triPoints = new Vector2[] { this.p1, this.p2, this.p3 };
        }

        public override Vector3 Center
        {
            get { return new Vector3(center.X, center.Y, 0); }
        }

        public override float Area
        {
            get
            {
                float coordinateInferno = p1.X * (p2.Y - p3.Y) + p2.X * (p3.Y - p1.Y) + p3.X * (p1.Y - p2.Y);
                return Math.Abs(coordinateInferno) / 2;
            }
        }

        public override float Circumference
        {
            get
            {
                double s1 = Math.Sqrt(Math.Pow(p1.X - p2.X, 2) + Math.Pow(p1.Y - p2.Y, 2));
                double s2 = Math.Sqrt(Math.Pow(p1.X - p3.X, 2) + Math.Pow(p1.Y - p3.Y, 2));
                double s3 = Math.Sqrt(Math.Pow(p2.X - p3.X, 2) + Math.Pow(p2.Y - p3.Y, 2));
                return (float)(s1 + s2 + s3);
            }
        }

        int position = -1;

        public object Current
        {
            get { return triPoints[position]; }
        }

        public bool MoveNext()
        {
            position++;
            return (position < triPoints.Length);
        }

        public void Reset()
        {
            this.position = -1;
        }

        public IEnumerator GetEnumerator()
        {
            return this;
        }

        public override string ToString()
        {
            return $"triangle @({FormatVector(center)}): p1({FormatVector(p1)}), p2({FormatVector(p2)}), p3({FormatVector(p3)})";
        }
    }
}
