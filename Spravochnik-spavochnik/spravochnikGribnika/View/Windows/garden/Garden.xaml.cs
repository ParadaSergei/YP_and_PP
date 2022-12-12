using spravochnikGribnika.View.Pages.garden;
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

namespace spravochnikGribnika.View.Windows.garden
{
    /// <summary>
    /// Логика взаимодействия для Garden.xaml
    /// </summary>
    public partial class Garden : Window
    {
        
        public Garden(string name)
        {
            InitializeComponent();
            ogor.Navigate(new PageGrden(name));
        }

        private void Behaind_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
