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

namespace spravochnikGribnika.View.Windows.programm
{
    /// <summary>
    /// Логика взаимодействия для o_prog.xaml
    /// </summary>
    public partial class o_prog : Window
    {
        public o_prog()
        {
            InitializeComponent();
        }

        private void behand_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
