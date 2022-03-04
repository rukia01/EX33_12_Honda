using System;

namespace EX33_hint
{
    class Program
    {
        static void Main(string[] args)
        {
            RectAngle rectAngle1 = new RectAngle(5, 3);
            RectAngle rectAngle2 = new RectAngle(2, 8);
            var rectAngle3 = rectAngle1 + rectAngle2;
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("同じ四角形");
            }
            else
            {
                Console.WriteLine("違う四角形");
            }
            Console.WriteLine($"rectAngle1 + rectAngle2 = {rectAngle3.height} × {rectAngle3.width} = {rectAngle3.GetSurface()}");
            TestEx33();
        }
        static void TestEx33()
        {
            Console.WriteLine("TestEx33");
            RectAngle rectAngle1 = new RectAngle(3, 5);
            RectAngle rectAngle2 = new RectAngle(2, 8);
            RectAngle rectAngle3 = new RectAngle(2, 4);
            if (rectAngle1 == rectAngle2)
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しい");
            }
            else
            {
                Console.WriteLine("rectAngle1とrectAngle2は等しくない");
            }
            var rectAngle4 = rectAngle1 + rectAngle2;
            Console.WriteLine($"rectAngle1+rectAngle2=({rectAngle4.width},{rectAngle4.height})");
            var rectAngle5 = rectAngle1 + rectAngle3;
            Console.WriteLine($"rectAngle1+rectAngle3=({rectAngle5.width},{rectAngle5.height})");

            var rectAngle6 = new RectAngle(5, 1);
            var rectAngle7 = new RectAngle(3, 2);
            var rectAngle8 = rectAngle6 + rectAngle7;
            Console.WriteLine($"rectAngle6+rectAngle7=({rectAngle8.width},{rectAngle8.height})");
            var rectAngle10 = (new RectAngle(1, 5)) + rectAngle7;
            Console.WriteLine($"RectAngle(1,5)+rectAngle7=({rectAngle10.width},{rectAngle10.height})");
            rectAngle10 = (new RectAngle(1, 5)) + new RectAngle(2,3);
            Console.WriteLine($"RectAngle(1,5)+RectAngle(2,3)=({rectAngle10.width},{rectAngle10.height})");
            rectAngle10 = (new RectAngle(5, 1)) + new RectAngle(2, 3);
            Console.WriteLine($"RectAngle(5,1)+RectAngle(2,3)=({rectAngle10.width},{rectAngle10.height})");
        }
    }
}
