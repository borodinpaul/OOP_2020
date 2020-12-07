using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public class CPoint : CGraphicsObject
    {
        public double radius, angle;
        public CPoint(double r, double a)
        {
            radius = r;
            angle = a;
        }

        ~CPoint()
        {
            Console.WriteLine("Об'єкт зруйновано");
        }

        public override void SetRadius(double r)
        {
            radius = r;
        }
        public override double GetRadius() 
        {
            return radius;
        }
        public override void SetAngle(double a)
        {
            angle = a;
        }
        public override double GetAngle()
        {
            return angle;
        }

        public void Show()
        {
            Console.WriteLine("Радіус дуги = {0,5:f3}, Центральний кут (у радіанах) = {0,5:f3}", radius, angle);
        }
    }
}