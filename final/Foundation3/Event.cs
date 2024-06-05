using System;
using System.Runtime.InteropServices;

class Event
{
    protected string _title;
    protected string _description;
    protected string _date;
    protected string _time;
    protected Address _address;
    public Event(){
        _title = "";
        _description = "";
        _date = "";
        _time = "";
        _address = new Address();
    }
    public void GetStandardDetails(){
        Console.WriteLine($"{_title}");
        Console.WriteLine($"{_description}");
        Console.WriteLine($"{_date} at {_time}");
        _address.GetAddressMultiLine();
    }
    public void GetFullDetails(string eventType, string speaker = "", int capacity = 0, string email = "", string weather = ""){
            Console.WriteLine($"Type of event: {eventType}");
        if (eventType.ToLower() == "lecture"){
            Console.WriteLine($"{_title} - Speaker: {speaker} - seating capacity: {capacity}");
        }
        else if (eventType.ToLower() == "outdoor"){
            Console.WriteLine($"{_title} - the weather will be: {weather}");
        }
        else if(eventType.ToLower() == "reception"){
            Console.WriteLine($"{_title} - rsvp email: {email}");
        }
            Console.WriteLine($"{_description}");
            Console.WriteLine($"On {_date} at {_time}");
            _address.GetAddressMultiLine();
    }
    public void GetShortDetails(string type){
        Console.WriteLine($"Type of event: {type}, Title: {_title} on {_date}");
    }

}