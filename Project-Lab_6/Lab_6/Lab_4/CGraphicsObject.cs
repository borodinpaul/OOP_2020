using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    abstract class CGraphicsObject
    {
        public float CenterX { get; set; }
        public float CenterY { get; set; }
        public CGraphicsObject(float x, float y)
        {
            CenterX = x;
            CenterY = y;
        }
        public abstract string Show();
        public abstract double Area();
        public static double operator -(CGraphicsObject c1, CGraphicsObject c2)
        {
            return c1.Area() + c2.Area();
        }
    }
}
