using PrintPrice.Database;
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
using PrintPrice.Database;
namespace PrintPrice
{
    /// <summary>
    /// Логика взаимодействия для PrintWindow.xaml
    /// </summary>
    public partial class PrintWindow : Window
    {
        public PrintWindow(Products product)
        {
            InitializeComponent();
            txtName.Text = new Helper().BrendWord(product.name);
            txtCompos.Text = new Helper().InsertEnter(product.composition);
            txtDep.Text = new Helper().DeleteDuplicate(product.department);
            txtOrg.Text = new Helper().GetOrganizationalForm(product.organization);
            txtPrice.Text = new Helper().SplitTriads(product.price.ToString());
            txtUnit.Text =  new Helper().ShortWord(product.unitMeasurement);
            txtBrand.Text = new Helper().GetBrend(product.organization);
        }
    }
}
