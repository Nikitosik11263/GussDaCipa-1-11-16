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
using GussDaCipa;

namespace GussDaCipa
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        List<string> genderList = new List<string>() { "Мужской", "Женский" };
        public MainWindow()
        {
            InitializeComponent();
            gender.ItemsSource = genderList;
        }

        private void Reset_Click(object sender, RoutedEventArgs e)
        {
            txtAge.Clear();
            txtHgt.Clear();
            txtMas.Clear();
            
        }

        private void Result_Click(object sender, RoutedEventArgs e)
        {
            double Mas = Convert.ToDouble(txtMas.Text);
            double Age = Convert.ToDouble(txtAge.Text);
            double Hgt = Convert.ToDouble(txtHgt.Text);

            double BMR = 0;
            if (gender.SelectedItem.ToString()=="Мужской")
            {
                BMR = 66 + (9.6 * Mas) + (5 * Hgt) - (6.8 * Age);
            }
            else
            {
                BMR = 655 + (9.6 * Mas) + (1.8 * Hgt) - (4.7 * Age);
            }
            this.Hide();
            FinalWindow final = new FinalWindow(BMR.ToString());
            final.ShowDialog();
            this.Show();
        }

        private void txtHgt_TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}
