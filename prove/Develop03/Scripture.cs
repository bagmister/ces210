using System;
using System.Linq;

class Scripture
{
    private Reference _reference{ get; set; }
    private List<Word> _words { get; set; }
    private HashSet<int> _wordsHiddenSet = new HashSet<int>();
    
    public Scripture(Reference reference, string text){
        _words = new List<Word>();
        _reference = reference;
        string[] wordsArray = text.Split(' ');
        foreach (string entry in wordsArray){
          Word w = new(entry);
          if (entry != null){
            _words.Add(w);
          }
        }   
    }

    public void HideRandomWords(int numberToHide){
        _words[numberToHide].Hide();
        if(_wordsHiddenSet.Count > 0){
            foreach(int w in _wordsHiddenSet){
                _words[w].Hide();
            }
        }
    }
    
    public string GetDisplayText(){
        string result = "";
        for (int i = 0; i < _words.Count; i++) {
            var text = _words[i].GetDisplayText();
            result = result + text + " ";
        }
        return result;
    }
    public string GetDisplayReference(){
        return _reference.GetDisplayReference();
    }
    public bool IsCompletelyHidden(){
        if (_wordsHiddenSet.Count == _words.Count){
            return true;

        }
        return false;
    }
    public List<Word> GetWords(){
        return _words;
    }
    public HashSet<int> GetHashSet(){
        return _wordsHiddenSet;
    }
    public void AddToHashSet(int i){
        _wordsHiddenSet.Add(i);
    }
}