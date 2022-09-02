using System;

namespace OOP
{

    class Driver
    {

        public static void Main(string[] args)
        {
            //Inheritance
            AutoMobile car = new AutoMobile(4, "red", "v8");
            PulledVehicle horseChariot = new PulledVehicle(4, "horse", 2);
            Console.WriteLine($"Car Discription: Color - {car.Color}, Car Engine - {car.EngineType}, Car Wheels - {car.NumberOfWheels} ");
            Console.WriteLine($"Horse Chariot: Pulled by - {horseChariot.PulledBy}, Number of puller - {horseChariot.NumberOfPuller}, Chariot Wheels - {horseChariot.NumberOfWheels} ");


            //Abstaction
            Rabbit rab = new Rabbit();
            Dog dog = new Dog();
            Fish fish = new Fish();
            rab.Locomotion();
            dog.Locomotion();
            fish.Locomotion();

            //Polymorphism
            ////Runtime
            Man m1 = new Man();
            Man m2 = new AngryMan();
            m1.Speaks();
            m2.Speaks();

            ////Compile time
            Calculate calc = new Calculate();
            Console.WriteLine(calc.Add(4.5f, 3.5f));
            Console.WriteLine(calc.Add(4, 3));
            Console.WriteLine(calc.Add("4", "3"));

        }


    }
}
