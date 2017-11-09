using System.Windows;
using System.Windows.Controls;

namespace DopravniSoutez
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        
        //Private var

        public MainWindow()
        {

            InitializeComponent();
            this.contentControl.Content = new UserControlTabsGrid();

        }

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
