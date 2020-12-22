using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5
{
    interface IPerson
    {
        public string Name { get; set; }
        public int Height { get; set; }
        public int MaxSpeed { get; set; }
        public void MovesOn(string transport);
    }
}
