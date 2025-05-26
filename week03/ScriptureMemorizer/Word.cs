public class Word
{
    private string _word;
    private bool _isHidden;

    // Constructor
    // sets _isHidden to false to show all words initially
    public Word(string word)
    {
        _word = word;
        _isHidden = false;
    }

    // sets the word as hidden; called to hide word
    public void Hide()
    {
        _isHidden = true;
    }

    // checks if word is already hidden
    // prevents hiding word already hidden **stretch challenge**
    public bool isHidden()
    {
        return _isHidden;
    }

    // checks if word is hidden
    // if hidden, it replaces with underscores accoring to length of word
    public string GetDisplayText()
    {
        if (_isHidden)
        {
            return new string('_', _word.Length);
        }

        else
        {
            return _word;
        }
    }
}