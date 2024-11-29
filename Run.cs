// Properties and Encapsulation
// Before we start to explain properties, you should have a basic understanding of "Encapsulation".

// The meaning of Encapsulation, is to make sure that "sensitive" data is hidden from users. To achieve this, you must:

// declare fields/variables as private
// provide public get and set methods, through properties, to access and update the value of a private field


//
//A property is like a combination of a variable and a method, and it has two methods: a get and a set method:


class Run
{
    private string name = ""; // field

    // public string? Gender { get; set; } //declare property as nullable
    public string Name
    {
        get { return name; }
        set
        {
            if (value.Length > 0) { name = value; }
            else
            {
                throw new ArgumentException(
                "agrument is invalid.");
            }
        }
    }


}