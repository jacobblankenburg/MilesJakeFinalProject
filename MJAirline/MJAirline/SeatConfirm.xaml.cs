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
    public partial class Flight1 : Page
    {
        public Flight1()
        {
            InitializeComponent();
        }



        private void seatCoach_Click(object sender, RoutedEventArgs e)
        {
            CoachConfirm coachConfirm = new CoachConfirm();
            coachConfirm.Show();

        }

        private void seatFirst_Click(object sender, RoutedEventArgs e)
        {
            FirstConfirm3 firstc3 = new FirstConfirm3();
            firstc3.Show();
        }
    }
}

