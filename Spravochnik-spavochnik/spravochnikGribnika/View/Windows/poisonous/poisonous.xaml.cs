
using spravochnikGribnika.View.Pages.poisonous;
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

namespace spravochnikGribnika.View.Windows.poisonous
{
    /// <summary>
    /// Логика взаимодействия для poisonous.xaml
    /// </summary>
    public partial class poisonous : Window
    {
        public poisonous(string name)
        {
            InitializeComponent();
            Infa.Navigate(new Poisonous(name));
        }

        private void Behand_Click(object sender, RoutedEventArgs e)
        {

            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
