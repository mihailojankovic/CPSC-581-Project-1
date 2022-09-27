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
    /// Interaction logic for I5s.xaml
    /// </summary>
    public partial class I5s : Window
    {
        public I5s()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines main = new Engines();
            this.Close();
            main.Show();
        }

        private void RS3_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer rs3 = new SoundPlayer(Properties.Resources.rs3sound);
            rs3.Play();
        }

        private void S1_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer s1 = new SoundPlayer(Properties.Resources.s1sound);
            s1.Play();
        }

        private void Fiat_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer fiat = new SoundPlayer(Properties.Resources.fiatsound);
            fiat.Play();
        }
    }
}
