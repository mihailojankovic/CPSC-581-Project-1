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
    /// Interaction logic for V10s.xaml
    /// </summary>
    public partial class V10s : Window
    {
        public V10s()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Engines engines = new Engines();
            this.Close();
            engines.Show();
        }

        private void LFA_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer lfa = new SoundPlayer(Properties.Resources.lfasound);
            lfa.Play();
        }

        private void Carrera_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer carrera = new SoundPlayer(Properties.Resources.carrerasound);
            carrera.Play();
        }

        private void R8_Click(object sender, RoutedEventArgs e)
        {
            SoundPlayer r8 = new SoundPlayer(Properties.Resources.r8sound);
            r8.Play();
        }
    }
}
