using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Shapes
{
    public class Cuboid : Shape3D
    {
        private Vector3 center;
        private Vector3 size;

        public Cuboid(Vector3 center, Vector3 size)
        {
            this.center = center;
            this.size = size;
        }

        public Cuboid(Vector3 center, float width)
        {
            this.center = center;
            Vector3 sz = new Vector3(width, width, width);
            size = sz;
        }

        public override Vector3 Center
        {
            get { return new Vector3(center.X, center.Y, center.Z); }
        }

        public override float Area
        {
            get 
            {
                return (size.X * size.Y + size.X * size.Z + size.Y * size.Z) * 2;
            }
        }

        public bool IsCube
        {
            get { return size.X == size.Y && size.X == size.Z; }
        }

        public override float Volume
        {
            get { return size.X * size.Y * size.Z; }
        }

        public override string ToString()
        {
            string cub = IsCube ? "cube" : "cuboid";

            return $"{cub} @({center.X}, {center.Y}, {center.Z}): w = {size.X}, h = {size.Y}, l = {size.Z}";
        }
    }
}
