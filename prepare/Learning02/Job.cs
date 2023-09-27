// Reference for assignment: https://byui-cse.github.io/cse210-course-2023/unit02/prepare.html

public class Job
{
    // Attributes: member variables
    // CLASS DIAGRAM ATTRIBUTES
    // Job
    // _company : string
    // _jobTitle : string
    // _startYear : int
    // _endYear : int 

    public string _company;
    public string _jobTitle;
    public int _startYear;
    public int _endYear;

    // Method(s): member function(s)
    // CLASS DIAGRAM METHOD(S)
    // Job
    // DisplayJobDetails() : void

    public void DisplayJobDetails()
    {
        // Format: "Job Title (Company) StartYear-EndYear"
        // Example: Software Engineer (Microsoft) 2019-2022
        Console.WriteLine($"{_jobTitle} ({_company}) {_startYear}-{_endYear}");
    }
}