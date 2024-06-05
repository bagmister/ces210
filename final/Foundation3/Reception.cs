using System;

class Reception : Event
{
    private string _email;
    public Reception(){
        _email = "";
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
    public string SetEmail(string email){
        return _email = email;
    }
    public string GetEmail(){
        return _email;
    }
}