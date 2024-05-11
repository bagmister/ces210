using System;

class Scripture
{
    private Reference reference;
    private List<Word> words;
    
    public Scripture(Reference reference, string text){
        string[] words = text.Split(' ');
    }
    public void HideRandomWords(int numberToHide){

    }
    public string GetDisplayText(){
        return "";
    }
    public bool IsCompletelyHidden(){
        return false;
    }
}