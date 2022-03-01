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
            float h1, w1, h2, w2, h3, w3, h4, w4, s1, s2, s3, s4, rect;
            h1 = MathF.Max(rectAngle1.height, rectAngle1.width) + MathF.Max(rectAngle2.height, rectAngle2.width);
            w1 = MathF.Max(MathF.Min(rectAngle1.height, rectAngle1.width),MathF.Min(rectAngle2.height,rectAngle2.width));
            s1 = h1 * w1;
            h2 = MathF.Max(MathF.Max(rectAngle1.height, rectAngle1.width), MathF.Max(rectAngle2.height, rectAngle2.width));
            w2 = MathF.Min(rectAngle1.height, rectAngle1.width) + MathF.Min(rectAngle2.height, rectAngle2.width);
            s2 = h2 * w2;
            h3 = MathF.Max(MathF.Min(rectAngle1.height, rectAngle1.width), MathF.Max(rectAngle2.height, rectAngle2.width));
            w3 = MathF.Max(rectAngle1.height, rectAngle1.width) + MathF.Min(rectAngle2.height, rectAngle2.width);
            s3 = h3 * w3;
            h4 = MathF.Max(MathF.Max(rectAngle1.height, rectAngle1.width), MathF.Min(rectAngle2.height, rectAngle2.width));
            w4 = MathF.Min(rectAngle1.height, rectAngle1.width) + MathF.Max(rectAngle2.height, rectAngle2.width);
            s4 = h4 * w4;
            rect = MathF.Min(s1, s2);
            rect = MathF.Min(rect, s3);
            rect = MathF.Min(rect, s4);

            if (rect == s1)
            {
                return new RectAngle(h1, w1);
            }
            else if (rect == s2)
            {
                return new RectAngle(h2, w2);
            }
            else if (rect == s3)
            {
                return new RectAngle(h3, w3);
            }
            else
            {
                return new RectAngle(h4, w4);
            }
        }
    }
}
