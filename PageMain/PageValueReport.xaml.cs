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
using ZadohinConrol18.Class;
using ZadohinConrol18.Model;

namespace ZadohinConrol18.PageMain
{
    /// <summary>
    /// Логика взаимодействия для PageValueReport.xaml
    /// </summary>
    public partial class PageValueReport : Page
    {
        public PageValueReport(GroupStudent group)
        {
            InitializeComponent();

            GridJournal.ItemsSource = App.context.AccountingCollege.Where(x => x.idGroup == group.id).ToList();
        }

        private void ReportBtn_Click(object sender, RoutedEventArgs e)
        {
            PrintDialog printDialog = new PrintDialog();
            if (printDialog.ShowDialog() == true) printDialog.PrintVisual(GridJournal,"Баллы");
        }
    }
}
