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
            SoundPlayer lfa = new SoundPlayer(Properties.Resources.lfasound);
            lfa.Play();
        }
    }
}
