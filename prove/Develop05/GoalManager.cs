using System;
using System.Collections;

public class GoalManager
{
    List<Goal> _goals;
    int _score;
    public GoalManager()
    {

    }

    public void Start()
    {

    }

    public void DisplayPlayerInfo()
    {

    }
    //Case 2
    public void ListGoalNames()
    {

    }
    //Case 2
    public void ListGoalDetails()
    {

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
            string points = Console.ReadLine();

            switch(input)
            {
                case 1:
                break;
                case 2:
                break;
                case 3:
                break;
            }
            counter++;
            if (counter == 1);
            {
                break;
            }

        }

    }
    //Case 5
    public void RecordEvent()
    {

    }
    //Case 3
    public void SaveGoals()
    {

    }
    //Case 4
    public void LoadGoals()
    {

    }
}