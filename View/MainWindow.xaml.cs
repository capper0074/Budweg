using Budweg.Models;
using Budweg.ViewModels;
using System.Windows;


namespace Budweg
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            OrderController orderController = new OrderController();
            DataContext = orderController;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            listBox1.Items.Clear();
            OrderController orderController = new OrderController();
            foreach (Order x in orderController.RetrieveAllOrders())
            {
                listBox1.Items.Add(x);
            }
        }

        private void Create_Order_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderController orderController = new OrderController();
                orderController.CreateOrder(Convert.ToInt32(TB_EmpID.Text), TB_CaTy.Text, Convert.ToInt32(TB_NumCal.Text), TB_Comm.Text);
                TB_EmpID.Text = "";
                TB_CaTy.Text = "";
                TB_NumCal.Text = "";
                TB_Comm.Text = "";
            }
            catch (Exception ex)
            {
                ErrorWindow errorWindow = new ErrorWindow();
                errorWindow.Show();
                errorWindow.TB_Error.Text = "Ups, i am missing some information";
            }

        }
    }
}
