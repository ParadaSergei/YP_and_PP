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

namespace spravochnikGribnika.View.Pages.ydov
{
    /// <summary>
    /// Логика взаимодействия для PageYdov.xaml
    /// </summary>
    public partial class PageYdov : Page
    {
        private readonly PageViewModel _viewModel;

        public PageYdov(string name)
        {
            DataContext = _viewModel = new PageViewModel(name);

            InitializeComponent();

            var info = new DirectoryInfo(@"../../../spravochnikGribnika/Image/Ydov/");

            ObservableCollection<User> userList = new ObservableCollection<User>();

            foreach (var item in info.GetFiles())
            {


                User user = null;

                if (item.Name == "Бледная поганка.jpg")
                {
                    user = new User()
                    {
                        Name = "Бледная поганка",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Волоконница волокнистая.jpg")
                {
                    user = new User()
                    {
                        Name = "Волоконница волокнистая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Волоконница земляная.jpg")
                {
                    user = new User()
                    {
                        Name = "Волоконница земляная",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Волоконница острая.jpg")
                {
                    user = new User()
                    {
                        Name = "Волоконница острая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Волоконница патуйяра (краснеющая).jpg")
                {
                    user = new User()
                    {
                        Name = "Волоконница патуйяра (краснеющая)",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Гебелома горчичная.jpg")
                {
                    user = new User()
                    {
                        Name = "Гебелома горчичная",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Говорушка восковатая.jpg")
                {
                    user = new User()
                    {
                        Name = "Говорушка восковатая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Мицена чистая.jpg")
                {
                    user = new User()
                    {
                        Name = "Мицена чистая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Мухомор красный.jpg")
                {
                    user = new User()
                    {
                        Name = "Мухомор красный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (user != null)
                {
                    userList.Add(user);
                }
            }

            ydov.ItemsSource = userList;
        }
    }
}
