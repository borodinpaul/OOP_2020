using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Trapezoid : CGraphicsObject
    {
        public float RightTopX { get; set; }
        public float RightTopY { get; set; }
        public float RightBottomX { get; set; }
        public float RightBottomY { get; set; }
        public float LeftBottomX { get; set; }
        public float LeftBottomY { get; set; }
        public float Height { get; set; }
        public Trapezoid(float x, float y, float x1, float y1, float x2, float y2, float x3, float y3) : base(x, y)
        {
            RightTopX = x1;
            RightTopY = y1;
            RightBottomX = x2;
            RightBottomY = y2;
            LeftBottomX = x3;
            LeftBottomY = y3;
            Height = y3 - y;
        }
        ~Trapezoid()
        {
            Console.WriteLine("Об'єкт зруйновано");
        }
        public override string Show()
        {
            return $"Координати трапеції:\nLT({CenterX}, {CenterY}), RT({RightTopX}, {RightTopY}),\nRB({RightBottomX},{RightBottomY}), LB({LeftBottomX}, {LeftBottomY})\nВисота: {Height}\nІнформація про предків: {typeof(Trapezoid).BaseType} -> {typeof(Trapezoid)}";
        }
        public override double Area()
        {
            double Top = RightTopX - CenterX;
            double Bottom = RightBottomX - LeftBottomX;
            double Area = (Top + Bottom)/2 * Height;
            Area = Math.Round(Area, 2);
            return Area;
        }
    }
}
