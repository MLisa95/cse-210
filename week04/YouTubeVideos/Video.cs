using System.Diagnostics.Contracts;

public class Video
{
    private string _title;
    private string _author;
    private int _length;
    private List<Comment> _commentList;

    // initializing member variables
    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
        _commentList = new List<Comment>();
    }

    public void AddComment(string name, string commentText)
    {
        Comment newComment = new Comment(name, commentText);
        _commentList.Add(newComment);

    }

    public string GetTitle()
    {
        return _title;
    }

    public string GetAuthor()
    {
        return _author;
    }

    public int GetLength()
    {
        return _length;
    }

    public List<Comment> GetComments()
    {
        return _commentList;
    }
}