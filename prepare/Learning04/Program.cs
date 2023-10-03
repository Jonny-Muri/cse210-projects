using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assign0 = new Assignment("Samuel Bennett", "Division");
        MathAssignment assign1 = new MathAssignment("Roberto Rodriguiez", "Multiplication", "7.3", "8-19");
        WritingAssignment assign2 = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");

        Console.WriteLine(assign0.GetSummary());
        Console.WriteLine();
        Console.WriteLine(assign1.GetHomeworkList());
        Console.WriteLine();
        Console.WriteLine(assign2.GetWritingInfo());
    }
}