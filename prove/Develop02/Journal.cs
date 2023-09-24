using System.IO.Enumeration;
using System.IO;
using System.Collections.Generic;

public class Journal
{

    Entry newEntry = new Entry();
    public List<Entry> _entries = new List<Entry>();
    public PromptGenerator generate = new PromptGenerator();


    public void AddEntry(Entry newEntry)
    {
        generate.GetRandomPrompt();
        Console.Write("> ");   
        newEntry._entryText = Console.ReadLine();
        _entries.Add(newEntry);
    }

    public void DisplayAll()
    {
        newEntry.Display();
    }

    public void SaveToFile(string file)
    {

        using (StreamWriter outputFile = new StreamWriter(file))
        {
            // Line of Code below is a debug code
            outputFile.WriteLine("Gressie shall stand");

            foreach (Entry ent in _entries)
            {
                outputFile.WriteLine($"{ent}~");
            }
        }
        Console.WriteLine("Finished saving to File");
    }

    public void LoadFromFile(string file)
    {
        string filename = "jounal1.txt";
        string [] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string [] parts = line.Split("~");

        }
    }
}
