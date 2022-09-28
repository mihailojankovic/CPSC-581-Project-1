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
using System.Windows.Navigation;

namespace _581a1
{
    /// <summary>
    /// Interaction logic for I3s.xaml
    /// </summary>
    public partial class I3s : Window
    {
        public I3s()
        {
            InitializeComponent();
        }

        private void Yaris_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer yaris = new SoundPlayer(Properties.Resources.yarisgrsound);
            yaris.Play();
        }

        private void Ford_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer ford = new SoundPlayer(Properties.Resources.fiestastsound);
            ford.Play();
        }

        private void Saab_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer saab = new SoundPlayer(Properties.Resources.saabsound);
            saab.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines engines = new Engines();
            this.Close();
            engines.Show();
        }
    }
}
