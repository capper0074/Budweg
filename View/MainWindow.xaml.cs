using Budweg2._1.Model;
using Budweg2._1.View;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Budweg2._1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            listBox1.Items.Clear();
            OrderController orderController = new OrderController();
            foreach (Order x in orderController.RetrieveAllOrders())
            {
                listBox1.Items.Add(x);
            }
        }

        private void Create_Order_Click(object sender, RoutedEventArgs e)
        {
            CreateOrder createOrder = new CreateOrder();
            Close();
            createOrder.Show();
        }

        private void Delete_Order_Click(object sender, RoutedEventArgs e)
        {
            DeleteOrder deleteOrder = new DeleteOrder(); 
            Close();
            deleteOrder.Show();
        }

        private void UpdateOrder_Click(object sender, RoutedEventArgs e)
        {
            UpdateOrder updateOrder = new UpdateOrder();
            Close();
            updateOrder.Show();
        }
    }
}
