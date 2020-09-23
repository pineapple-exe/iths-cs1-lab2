using System;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;
using System.Text;
using System.Numerics;

namespace Lab2.Shapes
{
    public class Sphere : Shape3D
    {
        private Vector3 center;
        private float radius;

        public Sphere(Vector3 center, float radius)
        {
            this.center = center;
            this.radius = radius;
        }

        public override Vector3 Center 
        {
            get { return new Vector3(center.X, center.Y, center.Z); } 
        }

        public override float Area
        {
            get
            {
                return (float)(4 * Math.PI * radius * radius);
            }
        }

        public override float Volume
        {
            get { return (float)(4 * Math.PI * Math.Pow(radius, 3) / 3); }
        }

        public override string ToString()
        {
            return $"sphere @({FormatVector(center)}): r = {FormatFloat(radius)}";
        }
    }
}
