using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    interface IMotorcycle
    {
        public string Brand { get; set; }
        public int MaxSpeed { get; set; }
        public void Rider(string rider);
    }
}
