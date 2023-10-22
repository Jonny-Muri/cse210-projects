using System;

class Program
{
    static void Main(string[] args)
    {
        Video vid1 = new Video("How to make Cookies", "Jonathan Murillo", 120);
        Video vid2 = new Video("Monster Derby", "Jonathan Murillo", 320);
        Video vid3 = new Video("Squirrel Suit Tutorial", "Jonathan Murillo", 434);
        Comment com = new Comment();

        vid1.Display();
        com.Display1();

        vid2.Display();
        com.Display2();

        vid3.Display();
        com.Display3();



    }
}