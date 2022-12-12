using spravochnikGribnika.View.Pages.falses;
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

namespace spravochnikGribnika.View.Windows.False
{
    /// <summary>
    /// Логика взаимодействия для falsess.xaml
    /// </summary>
    public partial class falsess : Window
    {
        public falsess(string name)
        {
            InitializeComponent();
            falseer.Navigate(new Pagefalses(name));
        }

        private void behand_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
