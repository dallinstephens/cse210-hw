public class Video
{
    private string _title;
    private string _author;
    private int _length; // length in seconds of the video
    private List<Comment> _comments = new List<Comment>();

    public Video(string title, string author, int length)
    {
        _title = title;
        _author = author;
        _length = length;
    }

    private int ReturnNumberOfComments()
    {
        return _comments.Count(); // number of comments;
    }

    public void AddComment(Comment comment)
    {
        _comments.Add(comment);
    }

    private string ReturnComments()
    {
        string comments = "";

        foreach (Comment comment in _comments)
        {
            comments += comment.ToString();
        }

        return comments;
    }

    // Reference video on how to override using ToString():
    // https://www.youtube.com/watch?v=MwPZLPNR3ns
    public override string ToString()
    {
        return $"Title: {_title}\nAuthor: {_author}\nLength: {_length} seconds\nNumber of comments: {ReturnNumberOfComments()}\n" +
               $"{ReturnComments()}\n";
    }
}