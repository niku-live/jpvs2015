using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

namespace PhoneApp1
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();

            ApplicationTitle.Text = "Testas";
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            ApplicationTitle.Text = "Paspaustas";
            NavigationService.Navigate(new Uri("/Panorama.xaml", UriKind.RelativeOrAbsolute));
        }
    }
}