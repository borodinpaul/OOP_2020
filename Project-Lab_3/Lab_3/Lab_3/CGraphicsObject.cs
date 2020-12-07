using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3
{
    public abstract class CGraphicsObject
    {
        double radius;
        double angle;

        public abstract void SetRadius(double radius);
        public abstract void SetAngle(double angle);
        public abstract double GetRadius();
        public abstract double GetAngle();
        
    }
}