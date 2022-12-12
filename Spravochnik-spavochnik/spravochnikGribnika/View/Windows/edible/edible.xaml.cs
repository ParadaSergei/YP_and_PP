using spravochnikGribnika.View.Pages.edible;
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

namespace spravochnikGribnika.View.Windows.edible
{
    /// <summary>
    /// Логика взаимодействия для edible.xaml
    /// </summary>
    public partial class edible : Window
    {
        public edible(string name)
        {
            InitializeComponent();
            edibles.Navigate(new PageEdible(name));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
