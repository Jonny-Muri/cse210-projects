public class Entry
{

    public string _date;
    public string _entryText;
    PromptGenerator prompt = new PromptGenerator();

    public void Display()
    {
        DateTime theCurrentTime = DateTime.Now;
        _date = theCurrentTime.ToShortDateString();
        Console.WriteLine($"{_date} - Prompt: {prompt._prompts}");
        Console.WriteLine($"{_entryText}");
        
    }
}