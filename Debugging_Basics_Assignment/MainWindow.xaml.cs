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

namespace Debugging_Basics_Assignment
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

        private void buttonAnswer_Click(object sender, RoutedEventArgs e)
        {
            int a, b, c;
            double answer;

            // Get answer for box dimensions

            try
            {
                a = int.Parse(textBoxHeight.Text);
                b = ((int)double.Parse(textBoxWidth.Text));
                c = int.Parse(textBoxLength.Text);
                answer = a * b * c /3;
                labelAnswer.Content = answer.ToString();
            }
            catch (Exception)
            {

                labelAnswer.Content = "Error 404 Answer Is Unknown";
            }
        }
    }
}
