using spravochnikGribnika.Model;
using spravochnikGribnika.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace spravochnikGribnika.View.Pages.inedible
{
    /// <summary>
    /// Логика взаимодействия для Pageinedible.xaml
    /// </summary>
    public partial class Pageinedible : Page
    {
        private readonly PageViewModel _viewModel;

        public Pageinedible(string name)
        {
            DataContext = _viewModel = new PageViewModel(name);

            InitializeComponent();

            var info = new DirectoryInfo(@"../../../spravochnikGribnika/Image/inedible/");

            ObservableCollection<User> userList = new ObservableCollection<User>();

            foreach (var item in info.GetFiles())
            {


                User user = null;

                if (item.Name == "Гигроцибе красная.jpg")
                {
                    user = new User()
                    {
                        Name = "Гигроцибе красная",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Ложнодождевик бородавчатый.jpg")
                {
                    user = new User()
                    {
                        Name = "Ложнодождевик бородавчатый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Лопастник курчавый.jpg")
                {
                    user = new User()
                    {
                        Name = "Лопастник курчавый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Паутинник козлиный.jpg")
                {
                    user = new User()
                    {
                        Name = "Паутинник козлиный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Паутинник полускрученный.jpg")
                {
                    user = new User()
                    {
                        Name = "Паутинник полускрученный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Рогатик желтый.jpg")
                {
                    user = new User()
                    {
                        Name = "Рогатик желтый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Рогатик крыночковидный.jpg")
                {
                    user = new User()
                    {
                        Name = "Рогатик крыночковидный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Ложнодождевик.jpg")
                {
                    user = new User()
                    {
                        Name = "Ложнодождевик",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Паутинник камфорный.jpg")
                {
                    user = new User()
                    {
                        Name = "Паутинник камфорный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (user != null)
                {
                    userList.Add(user);
                }
            }

            ner.ItemsSource = userList;
        }
    }
}
