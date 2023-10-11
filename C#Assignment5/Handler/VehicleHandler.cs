using C_Assignment5.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment5.Handler
{
    public class VehicleHandler
    {
        // Implement methods for creating instances of vehicle subclasses
        Car myCar = new Car("CAR123", "Blue", 4, 1, "Gasoline", 4);
        Airplane myAirplane = new Airplane("AIRPLANE456", "White", 6, 2, "Jet Fuel", 30000);
        Motorcycle myMotorcycle = new Motorcycle("MOTO789", "Red", 2, 1, "Gasoline", 600);
        Bus myBus = new Bus("BUS101", "Yellow", 6, 1, "Diesel", 30);
        Boat myBoat = new Boat("BOAT555", "Green", 0, 2, "Diesel", 30);

        VehicleHandler vehicleHandler = new VehicleHandler();
        public Car CreateCar
        {
            get
            {
                // Create a Car instance and set its properties
                string registrationNumber = "CAR123";
                string color = "Blue";
                int numberOfWheels = 4;
                int numberOfEngines = 1;
                string fuelType = "Gasoline";
                int numberOfDoors = 4;

                Car myCar = vehicleHandler.CreateCar;

            }
        }

        public Airplane CreateAirplane
        {
            get
            {
                // Create an Airplane instance and set its properties
                string registrationNumber = "AIRPLANE456";
                string color = "White";
                int numberOfWheels = 6;
                int numberOfEngines = 2;
                string fuelType = "Jet Fuel";
                int maximumAltitude = 30000;

                Airplane myAirplane = vehicleHandler.CreateAirplane;
            }
        }

        public Motorcycle CreateMotorcycle
        {
            get
            {
                // Create a Motorcycle instance and set its properties
                string registrationNumber = "MOTO789";
                string color = "Red";
                int numberOfWheels = 2;
                int numberOfEngines = 1;
                string fuelType = "Gasoline";
                int cylinderVolume = 600;

                Motorcycle myMotorcycle = vehicleHandler.CreateMotorcycle;
            }
        }

        public Bus CreateBus
        {
            get
            {
                // Create a Bus instance and set its properties
                string registrationNumber = "BUS101";
                string color = "Yellow";
                int numberOfWheels = 6;
                int numberOfEngines = 1;
                string fuelType = "Diesel";
                int numberOfSeats = 30;

                Bus myBus = vehicleHandler.CreateBus;
            }
        }

        public Boat CreateBoat
        {
            get
            {
                // Create a Boat instance and set its properties
                string registrationNumber = "BOAT555";
                string color = "Green";
                int numberOfEngines = 2;
                int lenght = 30;
                string fuelType = "Diesel";

                Boat myBoat = vehicleHandler.CreateBoat;
            }
        }
    }
}
