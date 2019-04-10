using System;
using System.Collections.Generic;
using System.Text;

namespace PentaStagiuFirstHomework
{
    public class Person
    {
        private string name;

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }

        public House personHouse = new House();
        public Door personDoor = new Door();

        public override string ToString()
        {
            return $"My name is {name}. " + "\n" +  personHouse + "\n" + personDoor; 
        }
    }
}
