using System;

namespace OOP
{
    //Inheritance
    class Vehicle
    {
        private int numberOfWheels;

        public int NumberOfWheels { get { return numberOfWheels; } }

        public Vehicle(int numberOfWheels)
        {
            this.numberOfWheels = numberOfWheels;
        }
    }

    class PulledVehicle : Vehicle
    {
        private string pulledBy;

        private int numberOfPuller;


        public string PulledBy { get { return pulledBy; } }
        public int NumberOfPuller { get { return numberOfPuller; } }

        public PulledVehicle(int numberOfWheels, string pulledBy, int numberOfPuller) : base(numberOfWheels)
        {

            this.pulledBy = pulledBy;
            this.numberOfPuller = numberOfPuller;
        }


    }

    class AutoMobile : Vehicle
    {
        private string engineType;
        private string color;

        public string EngineType { get { return engineType; } }
        public string Color { get { return color; } }

        public AutoMobile(int numberOfWheels, string color, string engineType) : base(numberOfWheels)
        {

            this.color = color;
            this.engineType = engineType;
        }


    }
}
