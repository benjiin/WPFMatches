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
            //startgame();
            



        }
        private void startgame()
        {
            this.wrappi = new WrapPanel();
            Button button2 = new Button();
            button2.Content = "2 Spieler";

            Button button3 = new Button();
            button3.Content = "3 Spieler";

            Button button4 = new Button();
            button4.Content = "4 Spieler";

            Button button5 = new Button();
            button5.Content = "5 Spieler";

            TextBlock textBlock = new TextBlock();
            textBlock.Text = "Bitte geben Sie Ihre Anzahl an Spielern an";
            this.wrappi.Children.Add(button2);
            this.wrappi.Children.Add(button3);
            this.wrappi.Children.Add(button4);
            this.wrappi.Children.Add(button5);
            this.wrappi.Children.Add(textBlock);
            grid1.Children.Add(this.wrappi);
        }

        private void player2_Click(object sender, RoutedEventArgs e)
        {
           
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
            //textBlock.Text = "";

        }
    }
}
 