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

namespace ZadohinConrol18.PageMain
{
    /// <summary>
    /// Логика взаимодействия для MenuPage.xaml
    /// </summary>
    public partial class MenuPage : Page
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private void AddGroupBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.AddGroupPage());
        }

        private void AccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.AccountingStudent());
        }

        private void AddActivityBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.AddActivityPage());
        }

        private void AddAccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.AddAccountingPage());
        }

        private void SecAccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.ReportPage());
        }
    }
}
