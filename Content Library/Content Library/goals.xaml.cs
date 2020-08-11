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

namespace Content_Library
{
 

    /// <summary>

    /// Interaction logic for MainWindow.xaml

    /// </summary>

    public partial class Goals : Page

    {
        
        System.Windows.Threading.DispatcherTimer Timer = new System.Windows.Threading.DispatcherTimer();



        public Goals()

        {

            InitializeComponent();

            Timer.Tick += new EventHandler(Timer_Click);

            Timer.Interval = new TimeSpan(0, 0, 1);

            Timer.Start();

        }



        private void Timer_Click(object sender, EventArgs e)

        {

            DateTime d;

            d = DateTime.Now;

            clocklabel.Content = $"{d.Hour}:{d.Minute}:{d.Second} here is some more text";

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
    }

}  





