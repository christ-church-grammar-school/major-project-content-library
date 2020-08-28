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
    /// Interaction logic for Page1.xaml
    /// </summary>
    public partial class Page1 : Page
    {
        public Page1()
        {
            InitializeComponent();
        }

        private void goal_add(object sender, RoutedEventArgs e)
        {
            var tabItem = new TabItem();
            tabItem.Header = "My Tab Header";
            tabItem.Content = new Page3();
            maintabcontroal.Items.Add(tabItem);
            this.NavigationService.Navigate(new Page2());
           

        }

        private void maintabcontroal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
