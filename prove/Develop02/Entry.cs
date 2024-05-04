using System;

class Entry
{
    public DateTime _date = DateTime.Now;
    public String _promptText = "";
    public String _entryText = "";
    public void Display(String filePath)
    {          
        Console.WriteLine($"{_date} : {_promptText} - {_entryText}");

    }
}