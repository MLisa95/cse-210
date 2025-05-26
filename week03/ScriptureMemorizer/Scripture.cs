public class Scripture
{
    // What does it do?
    // Store reference and words of scripture text
    //Display the scripture and hidden words
    //Tell us when all words are hidden (or closes)

    private Reference _reference;
    private List<Word> _words; //list of word objects

    //constructor
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = new List<Word>();

        //break up the text into words
        string[] parts = text.Split(' ');

        foreach (string part in parts)
        {
            _words.Add(new Word(part));
        }
    }

    public string GetDisplayText()
    {
        string fullText = _reference.GetReference() + "";

        foreach (Word word in _words)
        {
            fullText += word.GetDisplayText() + " ";
        }

        return fullText;
    }

    // hiding random words
    public void HideRandomWords()
    {
        Random random = new Random();
        int toHide = 2;

        // list indexes still visible from list
        List<int> visibleIndexes = new List<int>();

        for (int i = 0; i < _words.Count; i++)
        {
            if (!_words[i].isHidden())
            {
                visibleIndexes.Add(i);
            }
        }

        int count = Math.Min(toHide, visibleIndexes.Count);

        for (int i = 0; i < count; i++)
        {
            int randomIndex = random.Next(visibleIndexes.Count);
            int wordIndex = visibleIndexes[randomIndex];
            _words[wordIndex].Hide();

            visibleIndexes.RemoveAt(randomIndex);
        }
    }


    public bool AreAllWordsHidden()
    {

        foreach (Word word in _words)
        {
            if (!word.isHidden())
            {
                return false;
            }
        }
        return true;

    }

}
    
