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
        private int n;
        //public int v;
        public GoalReview(int gindex)
        {
            InitializeComponent();

            Goal g = MainWindow.goals[gindex];
            
            //v = gindex;
            n = gindex;
            main_title.Content = g.title;
            int x = 0;
            int y = 0;
            int t = 0;
            int number = 0;
            foreach (var a in g.activites)
            {
                x += 1;
                CheckBox cek = new CheckBox();
                cek.Content = a.name;
                if (!a.completed)
                {
                    y += 1;
                    cek.IsChecked = false;
                }
                if (a.completed)
                {
                    cek.IsChecked = true;
                }
                cek.Background = new SolidColorBrush(Colors.Black);
                cek.Foreground = new SolidColorBrush(Colors.Orange);
                cek.Tag = number;
                cek.Checked += new RoutedEventHandler(Checkedtrue);
                cek.Unchecked += new RoutedEventHandler(Checkedfalse);
                ActivityListBox.Children.Add(cek);
                number += 1;


            }
            progress.Maximum = x;

            
            progress.Value = y;
        }
        private void Checkedtrue(object sender, RoutedEventArgs e)
        {
            int a = (int)((CheckBox)sender).Tag;
            var b = ((CheckBox)sender).IsChecked;

            {
                MainWindow.goals[n].activites[a].completed = true;
            }


        }    
        private void Checkedfalse(object sender, RoutedEventArgs e)
        {
                    int a = (int)((CheckBox)sender).Tag;
                    var b = ((CheckBox)sender).IsChecked;
                    MainWindow.goals[n].activites[a].completed = false;
        }


        
        private void Back(object sender, RoutedEventArgs e)
        {
            this.NavigationService.Navigate(new Goals());
        }

      

        private void New_Activity(object sender, RoutedEventArgs e)
        {
        MainWindow.goals[n].activites.Add(new Activity(new_activity_name.Text));
          
        }
    }
}
