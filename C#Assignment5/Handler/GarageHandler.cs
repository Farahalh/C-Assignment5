using C_Assignment5.Garage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment5.Handler
{
    public class GarageHandler
    {
        private Garage<Vehicle> garage;

        public GarageHandler(Garage<Vehicle> garage)
        {
            this.garage = garage;
        }

        public void ParkVehicle(Vehicle vehicle)
        {
            // Implement parking logic
            // Check if the garage is full, check for duplicate registration numbers, etc.
            // Add the vehicle to the garage
        }

        public void RetrieveVehicle(string registrationNumber)
        {
            // Implement retrieving logic
            // Check if the vehicle is in the garage, remove it, etc.
        }

        public void ListAllParkedVehicles()
        {
            // Implement listing logic
            // Display a list of all vehicles currently parked in the garage
        }

        public void ListVehicleTypesAndCounts()
        {
            // Implement listing logic
            // Display the count of each vehicle type in the garage
        }

        public void FindVehicleByRegistrationNumber(string registrationNumber)
        {
            // Implement finding logic
            // Search for a vehicle by its registration number and display its details
        }

        public void SearchVehiclesByProperties(string[] properties)
        {
            // Implement searching logic
            // Search for vehicles based on specified properties and display the results
        }
    }

}
