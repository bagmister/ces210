using System;

class Address
{
    private string _street;
    private string _city;
    private string _stateProv;
    private string _country;

    public Address(){
        _street = "";
        _city = "";
        _stateProv = "";
        _country = "";
    }
    public bool IsAddressInUSA(string country){
        if (country != "USA"){
            return false;
        }
        else{
            return true;
        }
    }
    public void GetAddressMultiLine( ){
        Console.WriteLine("");
        Console.WriteLine($"{_street}");
        Console.WriteLine($"{_city}, {_stateProv}, {_country}");
    }
    public string SetStreet(string street) {
        return _street = street;
    }
    public string SetCity(string city){
        return _city = city;
    }
    public string SetStateProv(string stateProv){
        return _stateProv = stateProv;
    }
    public string GetCountry(){
        return _country;
    }
    public string SetCountry(string country){
        return _country = country;
    }
}