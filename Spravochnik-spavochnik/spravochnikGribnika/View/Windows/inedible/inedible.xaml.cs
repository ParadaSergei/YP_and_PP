using spravochnikGribnika.View.Pages.inedible;
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

namespace spravochnikGribnika.View.Windows.inedible
{
    /// <summary>
    /// Логика взаимодействия для inedible.xaml
    /// </summary>
    public partial class inedible : Window
    {
        public inedible(string name)
        {
            InitializeComponent();
            Infar.Navigate(new Pageinedible(name));
        }
        private void Behand_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
