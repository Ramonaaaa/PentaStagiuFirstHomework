using System;
using System.Collections.Generic;
using System.Text;

namespace PentaStagiuFirstHomework
{
    public class House
    {
       protected int area;

       public House() { }
       
        public virtual int Area
        {
            get
            {
                return this.area;
            }
            set
            {
                this.area = value;
            }
        }

        public Door door = new Door();

        public override string ToString()
        {
            return $"The area of my house is {area} m2.";
        }
    }
}
