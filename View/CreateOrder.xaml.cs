using Budweg2._1.ViewModel;
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
using System.Windows.Shapes;

namespace Budweg2._1.View
{
    /// <summary>
    /// Interaction logic for CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : Window
    {
        public CreateOrder()
        {
            InitializeComponent();
        }

        private void BT_Create_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderController orderController = new OrderController();
                orderController.CreateOrder(Convert.ToInt32(TB_EmpID.Text), TB_CaTy.Text, Convert.ToInt32(TB_NumCal.Text), TB_Comm.Text);
                TB_EmpID.Text = "";
                TB_CaTy.Text = "";
                TB_NumCal.Text = "";
                TB_Comm.Text = "";
                MainWindow mainWindow = new MainWindow();
                Close();
                mainWindow.Show();
            }
            catch (Exception)
            {
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Show();
                errorWindow.TB_Error.Text = "Ups, i am missing some information";
            }
        }
        private void Close_Window_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }
    }
}
