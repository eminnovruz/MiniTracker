using System.Windows.Controls;

namespace MainView.UserControls
{
    public partial class Article_UC : UserControl
    {
        public Article_UC(Article article)
        {
            InitializeComponent();

            articlephoto_img.Source = article.ContentImage;
            articletopic_txt.Text = article.Topic;
            articlecontent_txt.Text = article.Content;
        }
    }
}
