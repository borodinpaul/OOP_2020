using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Motorbike : IMotorcycle
    {
        public Motorbike(string brand, int speed)
        {
            Brand = brand;
            MaxSpeed = speed;
        }
        ~Motorbike()
        {
            Console.WriteLine("Об'єкт зруйновано");
        }
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public void Rider(string rider)
        {
            Console.WriteLine($"На этом мотоцикле {Brand} ездит {rider}.");
        }
        public void About(string rider)
        {
            Console.WriteLine($"Это мотоцикл фирмы {Brand}. Максимальная скорость этого мотоцикла = {MaxSpeed}.");
            Rider(rider);
        }
    }
}
