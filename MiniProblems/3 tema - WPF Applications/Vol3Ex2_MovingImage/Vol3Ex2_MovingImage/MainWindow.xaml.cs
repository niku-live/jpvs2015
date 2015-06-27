using System;
using System.Collections;
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
using System.Windows.Media.Animation;

namespace Vol3Ex2_MovingImage
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            var enumerator = Resources.GetEnumerator();
            Storyboard storyboard = (from r in Resources.OfType<DictionaryEntry>() where r.Key.ToString() == "MovingImage" select r.Value).FirstOrDefault() as Storyboard;
            if (storyboard != null)
            {
                storyboard.Begin();
            }
        }
    }
}
