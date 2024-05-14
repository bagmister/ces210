using System;
using System.Runtime.InteropServices;

class Reference
{
    private string _book;
    private int _chapter;
    private int _verse;
    private int _endverse;
    private string _text;

    public Reference(string book, int chapter, int verse){
        _book = book;
        _chapter = chapter;
        _verse = verse;        
    }
    public Reference(string book, int chapter, int verse, int endverse){
        _book = book;
        _chapter = chapter;
        _book = book;
        _verse = verse ;
        _endverse = endverse;
    }

    public string GetDisplayText(int choice){
        if (choice == 1){
            _text = "Trust in the Lord with all thine heart; and lean not unto thine own understanding. In all thy ways acknowledge him, and he shall direct thy paths.";
        }
        else if (choice == 2){
            _text = "For God so loved the world, that he gave his only begotten Son, that whosoever believeth in him should not perish, but have everlasting life.";
        }
        else{
            _text = "Do not pass Go. Do not collect $200. Invalid choice.";
        }
        return _text;
    }

    public string GetDisplayReference() {
        var completeReference = "";
        if (_endverse == 0){
            completeReference = $"{_book} {_chapter}:{_verse}";
        }
        else{
            completeReference = $"{_book} {_chapter}:{_verse}-{_endverse}";
        }
        return completeReference;
    }
}