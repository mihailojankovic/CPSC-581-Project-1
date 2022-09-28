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
    /// Interaction logic for V8s.xaml
    /// </summary>
    public partial class V8s : Window
    {
        public V8s()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines engines = new Engines();
            this.Close();
            engines.Show();
        }

        private void Demon_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer demon = new SoundPlayer(Properties.Resources.demonsound);
            demon.Play();
        }

        private void Jag_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer jag = new SoundPlayer(Properties.Resources.jagsound);
            jag.Play();
        }

        private void Ferrari_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer f458 = new SoundPlayer(Properties.Resources.f458sound);
            f458.Play();
        }
    }
}
