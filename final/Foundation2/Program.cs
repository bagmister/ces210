using System;

class Program
{
    static void Main(string[] args)
    {
        var customer1 = new Customer();
        var address1 = new Address();
        var customer2 = new Customer();
        var address2 = new Address();
        var customer3 = new Customer();
        var address3 = new Address();
        var order1 = new Order();
        var order2 = new Order();
        var order3 = new Order();
        var wand2 = new Product();
        var wand3 = new Product();
        var horseOrder1 = new Product();
        var horseOrder2 = new Product();
        var horseOrder3 = new Product();
        var ringOfPower2 = new Product();
        var ringOfPower3 = new Product();
        var staff1 = new Product();
        var staff3 = new Product();
        var alchemyLab1 = new Product();

        horseOrder1.SetId("1How");
        horseOrder1.SetName("Mace");
        horseOrder1.SetQuantity(1);
        horseOrder1.SetPrice(42.44);
        order1.AddProductToOrder(horseOrder1);
        staff1.SetName("Oogi-boogie");
        staff1.SetQuantity(1);
        staff1.SetPrice(39.99);
        staff1.SetId("1Sob");
        order1.AddProductToOrder(staff1);
        alchemyLab1.SetQuantity(2);
        alchemyLab1.SetPrice(69.38);
        alchemyLab1.SetId("2AjL");
        alchemyLab1.SetName("Journeyman Lab");
        order1.AddProductToOrder(alchemyLab1);

        wand2.SetName("Wabbajack");
        wand2.SetQuantity(1);
        wand2.SetId("1Sw");
        wand2.SetPrice(990.44);
        order2.AddProductToOrder(wand2);
        horseOrder2.SetName("Sleepy Hollow");
        horseOrder2.SetId("1Hsh");
        horseOrder2.SetPrice(34.99);
        horseOrder2.SetQuantity(1);
        order2.AddProductToOrder(horseOrder2);
        ringOfPower2.SetName("The One Ring");
        ringOfPower2.SetQuantity(1);
        ringOfPower2.SetId("1Rtor");
        ringOfPower2.SetPrice(1000.99);
        order2.AddProductToOrder(ringOfPower2);

        staff3.SetName("Walking Stick");
        staff3.SetId("1Sws");
        staff3.SetPrice(2);
        staff3.SetQuantity(1);
        order3.AddProductToOrder(staff3);
        ringOfPower3.SetName("Eldwin Ring");
        ringOfPower3.SetId("3ERw");
        ringOfPower3.SetPrice(30.24);
        ringOfPower3.SetQuantity(2);
        order3.AddProductToOrder(ringOfPower3);
        wand3.SetName("Elder Wand");
        wand3.SetId("1WEW");
        wand3.SetQuantity(1);
        wand3.SetPrice(999);
        order3.AddProductToOrder(wand3);
        horseOrder3.SetName("fatty Lumpkin");
        horseOrder3.SetId("1HuOP");
        horseOrder3.SetPrice(100);
        horseOrder3.SetQuantity(1);
        order3.AddProductToOrder(horseOrder3);
        
        customer1.SetName("Billio Bobby");
        address1.SetStreet("358 Yellow Brick Road");
        address1.SetCity("OZ");
        address1.SetStateProv("AZ");
        address1.SetCountry("USA");
        customer1.SetAddress(address1);
        
        customer2.SetName("King Boo");
        address2.SetStreet("213 Lava Road");
        address2.SetCity("Koopa Kingdom");
        address2.SetStateProv("BA");
        address2.SetCountry("CA");
        customer2.SetAddress(address2);

        customer3.SetName("Tom Bombadil");
        address3.SetStreet("1 Brandywine River");
        address3.SetCity("Old Forest");
        address3.SetStateProv("OR");
        address3.SetCountry("USA");
        customer3.SetAddress(address3);

        var total1 = order1.GetTotalPrice(address1);
        Console.WriteLine($"Order1 total cost: ${total1}");
        order1.DisplayPackinglabel();
        order1.DisplayShipingLabel(customer1);
        Console.WriteLine("");
        
        var total2 = order2.GetTotalPrice(address2);
        Console.WriteLine($"Order2 total cost: ${total2}");
        order2.DisplayPackinglabel();
        order2.DisplayShipingLabel(customer2);
        Console.WriteLine("");
        
        var total3 = order3.GetTotalPrice(address3);
        Console.WriteLine($"Order3 total cost: ${total3}");
        order3.DisplayPackinglabel();
        order3.DisplayShipingLabel(customer3);

    }
}