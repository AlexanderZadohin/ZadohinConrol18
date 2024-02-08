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
    /// Логика взаимодействия для AddActivityPage.xaml
    /// </summary>
    public partial class AddActivityPage : Page
    {
        public AddActivityPage()
        {
            InitializeComponent();

            ChooseDirectionsCmb.DisplayMemberPath = "Name";
            ChooseDirectionsCmb.SelectedValuePath = "id";
            ChooseDirectionsCmb.ItemsSource = App.context.Directions.ToList();
        }

        private void AddProductBtn_Click(object sender, RoutedEventArgs e)
        {
            string mes = "";
            if (ActivityNameTB.Text == "")
                mes += "Введите название мероприятия\n";
            if (ChooseDirectionsCmb.Text == "")
                mes += "Выберите направленность\n";
            if (mes != "")
            {
                MessageBox.Show(mes);
                return;
            }
            else
            {
                ActivityStudent addActivity = new ActivityStudent
                {
                    Name = ActivityNameTB.Text,
                    Directions = ChooseDirectionsCmb.SelectedItem as Directions
                };

                App.context.ActivityStudent.Add(addActivity);
                App.context.SaveChanges();
                MessageBox.Show("Добавлено новое мероприятие");
                ActivityNameTB.Text = "";
                ChooseDirectionsCmb.Text = "";
            }
        }
    }
}
