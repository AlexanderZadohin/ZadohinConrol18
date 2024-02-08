using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using ZadohinConrol18.Model;

namespace ZadohinConrol18
{
    /// <summary>
    /// Логика взаимодействия для App.xaml
    /// </summary>
    public partial class App : Application
    {
        public static ZadohinAccountingStudentEntities context = new ZadohinAccountingStudentEntities();
    }
}
