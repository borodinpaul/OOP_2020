using System;
using System.Collections.Generic;
using System.Text;

namespace Project_Lab_2
{
    class Cylinder
    {
        double radius, height;
        public Cylinder(double r, double h) { 
            radius = r; 
            height = h; 
        }
        ~Cylinder()
        {
            Console.WriteLine("Об'єкт зруйновано");
        }
        public double AreaBase()
        {
            return radius * Math.Pow(Math.PI, 2);
        }
        public double AreaSideSurface() 
        { 
            return 2 * Math.PI * radius * height; 
        }

        public double Volume() 
        { 
            return Math.PI* Math.Pow(radius, 2) * height; 
        }

        public void SetRadius(double r) 
        { 
            radius = r; 
        }
        public void SetHeight(double h) 
        { 
            height = h; 
        }
        public double GetRadius() 
        { 
            return radius; 
        }
        public double GetHeight() 
        { 
            return height; 
        }
    }
}
