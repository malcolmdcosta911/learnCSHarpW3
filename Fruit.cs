//C# Abstraction

// Abstract Classes and Methods
// Data abstraction is the process of hiding certain details and showing only essential information to the user.
// Abstraction can be achieved with either abstract classes or interfaces (which you will learn more about in the next chapter).

// The abstract keyword is used for classes and methods:

// Abstract class: is a restricted class that cannot be used to create objects (to access it, it must be inherited from another class).

// Abstract method: can only be used in an abstract class, and it does not have a body.
//  The body is provided by the derived class (inherited from).
// An abstract class can have both abstract and regular methods:

// Why And When To Use Abstract Classes and Methods?
// To achieve security - hide certain details and only show the important details of an object.

// Note: Abstraction can also be achieved with Interfaces,


abstract class Fruit
{

    //virtual or abstract members cannot be private
    //abstract method cannot have implementation
    public abstract void PrintName();

    protected void Grow()
    {
        Console.WriteLine("growing");
    }

    public void NewSeeds()
    {
        Console.WriteLine("NewSeeds");
    }


}



class Mango : Fruit
{

    //has to include abstarct method else error
    //override method cannot be private


    //no super keyword in c# unlike javascript 
    public override void PrintName()
    {
        Grow(); //can directly call protected method here
        Console.WriteLine("Mango class");
    }

}