using System;
using System.Runtime.CompilerServices;

class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _comments;
    public Video(){
        _title = "";
        _author = "";
        _length = 0;
        _comments = new List<Comment>();
    }
    public void AddCommentToList(Comment comment){
        _comments.Add(comment);
    } 
    public void DisplayVideosWithComments(Video video){
        Console.WriteLine("");
        Console.WriteLine($"{video._title} by {video._author} ({video._length} seconds)");
        var number = video.NumberofComments(video._comments);
        Console.WriteLine($"Number of Coments: {number}");
        foreach (Comment commentValue in video._comments){
            commentValue.DisplayComment();
        };
    }
    public int NumberofComments(List<Comment> comments){
        return comments.Count;
    }
    public string SetTitle(string title){
        return _title = title;
    }
    public string GetTitle(){
        return _title;
    }
    public string SetAuthor(string author){
        return _author = author;
    }
    public string GetAuthor(){
        return _author;
    }
    public int SetLength(int length){
        return _length = length;
    }
    public int Getlength(){
        return _length;
    }
    public List<Comment> GetCommentsList(){
        return _comments;
    }

}