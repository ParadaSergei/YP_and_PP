using spravochnikGribnika.View.Pages.inedible;
using spravochnikGribnika.View.Pages.poisonous;
using spravochnikGribnika.View.Windows.False;
using spravochnikGribnika.View.Windows.garden;
using spravochnikGribnika.View.Windows.programm;
using spravochnikGribnika.View.Windows.protivoiadie;
using spravochnikGribnika.View.Windows.ydov;
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

namespace spravochnikGribnika.View.Windows
{
    /// <summary>
    /// Логика взаимодействия для GlavMenu.xaml
    /// </summary>
    public partial class GlavMenu : Window
    {
        public GlavMenu()
        {
            InitializeComponent();
        }

        private void Vkus_Click(object sender, RoutedEventArgs e)
        {
            poisonous.poisonous poisonous = new poisonous.poisonous((sender as Button).Name);
            poisonous.Show();
            this.Close();
        }

        private void inedible_Click(object sender, RoutedEventArgs e)
        {
            inedible.inedible inedibles = new inedible.inedible((sender as Button).Name);
            inedibles.Show();
            this.Close();
        }
         private void conditionally_Click(object sender, RoutedEventArgs e)
        {
            conditionally.Conditionally inedibles = new conditionally.Conditionally((sender as Button).Name);
            inedibles.Show();
            this.Close();
        }

        private void ogorod_Click(object sender, RoutedEventArgs e)
        {
            Garden garden = new Garden((sender as Button).Name);
            garden.Show();
            this.Close();
        }

        private void edible_Click(object sender, RoutedEventArgs e)
        {
            edible.edible edible = new edible.edible((sender as Button).Name);
            edible.Show();
            this.Close();
            
        }

        private void false_Click(object sender, RoutedEventArgs e)
        {
            falsess fales =new falsess((sender as Button).Name);
            fales.Show();
            this.Close();

        }

        private void ydov_Click(object sender, RoutedEventArgs e)
        {
            WinYdov ydovs = new WinYdov((sender as Button).Name);
            ydovs.Show();
            this.Close();
        }
        private void vs_Click(object sender, RoutedEventArgs e)
        {
            protivoyd ydovs = new protivoyd((sender as Button).Name);
            ydovs.Show();
            this.Close();
        }

        private void oprog_Click(object sender, RoutedEventArgs e)
        {
            o_prog Prog = new o_prog();
            Prog.Show();
            this.Close();
        }
    }
}
