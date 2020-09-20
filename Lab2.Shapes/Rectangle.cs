using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Shapes
{
//    Denna klass ska ha en konstruktor som tar parametrar: Vector2 center, Vector2
//size(dvs.höjd/bredd), samt en alternativ konstruktor: Vector2 center, float width
//(som sätter både höjd och bredd till samma värde).
//Den ska även implementera en property IsSquare som returnerar true om höjd
//och bredd är lika(annars false).
//ToString() => “rectangle @(3.0, 4.0): w = 4.0, h = 5.0” (square om w == h). 

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
            Vector2 sz = new Vector2(width, width);
            size = sz;
            
        }
        public override Vector3 Center
        {
            get { return new Vector3(center.X, center.Y, 0); }
        }

        public override float Area
        {
            get { return size.X * size.Y; }
        }

        public override float Circumference 
        { 
            get { return (size.X * 2) + (size.Y * 2); }
        }

        public bool IsSquare 
        { 
            get { return size.X == size.Y; }
        }

        public override string ToString()
        {
            string rectangleOrSquare = IsSquare ? "square" : "rectangle";

            return $"{rectangleOrSquare} @({center}): w = {size.X}, h = {size.Y}";
        }
    }
}
