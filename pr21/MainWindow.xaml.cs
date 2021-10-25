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

namespace pr21
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
        int[] mas;
        private void zapoln_Click(object sender, RoutedEventArgs e)
        {
            int randMax = Convert.ToInt32(TB2.Text);
            int Count = Convert.ToInt32(columnCount.Text);
            mas = new int[Count];
            Random Rand = new Random();
            for (int i = 0; i < mas.Length; i++) mas[i] = Rand.Next(-randMax,randMax);
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            dataGrid.ItemsSource = null;
            mas = null;
        }

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void sozd_Click(object sender, RoutedEventArgs e)
        {
            int Count = Convert.ToInt32(columnCount.Text);
            mas = new int[Count];
            dataGrid.ItemsSource = VisualArray.ToDataTable(mas).DefaultView;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {  double g=0;
            for (int i = 0; i < mas.Length; i++)
            {
                if (mas[i] < 3)
                {
                  
                    g += mas[i];
                   

                   
                }
            } LB1.Items.Add(Math.Cos(g));
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
    

