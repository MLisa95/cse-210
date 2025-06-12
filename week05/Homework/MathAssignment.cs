public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    public MathAssignment(string name, string topic, string tbSection, string problems) : base(name, topic)
    {
        _textbookSection = tbSection;
        _problems = problems;
    }

    // append GetHomeworkList() to existing GetSummary() info
    public string GetHomeworkList()
    {
        return $"{GetSummary()} \n {_textbookSection} --- {_problems}";
    }
}