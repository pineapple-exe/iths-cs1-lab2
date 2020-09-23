using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;
using System.Numerics;

namespace Lab2.Shapes
{
    public class Circle : Shape2D
    {
        private Vector2 center;
        private float radius;

        public Circle(Vector2 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override Vector3 Center
        { 
            get { return new Vector3(center.X, center.Y, 0); } 
        }

        public override float Area 
        { 
            get { return (float)Math.PI * radius * radius; } 
        }

        public override float Circumference
        {
            get { return (float)Math.PI * radius * 2; }
        }

        public override string ToString()
        {
            return $"circle @({FormatVector(center)}): r = {FormatFloat(radius)}";
        }
    }
}
