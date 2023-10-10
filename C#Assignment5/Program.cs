using System.Collections.Generic;
using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;
using C_Assignment5.Garage;

namespace C_Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create instances of the spcified classes
            Car myCar = new Car("CAR123", "Blue", 4, 1, "Gasoline", 4);
            Airplane myAirplane = new Airplane("AIRPLANE456", "White", 6, 2, "Jet Fuel", 30000);
            Motorcycle myMotorcycle = new Motorcycle("MOTO789", "Red", 2, 1, "Gasoline", 600);
            Bus myBus = new Bus("BUS101", "Yellow", 6, 1, "Diesel", 30);
            Boat myBoat = new Boat("BOAT555", "Green", 0, 2, "Diesel", 30);

            // Accessing property values
            _ = myCar.RegistrationNumber;
            _ = myCar.Color;
            _ = myCar.NumberOfWheels;
            _ = myCar.NumberOfEngines;
            _ = myCar.FuelType;
            _ = myCar.NumberOfDoors;

            _ = myAirplane.RegistrationNumber;
            _ = myAirplane.Color;
            _ = myAirplane.NumberOfWheels;
            _ = myAirplane.NumberOfEngines;
            _ = myAirplane.FuelType;
            _ = myAirplane.MaximumAltitude;

            _ = myMotorcycle.RegistrationNumber;
            _ = myMotorcycle.Color;
            _ = myMotorcycle.NumberOfWheels;
            _ = myMotorcycle.NumberOfEngines;
            _ = myMotorcycle.FuelType;
            _ = myMotorcycle.CylinderVolume;

            _ = myBus.RegistrationNumber;
            _ = myBus.Color;
            _ = myBus.NumberOfWheels;
            _ = myBus.NumberOfEngines;
            _ = myBus.FuelType;
            _ = myBus.NumberOfSeats;

            _ = myBoat.RegistrationNumber;
            _ = myBoat.Color;
            _ = myBoat.NumberOfEngines;
            _ = myBoat.Length;
            _ = myBoat.FuelType;

        }
    }
}