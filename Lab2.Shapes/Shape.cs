using System;
using System.Collections.Specialized;

namespace Lab2.Shapes
{
    public abstract class Shape
    {
        public abstract Vector3 Center { get; }
        public abstract float Area { get; }
    }
}
