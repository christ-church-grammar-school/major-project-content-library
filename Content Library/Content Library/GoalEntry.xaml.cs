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
    public partial class GoalEntry : Page
    {
        public static string goalnamess;
        public GoalEntry()
        {
            InitializeComponent();

            goalnamess = "We did it!";
        }
   
        public void Clickcomit(object sender, RoutedEventArgs e)
        {
            Goal g = new Goal(goalname.Text);

            g.activites.Add(new Activity(activityone.Text));
            g.activites.Add(new Activity(activitytwo.Text));
            g.activites.Add(new Activity(activitythree.Text));

            MainWindow.goals.Add(g);

            //List<string> goals = new List<string> {goalnames ,goalhelper1 , goalhelper2 ,goalhelper3 };

            //MainWindow.importantdata.Add(goals);

            //goalnamess = goalnames;

            
            this.NavigationService.Navigate(new Goals());
        }

        private void goalname_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }    
    
}