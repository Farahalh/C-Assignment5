# C-Assignment5
 Garage 1.0

NOTE: The result of this exercise should be presented to the teacher and approved before it is considered completed.

A First Comprehensive Project
To consolidate much of what you've learned, we will now build a garage application. This application should provide the functionality that a system might need to simulate a simple garage. You should be able to park vehicles, retrieve vehicles, check what vehicles are there, and view their properties. All of this in a console application with a main menu and submenus.

The reason you are programming a garage is that it is easy to divide the project. We can mainly divide a garage into the following parts:

The Garage: A representation of the building itself. The garage is a place where a variety of vehicles can be stored. The garage can be represented as a collection of vehicles.
Vehicles: Cars, motorcycles, unicycles, or any type of vehicle you want to park in the garage.
These are the two "object types" you see in a physical garage. But if you look closer, there should also be subclasses of vehicles, meaning that each type of vehicle is its own subclass in the system. In addition, functionality is needed to handle parking vehicles, removing vehicles from the garage, and to view what is in the garage and search within it.

In more programmer-friendly terms, we need at a minimum:

A collection of vehicles; the Garage class.
A vehicle class; the Vehicle class.
Several subclasses of vehicles.
A user interface that allows us to use the functionality of the garage. All interaction with the user takes place here.
A GarageHandler. To abstract a layer so that there is no direct contact between the user interface and the garage class. This is typically done through a class that handles the functionality the interface needs access to.
We do not program directly against concrete types, so we use Interfaces for that, such as IUI, IHandler, IVehicle. (A tip is to extract to interfaces when the implementation is complete if you find this part difficult)
Requirements
Vehicles should be implemented as the Vehicle class and its subclasses.

Vehicle should contain all properties that should exist in all types of vehicles, such as registration number, color, number of wheels, and other properties you can think of.
The registration number must be unique.
There must be at least the following subclasses:
Airplane
Motorcycle
Car
Bus
Boat

These should implement at least one unique property, e.g.:
Number of Engines
Cylinder volume
Fuel type (Gasoline/Diesel)
Number of seats
Length

The garage itself should be implemented as a generic collection of vehicles:
class Garage<T>

Additionally, the generic type should be constrained using a constraint:
class Garage<T> where ....

Furthermore, it should be possible to iterate over an instance of Garage using foreach. This means that Garage should implement the generic version of the IEnumerable interface:
class Garage<T> : ....

The class does not need to inherit from any other class or implement any other interface.
The collection of vehicles should be internally managed as an array in the class, i.e., Vehicle[]. The internal array should be private. When initializing a new garage, the capacity must be specified as an argument to the constructor.
DO NOT use a List<Vehicle> internally in the Garage class.

Functionality
The program should be able to:

List all parked vehicles.
List types of vehicles and how many of each are in the garage.
Add and remove vehicles from the garage.
Set a capacity (number of parking spaces) when initializing a new garage.
Populate the garage with a certain number of vehicles from the start.
Find a specific vehicle by registration number. It should work with both ABC123 and Abc123 or AbC123.
Search for vehicles based on one or more properties (all possible combinations from the base Vehicle class). For example:
All black vehicles with four wheels.
All pink motorcycles with three wheels.
All trucks.
All red vehicles.
Provide the user with feedback on whether things have gone well or not. For example, when parking a vehicle, we want confirmation that the vehicle has been parked. If it doesn't work, the user should be informed of the reason.
The program should be a console application with a text-based user interface. From the interface, you should be able to:

Navigate to all functionality from the garage through the interface.
Create a garage with a user-specified size.
Be able to shut down the application from the interface.
The application should handle input errors in a robust way, so that it doesn't crash due to incorrect input or usage.

Unit Testing
Tests should be created in a separate test project. We will limit ourselves to testing the public methods in the Garage class (writing tests for the entire application is considered an extra task if time allows). Feel free to experiment with writing the tests before implementing the functionality. Then use Ctrl + . to generate your objects and methods. Implement the functionality once the test passes. Structure the tests according to the following principles:

Arrange: Set up what should be tested, instantiate objects and inputs.
Act: Call the method to be tested.
Assert: Check that you have received the expected result.

Also, name your tests in an explanatory way. When a test fails, we want to know what went wrong just by looking at the test method name. For example:
[MethodName_StateUnderTest_ExpectedBehavior]
public void Sum_NegativeNumberAs1stParam_ExceptionThrown()

BONUS: For those who still have time
You can use C# to read and write to the file system from your application. Find out how to save your garage (via a menu or automatically when the application is closed) and load your garage (via a menu or automatically when the application starts). It should also be possible to search based on the specific vehicle properties. Read the garage size from configuration. Manage multiple garages. Implement optional functionality that you think should be included.

Good luck!
