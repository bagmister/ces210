using System;
using System.Reflection.Metadata.Ecma335;

class Order
{
    private List<Product> _products;
    private Customer _customer;
    private double _totalComined;

    public Order(){
        _products = new List<Product>();
        _customer = new Customer();
    }
    public void AddProductToOrder(Product product){
        _products.Add(product);
    }
    public double GetTotalPrice(Address address){
        var shippingCost = 0;
        var shippingAddressInUSA = address.IsAddressInUSA(address.GetCountry());
        if (shippingAddressInUSA != true){
            shippingCost = 35;
        }
        else {
            shippingCost = 5;
        }
        foreach (Product product in _products){
            var costWithQuanity = product.CalculateCost();
            _totalComined += costWithQuanity;

        };
        var total = _totalComined + shippingCost;
        return total;
    }
    public void DisplayPackinglabel(){
        Console.WriteLine("Packing Label");
        Console.WriteLine("================");
        foreach(Product product in _products){
            Console.WriteLine($"{product.GetId()} - {product.GetName()}");
        }
        Console.WriteLine("");
    }
    public void DisplayShipingLabel(Customer customer) {
        Console.WriteLine("Shipping Label");
        Console.WriteLine("================");
        customer.GetAddress().GetAddressForShipping(customer);
        Console.WriteLine("");

    }
}