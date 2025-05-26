using System.Collections.Concurrent;

public class Reference
{
    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    // when scripture has only one verse
    public Reference(string book, int chapter, int verse)
    {
        // remember that these are the ones that hold the data
        _book = book;
        _chapter = chapter;
        _verseStart = verse;
    }

    // when scripture has multiple verses (range)
    public Reference(string book, int chapter, int verseStart, int verseEnd)
    {
        _book = book;
        _chapter = chapter;
        _verseStart = verseStart;
        _verseEnd = verseEnd;
    }

    public string GetBook()
    {
        return _book;
    }

    public int GetChapter()
    {
        return _chapter;
    }

    public int GetVerseStart()
    {
        return _verseStart;
    }

    public int GetVerseEnd()
    {
        return _verseEnd;
    }

    public string GetReference()
    {
        if (_verseStart == _verseEnd)
            return $"{_book} {_chapter}: {_verseStart}";

        else
            return $"{_book} {_chapter}: {_verseStart} - {_verseEnd}";
    }

}
