using System;
using System.Collections;

class Word
{
    private string _text;
    private bool _isHidden;
    public Word(string text){
        _text = text;
        _isHidden = false;
    }
    public void Hide(){
        _isHidden = true;
    }
    public void Show(){
        _isHidden = false;
    }
    public bool IsHidden(){
        return false;
    }
    public string GetDisplayText(){
        char[] chars = _text.ToCharArray();
        var hidden = "";
        if(_isHidden == false){
            return _text;
        }
        else{
            foreach (char w in chars) {
                hidden = hidden + "_";
            }
                return hidden;
        }
    }
}