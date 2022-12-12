using spravochnikGribnika.View.Pages.conditionally;
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
using System.Xml.Linq;

namespace spravochnikGribnika.View.Windows.conditionally
{
    /// <summary>
    /// Логика взаимодействия для Conditionally.xaml
    /// </summary>
    public partial class Conditionally : Window
    {
        public Conditionally(string name)
        {
            InitializeComponent();
            Infom.Navigate(new PagesConditionally(name));
        }

        private void behand_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
