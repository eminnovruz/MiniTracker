using MainView.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace MainView.Views
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            Article_UC article = new Article_UC(new Article("COMMUNITY ROUNDUP: APRIL 2023", "Get some frame-perfect plays with the new Radiant Entertainment System skins, explore the return of Bind, and level up your collection with a new Battlepass in the last act of REVELATION.", new BitmapImage(new Uri("../Images/articleimg.jpg", UriKind.RelativeOrAbsolute))));
            Article_UC article2 = new Article_UC(new Article("VALORANT PATCH NOTES 6.08", "Before you start grinding the new battlepass, we’ve made some updates to Killjoy and Gekko. Check those out and more here.", new BitmapImage(new Uri("../Images/articleimg2.jpg", UriKind.RelativeOrAbsolute))));
            
            main_panel.Children.Add(article);
            main_panel.Children.Add(article2);
        }
    }
}
