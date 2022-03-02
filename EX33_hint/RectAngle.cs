using System;
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
            float h1, w1, h2, w2,  s1, s2, rect;
            h1 = MathF.Max(rectAngle1.height, rectAngle1.width) + MathF.Max(rectAngle2.height, rectAngle2.width);
            w1 = MathF.Max(MathF.Min(rectAngle1.height, rectAngle1.width),MathF.Min(rectAngle2.height,rectAngle2.width));
            s1 = h1 * w1;
            h2 = MathF.Max(MathF.Max(rectAngle1.height, rectAngle1.width), MathF.Max(rectAngle2.height, rectAngle2.width));
            w2 = MathF.Min(rectAngle1.height, rectAngle1.width) + MathF.Min(rectAngle2.height, rectAngle2.width);
            s2 = h2 * w2;
            rect = MathF.Min(s1, s2);

            if (rect == s1)
            {
                return new RectAngle(w1, h1);
            }
            else
            {
                return new RectAngle(w2, h2);
            }
        }
    }
}
