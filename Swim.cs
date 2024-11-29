//Access Modifiers


//
//Note: By default, all members of a class are private if you don't specify an access modifier:

//Why Access Modifiers?
//To control the visibility of class members (the security level of each individual class and class member).

//To achieve "Encapsulation" - which is the process of making sure that "sensitive" data is hidden from users. 
//This is done by declaring fields as private.


// Modifier	Description
// public	---The code is accessible for all classes
// private	---The code is only accessible within the same class
// protected	---The code is accessible within the same class, or in a class that is inherited from that class. 
// internal	---The code is only accessible within its own assembly, but not from another assembly. 




class Swim
{
    private int age;


    public Swim(byte _age)
    {
        this.age = _age;
    }

    private string GetStatus()//not need to add private as it default
    {
        return this.age + "can swim";
    }

    public string GetSwimmerAge()
    {
        return this.age + " is the age of swimmer";
    }
    //
    //GetStatus works inside own class in Main 
    //but will give error in other class
    // static void Main(string[] args)
    // {
    //     Swim swimmer = new Swim(21);
    //     Console.WriteLine(swimmer.GetStatus()); 
    // }
}


