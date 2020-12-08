using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_4
{
    class Circle : CGraphicsObject
    {
        public float Radius { get; set; }
        public Circle(float x, float y, float radius):base(x, y) 
        {
            Radius = radius;
        } 
        ~Circle()
        {
            Console.WriteLine("Об'єкт зруйновано");
        }
        public override string Show()
        {
            return $"Центр кола точка з кординатами: {CenterX + Radius}, {CenterY + Radius}\nРадіус: {Radius}\nІнформація про предків: {typeof(Circle).BaseType} -> {typeof(Circle)}";
        }
        public override double Area()
        {
            double Area = Math.PI * Math.Pow(Radius, 2);
            return Math.Round(Area, 2);
        }
    }
}
