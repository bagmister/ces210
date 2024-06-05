using System;
using Microsoft.VisualBasic;

class Program
{
    static void Main(string[] args)
    {
        var outdoor = new OutDoor();
        var lecture = new Lecture();
        var reception = new Reception();
        var outDoorAddress = new Address();
        var lectureAddress = new Address();
        var receptionAddress = new Address();
        var typeOutDoor = "OutDoor";
        var typeLecture = "Lecture";
        var typeReception = "Reception";

        reception.SetTime("6:00 PM");
        reception.SetDescription("Wedding of Samwise Gamgee and Rose Cotton. Lots of fun to be had!");
        reception.SetDate("07/12/24");
        reception.SetTitle("Marriage of Samwise and Rose");
        reception.SetEmail("frodobaggins@shire.com");
        receptionAddress.SetStreet("34 Bag End");
        receptionAddress.SetCity("Hobbiton");
        receptionAddress.SetCountry("Eriador");
        receptionAddress.SetStateProv("Shire");
        reception.SetAddress(receptionAddress);

        lecture.SetTime("9:00 AM");
        lecture.SetTitle("The Case For God");
        lecture.SetDate("6/17/24");
        lecture.SetCapacity(420);
        lecture.SetSpeaker("Dennis Prager");
        lecture.SetDescription("In this event Dennis will make the case for God and and why it's important to have a God.");
        lectureAddress.SetStreet("456 PragerU");
        lectureAddress.SetCity("Los Angeles");
        lectureAddress.SetStateProv("CA");
        lectureAddress.SetCountry("USA");
        lecture.SetAddress(lectureAddress);

        outdoor.SetWeather("cloudy with a 50% chance of rain.");
        outDoorAddress.SetStateProv("Glasgow");
        outDoorAddress.SetCountry("Scotland");
        outDoorAddress.SetCity("Glasgow City");
        outDoorAddress.SetStreet("123 Glencoe");
        outdoor.SetAddress(outDoorAddress);
        outdoor.SetDate("6/15/24");
        outdoor.SetTime("12:00 PM");
        outdoor.SetDescription("We shall venture forth through the land of Glen Coe. To see where the Campbell clan massacred the clan MacDonald, by order of the king.");
        outdoor.SetTitle("highland's of Scotland");
        
        Console.WriteLine("");
        outdoor.GetFullDetails(typeOutDoor,weather:outdoor.GetWeather());
        Console.WriteLine("");
        outdoor.GetShortDetails(typeOutDoor);
        Console.WriteLine("");
        outdoor.GetStandardDetails();
        Console.WriteLine("");

        Console.WriteLine("");
        lecture.GetFullDetails(typeLecture,speaker:lecture.GetSpeaker(),capacity:lecture.GetCapacity());
        Console.WriteLine("");
        lecture.GetShortDetails(typeLecture);
        Console.WriteLine("");
        lecture.GetStandardDetails();
        Console.WriteLine("");

        Console.WriteLine("");
        reception.GetFullDetails(typeReception,email:reception.GetEmail());
        Console.WriteLine("");
        reception.GetShortDetails(typeReception);
        Console.WriteLine("");
        reception.GetStandardDetails();
        Console.WriteLine("");



    }
}