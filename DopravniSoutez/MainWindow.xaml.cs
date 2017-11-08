using System;
using System.Collections.Generic;
using System.Data;
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

namespace DopravniSoutez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        //NorthwindDataSet ds;

        // Private var

        public MainWindow()
        {
            InitializeComponent();
            this.contentControl.Content = new UserControlTabsGrid();

            //Create new DataSeta
            //ds = new NorthwindDataSet();

            ////Create table adapter for Customers
            //NorthwindDataSetTableAdapters.CustomersTableAdapter customerAdapter =
            //        new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            ////Populate adapter
            //customerAdapter.Fill(ds.Customers);

            ////Bind adapter to datagrid
            //dataGrid1.ItemsSource = ds.Customers.DefaultView;
        }

        //private void TreeViewItem_MouseDoubleClick_Mapa(object sender, MouseButtonEventArgs e)
        //{
        //    this.contentControl.Content = new UserControlGrid();
        //}

        private void treeView_SelectedItemChanged(object sender, RoutedPropertyChangedEventArgs<object> e)
        {

            if (((TreeViewItem) e.NewValue).Name == "Mapa")
            {
                this.contentControl.Content = new UserControlGrid();
            }
            else
            {
                this.contentControl.Content = new UserControlTabsGrid();
            }
        }



        //private void dataGrid1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        //{
        //    //Get selected Row
        //    DataRowView row = (DataRowView)dataGrid1.SelectedItem;

        //    //Get selected Row Cell base on which the datagrid will be changed
        //    string customerId = row.Row["CustomerID"].ToString();

        //    //Check if everything is OK
        //    if (customerId == null || customerId == string.Empty)
        //    {
        //        return;
        //    }

        //    //Change view based on RowFilet
        //    DataView view = ds.Orders.DefaultView;
        //    view.RowFilter = string.Format("CustomerID='{0}'", customerId);
        //}
    }
}
