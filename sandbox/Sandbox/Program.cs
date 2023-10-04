using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();

        Console.WriteLine("Loading... ");

        char[] animationChars = {'|', '/', '-', '\\'};

        for (int i = 0; i < 20; i++)
        {
            char animationChar = animationChars[i % animationChars.Length];

            Console.Write("\r" + animationChar);

            Thread.Sleep(100);
        }
        Console.Clear();

        Console.WriteLine("Loading complete!");
    }
}
