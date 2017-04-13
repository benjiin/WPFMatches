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

            this.wrappi = new WrapPanel();
            textBlock.Text = "Bitte geben Sie Ihre Anzahl an Spielern an";


        }

        private void player2_Click(object sender, RoutedEventArgs e)
        {
            Alles(2);
        }

        private void player3_Click(object sender, RoutedEventArgs e)
        {

        }

        private void player4_Click(object sender, RoutedEventArgs e)
        {

        }

        private void player5_Click(object sender, RoutedEventArgs e)
        {

        }
        private void Alles(int click)
        {
            Random rnd = new Random();
            int
               person = click,
               zufall = rnd.Next(0, person),
               runden = person,
               loser = 0;
            int[]
                nummer = new int[person];
            bool[]
                isUsedId = new bool[person];

            for (int j = 0; j < person; j++)
            {

                textBlock.Text = "Gezeigt werden die Streichhölzer \"nebeneinanderliegend\" wobei das Streichholz mit der 1 das kurze ist";
                nummer[zufall] = 1;
                for (int i = 0; i < nummer.Length; i++)
                {
                    if (isUsedId[i] == false)
                    {
                        textBlock.Text = "Streichholz" + i + 1 + ": hat den Wert" + nummer[i];
                    }
                }
                textBlock.Text = "Spieler " + j + 1 + " Bitte ziehen Sie ein Streichholz. (Nummer zwischen 1-" + person + "eingeben)";
                int auswahl = Convert.ToInt32(Console.ReadLine()) - 1; // buttons

                //isUsedId[auswahl] = true;

                //if (auswahl == zufall)
                //{
                //    loser = j + 1;
                //}
                //runden -= 1;

                textBlock.Text = "Spieler" + loser + "hat das Spiel verloren";
            }
        }
    }
}
        
    


/*
 *     public partial class MainWindow : Window
    {
        WrapPanel wrapPanel;
        public MainWindow()
        {
            InitializeComponent();
            Random random = new Random();
            int count = random.Next(5);

            this.wrapPanel = new WrapPanel();

            for (int i = 0; i<count; i++)
            {
                Button button = new Button();
                button.Content = i + "";
                this.wrapPanel.Children.Add(button);
            }
            grid1.Children.Add(this.wrapPanel);

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if(this.wrapPanel.Children.Count > 0)
            {
                this.wrapPanel.Children.RemoveAt(0);
            }
            MessageBox.Show("Es wurde ein Button gelöscht!");
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Button button = new Button();
            button.Content = "AA";
            this.wrapPanel.Children.Add(button);
            
        }
    }
}
*/
 