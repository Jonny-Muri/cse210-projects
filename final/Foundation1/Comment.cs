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
            
            for (int j = 0; j <=2; j++)
            {
                Console.WriteLine(_comment[j]);
                j++;
                break;
            }
        }
    }
   
}