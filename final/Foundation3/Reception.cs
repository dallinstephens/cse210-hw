public class Reception : Event
{
    private string _email;

    // Reference on how to break long code lines:
    // https://stackoverflow.com/questions/1263326/break-long-code-lines-in-visual-studio-2008#:~:text=C%23%20is%20not%20line%20based,more%20params%20etc...%20)&text=To%20break%20strings%20you%20can,you%20put%20%40%20before%20the%20string.
    public Reception(
        string email,
        string title, string description, string date, string time, Address address)
        : base(title, description, date, time, address)
    {
        _email = email;
    }

    public override string ToString()
    {
        return $"{StartUnderline()}Email for RSVP{EndUnderline()}: {_email}";
    }
}