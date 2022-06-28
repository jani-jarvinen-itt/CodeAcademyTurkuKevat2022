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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfDemo
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            // koodia tähän...
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
           // this.Storyboard1.Begin();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Storyboard1.
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            List<int> luvut = new();
            List<string> nimet = new();

            luvut.Add(123);
            // luvut.Add("nimi");

            nimet.Add("Jaska Jokunen");
            // nimet.Add(233);
        }
    }
}
