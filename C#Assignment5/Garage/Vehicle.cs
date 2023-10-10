using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace C_Assignment5.Garage
{
    public class Vehicle
    {
        // Common properties and methods for Vehicles
        public string RegistrationNumber { get; set; }
        public string Color { get; set; }
        public int NumberOfWheels { get; set; }
        public int NumberOfEngines { get; set; }
        public string FuelType { get; set; }

        public Vehicle(string registrationNumber, string color, int numberOfWheels, int numberOfEngines, string fuelType)
        {
            RegistrationNumber = registrationNumber;
            Color = color;
            NumberOfWheels = numberOfWheels;
            NumberOfEngines = numberOfEngines;
            FuelType = fuelType;
        }
    }

    public class Car : Vehicle
    {
        // Additional properties and methods specific to cars
        public int NumberOfDoors { get; set; }

        public Car(string registrationNumber, string color, int numberOfWheels, int numberOfEngines, string fuelType, int numberOfDoors)
        : base(registrationNumber, color, numberOfWheels, numberOfEngines, fuelType)
        {
            NumberOfDoors = numberOfDoors;
        }
    }

    public class Airplane : Vehicle
    {
        // Additional properties and methods specific to airplanes
        public int MaximumAltitude { get; set; }

        public Airplane(string registrationNumber, string color, int numberOfWheels, int numberOfEngines, string fuelType, int maximumAltitude)
        : base(registrationNumber, color, numberOfWheels, numberOfEngines, fuelType)
        {
            MaximumAltitude = maximumAltitude;
        }
    }

    public class Motorcycle : Vehicle
    {
        // Additional properties and methods specific to motorcycles
        public int CylinderVolume { get; set; }

        public Motorcycle(string registrationNumber, string color, int numberOfWheels, int numberOfEngines, string fuelType, int cylinderVolume)
        : base(registrationNumber, color, numberOfWheels, numberOfEngines, fuelType)
        {
            CylinderVolume = cylinderVolume;
        }
    }

    public class Bus : Vehicle
    {
        // Additional properties and methods specific to buses
        public int NumberOfSeats { get; set; }

        public Bus(string registrationNumber, string color, int numberOfWheels, int numberOfEngines, string fuelType, int numberOfSeats) 
            : base(registrationNumber, color, numberOfWheels, numberOfEngines, fuelType)
        {
            NumberOfSeats = numberOfSeats;
        }
    }

    public class Boat : Vehicle
    {
        // Additional properties and methods specific to boats
        public int Length { get; set; }

        public Boat(string registrationNumber, string color, int numberOfWheels, int numberOfEngines, string fuelType, int length) 
            : base(registrationNumber, color, numberOfWheels, numberOfEngines, fuelType)
        {
            Length = length;
        }
    }
}
