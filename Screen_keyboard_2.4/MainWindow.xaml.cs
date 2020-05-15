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

namespace Screen_keyboard_2._4
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonShift.Content.ToString() == "shift" && ButtonCapslock.Content.ToString() == "capslock")
            {

                textbox.Text += string.Format("{0}", (sender as Button).Content.ToString().ToLower());
            }
            else
            {

                textbox.Text += string.Format("{0}", (sender as Button).Content.ToString().ToUpper());
            }
            ButtonShift.Content = "shift";
        }

        private void ButtonCapslock_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonCapslock.Content.ToString() == "CAPSLOCK")
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToLower();
            }
            else
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToUpper();
            }
        }

        private void ButtonShift_Click(object sender, RoutedEventArgs e)
        {
            if (ButtonShift.Content.ToString() == "SHIFT")
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToLower();
            }
            else
            {
                (sender as Button).Content = (sender as Button).Content.ToString().ToUpper();
            }
        }

        private void ButtonSpace_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text += string.Format("{0}", " ");
        }

        private void ButtonInter_Click(object sender, RoutedEventArgs e)
        {
            textbox.Text += Environment.NewLine;
          }

    }   
}
