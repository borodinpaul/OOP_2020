using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class СircleArc : CPoint
    {
        double radius, angle;
        public СircleArc(double r, double a) : base(r, a) { }

        ~СircleArc()
        {
            Console.WriteLine("Об'єкт зруйновано");
        }

        public void Show()
        {
            Console.WriteLine("Радіус дуги = {0,5:f3}, Центральний кут (у радіанах) = {0,5:f3}, Довжина дуги = {0,5:f3}", radius, angle, radius * angle);
        }
    }
}