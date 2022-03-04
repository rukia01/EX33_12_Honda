using System;
using System.Collections.Generic;
using System.Text;

namespace EX33_hint
{
    class RectAngle : ISurface, ICircumference, IBounds
    {
        readonly public float width;
        readonly public float height;
        readonly public float shorter;
        readonly public float longer;
        public RectAngle(float width = 0, float height = 0)
        {
            this.width = width;
            this.height = height;
            if (height < width)
            {
                shorter = height;
                longer = width;
            }
            else
            {
                shorter = width;
                longer = height;
            }
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
            var rectAngleA = new RectAngle(
                rectAngle1.longer+rectAngle2.longer,
                MathF.Max(rectAngle1.shorter,rectAngle2.shorter));
            var rectAngleB  = new RectAngle(
                MathF.Max(rectAngle1.longer, rectAngle2.longer),
                rectAngle1.shorter + rectAngle2.shorter);
            return (rectAngleA.GetSurface() < rectAngleB.GetSurface())
                ? rectAngleA : rectAngleB;
        }
    }
}
