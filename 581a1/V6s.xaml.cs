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
using System.Media;

namespace _581a1
{
    /// <summary>
    /// Interaction logic for V6s.xaml
    /// </summary>
    public partial class V6s : Window
    {
        public V6s()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines main = new Engines();
            this.Close();
            main.Show();
        }

        private void GTR_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer gtr = new SoundPlayer(Properties.Resources.gtrsound);
            gtr.Play();
        }

        private void Stratos_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer stratos = new SoundPlayer(Properties.Resources.stratossound);
            stratos.Play();
        }

        private void Alfa_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer alfa = new SoundPlayer(Properties.Resources.gtv6sound);
            alfa.Play();
        }
    }
}
