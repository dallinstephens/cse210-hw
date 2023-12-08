using System.Text;

public class Event
{
    private string _title;
    private string _description;
    private string _date;
    private string _time;
    private Address _address;

    public Event(string title, string description, string date, string time, Address address)
    {
        _title = title;
        _description = description;
        _date = date;
        _time = time;
        _address = address;
    }

    private string GetStandardDetails()
    {
        // Reference for StringBuilder:
        // https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0 
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{StartUnderline()}Title{EndUnderline()}: {_title}");
        sb.AppendLine($"{StartUnderline()}Description{EndUnderline()}: {_description}");
        sb.AppendLine($"{StartUnderline()}Date{EndUnderline()}: {_date}");
        sb.AppendLine($"{StartUnderline()}Time{EndUnderline()}: {_time}");
        // Reference to use Append instead of AppendLine so to not have new line:
        // https://www.dotnetperls.com/append
        sb.Append($"{StartUnderline()}Address{EndUnderline()}: {_address.ToString()}");

        return sb.ToString();
    }

    public string ReturnStandardDetails()
    {
        // Reference for StringBuilder:
        // https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0 
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{StartRedText()}STANDARD DETAILS ({this.GetType()}){EndRedText()}");
        sb.AppendLine($"{GetStandardDetails()}");

        return sb.ToString();
    }

    public string ReturnFullDetails()
    {
        // Reference on Object.GetType Method:
        // https://learn.microsoft.com/en-us/dotnet/api/system.object.gettype?view=net-7.0

        // Reference for StringBuilder:
        // https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0 
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{StartRedText()}FULL DETAILS ({this.GetType()}){EndRedText()}");
        sb.AppendLine($"{GetStandardDetails()}");
        sb.AppendLine($"{StartUnderline()}Type of Event{EndUnderline()}: {this.GetType()}");
        sb.AppendLine($"{this.ToString()}");

        return sb.ToString();
    }

    public string ReturnShortDescription()
    {
        // Reference for StringBuilder:
        // https://learn.microsoft.com/en-us/dotnet/api/system.text.stringbuilder?view=net-8.0 
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{StartRedText()}SHORT DESCRIPTION ({this.GetType()}){EndRedText()}");
        sb.AppendLine($"{StartUnderline()}Type of Event{EndUnderline()}: {this.GetType()}");
        sb.AppendLine($"{StartUnderline()}Title{EndUnderline()}: {_title}");
        sb.AppendLine($"{StartUnderline()}Date{EndUnderline()}: {_date}");

        return sb.ToString();
    }

    // Reference on how to underline in terminal:
    // https://stackoverflow.com/questions/5237666/adding-text-decorations-to-console-output

    // Reference for how to change terminal text color to red:
    // https://gist.github.com/raghav4/48716264a0f426cf95e4342c21ada8e7

    protected string StartUnderline()
    {
        return "\x1b[4m";
    }

    protected string EndUnderline()
    {
        return "\x1b[0m";
    }

    private string StartRedText()
    {
        return "\x1b[31m";
    }

    private string EndRedText()
    {
        return "\x1b[0m";
    }
}