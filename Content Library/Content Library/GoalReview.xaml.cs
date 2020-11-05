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
    /// Interaction logic for Page3.xaml
    /// </summary>
    public partial class GoalReview : Page
    {
        
        public GoalReview(int gindex)
        {
            InitializeComponent();

            Goal g = MainWindow.goals[gindex];
            v = gindex;
            main_title.Content = g.title;
            int x = 0;
            foreach (var a in g.activites)
            {
                CheckBox cek = new CheckBox();
                cek.Content = a.name;
                
                cek.Background = new SolidColorBrush(Colors.Black);
                cek.Foreground = new SolidColorBrush(Colors.Orange);
                ActivityListBox.Children.Add(cek);

                

            }
        }
        public int v;
        private void back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Goals());
        }

      

        private void new_activity(object sender, RoutedEventArgs e)
        {
        MainWindow.goals[v].activites.Add(new Activity(new_activity_name.Text));
          
        }
    }
}
