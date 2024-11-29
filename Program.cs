// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
//install c# vscode extension and .net sdk
//dotnet new console
//dotnet run


namespace ProgramTrial
{
    class Program
    {
        static void Main(string[] args)
        {

            //methods in Human.cs

            //     //Human.cs
            //     Human h1 = new Human(); //use Human as type not 'const' like js
            //     Console.WriteLine(h1.DisplayGender());
            //     Console.WriteLine(h1.DisplayGender("Female"));
            //     h1.gender = "Maleee";
            //     Console.WriteLine(h1.DisplayGender());
            //
            //
            //Swim.cs   
            // Swim swimmer = new Swim(21);
            // // Console.WriteLine(swimmer.GetStatus()); //getStatus is private and wont work
            // Console.WriteLine(swimmer.GetSwimmerAge());
            //
            //Run.cs
            // Run runner = new Run();
            // runner.Name = "Malcolm";
            // Console.WriteLine(runner.Name);
            // runner.Name = "";
            // Console.WriteLine(runner.Name);

            //

            //Vechile.cs
            // Car car1 = new Car();
            // car1.carName = "creata";
            // car1.vechileType = "SUV";
            // Console.WriteLine(car1.carName + " " + car1.vechileType);
            // car1.Honk();


            //Animal.cs
            // Animal[] animals = { new Animal(), new Dog() };
            // for (int i = 0; i < animals.Length; i++)
            // {
            //     animals[i].MakeSoud();
            // }

            //Fruit.cs

            // Mango mangoOne = new Mango();
            // mangoOne.NewSeeds();
            // mangoOne.PrintName();
            // // mangoOne.Grow(); //protected and can use only inside class

            //ChildClass.cs
            // ChildClass childClass = new ChildClass();
            // childClass.PrintDate();
            // childClass.PrintName();

            //TryEnum.cs
            // Level myVar = Level.Medium;
            // Console.WriteLine(myVar); //The output will be: Medium
            // int myNum = (int)Level.Medium;
            // Console.WriteLine(myNum);
            // int myMonthsNo = (int)Months.April;
            // Console.WriteLine(myMonthsNo);
            // //
            // switch (myVar)
            // {
            //     case Level.Low:
            //         Console.WriteLine("Low level");
            //         break;
            //     case Level.Medium:
            //         Console.WriteLine("Medium level");
            //         break;
            //     default:
            //         Console.WriteLine("no level");
            //         break;
            // }

            //
            // Student student = new Student();
            // // student.gender="Ha"; //fails can only use enum
            // student.gender = Gender.Male;
            // Console.WriteLine("student.gender {0}", student.gender);

            //Errors
            // Program.ArrayErrorFunction();
            Program.ThrowErrorFunc();

        }

        static void ArrayErrorFunction()
        {
            try
            {
                int[] numbers = { 1, 2 };
                Console.WriteLine(numbers[4]);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The 'try catch' is finished.");
            }
        }


        static void ThrowErrorFunc()

        {
            byte age = 7;
            if (age < 18)
            {
                throw new ArithmeticException("Access denied - You must be at least 18 years old.");
            }
            else
            {
                Console.WriteLine("Access granted - You are old enough!");
            }
        }

    }
}