using System;

namespace Lab_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Human Paul = new Human("Paul", 195, 20);
            Motorbike Yamaha = new Motorbike("Yamaha", 260);
            Paul.About(Yamaha.Brand);
            Yamaha.About(Paul.Name);
        }
    }
}
