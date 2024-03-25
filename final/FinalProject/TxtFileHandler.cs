using System.IO;

public class TxtFileHandler
{
    public string fileName{get; set;}
    public static string[] files = Directory.GetFiles("terrainData");
    public TxtFileHandler(){Console.WriteLine(files[0]);}
    //Dont like this, but we can fix later
    private static string workingDirectory = @".\terrainData\";
    public TxtFileHandler(string fileName)
    {
        this.fileName = workingDirectory + fileName;
    }

    public string[] ImportFromFile()
    {
        //Read all lines from the file
        string[] fileData = System.IO.File.ReadAllLines(fileName);
        return fileData; 
    }
}