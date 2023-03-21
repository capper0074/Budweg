using Budweg2._1.Model;
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
    /// Interaction logic for DeleteOrder.xaml
    /// </summary>
    public partial class DeleteOrder : Window
    {
        public DeleteOrder()
        {
            InitializeComponent();
            LB_ShowOrders.Items.Clear();
            OrderController orderController = new OrderController();
            foreach (Order x in orderController.RetrieveAllOrders())
            {
                LB_ShowOrders.Items.Add(x);
            }
        }

        private void BT_DeleteOrder_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderController orderController = new OrderController();
                orderController.DeleteOrder(Convert.ToInt32(TB_OrderID.Text));
                TB_OrderID.Text = "";

            }
            catch (Exception ex)
            {
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Show();
                errorWindow.TB_Error.Text = "I am missing a OrderID";
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
