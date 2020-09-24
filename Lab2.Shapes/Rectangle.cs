using System.Numerics;

namespace Lab2.Shapes
{
    public class Rectangle : Shape2D
    {
        private Vector2 center;
        private Vector2 size;

        public Rectangle(Vector2 center, Vector2 size)
        {
            this.center = center;
            this.size = size;
        }

        public Rectangle(Vector2 center, float width)
        {
            this.center = center;
            size = new Vector2(width, width);   
        }

        public override Vector3 Center
        {
            get { return new Vector3(center.X, center.Y, 0); }
        }

        public bool IsSquare
        {
            get { return size.X == size.Y; }
        }

        public override float Area
        {
            get { return size.X * size.Y; }
        }

        public override float Circumference 
        { 
            get { return (size.X * 2) + (size.Y * 2); }
        }

        public override string ToString()
        {
            string rectangleOrSquare = IsSquare ? "square" : "rectangle";
            return $"{rectangleOrSquare} @({FormatVector(center)}): w = {FormatFloat(size.X)}, h = {FormatFloat(size.Y)}";
        }
    }
}
