using System;
using System.Collections;
using System.Xml;

public class GoalManager
{
    
    List<Goal> _goals = new List<Goal>();
    int _score = 0;
    public GoalManager()
    {

    }

    public void Start()
    {
        int input = -1;
        while (input != 6)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options");
            Console.WriteLine(" 1. Create New Goal");
            Console.WriteLine(" 2. List Goals");
            Console.WriteLine(" 3. Save Goals");
            Console.WriteLine(" 4. Load Goals");
            Console.WriteLine(" 5. Record Event");
            Console.WriteLine(" 6. Quit");
            Console.Write("Select a choice from the menu: > ");
            string user = Console.ReadLine();
            input = int.Parse(user);

            switch(input)
            {
                // Create
                case 1:
                CreateGoal();
                break;

                // List
                case 2:
                ListGoalDetails();
                break;

                // Save
                case 3:
                SaveGoals();
                break;

                // Load
                case 4:
                LoadGoals();
                break;

                // Record
                case 5:
                break;

                // Quit
                case 6:
                break;
            }
        }
    }

    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"\nYou have {_score} points.\n");
    }
    //Case 2
    public void ListGoalNames()
    {
        foreach (Goal gl in _goals)
        {
            string details = gl.GetStringRepresentation();
        }

    }
    //Case 2
    public void ListGoalDetails()
    {
        int i = 0;
        Console.WriteLine("The goals are: ");
        foreach (Goal gl in _goals)
        {
            
            i++;
            Console.WriteLine($"{i}. {gl.GetDetailsString()}");
        }
    }
    //Case 1
    public void CreateGoal()
    {
        int input = 0;
        int counter = 0;
        while (true)
        {
            Console.WriteLine("The types of Goals are: ");
            Console.WriteLine(" 1. Simple Goal\n 2. Eternal Goal\n 3. Checklist Goal");

            Console.Write("Which type of goal would you like to create? ");
            string user = Console.ReadLine();
            input = int.Parse(user);

            Console.Write("What is the name of your goal? ");
            string name = Console.ReadLine();

            Console.Write("What is a short description of it? ");
            string description = Console.ReadLine();

            Console.Write("What is the amount of points associated with this goal? ");
            string pointsString = Console.ReadLine();
            int points = int.Parse(pointsString);

            switch(input)
            {
                case 1:
                SimpleGoal simple = new SimpleGoal(name, description, points);
                _goals.Add(simple);
                break;

                case 2:
                EternalGoal eternal = new EternalGoal(name, description, points);
                _goals.Add(eternal);
                break;

                case 3:
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                string targetString = Console.ReadLine();
                int target = int.Parse(targetString);

                Console.Write("What is the bonus points for accomplishing it that many times? ");
                string bonusString = Console.ReadLine();
                int bonus = int.Parse(bonusString);

                ChecklistGoal check = new ChecklistGoal(name, description, points, target, bonus);
                _goals.Add(check);
                break;
            }

            counter++;

            if (counter == 1)
            {
                break;
            }

        }

    }
    //Case 5
    public void RecordEvent()
    {
        int i = 0;
        Console.WriteLine("The goals are: ");
        foreach (Goal gl in _goals)
        {
            
            i++;
            Console.WriteLine($"{i}. {gl.GetDetailsString()}");
        }
        
        Console.Write("Which goals did you accomplish? ");
        string inputString = Console.ReadLine();
        i = int.Parse(inputString);


    }
    //Case 3
    public void SaveGoals()
    {
        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(filename))
        {
                foreach (Goal gl in _goals)
                {
                    outputFile.WriteLine(gl.GetStringRepresentation());
                }
        }

        
    }
    //Case 4
    public void LoadGoals()
    {
        List<Goal> _goals = new List<Goal>();

        Console.Write("What is the filename of the goal file? ");
        string filename = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines(filename);
        
        foreach (string line in lines)
        {
            string [] parts = line.Split(':', ',');
        }
    }
}