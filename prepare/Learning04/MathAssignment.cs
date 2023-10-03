using System;

public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string texbook, string problem) : base(name, topic)
    {
        _textbookSection = texbook;
        _problems = problem;
    }

    public string GetTextBook()
    {
        return _textbookSection;
    }

    public string GetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"{_studentName} - {_topic} \nSection {_textbookSection} Problems {_problems}";
    }

}