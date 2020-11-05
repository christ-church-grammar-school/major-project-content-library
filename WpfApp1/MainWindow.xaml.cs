You can do it in XAML but I haven't tried that as you need to be able to load the XAML string you've just created and display it...  Not too hard to do really, I just haven't done it...

On the other hand; I've frequently created Buttons in code behind like this:

using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
namespace TEST
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        delegate void dlg(object sender, RoutedEventArgs e);
        private dlg bclick;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void XButton_Click(object sender, RoutedEventArgs e)
        {
            List<string> names = new List<string> { "BTN1", "BTN2", "BTN3" };
            var stuff = names.OfType<string>();
            foreach (string str in names)
            {
                Button b = new Button();
                b.Content = str;
                b.Height = 25;
                b.Width = 100;
                b.Name = str;
                b.Click += new RoutedEventHandler(b_Click);
                XStackPanel.Children.Add(b);
            }
        }
        private void b_Click(object sender, RoutedEventArgs e)
        {
            //do your button stuff here
        }
    }
}