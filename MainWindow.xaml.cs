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

namespace Options
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        internal ViewModel vm;
        public MainWindow()
        {
            InitializeComponent();
            vm = DataContext as ViewModel;
        }

        private void AddOVR_Click(object sender, RoutedEventArgs e)
        {
            vm.AddOVR();

        }

        private void line_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListBox lb && lb.SelectedItem is LineObject o)
            {
                o.Options.LineColor = Colors.Black;
            }
        }

        private void text_DoubleCLick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListBox lb && lb.SelectedItem is TextObject o)
            {
                o.Options.LineColor = Colors.Red;
            }
        }

        private void lines_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListBoxItem lb && lb.DataContext is OVR3 o)
            {
                o.Options.LineOptions.LineColor = Colors.Green;
            }
        }

        private void texts_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListBoxItem lb && lb.DataContext is OVR3 o)
            {
                o.Options.TextOptions.LineColor = Colors.Purple;
            }
        }

        private void ovr_doubleClick(object sender, MouseButtonEventArgs e)
        {
            if (sender is ListBox lb && lb.SelectedItem is OVR3 o)
            {
                o.Options.LineOptions.LineColor = Colors.Red;
            }
        }
    }
}
