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

namespace WPF4
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

        private void DollarsToRubles_Click(object sender, RoutedEventArgs e)
        {
            double rateDollar = Convert.ToDouble(dollarRate.Text);
            double sumDollar = Convert.ToDouble(dollarSum.Text);
            double resDouble = rateDollar * sumDollar;
            resSumDollar.Text = resDouble.ToString();
        }

        private void EuroToRubles_Click(object sender, RoutedEventArgs e)
        {
            double rateEuro = Convert.ToDouble(euroRate.Text);
            double sumEuro = Convert.ToDouble(euroSum.Text);
            double resEuro = rateEuro * sumEuro;
            resSumEuro.Text = resEuro.ToString();
        }

        private void hryvniaToRubles_Click(object sender, RoutedEventArgs e)
        {
            double rateHryvnia = Convert.ToDouble(hryvniaRate.Text);
            double sumHryvnia = Convert.ToDouble(hryvniaSum.Text);
            double resHryvnia = rateHryvnia * sumHryvnia;
            resSumHryvnia.Text = resHryvnia.ToString();
        }

        private void dramaToRubles_Click(object sender, RoutedEventArgs e)
        {
            double rateDrama = Convert.ToDouble(dramaRate.Text);
            double sumDrama = Convert.ToDouble(dramaSum.Text);
            double resDrama = rateDrama * sumDrama;
            resSumDrama.Text = resDrama.ToString();
        }

        private void inchToMeters_Click(object sender, RoutedEventArgs e)
        {
            double Inch = Convert.ToDouble(inch.Text);
            double ResInch = Inch * 0.0254;
            resInch.Text = ResInch.ToString();
        }

        private void feetToMeters_Click(object sender, RoutedEventArgs e)
        {
            double Feet = Convert.ToDouble(feet.Text);
            double ResFeet = Feet * 0.3048;
            resFeet.Text = ResFeet.ToString();
        }

        private void mileToMeters_Click(object sender, RoutedEventArgs e)
        {
            double Mile = Convert.ToDouble(mile.Text);
            double ResMile = Mile * 1609.34;
            resMile.Text = ResMile.ToString();
        }

        private void verstToMeters_Click(object sender, RoutedEventArgs e)
        {
            double Verst = Convert.ToDouble(verst.Text);
            double ResVerst = Verst * 1066.8;
            resVerst.Text = ResVerst.ToString();
        }
    }
}
