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
    /// Логика взаимодействия для ReportPage.xaml
    /// </summary>
    public partial class ReportPage : Page
    {
        public ReportPage()
        {
            InitializeComponent();
            SpecialCmb.DisplayMemberPath = "Name";
            SpecialCmb.SelectedValuePath = "id";
            SpecialCmb.ItemsSource = App.context.Specialization.ToList();
        }

        private void Search_Click(object sender, RoutedEventArgs e)
        {
            int selectedDS = Convert.ToInt32(SpecialCmb.SelectedValue);

            DataGridInfo.ItemsSource = App.context.GroupStudent.Where(x => x.idSpecialization == selectedDS).ToList();
        }

        private void SpisocBtn_Click(object sender, RoutedEventArgs e)
        {
            ClassFrame.FrameBody.Navigate(new PageMain.PageValueReport((sender as Button).DataContext as GroupStudent));
        }
    }
}
