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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp2
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

        private void sliRed_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctColor.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliRed.Value), Convert.ToByte(sliGreen.Value), Convert.ToByte(sliBlue.Value)));
        }

        private void sliGreen_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctColor.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliRed.Value), Convert.ToByte(sliGreen.Value), Convert.ToByte(sliBlue.Value)));
        }

        private void sliBlue_ValueChanged(object sender, RoutedPropertyChangedEventArgs<double> e)
        {
            rctColor.Fill = new SolidColorBrush(Color.FromRgb(Convert.ToByte(sliRed.Value), Convert.ToByte(sliGreen.Value), Convert.ToByte(sliBlue.Value)));
        }
    }
}
