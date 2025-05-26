public class Comment
{
    private string _nameOfCommentor;
    private string _commentText;

    public Comment(string name, string comment)
    {
        _nameOfCommentor = name;
        _commentText = comment;
    }

    public string GetName()
    {
        return _nameOfCommentor;
    }

    public string GetText()
    {
        return _commentText;
    }
}