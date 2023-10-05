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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PrintPrice
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Entities db;
        public MainWindow()
        {
            InitializeComponent();
            Refresh();
        }
        public void Refresh()
        {
            db = new Entities();
            dgItems.ItemsSource = db.Products.ToList();
        }
        private void dgItems_MouseDoubleClick(object sender, MouseButtonEventArgs e)
        {
            if(dgItems.SelectedValue is null)
            {
                MessageBox.Show("Выберите объект!");
                return;
            }
            var item = (Products)dgItems.SelectedValue;
            var newWin = new PrintWindow(item);
            newWin.ShowDialog();
        }
    }
}
