using System;
using Microsoft.VisualBasic.FileIO;
class Journal
{
    public List<String> _entries = new List<String>();
    public void AddEntry(Random random, PromptGenerator promptGenerator)
    {
        Entry e = new Entry();
        var number = random.Next(0,5);
        e._promptText = promptGenerator.GetRandomPrompt(number);
        Console.WriteLine($"{e._promptText}");
        e._entryText = Console.ReadLine();
        var entryTosave = $"{e._date} : {e._promptText} - {e._entryText};";
        Console.WriteLine(entryTosave);
        _entries.Add(entryTosave);
    }
    public void DisplayAll(String filePath)
    {
    var fileExists = File.Exists(filePath);
        if (fileExists != false){
            var reader = System.IO.File.ReadAllLines(filePath);
                foreach(String line in reader) {
                    Console.WriteLine(line);
                    Console.WriteLine();
                    Console.WriteLine();
                }
            

            }
        else {
            Console.WriteLine("There is no file to read from. Displaying what is currently stored in memory.");
            Console.WriteLine(_entries.Count);
            foreach(String singleEntry in _entries){
                Console.WriteLine($"{singleEntry}");
                Console.WriteLine();
                Console.WriteLine();
            }
        }
    }
    public void SaveToFile(String filePath)
    {
        using (StreamWriter outputFile = new StreamWriter(new FileStream(filePath,
        FileMode.Create, FileAccess.Write)))
        foreach (string item in _entries) {
            outputFile.WriteLine(item);
            outputFile.WriteLine(";");
        }
    }
    public void LoadFromFile(String filePath)
    {
        if (filePath != null){
            using (Microsoft.VisualBasic.FileIO.TextFieldParser parser = new TextFieldParser(filePath))
            {   
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(";");
                while (!parser.EndOfData) 
                {
                    string[] fields = parser.ReadFields();
                    foreach (string field in fields) {
                        _entries.Add(field);
                    }
                }
            }
        }
        else{
            Console.WriteLine("No file to load from. Select 1 to write an entry.");
        }
    }
}