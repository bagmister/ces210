using System;

class Comment
{
   private string _name;
   private string _text;

   public Comment(){
    _name = "";
    _text = "";
   }
   public void DisplayComment(){
    Console.WriteLine("");
    Console.WriteLine($"{_name}: {_text}");
   }
   public string SetName(string name){
    return _name = name;
   }
   public string GetName(){
    return _name;
   }
   public string SetText(string text){
    return _text = text;
   }
   public string GetText(){
    return _text;
   }

}