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
    /// Interaction logic for Page2.xaml
    /// </summary>
    public partial class Page2 : Page
    {
        public Page2()
        {
            InitializeComponent();
        }

        private void clickcomit(object sender, RoutedEventArgs e)
        {
            
           string goalnames = goalname.Text;
            string goalhelper1 = activityone.Text;
            string goalhelper2 = activitytwo.Text;
            string goalhelper3 = activitythree.Text;
            List<string> goals = new List<string> {goalnames ,goalhelper1 , goalhelper2 ,goalhelper3 };

            MainWindow.importantdata.Add(goals);

            

            
            this.NavigationService.Navigate(new Page1());
        }
    }
}
