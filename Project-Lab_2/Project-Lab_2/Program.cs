using System;

namespace Project_Lab_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Cylinder C = new Cylinder(5, 10);
            Console.WriteLine("Радіус циліндра = {0,5:f3}", C.GetRadius());
            Console.WriteLine("Висота циліндра = {0,5:f3}", C.GetHeight());
            Console.WriteLine("Площа бічної поверхні циліндра = {0,5:f3}", C.AreaSideSurface());
            Console.WriteLine("Площа основи циліндра = {0,5:f3}", C.AreaBase());
            Console.WriteLine("Об'єм циліндра = {0,5:f3}", C.Volume());
            C.SetRadius(10);
            Console.WriteLine("Радіус циліндра = {0,5:f3}", C.GetRadius());
        }
    }
}
