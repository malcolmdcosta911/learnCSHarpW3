
//C# Class Members

class Human
{


    //unlike typescript all are private methods n fields by default
    public string? gender;

    public string DisplayGender(string _gender = "Male")
    {
        gender = _gender;
        return $"gender is {gender}";
    }



}