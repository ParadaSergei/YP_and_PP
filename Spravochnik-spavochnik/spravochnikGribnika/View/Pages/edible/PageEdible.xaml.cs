using spravochnikGribnika.Model;
using spravochnikGribnika.View.Windows.garden;
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

namespace spravochnikGribnika.View.Pages.edible
{
    /// <summary>
    /// Логика взаимодействия для PageEdible.xaml
    /// </summary>
    public partial class PageEdible : Page
    {
        private readonly PageViewModel _viewModel;

        public PageEdible(string name)
        {
            DataContext = _viewModel = new PageViewModel(name);

            InitializeComponent();

            var info = new DirectoryInfo(@"../../../spravochnikGribnika/Image/edible/");

            ObservableCollection<User> userList = new ObservableCollection<User>();

            foreach (var item in info.GetFiles())
            {


                User user = null;

                if (item.Name == "Вешенка дубовая.jpg")
                {
                    user = new User()
                    {
                        Name = "Вешенка дубовая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Вешенка ильмовая.jpg")
                {
                    user = new User()
                    {
                        Name = "Вешенка ильмовая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Вешенка обыкновенная.jpg")
                {
                    user = new User()
                    {
                        Name = "Вешенка обыкновенная",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Вешенка осенняя.jpg")
                {
                    user = new User()
                    {
                        Name = "Вешенка осенняя",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Лисичка серая.jpg")
                {
                    user = new User()
                    {
                        Name = "Лисичка серая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Масленок лиственничный.jpg")
                {
                    user = new User()
                    {
                        Name = "Масленок лиственничный",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Мокруха розовая.jpg")
                {
                    user = new User()
                    {
                        Name = "Мокруха розовая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Вешенка рожковидная.jpg")
                {
                    user = new User()
                    {
                        Name = "Вешенка рожковидная",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Рядовка пятнистая.jpg")
                {
                    user = new User()
                    {
                        Name = "Рядовка пятнистая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (user != null)
                {
                    userList.Add(user);
                }
            }

            edible.ItemsSource = userList;
        }
    }
}
