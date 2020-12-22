using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    class Human : IPerson
    {
        public Human(string name, int height, int speed)
        {
            Name = name;
            Height = height;
            MaxSpeed = speed;
        }
        ~Human()
        {
            Console.WriteLine("Об'єкт зруйновано");
        }
        public string Name { get; set; }
        public int Height { get; set; }
        public int MaxSpeed { get; set; }
        public void MovesOn(string transport)
        {
            Console.WriteLine($"{Name} ездит на мотоцикле {transport}. \n");
        }
        public void About(string transport)
        {
            Console.WriteLine($"Меня зовут {Name}. Мой рост {Height}. Моя максимальная скорость = {MaxSpeed}.");
            MovesOn(transport);
        }
    }
}
