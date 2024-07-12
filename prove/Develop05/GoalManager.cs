using System;
using System.IO.Enumeration;
public class GoalManager
{
    private List<Goal> _goals;
    private int _score;

    
    public GoalManager()
    {
        _score = 0;
        _goals = new List<Goal>();
    }


    public void Start()
    {
        while(true)
        {
            DisplayPlayerInfo();

            Console.WriteLine("Menu Options: ");
            Console.WriteLine("1. Creat New Goal");
            Console.WriteLine("2. List Goals");
            Console.WriteLine("3. Save Goals");
            Console.WriteLine("4. Load Goals");
            Console.WriteLine("5. Record Event");
            Console.WriteLine("6. Quit");
            Console.Write("Plese select a choice from the menu: ");
            string option = Console.ReadLine();
            Console.WriteLine();

            if (option == "1")
            {
                CreateGoal();
            }
            else if (option == "2")
            {
                ListGoalDetails();
            }
            else if (option == "3")
            {
                
            }
            else if (option == "4")
            {
                
            }
            else if (option == "5")
            {
                RecordEvent();
            }
            else if (option == "6")
            {
                break;
            }
            else
            {
                Console.WriteLine("Please try again.");
            }
        }
    }


    public void DisplayPlayerInfo()
    {
        Console.WriteLine($"You have {_score} points.");
    }


    public void CreateGoal()
    {
        Console.WriteLine("The types of goals are:");
        Console.WriteLine("1. Simple Goal");
        Console.WriteLine("2. Eternal Goal");
        Console.WriteLine("3. Checklist Goal");
        Console.Write("Which type o fgoal would you like to create? ");
        int choice = int.Parse(Console.ReadLine());
        Console.WriteLine();

        if (choice > 0 && choice <= 3)
        {
            Console.Write("Enter goal name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.Write("Enter a short goal description: ");
            string description = Console.ReadLine();
            Console.WriteLine();
            Console.Write("How many points will this goal be worth? ");
            int points = int.Parse(Console.ReadLine());
            Console.WriteLine();


            if (choice == 1)
            {
                _goals.Add(new SimpleGoal(name, description, points));
            }
            if (choice == 2)
            {
                _goals.Add(new EternalGoal(name, description, points));
            }
            if (choice == 3)
            {
                Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                int target = int.Parse(Console.ReadLine());
                Console.WriteLine();
                Console.Write("What is the amount of bonus points for accomplishing it that many times? ");
                int bonus = int.Parse(Console.ReadLine());
                Console.WriteLine();
                _goals.Add(new CheckListGoal(name, description, points, target, bonus));
            }
        }
        else
        {
            Console.WriteLine("Not a valid option. No goal created.");
            Console.WriteLine();
        }
    }


    public void ListGoalDetails()
    {
        Console.WriteLine("Your goals: ");
        for (int i = 0; i < _goals.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {_goals[i].GetDetailsString()}");
        }
    }


    public void RecordEvent()
    {
        ListGoalDetails();
        Console.Write("Select the goal you have accomplished: ");
        int goalIndex = int.Parse(Console.ReadLine()) - 1;
        Console.WriteLine();

        if (goalIndex >= 0 && goalIndex < _goals.Count)
        {
            if (_goals[goalIndex].IsComplete())
            {
                Console.WriteLine("Goal already completed.");
            }
            else
            {
                _score += _goals[goalIndex].RecordEvent();
            }
        }
        else
        {
            Console.WriteLine("Invalid goal number.");
            Console.WriteLine();
        }
    }
    public void SaveGoals()
    {
        Console.Write("What is the filename for the goal file? ");
        string fileName = Console.ReadLine();

        using (StreamWriter outputFile = new StreamWriter(fileName))
        {
            outputFile.WriteLine($"Score|{_score}");
            foreach (Goal goal in _goals)
            {
                outputFile.WriteLine(goal.GetStringRepresentation());
            }
        }
        Console.WriteLine("Your goals were saved!");
    }
    public void LoadGoals(string fileName)
    {
        if (File.Exists(fileName))
        {
            string[] lines = System.IO.File.ReadAllLines(fileName);
            foreach (string line in lines)
            {
                string[] parts = line.Split("|");
                switch(parts[0])
                {
                    case "EternalGoal":
                        _goals.Add(new EternalGoal(parts[1], parts[2], int.Parse(parts[3])));
                        break;
                    case "SimpleGoal":
                        _goals.Add(new SimpleGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4])));
                        break;
                    case "CheckListGoal":
                        _goals.Add(new CheckListGoal(parts[1], parts[2], int.Parse(parts[3]), bool.Parse(parts[4]), int.Parse(parts[5]), int.Parse(parts[6]), int.Parse(parts[7])));
                        break;
                    case "Score":
                        _score = int.Parse(parts[1]);
                        break;
                }
            }
            Console.WriteLine("Goals Loaded successfully.");
        }
        else
        {
            Console.WriteLine("File not found.");
        }
    }
}