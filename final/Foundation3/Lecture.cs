using System;

class Lecture : Event
{
    private string _speaker;
    private int _capacity;
    public Lecture(){
        _speaker = "";
        _capacity = 0;
        _address =  new Address();
        _date = "";
        _description = "";
        _title = "";
    }
    public string GetSpeaker(){
        return _speaker;
    }
    public string SetSpeaker(string speaker){
        return _speaker = speaker;
    }
    public int GetCapacity(){
        return _capacity;
    }
    public int SetCapacity(int capacity){
        return _capacity = capacity;
    }
       public string SetTitle(string title){
        return _title = title;
    }
    public string GetTitle(){
        return _title;
    }
    public string SetTime(string time){
        return _time = time;
    }
    public string SetDescription(string description){
        return _description = description;
    }
    public string GetDescription(){
        return _description;
    }
    public string GetDate(){
        return _date;
    }
    public string SetDate(string date){
        return _date = date;
    }
        public Address SetAddress(Address address){
        return _address = address;
    }
}