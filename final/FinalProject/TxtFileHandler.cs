using System.IO;

public class TxtFileHandler
{
    public string fileName{get; set;}
    public TxtFileHandler(){}

    public TxtFileHandler(string fileName)
    {
        this.fileName = fileName;
    }

    public string[] ImportFromFile()
    {
        //Read all lines from the file
        string[] fileData = System.IO.File.ReadAllLines(fileName);
        return fileData; 
    }
}