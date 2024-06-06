using System;

class GoalManager
{
    private List<Goal> _goals;
    private int _score;
    private string _player;
    public GoalManager(){
        _goals = new List<Goal>();
    }
    public void Start(){
        GoalManager goalManager= new GoalManager();
        var choice = 0;
        Console.WriteLine("What is your name?");
        SetPlayer(Console.ReadLine());
        do{
            DisplayPlayerInfo();
            Console.WriteLine("What Kind of Goal would you like to do?");
            Console.WriteLine("Menu Options: Enter a number 1-5");
            Console.WriteLine("1. Create a goal.");
            Console.WriteLine("2. Display goals.");
            Console.WriteLine("3. Load goals");
            Console.WriteLine("4. save goals");
            Console.WriteLine("5. record an event");
            Console.WriteLine("6. quit");
            choice = int.Parse(Console.ReadLine());
            if (choice == 1)
            {
                Console.WriteLine("Creating a goal.");
                goalManager.CreateGoal();

            }
            else if (choice == 2)
            {
                Console.WriteLine("Display goals");
                var goals = goalManager.GetGoals();
                foreach (Goal goal in goals){
                    Console.WriteLine("");
                    Console.WriteLine(goal.GetStringRepresentation(goal));
                } 
            }
            else if (choice == 3)
            {
                Console.WriteLine("What is the file you want to load?");
                Console.ReadLine();   

            }
            else if (choice == 4)
            {
               Console.WriteLine("4 has been entered. saving goals.."); 

            }
            else if(choice == 5)
            {
                Console.WriteLine("5 has been entered. Record event.");
            }
            else if(choice == 6)
            {
                Console.WriteLine("6 has been entered. Shutting down.");
                Environment.Exit(choice);
            }
            else
            {
                Console.WriteLine("Invalid choice. Enter a number again....");
            }
        }
        while(choice != 6);  
    

    }
    public void DisplayPlayerInfo(){
        Console.WriteLine($"Player: {_player}. Current score: {_score}");

    }
    public void ListGoalNames(){

    }
    public void ListGoalDetails(){


    }
    public void CreateGoal() {
        Console.WriteLine("What kind of goal would you like to create?");
        Console.WriteLine("1. Simple goal");
        Console.WriteLine("2. List goal");
        Console.WriteLine("3. Eternal goal");
        var choice = int.Parse(Console.ReadLine());

        switch(choice){
            case 1:
                SimpleGoal simpleGoal = new SimpleGoal();
                Console.WriteLine("What is the name of the goal?");
                var simpleName = Console.ReadLine();
                Console.WriteLine("What is a short description of this goal? " + simpleName);
                var description = Console.ReadLine();
                Console.WriteLine("What is the amount of points you want this goal worth? " + simpleName);
                var points = int.Parse(Console.ReadLine());
                var goal = simpleGoal.CreateSimpleGoal(simpleName, description, points, false);
                _goals.Add(goal);
                break;
            case 2:
                CheckListGoal checkListGoal = new CheckListGoal();
                Console.WriteLine("What is the name of the goal?");
                var checkListname = Console.ReadLine();
                Console.WriteLine("What is a description of this goal?");
                var checkListDescription = Console.ReadLine();
                Console.WriteLine("How many times do you want to repeat this goal to accomplish this goal?");
                var checkListNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("How many bonus points should you get once you have completed the goal?");
                var checkListBonusPoints = int.Parse(Console.ReadLine());
                var checkGoal = checkListGoal.CreateCheckListGoal(checkListname, checkListDescription, checkListNumber, checkListBonusPoints);
                _goals.Add(checkGoal);
                break;
            case 3:
                EternalGoal eternalGoaleternalGoal = new EternalGoal();
                Console.WriteLine("What is the name of the goal?");
                break;
            default:
                Console.WriteLine("You did not enter a number 1 - 3");
                break;

        }
    }
    public void RecordEvent() {

    }
    public void SaveGoals(){

    }
    public void LoadGoals(){

    }
    public string GetPlayer(){
        return _player;
    }
    public string SetPlayer(string player){
        return _player = player;
    }
    public List<Goal> GetGoals(){
        return _goals;
    }
    public List<Goal> SetGoals(List<Goal> goals){
        return _goals = goals;
    }
}