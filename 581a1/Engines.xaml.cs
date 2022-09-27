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

namespace _581a1
{
    /// <summary>
    /// Interaction logic for Engines.xaml
    /// </summary>
    public partial class Engines : Window
    {
        public Engines()
        {
            InitializeComponent();
        }

        private void i3Button_Click(object sender, RoutedEventArgs e)
        {
            I3s i3s = new I3s();
            this.Close();
            i3s.Show();
        }

        private void i4Button_Click(object sender, RoutedEventArgs e)
        {
            I4s i4s = new I4s();
            this.Close();
            i4s.Show();
        }

        private void i5Button_Click(object sender, RoutedEventArgs e)
        {
            I5s i5s = new I5s();
            this.Close();
            i5s.Show();
        }

        private void i6Button_Click(object sender, RoutedEventArgs e)
        {
            I6s i6s = new I6s();
            this.Close();
            i6s.Show();
        }

        private void v6Button_Click(object sender, RoutedEventArgs e)
        {
            V6s v6s = new V6s();
            this.Close();
            v6s.Show();
        }

        private void v8Button_Click(object sender, RoutedEventArgs e)
        {
            V8s v8s = new V8s();
            this.Close();
            v8s.Show();
        }

        private void v10Button_Click(object sender, RoutedEventArgs e)
        {
            V10s v10s = new V10s();
            this.Close();
            v10s.Show();
        }

        private void v12Button_Click(object sender, RoutedEventArgs e)
        {
            V12s v12s = new V12s();
            this.Close();
            v12s.Show();
        }
    }
}
