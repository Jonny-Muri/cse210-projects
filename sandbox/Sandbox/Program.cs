using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {

        //for (int i = 5; i > 0; i--)
       // {
       //     Console.Write(i);
       //     Thread.Sleep(1000);
       //     Console.Write("\b \b");
       // }

        Console.WriteLine("Loading...");
        List<string> animationSymbol = new List<string>();
        animationSymbol.Add("|");
        animationSymbol.Add("/");
        animationSymbol.Add("-");
        animationSymbol.Add("\\");
        animationSymbol.Add("|");
        animationSymbol.Add("/");
        animationSymbol.Add("-");
        animationSymbol.Add("\\");

        DateTime startTime = DateTime.Now;
        DateTime endTime = startTime.AddSeconds(1);

        int i = 0;

        while(DateTime.Now < endTime)
        {
            string s = animationSymbol[i];
            Console.Write(s);
            Thread.Sleep(100);
            Console.Write("\b \b");

            i++;

            if (i >= animationSymbol.Count)
            {
                i = 0;
            }
        }
        Console.Clear();
        Console.WriteLine("Loading Complete!");


       // Console.Clear();
       // Console.WriteLine("Loading... ");

       // char[] animationChars = {'|', '/', '-', '\\'};

       // for (int i = 0; i < 20; i++)
       // {
       //     char animationChar = animationChars[i % animationChars.Length];

       //     Console.Write("\r" + animationChar);

       //     Thread.Sleep(100);
       // }
       // Console.Clear();
       // Console.WriteLine("Loading complete!");

    }
}
