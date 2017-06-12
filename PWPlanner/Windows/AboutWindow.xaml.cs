﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using System.Windows;
using System.Windows.Documents;

namespace PWPlanner.Windows
{
    public partial class AboutWindow : Window
    {
        public AboutWindow()
        {
            InitializeComponent();
            version.Content = UpdateChecker.current;
        }

        public void forumsURL_Click(object sender, RoutedEventArgs e)
        {
            var link = (Hyperlink)sender;
            Process.Start(link.NavigateUri.ToString());
        }

        public void github_Click(object sender, RoutedEventArgs e)
        {
            var link = (Hyperlink)sender;
            Process.Start(link.NavigateUri.ToString());
        }
    }

}
