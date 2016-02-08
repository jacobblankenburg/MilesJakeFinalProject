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

namespace MJAirline
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

        private void buttonCreat_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                PassengerName name = new PassengerName();
                name.Name = textBoxData1.Text;

                DatePicker date = new DatePicker();
                date.SelectedDate = DatePicker1.SelectedDate;
                date.DisplayDateStart = new DateTime(2 / 4 / 16);
                date.DisplayDateEnd = new DateTime(2 / 29 / 16);
                date.IsTodayHighlighted = true;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void FightPicker_Click(object sender, RoutedEventArgs e)
        {
            Flight flight = new Flight();
            Content = flight;
        }
    }
}
