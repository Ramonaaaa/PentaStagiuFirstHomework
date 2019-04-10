using System;
using System.Collections.Generic;
using System.Text;

namespace PentaStagiuFirstHomework
{
    public class SmallApartment: House
    {
        public override int Area
        {
            get
            {
                return this.area;
            }
            set
            {
                if (value > 50)
                    Console.WriteLine("Please insert a value smaller than 50 m2!");
                else
                    this.area = value;
            }
        }
    }
}
