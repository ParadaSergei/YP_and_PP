using spravochnikGribnika.Model;
using spravochnikGribnika.View.Windows.False;
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

namespace spravochnikGribnika.View.Pages.falses
{
    /// <summary>
    /// Логика взаимодействия для Pagefalses.xaml
    /// </summary>
    public partial class Pagefalses : Page
    {

        private readonly PageViewModel _viewModel;

        
        public Pagefalses(string name)
        {
            DataContext = _viewModel = new PageViewModel(name);

            InitializeComponent();

            var info = new DirectoryInfo(@"../../../spravochnikGribnika/Image/false/");

            ObservableCollection<User> userList = new ObservableCollection<User>();

            foreach (var item in info.GetFiles())
            {


                User user = null;

                if (item.Name == "Ложная лисичка.jpg")
                {
                    user = new User()
                    {
                        Name = "Ложная лисичка",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Ложный белый.jpg")
                {
                    user = new User()
                    {
                        Name = "Ложный белый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Ложный валуй.jpg")
                {
                    user = new User()
                    {
                        Name = "Ложный валуй",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Опёнок серно-жёлтый.jpg")
                {
                    user = new User()
                    {
                        Name = "Опёнок серно-жёлтый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Рядовка мыльная.jpg")
                {
                    user = new User()
                    {
                        Name = "Рядовка мыльная",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Рядовка отличающаяся.jpg")
                {
                    user = new User()
                    {
                        Name = "Рядовка отличающаяся",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Сатаниский гриб .jpg")
                {
                    user = new User()
                    {
                        Name = "Сатаниский гриб",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Дубовик укорененный.jpg")
                {
                    user = new User()
                    {
                        Name = "Дубовик укорененный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }         
                if (user != null)
                {
                    userList.Add(user);
                }
            }

            fasles.ItemsSource = userList;
        }
    }
}
