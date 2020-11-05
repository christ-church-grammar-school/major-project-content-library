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
using System.Timers;
using System.Windows.Threading;

namespace Content_Library
{


    /// <summary>

    /// Interaction logic for MainWindow.xaml

    /// </summary>

    public partial class Goals : Page

    {

        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();

        private int time = 0;
        private DispatcherTimer Timer3;

        public Goals()

        {

            InitializeComponent();


            Timer = new DispatcherTimer();
            Timer.Interval = new TimeSpan(0, 0, 1);
            //Timer.Tick += Timer_Tick;
            Timer.Start();

            Timer.Tick += new EventHandler(Timer_Click);

            Timer.Interval = new TimeSpan(0, 0, 1);

            Timer.Start();

        }



        private void Timer_Click(object sender, EventArgs e)

        {

            DateTime d;

            d = DateTime.Now;

            clocklabel.Content = $"{d.Hour}:{d.Minute}:{d.Second} ";

        }

        void Timer_Tick(object sender, EventArgs e)
        {
            if (time > 10)
            {
                if (time <= 10)
                    if (time % 2 == 0)
                    {
                        TBCountDown.Foreground = Brushes.Red;
                    }
                    else
                    {
                        TBCountDown.Foreground = Brushes.White;
                    }
                else
                {
                    time--;
                    TBCountDown.Text = string.Format("00:0{0}:{1}", time / 60, time % 60);
                }


            }
            else
            {
                Timer.Stop();
                MessageBox.Show("BooW!");
            }
        }



        private void maintabcontroal_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void goal_add(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new GoalEntry());
        }


        
       
        private void b_Click(object sender, RoutedEventArgs e)
        {
            var gindex = ((Button)sender).Tag;
            this.NavigationService.Navigate(new GoalReview((int)gindex));
            
        }

        private void loadedp0age(object sender, RoutedEventArgs e)
        {
            //var namessssss = GoalEntry.goalnamess;
            //var tabItem = new TabItem();
            //tabItem.Header = namessssss;
            //tabItem.Content = " ";
            //maintabcontroal.Items.Add(tabItem);
            var g = 0;
            var x = 0;
            var w = 0;
            var nw = -630;
            var ng = -320;

            int gindex = 0;

            foreach (var goal in MainWindow.goals)
            {

                
                Button btn = new Button();
                btn.Height = 80;
                btn.Width = 150;
                
                btn.Content = goal.title;
                btn.Tag = gindex;
                btn.Background  = new SolidColorBrush(Colors.Black);
                btn.Foreground = new SolidColorBrush(Colors.White);
                btn.Click += new RoutedEventHandler(b_Click);
                listbox12.Children.Add(btn);
                gindex += 1;
            }
        }
    }
}  





