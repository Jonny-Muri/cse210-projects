using System;

class Program
{
    static void Main(string[] args)
    {
        Lectures lecture = new Lectures("The Psychology of Decision-Making", "Examines factors and biases that influence decision-making", "October 25th", "6:30PM", "Elena Thornwood", 55);
        Reception reception = new Reception("Tori & Porter's Wedding Reception", "Commemorate the Newlyweds", "Oct 5th", "6:30PM", "jonny.murillo@gmail.com");
        Outdoor outdoor = new Outdoor("NatureFest", "Celebrates the beauty and wonders of the natural world", "Oct 27th", "5:00PM", "Partly Sunny");

        Console.WriteLine("\nLecture: ");
        lecture.AskAddress();
        Console.WriteLine(lecture.StandardDetail());
        Thread.Sleep(3000);
        Console.WriteLine(lecture.FullDetails());
        Thread.Sleep(5000);
        Console.WriteLine(lecture.ShortDescription());
        Thread.Sleep(3000);
        
        Console.WriteLine("\nReception: ");
        reception.AskAddress();
        Console.WriteLine(reception.StandardDetail());
        Thread.Sleep(3000);
        Console.WriteLine(reception.FullDetails());
        Thread.Sleep(5000);
        Console.WriteLine(reception.ShortDescription());
        Thread.Sleep(3000);

        Console.WriteLine("\nOutdoor Gathering: ");
        outdoor.AskAddress();
        Console.WriteLine(outdoor.StandardDetail());
        Thread.Sleep(3000);
        Console.WriteLine(outdoor.FullDetails());
        Thread.Sleep(5000);
        Console.WriteLine(outdoor.ShortDescription());
        Thread.Sleep(3000);
    }
}