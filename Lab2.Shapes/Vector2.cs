﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lab2.Shapes
{
    public class Vector2
    {
        public readonly float X;
        public readonly float Y;

        public Vector2(float x, float y)
        {
            X = x;
            Y = y;
        }

        public override string ToString()
        {
            return $"{X}, {Y}";
        }
    }
}
