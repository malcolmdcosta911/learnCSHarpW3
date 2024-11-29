using System.IO;  // include the System.IO namespace


// public 
class FileManagment
{
    //static
    public void WriteAndReadFile()
    {


        string userInput = Console.ReadLine() ?? "no data";
        File.WriteAllText("filename.txt", userInput);
        // Create a file and write the contents of userInput to it

        string readText = File.ReadAllText("filename.txt");
        Console.WriteLine(readText); // Output the content


    }
}