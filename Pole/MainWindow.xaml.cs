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

namespace Pole
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int a;
        int b;
        int[] pole = new int[10];
        List<int> seznam = new List<int>();
            
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //pole = new int[pole.Length + 1];
            Random random = new Random();
            //a = random.Next(1, 100);
            //b = random.Next(1, 100);

            //txtvypis.Text = a.ToString() + "; " + b.ToString();
            for(int i=0;i < pole.Length;i++)
            {
                pole[i] = random.Next(1, 100);
            }
            //vypsání prvků pole do stringu
            txtvypis.Text = "";
            for(int i= 0;i<pole.Length; i++)
            {
                txtvypis.Text += pole[i].ToString() + "; ";
            }
            //enter
            txtvypis.Text += "\r\n";
            txtvypis.Text += "\r\n";

            //jiný způsob vypsání prků pole do string
            txtvypis.Text += string.Join("; ", pole);

        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Random random = new Random();
            seznam.Add(random.Next(1, 100));
            txtvypis.Text = "";
            for (int i = 0; i < seznam.Count; i++)
            {
                txtvypis.Text += seznam[i].ToString() + "; ";
            }


        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            if(seznam.Count > 0)
            {
                seznam.RemoveAt(0);
            }
            txtvypis.Text = string.Join("; ", seznam);
        }
    }
}
