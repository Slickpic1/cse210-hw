using System.Diagnostics;
namespace Develop02;

public class Prompt
{
    public List<string> prompts = new List<string>();
    public Prompt()
    {
        prompts.Add("Who was the most interesting person I saw today?");
        prompts.Add("What was the strongest emotion I felt today?");
        prompts.Add("How much homework did I complete today?");
        prompts.Add("What did I enjoy about today?");
        prompts.Add("Did you see the Skin Man again?");
    }

    public string SelectPrompt()
    {
        //Choose random number 
        int length = this.prompts.Count;
        Random randomGenerator = new Random();
        int number = randomGenerator.Next(1,length);

        return prompts[number];
    }
}