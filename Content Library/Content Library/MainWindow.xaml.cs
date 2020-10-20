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

namespace Content_Library
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        public static List<List<String>> importantdata = new List<List<String>> { };

        public static List<Goal> goals;

        public MainWindow()
        {
            InitializeComponent();

            goals = new List<Goal>();
        }
        
        private void loaded(object sender, RoutedEventArgs e)
        {
           
          //Not needed because xaml content is already GoalEntry
          //mainframe.NavigationService.Navigate(new GoalEntry());
             
        }
    }
}
