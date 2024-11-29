// C# Enums
// An enum is a special "class" that represents a group of constants (unchangeable/read-only variables).

// To create an enum, use the enum keyword (instead of class or interface), and separate the enum items with a comma:

enum Level
{
    Low, Medium, High
}

// Enum Values
// By default, the first item of an enum has the value 0. The second has the value 1, and so on.

// To get the integer value from an item, you must explicitly convert the item to an int:

//You can also assign your own enum values, and the next items will update their numbers accordingly:


enum Months
{
    January,    // 0
    February,   // 1
    March = 6,    // 6
    April,      // 7
    May,        // 8
    June,       // 9
    July        // 10
}

//Enum in a Switch Statement
// Enums are often used in switch statements to check for corresponding values:

// Why And When To Use Enums?
// Use enums when you have values that you know aren't going to change, like month days, days, colors, deck of cards, etc.

enum Gender
{
    Male,
    Female
}
// class Student
// {
//     public Gender gender;

// }