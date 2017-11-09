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

namespace DopravniSoutez
{
    /// <summary>
    /// Interaction logic for UserControlTabsGrid.xaml
    /// </summary>
    public partial class UserControlTabsGrid : UserControl
    {
        NorthwindDataSet ds;
        public UserControlTabsGrid()
        {
            InitializeComponent();

            ds = new NorthwindDataSet();
            NorthwindDataSetTableAdapters.CustomersTableAdapter customerAdapter =
                    new NorthwindDataSetTableAdapters.CustomersTableAdapter();

            //Populate adapter
            customerAdapter.Fill(ds.Customers);

            //Bind adapter to datagrid
            dataGrid1.ItemsSource = ds.Customers.DefaultView;
        }
    }
}
