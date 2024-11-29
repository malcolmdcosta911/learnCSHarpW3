//C# Constructors

class Walk
{
    bool isWalking;
    public string name;


    // Note that the constructor name must match the class name,
    //  and it cannot have a return type(like void or int).

    // Also note that the constructor is called when the object is created.

    // All classes have constructors by default: 
    // if you do not create a class constructor yourself, C# creates one for you.

    //  However, then you are not able to set initial values for fields.

    public Walk(string _name) //constructor
    {
        this.isWalking = true; //can add this. too --nt needed
        name = _name;
    }

    
    // static void Main(string[] args)
    // {
    //     Walk walker = new Walk("mal");
    //     Console.WriteLine(walker.DisplayStatus());
    // }


    string DisplayStatus()
    {
        string walkStatus = this.isWalking ? "is walking" : "is nt walking";
        return $"{this.name} is {walkStatus}";
    }
}

