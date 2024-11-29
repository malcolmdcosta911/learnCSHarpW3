//C# Polymorphism

// Polymorphism and Overriding Methods
// Polymorphism means "many forms", and it occurs when we have many classes that are related to each other by inheritance.

// Like we specified in the previous chapter; Inheritance lets us inherit fields and methods from another class. 
//Polymorphism uses those methods to perform different tasks. 
//This allows us to perform a single action in different ways.

// For example, think of a base class called Animal that has a method called animalSound(). 
//Derived classes of Animals could be Pigs, Cats, Dogs
//, Birds - And they also have their own implementation of an animal sound (the pig oinks, and the cat meows, etc.):


// Not The Output I Was Looking For
// The output from the example above was probably not what you expected. That is because the base class method overrides the derived class method, when they share the same name.

// However, C# provides an option to override the base class method, 
// by adding the virtual keyword to the method inside the base class, 
// and by using the override keyword for each derived class methods:

class Animal
{
    public virtual void MakeSoud()
    {
        Console.WriteLine("Animal Makes sound");
    }
}


class Dog : Animal
{
    public override void MakeSoud()
    {
        Console.WriteLine("Dog barks");
    }
}