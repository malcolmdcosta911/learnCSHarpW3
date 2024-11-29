//C# Inheritance
// In C#, it is possible to inherit fields and methods from one class to another. We group the "inheritance concept" into two categories:

// Derived Class (child) - the class that inherits from another class
// Base Class (parent) - the class being inherited from
// To inherit from a class, use the : symbol.

//
//

// The sealed Keyword
// If you don't want other classes to inherit from a class, use the sealed keyword:

// If you try to access a sealed class, C# will generate an error:

// sealed class Vehicle
// {
//   ...
// }

// class Car : Vehicle
// {
//   ...
// }
// The error message will be something like this:

// 'Car': cannot derive from sealed type 'Vehicle'

class Vechile
{
    public string vechileType = "";


    public void Honk()
    {
        Console.WriteLine("Honk");
    }
}


class Car : Vechile
{
    public string carName = "";
}


