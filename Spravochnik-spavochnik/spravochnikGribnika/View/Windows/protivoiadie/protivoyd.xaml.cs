using spravochnikGribnika.View.Pages.protivoiadie;
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

namespace spravochnikGribnika.View.Windows.protivoiadie
{
    /// <summary>
    /// Логика взаимодействия для protivoyd.xaml
    /// </summary>
    public partial class protivoyd : Window
    {
        public protivoyd(string name)
        {
            InitializeComponent();
            protiv.Navigate(new PageProtiv(name));
        }

        private void prot_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
