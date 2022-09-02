using System;

namespace OOP
{
    abstract class Animal
    {
        abstract public void Locomotion();
    }

    class Rabbit : Animal
    {
        public override void Locomotion()
        {
            Console.WriteLine("Rabbit hops");
        }
    }

    class Dog : Animal
    {
        public override void Locomotion()
        {
            Console.WriteLine("Dog runs");
        }
    }

    class Fish : Animal
    {
        public override void Locomotion()
        {
            Console.WriteLine("Fish Swins");
        }
    }

}
