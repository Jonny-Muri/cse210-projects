using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("How to make Cookies", "Jonathan Murillo", 120);
        Video vid2 = new Video("Monster Derby", "Jonathan Murillo", 320);
        Video vid3 = new Video("Squirrel Suit Tutorial", "Jonathan Murillo", 434);
        vid1.Display();
        vid2.Display();
        vid3.Display();
        Comment com1 = new Comment();
        com1.Display();
    }
}