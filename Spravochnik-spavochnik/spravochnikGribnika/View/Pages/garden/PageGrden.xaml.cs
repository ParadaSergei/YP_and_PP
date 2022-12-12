using spravochnikGribnika.Model;
using spravochnikGribnika.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.ConstrainedExecution;
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

namespace spravochnikGribnika.View.Pages.garden
{
    /// <summary>
    /// Логика взаимодействия для PageGrden.xaml
    /// </summary>
    public partial class PageGrden : Page
    {
        private readonly PageViewModel _viewModel;
        public PageGrden(string name)
        {
            DataContext = _viewModel = new PageViewModel(name);

            InitializeComponent();

            var info = new DirectoryInfo(@"../../../spravochnikGribnika/Image/Ogorod/");

            ObservableCollection<User> userList = new ObservableCollection<User>();

            foreach (var item in info.GetFiles())
            {


                User user = null;

                if (item.Name == "Вешенка.jpg")
                {
                    user = new User()
                    {
                        Name = "Вешенка",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Лисичка.jpg")
                {
                    user = new User()
                    {
                        Name = "Лисичка",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Маслёнок.jpg")
                {
                    user = new User()
                    {
                        Name = "Маслёнок",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Подберезовик.jpg")
                {
                    user = new User()
                    {
                        Name = "Подберезовик",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Подосиновик.jpg")
                {
                    user = new User()
                    {
                        Name = "Подосиновик",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Трюфель.jpg")
                {
                    user = new User()
                    {
                        Name = "Трюфель",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Шампиньон.jpg")
                {
                    user = new User()
                    {
                        Name = "Шампиньон",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Опёнок зимний.jpg")
                {
                    user = new User()
                    {
                        Name = "Опёнок зимний",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Шиитаке.jpg")
                {
                    user = new User()
                    {
                        Name = "Шиитаке",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (user != null)
                {
                    userList.Add(user);
                }
            }

            grden.ItemsSource = userList;
        }
    }
}
