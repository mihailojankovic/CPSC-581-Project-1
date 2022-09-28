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
    /// Interaction logic for I6s.xaml
    /// </summary>
    public partial class I6s : Window
    {
        public I6s()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines engines = new Engines();
            this.Close();
            engines.Show();
        }

        private void R34_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer r34 = new SoundPlayer(Properties.Resources.r34sound);
            r34.Play();
        }

        private void Supra_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer supra = new SoundPlayer(Properties.Resources.suprasound);
            supra.Play();
        }

        private void TVR_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer f812 = new SoundPlayer(Properties.Resources.f812sound);
            f812.Play();
        }
    }
}
