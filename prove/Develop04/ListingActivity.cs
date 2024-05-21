using System;

class ListingActivity: Activity
{
    private int _count;
    private List<string> _prompts;
    private List<string> _userResposneList;
    public ListingActivity(){
    _name = "Listing Activity";
    _description = "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.";
    _duration = 0;
    _userResposneList = new List<string>();
   }
   public void Run(){
        _prompts = [
            "Who are people that you appreciate?",
            "What are personal strengths of yours?",
            "Who are people that you have helped this week?",
            "When have you felt the Holy Ghost this month?",
            "Who are some of your personal heroes?"
        ];
        DateTime startTime = DateTime.Now;
        DisplayStartingMessage();
        DateTime endTime = startTime.AddSeconds(_duration);
        GetRandomPrompt();
        Console.WriteLine("List as many responses you can to the following prompt:");
        Console.WriteLine("You may begin in:");
        DisplayCountDown(5);
        do{
            GetListFromUser();
        }
        while(DateTime.Now < endTime);
        _count = _userResposneList.Count() ;
        Console.WriteLine($"Well done! You listed {_count} items.");
        DisplayEndingMessage();

   }
   public void GetRandomPrompt(){
        Random random = new Random();
        var index = random.Next(0,5);
        var prompt = _prompts.ElementAt(index);
        Console.WriteLine(prompt);
        DisplaySpinner(6);
   }
   public List<string> GetListFromUser(){
    _userResposneList.Add(Console.ReadLine());
    return _userResposneList;
   }
}