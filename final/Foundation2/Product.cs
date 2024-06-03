using System;

class Product
{
    private string _name;
    private string _id;
    private double _price;
    private int _quantity;

    public Product(){
        _name = "";
        _id = "";
        _price = 0;
        _quantity = 0;
    }
    public double CalculateCost(){
        var combinedCost = _price * _quantity;
        return combinedCost;
    }
    public string GetName(){
        return _name;
    }
    public string SetName(string name) {
        return _name = name;
    }
    public string GetId(){
        return _id;
    }
    public string SetId(string id){
        return _id = id;
    }
    public int GetQuantity(){
        return _quantity;
    }
    public int SetQuantity(int quantity){
        return _quantity = quantity;
    }
    public double SetPrice(double price){
        return _price = price;
    }
}
