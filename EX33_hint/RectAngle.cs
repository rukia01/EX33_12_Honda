﻿using System;
using System.Collections.Generic;
using System.Text;

namespace EX33_hint
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
        }
        public float GetSurface()
        {
            return width * height;
        }
        public float GetCircumference()
        {
            return (width + height) * 2;
        }
        public void GetBounds(out float width, out float height)
        {
            width = this.width;
            height = this.height;
        }
        public static bool operator ==(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width;
        }
        
        public static bool operator !=(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            return !(rectAngle1.width == rectAngle2.width
                && rectAngle1.height == rectAngle2.height
                || rectAngle1.width == rectAngle2.height
                && rectAngle1.height == rectAngle2.width);
        }
        
        public static RectAngle operator +(RectAngle rectAngle1, RectAngle rectAngle2)
        {
            float h, w;
            if (MathF.Min(rectAngle1.height, rectAngle1.width) == MathF.Min(rectAngle2.height, rectAngle2.width))
            {
                h = MathF.Max(rectAngle1.height, rectAngle1.width) + MathF.Max(rectAngle2.height, rectAngle2.width);
                w = MathF.Min(rectAngle1.height, rectAngle1.width);
            }
            else
            {
                h = MathF.Max(MathF.Max(rectAngle1.height, rectAngle1.width), MathF.Max(rectAngle2.height, rectAngle2.width));
                w = MathF.Min(rectAngle1.height, rectAngle1.width) + MathF.Min(rectAngle2.height, rectAngle2.width);
            }
            return new RectAngle(h, w);
        }
    }
}
