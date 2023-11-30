using System.Reflection.Metadata.Ecma335;

public class Comment
{
    private string _name; // name of the person who made the comment
    private string _text; // text of the comment

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public override string ToString()
    {
        return $"Name: {_name}, Comment: {_text}\n";
    }

}