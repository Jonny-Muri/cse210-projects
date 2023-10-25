using System;

public class Comment
{
    List<string> _name = new List<string>();
    List<string> _comment = new List<string>();

    public void Display1()
    {
        _name.Add("Jackie");
        _name.Add("Joe");
        _name.Add("Jamal");
        _comment.Add("This looks delicious!");
        _comment.Add("This looks so easy to make!");
        _comment.Add("I will replace raisins with chocolate chips instead");
        
        for (int i = 0; i <=2; i++)
        {
            Console.WriteLine($"{_name[i]}: ");
            Console.WriteLine(_comment[i]);
        }
    }

    public void Display2()
    {
        _name.Add("Joseph");
        _name.Add("Rick");
        _name.Add("Stephen");
        _comment.Add("That was the best event ever!");
        _comment.Add("That looks very scary to be the driver.");
        _comment.Add("I will never have the courage to do that!");
        
        for (int i = 0; i <=2; i++)
        {
            Console.WriteLine($"{_name[i+3]}: ");
            Console.WriteLine(_comment[i+3]);
        }
    }

    public void Display3()
    {
        _name.Add("Rose");
        _name.Add("Mick");
        _name.Add("Theresa");
        _comment.Add("Imagine the air through your hair!");
        _comment.Add("It looks so graceful and daring at the same time.");
        _comment.Add("What would happen if you knock into another person? I wonder.");
        
        for (int i = 0; i <=2; i++)
        {
            Console.WriteLine($"{_name[i+6]}: ");
            Console.WriteLine(_comment[i+6]);
        }
    }
   
   
   
}