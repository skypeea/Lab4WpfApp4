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

namespace lab4WpfApp
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(rate.Text);
            double sumDollar = Convert.ToDouble(sum.Text);
            double resDouble1 = rateDollar * sumDollar;
            resSum.Text = resDouble1.ToString();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            double rateEvro = Convert.ToDouble(rate2.Text);
            double sumEvro = Convert.ToDouble(sum2.Text);
            double resDouble2 = rateEvro * sumEvro;
            resSum2.Text = resDouble2.ToString();
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            double rateGrivni = Convert.ToDouble(rate3.Text);
            double sumGrivni = Convert.ToDouble(sum3.Text);
            double resDouble3 = rateGrivni * sumGrivni;
            resSum3.Text = resDouble3.ToString();
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            double rateDrami = Convert.ToDouble(rate4.Text);
            double sumDrami = Convert.ToDouble(sum4.Text);
            double resDouble4 = rateDrami * sumDrami;
            resSum4.Text = resDouble4.ToString();
        }

        private void Button_Click_4(object sender, RoutedEventArgs e)
        {
            double rateLenght = Convert.ToDouble(lenght1.Text);
            double resDouble5 = rateLenght * 0.0254;
            resLenght.Text = resDouble5.ToString();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            double rateLenght2 = Convert.ToDouble(lenght2.Text);
            double resDouble6 = rateLenght2 * 0.3048;
            resLenght2.Text = resDouble6.ToString();
        }

        private void Button_Click_6(object sender, RoutedEventArgs e)
        {
            double rateLenght3 = Convert.ToDouble(lenght3.Text);
            double resDouble7 = rateLenght3 * 1609.34;
            resLenght3.Text = resDouble7.ToString();
        }

        private void Button_Click_7(object sender, RoutedEventArgs e)
        {
            double rateLenght4 = Convert.ToDouble(lenght4.Text);
            double resDouble8 = rateLenght4 * 1066.8;
            resLenght4.Text = resDouble8.ToString();
        }
    }
}
