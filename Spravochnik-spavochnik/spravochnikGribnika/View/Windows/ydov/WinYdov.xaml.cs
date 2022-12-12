using spravochnikGribnika.View.Pages.ydov;
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

namespace spravochnikGribnika.View.Windows.ydov
{
    /// <summary>
    /// Логика взаимодействия для WinYdov.xaml
    /// </summary>
    public partial class WinYdov : Window
    {
        public WinYdov(string name)
        {
            InitializeComponent();
            ydovis.Navigate(new PageYdov(name));
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            GlavMenu glavMenu = new GlavMenu();
            glavMenu.Show();
            this.Close();
        }
    }
}
