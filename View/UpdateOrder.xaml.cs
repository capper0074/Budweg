﻿using Budweg2._1.Model;
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
            foreach (Order order in orderController.RetrieveAllOrders())
            {
                LB_ShowList.Items.Add(order);
            }

            object employeeId;
            employeeId = "Medarbejder Id";
            ComboBox1.Items.Add(employeeId);

            object comment;
            comment = "Kommentar";
            ComboBox1.Items.Add(comment);

            object endControl;
            endControl = "Ende kontrol";
            ComboBox1.Items.Add(endControl);

            object caliberType;
            caliberType = "Kaliber type";
            ComboBox1.Items.Add(comment);

            object caliberNumber;
            caliberNumber = "Kaliber mængde";
            ComboBox1.Items.Add(caliberNumber);

        }

        private void BT_Update_Click(object sender, RoutedEventArgs e)
        {


            OrderController oc = new OrderController();

            oc.UpdateOrder(Convert.ToInt32(TextBox_Id.Text), ComboBox1.Text, TextBox_newData.Text);


            LB_ShowList.Items.Clear();
            OrderController orderController = new OrderController();
            foreach (Order x in orderController.RetrieveAllOrders())
            {
                LB_ShowList.Items.Add(x);
            }
            TextBox_newData.Text = "";
            TextBox_Id.Text = "";

        }
        private void Close_Window_Click(object sender, RoutedEventArgs e)
        {
            MainWindow mainWindow = new MainWindow();
            mainWindow.Show();
            Close();
        }

        private void ComboBox1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}
