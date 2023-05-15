using System.Windows.Media;
using System.Windows.Media.Imaging;

public class Article
{
    public string Topic { get; set; }
    public string Content { get; set; }
    public BitmapImage ContentImage { get; set; }

    public Article(string topic, string content, BitmapImage contentImage)
    {
        Topic = topic;
        Content = content;
        ContentImage = contentImage;
    }
}
