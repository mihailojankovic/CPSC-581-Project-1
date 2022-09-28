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
    /// Interaction logic for I4s.xaml
    /// </summary>
    public partial class I4s : Window
    {
        public I4s()
        {
            InitializeComponent();
        }

        private void M3_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer m3 = new SoundPlayer(Properties.Resources.e30sound);
            m3.Play();
        }

        private void S2k_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer s2k = new SoundPlayer(Properties.Resources.s2ksound);
            s2k.Play();
        }

        private void WRX_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer wrx = new SoundPlayer(Properties.Resources.wrxsound);
            wrx.Play();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines engines = new Engines();
            this.Close();
            engines.Show();
        }
    }
}
