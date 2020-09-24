using System.Numerics;

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
            size = new Vector3(width, width, width);
        }

        public override Vector3 Center
        {
            get { return new Vector3(center.X, center.Y, center.Z); }
        }

        public bool IsCube
        {
            get { return size.X == size.Y && size.X == size.Z; }
        }

        public override float Area
        {
            get 
            {
                return (size.X * size.Y + size.X * size.Z + size.Y * size.Z) * 2;
            }
        }

        public override float Volume
        {
            get { return size.X * size.Y * size.Z; }
        }

        public override string ToString()
        {
            string cub = IsCube ? "cube" : "cuboid";
            return $"{cub} @({FormatVector(center)}): w = {FormatFloat(size.X)}, h = {FormatFloat(size.Y)}, l = {FormatFloat(size.Z)}";
        }
    }
}
