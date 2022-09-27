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
    /// Interaction logic for V12s.xaml
    /// </summary>
    public partial class V12s : Window
    {
        public V12s()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines main = new Engines();
            this.Close();
            main.Show();
        }

        private void F812_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer f812 = new SoundPlayer(Properties.Resources.f812sound);
            f812.Play();
        }

        private void Pagani_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer huayra = new SoundPlayer(Properties.Resources.paganisound);
            huayra.Play();
        }

        private void Lambo_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer lambo = new SoundPlayer(Properties.Resources.lambosound);
            lambo.Play();
        }
    }
}
