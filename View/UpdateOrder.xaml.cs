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
    /// Interaction logic for UpdateOrder.xaml
    /// </summary>
    public partial class UpdateOrder : Window
    {
        public UpdateOrder()
        {
            InitializeComponent();
            LB_ShowList.Items.Clear();
            OrderController orderController = new OrderController();
            foreach (Order x in orderController.RetrieveAllOrders())
            {
                LB_ShowList.Items.Add(x);
            }
        }

        private void BT_Update_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
