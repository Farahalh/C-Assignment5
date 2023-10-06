using System.Collections.Generic;
using System;
using System.Drawing;
using System.Reflection.Metadata;
using System.Runtime.InteropServices;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace C_Assignment5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //- class manager(what is a manager? Calls to the UI and the handler.)
            //
            //- UI(user interaction?)
            //A text based user interface menu to communicate with the user.
            //From the interface, it should be possible to:
            //•	Navigate to all functionality from the garage via the interface.
            //•	Create a garage with a user-specified size.
            //•	Be able to shut down the application from the interface.
            //Menu:(functionalities: parking, retrieving, checking vehicles present,
            //characteristics)
            //Detailed menu:
            //1.List all parked vehicles
            //2.List vehicle types and how many of each are in the garage
            //A3.dd and remove vehicle from the garage
            //4.Populate the garage with a certain number of vehicles from the start
            //5.Find a specific vehicle by its registration number.
            //Make i work with ex ABC123,Abc123 or AbC123
            //6.Search for vehicles based on one or more properties (all possbile
            //combinations from the base Vehicle class). Ex.
            //All black vehicles with four wheels.
            //All oink motorcycles with three wheels.
            //All trucks.
            //All red vehicles.
            //7.The user should receive feedback on whether things have gone well or not.
            //For example, when parking a vehicle, we want confirmation that the vehicle has
            //been parked.
            //If it's not possible, the user should be informed of the reason.
            //The application should robustly handle input data so that it does not
            //crash when incorrect input or usage occurs. 
            //
            //- Handler(what is a handler?)
            //(GET from UI and CALL to garage to execute functions)
            //Handles all interactions between the user and the garage,
            //no direct contact between user and garage.
            //A class that handles the functionality
            //that the interface needs to access.
            //
            //- class garage: stores a number of vehicles
            //(functionalities: parking, retrieving, checking vehicles present, characteristics)
            //(create an array of the vehicles from the class vehicles to run through,
            //all detailed info is in class vehicles)
            //The garage class should be implemented a a generic collection of vehicles: 
            //class Garage<T>
            //Additionally, the generic type should be constrained using a constraint:
            //constrain to vehicles and to the subclasses of vehicles.
            //class Garage<T> where ....
            //Furthermore, it should be possible to iterate over an instance of Garage
            //using foreach.
            //This means that Garage should implement the generic version of the
            //IEnumerable interface:
            //class Garage<T> : ....
            //The class does not need to inherit from any other class or implement any
            //other interface.
            //The collection of vehicles should be internally managed as an array within the
            //class, i.e., Vehicle[]. The internal array should be private. When initializing
            //a new garage, the capacity must be specified as an argument to the constructor.
            //Do NOT use a List<Vehicle> internally in the Garage class!
            //
            //
            //- class vehicles (contains a subclass of vehicles with their properties)
            //(The properties are registration number, color, number of wheels etc.)
            //(Thereggistartion number needs to be unique, and you should implement
            //at least one unique property each ex number of engines, cylinder volume etc)
            //subclass car 
            //subclass airplane
            //subclass motrocycle
            //sublass bus
            //subclass boat
            //
            //Unit Testing
            //The tests should be created in a separate test project.We limit ourselves
            //to testing the public methods in the Garage class.
            //Feel free to experiment by writing the tests before implementing the
            //functionality!
            //Then use Ctrl + . to generate your objects and methods. Implement
            //the functionality until the test passes.
            //
            //Structure the tests as follows:
            //1.	Arrange: Set up what needs to be tested, instantiate objects,
            //and define inputs.
            //2.	Act: Call the method to be tested.
            //3.	Assert: Check that you have received the expected result.
            //Make sure to name the tests in an explanatory way. When a test fails,
            //we want to know what went wrong just by looking at the test method name.
            //For example:
            //[TestMethod]
            //[MethodName_StateUnderTest_ExpectedBehavior]
            //Public void Sum_NegativeNumberAs1stParam_ExceptionThrown()

        }
    }
}