using System.IO;

public class FileHandler
{
    ////////////////////////////////////////////////////////////////////////////////
    //For now we are going to have fileHandler handle the I/O specific to each file
    //This may change in the future, but I'm not sure why/how atm.
    ///////////////////////////////////////////////////////////////////////////////
    private string fileName;
    public FileHandler(){}
    public void GetSetFileName()
    {
        Console.Write("Please enter the name of the file you wish to access: ");
        fileName = Console.ReadLine(); 
    }

    //Do we want to parse the file here or in main?
    public string[] ImportFromFile()
    {
        //Read all lines from the file
        string[] rawInput = System.IO.File.ReadAllLines(fileName);
        return rawInput;

    }

    //Are we going to deal with overwriting? Or comparing and overwriting?
    public void ExportToFile(int totalPoints, List<Goal> goals)
    {
        //Note, this will overwrite old list
        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine(totalPoints);
            foreach (Goal goal in goals)
            {
                //Exports string export to the file
                outputFile.WriteLine(goal.Export());
            }
        }
    }
}