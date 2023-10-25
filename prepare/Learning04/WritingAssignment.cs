public class WritingAssignment : Assignment
{
    private string _title;


    // Used reference from sample solution to put ": base(studentName, topic)" on next line and indent:
    // https://github.com/byui-cse/cse210-student-sample-solutions/tree/main/prepare/Learning04

    // Calling the base class constructor sets the base class attributes: https://byui-cse.github.io/cse210-course-2023/unit04/prepare.html
    public WritingAssignment(string studentName, string topic, string title)
        : base(studentName, topic)
    {
        _title = title;
    }

    public string GetWritingInformation()
    {
        return $"{_title} by {GetStudentName()}";
    }
}