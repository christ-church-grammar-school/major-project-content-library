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

namespace test1_programic_creation
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

        private void add_1(object sender, RoutedEventArgs e)
        {
            {

                CheckBox btn = new CheckBox();

                btn.Height = 50;

                btn.Width = 100;


                btn.Content = newname.Text ;

                btn.Background = new SolidColorBrush(Colors.Orange);

                btn.Foreground = new SolidColorBrush(Colors.Black);

                SP.Children.Add(btn);

            }
        }
    }
}
