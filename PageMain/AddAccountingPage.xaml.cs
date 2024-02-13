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
using ZadohinConrol18.Model;

namespace ZadohinConrol18.PageMain
{
    /// <summary>
    /// Логика взаимодействия для AddAccountingPage.xaml
    /// </summary>
    public partial class AddAccountingPage : Page
    {
        public AddAccountingPage()
        {
            InitializeComponent();


            ActivityCmb.SelectedValuePath = "id";
            ActivityCmb.DisplayMemberPath = "Name";
            ActivityCmb.ItemsSource = App.context.ActivityStudent.ToList();

            DirectionsCmb.SelectedValuePath = "id";
            DirectionsCmb.DisplayMemberPath = "Name";
            DirectionsCmb.ItemsSource = App.context.Directions.ToList();

            GroupCmb.SelectedValuePath = "id";
            GroupCmb.DisplayMemberPath = "Name";
            GroupCmb.ItemsSource = App.context.GroupStudent.ToList();

            SpecializationCmb.SelectedValuePath = "id";
            SpecializationCmb.DisplayMemberPath = "Name";
            SpecializationCmb.ItemsSource = App.context.Specialization.ToList();
        }


        private void AddAccountingBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (string.IsNullOrWhiteSpace(ActivityCmb.Text))
                mes += "Выберите мероприятие\n";
            if (string.IsNullOrWhiteSpace(DirectionsCmb.Text))
                mes += "Выберите направление\n";
            if (string.IsNullOrWhiteSpace(GroupCmb.Text))
                mes += "Выберите группу\n";
            if (string.IsNullOrWhiteSpace(SpecializationCmb.Text))
                mes += "Выберите специальность\n";
            if (string.IsNullOrWhiteSpace(DTPicker.Text))
                mes += "Выберите Дату\n";
            if (string.IsNullOrWhiteSpace(PriceTb.Text))
                mes += "Введите балл\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                mes = "";
                return;
            }
            AccountingCollege addUcet = new AccountingCollege
            {
                GroupStudent = GroupCmb.SelectedItem as GroupStudent,
                ActivityStudent = ActivityCmb.SelectedItem as ActivityStudent,
                DateEvaluation = Convert.ToDateTime(DTPicker.Text),
                Evaluation = Convert.ToInt32(PriceTb.Text)
            };
            App.context.AccountingCollege.Add(addUcet);
            App.context.SaveChanges();
            MessageBox.Show("Запис добавлена");

            PriceTb.Text = "";
            DTPicker.Text = "";
            ActivityCmb.Text = "";
            DirectionsCmb.Text = "";
            GroupCmb.Text = "";
            SpecializationCmb.Text = "";

        }

        private void SpecializationCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedSP = Convert.ToInt32(SpecializationCmb.SelectedValue);
            GroupCmb.ItemsSource = App.context.GroupStudent.Where(g => g.Specialization.id == selectedSP).ToList();
        }

        private void DirectionsCmb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int selectedDR = Convert.ToInt32(DirectionsCmb.SelectedValue);
            ActivityCmb.ItemsSource = App.context.ActivityStudent.Where(g => g.Directions.id == selectedDR).ToList();
        }
    }
}
