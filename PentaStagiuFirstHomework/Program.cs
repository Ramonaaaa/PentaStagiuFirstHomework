using System;

namespace PentaStagiuFirstHomework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-----------------------------------------House------------------------------------------------------");

            House myHouse = new House();
            myHouse.Area = 200;
            Console.WriteLine(myHouse);
            myHouse.door.Color = "blue";
            Console.WriteLine(myHouse.door);


            Console.WriteLine("-----------------------------------------SmallApartment------------------------------------------------------");

            SmallApartment smallAp = new SmallApartment();
            smallAp.Area = 125;
            smallAp.Area = 40;
            Console.WriteLine(smallAp);
            smallAp.door.Color = "red";
            Console.WriteLine(smallAp.door);

            Console.WriteLine("-----------------------------------------Person-----------------------------------------------------");

            Person person = new Person();
            person.Name = "Lulu";
            person.personHouse.Area = 458;
            person.personDoor.Color = "green";
            Console.WriteLine(person);

        }
    }
}
