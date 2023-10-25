public class MathAssignment : Assignment
{
    private string _textbookSection;
    private string _problems;

    // Calling the base class constructor sets the base class attributes: https://byui-cse.github.io/cse210-course-2023/unit04/prepare.html
    public MathAssignment(string studentName, string topic, string textbookSection, string problems) : base(studentName, topic)
    {
        _textbookSection = textbookSection;
        _problems = problems;
    }

    public string GetHomeworkList()
    {
        return $"Section {_textbookSection} Problems {_problems}";
    }
}