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
    /// Логика взаимодействия для AddGroupPage.xaml
    /// </summary>
    public partial class AddGroupPage : Page
    {
        public AddGroupPage()
        {
            InitializeComponent();

            ChooseSpecializationCmb.DisplayMemberPath = "Name";
            ChooseSpecializationCmb.SelectedValuePath = "id";
            ChooseSpecializationCmb.ItemsSource = App.context.Specialization.ToList();
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (GropNameTB.Text == "")
                mes += "Введите название группы\n";
            if (ChooseSpecializationCmb.Text == "")
                mes += "Выберите специальность\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                return;
            }
            else
            {
                GroupStudent addGroup = new GroupStudent
                {
                    Name = GropNameTB.Text,
                    Specialization = ChooseSpecializationCmb.SelectedItem as Specialization
                };

                App.context.GroupStudent.Add(addGroup);
                App.context.SaveChanges();
                MessageBox.Show("Добавлена новая группа");
                GropNameTB.Text = "";
                ChooseSpecializationCmb.Text = "";
            }
        }
    }
}
