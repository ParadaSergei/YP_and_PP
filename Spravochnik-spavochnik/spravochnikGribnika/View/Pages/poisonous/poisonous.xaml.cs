using spravochnikGribnika.Model;
using spravochnikGribnika.View.Windows;
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

namespace spravochnikGribnika.View.Pages.poisonous
{
    /// <summary>
    /// Логика взаимодействия для poisonous.xaml
    /// </summary>
    public partial class Poisonous : Page
    {
        private readonly PageViewModel _viewModel;
        public Poisonous(string name)
        {
            DataContext = _viewModel = new PageViewModel(name);

            InitializeComponent();

            var info = new DirectoryInfo(@"../../../spravochnikGribnika/Image/poisonous/");

            ObservableCollection<User> userList = new ObservableCollection<User>();

            foreach (var item in info.GetFiles())
            {
                

                User user = null;

                if (item.Name == "Белый гриб березовый.jpg")
                {
                     user = new User()
                    {
                        Name = "Белый гриб березовый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Белый гриб боровик.jpg")
                {
                    user = new User()
                    {
                        Name = "Белый гриб боровик",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if(item.Name == "Белый гриб дубовый.jpg")
                {
                   user = new User()
                    {
                        Name = "Белый гриб дубовый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Белый гриб медный.jpg")
                {
                    user = new User()
                    {
                        Name = "Белый гриб медный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Белый гриб сосновый.jpg")
                {
                    user = new User()
                    {
                        Name = "Белый гриб сосновый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Груздь желтый.jpg")
                {
                    user = new User()
                    {
                        Name = "Груздь желтый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Белый гриб еловый.jpg")
                {
                    user = new User()
                    {
                        Name = "Белый гриб еловый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Груздь белый.jpg")
                {
                    user = new User()
                    {
                        Name = "Груздь белый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Рыжик настоящий еловый.jpg")
                {
                    user = new User()
                    {
                        Name = "Рыжик настоящий еловый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (user != null)
                {
                    userList.Add(user);
                }                
            }

            menus.ItemsSource = userList;
        }

       
    }
}
