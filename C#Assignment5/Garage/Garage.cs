using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Assignment5.Garage
{
    public class Garage<T> : IEnumerable<T> where T : Vehicle
    {
        private T[] vehicles;
        private int capacity;
        private int count;

        public Garage(int capacity)
        {
            this.capacity = capacity;
            this.vehicles = new T[capacity];
            this.count = 0;
        }

        // Method to park a vehicle in the garage
        public bool ParkVehicle(T vehicle)
        {
            if (count < capacity)
            {
                vehicles[count] = vehicle;
                count++;
                return true; // Successfully parked
            }
            return false; // Garage is full
        }

        // Method to retrieve a vehicle from the garage based on registration number
        public T RetrieveVehicle(string registrationNumber)
        {
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null && vehicle.RegistrationNumber == registrationNumber)
                {
                    return vehicle;
                }
            }
            return null; // Vehicle not found
        }

        // Method to list all parked vehicles
        public List<T> ListParkedVehicles()
        {
            List<T> parkedVehicles = new List<T>();
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null)
                {
                    parkedVehicles.Add(vehicle);
                }
            }
            return parkedVehicles;
        }

        // Method to check if a vehicle is in the garage
        public bool IsVehiclePresent(string registrationNumber)
        {
            foreach (T vehicle in vehicles)
            {
                if (vehicle != null && vehicle.RegistrationNumber == registrationNumber)
                {
                    return true;
                }
            }
            return false;
        }


        public IEnumerator<T> GetEnumerator()
        {
            return ((IEnumerable<T>)vehicles).GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }


}
