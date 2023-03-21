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
    /// Interaction logic for CreateOrder.xaml
    /// </summary>
    public partial class CreateOrder : Window
    {
        public CreateOrder()
        {
            InitializeComponent();
            
            LB_ShowList.Items.Clear();
            OrderController orderController = new OrderController();
            foreach (Order order in orderController.RetrieveAllOrders())
            {
                LB_ShowList.Items.Add(order);
            }

            orderController.GetRole(); //returns enum Role's

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

                
                LB_ShowList.Items.Clear();
                foreach (Order order in orderController.RetrieveAllOrders())
                {
                    LB_ShowList.Items.Add(order);
                }

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
