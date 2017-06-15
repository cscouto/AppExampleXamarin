using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using WinPhoneExample.Resources;

namespace WinPhoneExample
{
    public partial class MainPage : PhoneApplicationPage
    {
        int count = 1;
        // Constructor
        public MainPage()
        {
            
            InitializeComponent();

        }

        private void btHello_Click(object sender, RoutedEventArgs e)
        {
            btHello.Content = string.Format("{0} clicks!", count++);
        }

    }
}