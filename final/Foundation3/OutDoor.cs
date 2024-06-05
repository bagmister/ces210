using System;
using System.Dynamic;

class OutDoor : Event
{
    private string _weather;
    public OutDoor(){
        _weather = "";
        _address = new Address();
        _date = "";
        _description = "";
        _time = "";
        _title = "";
    }
    public string SetWeather(string weather){
        return _weather = weather;
    }
    public Address SetAddress(Address address){
        return _address = address;
    }
    public string GetWeather(){
        return _weather;
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
}