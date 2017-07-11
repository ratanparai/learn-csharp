using System;

namespace LearnAttribute
{
    class Program
    {
        static void Main(string[] args)
        {

            IAnimal dog = new Dog("Tom");
            Room room = new Room();
            room.For(dog);

            room.PrintWhoIsLeavingInTheRoom();


            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}