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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPFMatches
{
    /// <summary>
    /// Interaktionslogik für MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        WrapPanel wrappi;  
        public MainWindow()
        {
            InitializeComponent();
            // initialisieren
            startgame();



        }
        private void startgame()
        {
            this.wrappi = new WrapPanel();
            Button button = new Button();
            button.Content = "1";
            textBlock.Text = "Bitte geben Sie Ihre Anzahl an Spielern an";
            this.wrappi.Children.Add(button);
            grid1.Children.Add(this.wrappi);
        }

        private void player2_Click(object sender, RoutedEventArgs e)
        {
            Game();
        }

        private void player3_Click(object sender, RoutedEventArgs e)
        {
            Game();
        }

        private void player4_Click(object sender, RoutedEventArgs e)
        {
            Game();
        }

        private void player5_Click(object sender, RoutedEventArgs e)
        {
            Game();
        }
        private void Game()
        {
            textBlock.Text = "";

        }
    }
}
 