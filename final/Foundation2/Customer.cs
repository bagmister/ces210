using System;
using System.Diagnostics.Contracts;

class Customer
{
    private Address _address;
    private string _name;
    public Customer(){
        _address = new Address();
        _name = "";
    }
    public Address GetAddress(){
        return _address;
    }
    public Address SetAddress(Address address){
        return _address = address;
    }
    public string GetName(){
        return _name;
    }
    public string SetName(string name){
        return _name = name;
    }
}