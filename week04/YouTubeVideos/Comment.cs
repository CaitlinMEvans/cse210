public class Comment
{
    private string _author;
    private string _text;
    private int _likes;
    private int _dislikes;

    public Comment(string author, string text, int likes = 0, int dislikes = 0)
    {
        _author = author;
        _text = text;
        _likes = likes;
        _dislikes = dislikes;
    }

    public void Like()
    {
        _likes++;
    }

    public void Dislike()
    {
        _dislikes++;
    }

    public void DisplayComment()
    {
        Console.WriteLine($"    {_author}: {_text}");
        Console.WriteLine($"    Likes: {_likes}, Dislikes: {_dislikes}");
    }
}
