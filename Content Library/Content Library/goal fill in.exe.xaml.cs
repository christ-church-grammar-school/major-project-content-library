﻿using System;
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
    public partial class Page3 : Page
    {
        public Page3()
        {
            InitializeComponent();
        }

        private void add_1(object sender, RoutedEventArgs e)
        {
            {

                CheckBox btn = new CheckBox();

                btn.Height = 50;

                btn.Width = 100;


                btn.Content = newname.Text;

                btn.Background = new SolidColorBrush(Colors.Orange);

                btn.Foreground = new SolidColorBrush(Colors.Black);

                doxx.Children.Add(btn);

            }
        }
    }
}
