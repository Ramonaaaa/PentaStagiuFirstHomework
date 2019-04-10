using System;
using System.Collections.Generic;
using System.Text;

namespace PentaStagiuFirstHomework
{
    public class Door
    {
        private string color;

        public string Color
        {
            get
            {
                return this.color;
            }
            set
            {
                this.color = value;
            }
        }

        public override string ToString()
        {
            return $"The color of my entry door is {color}.";
        }
    }
}
