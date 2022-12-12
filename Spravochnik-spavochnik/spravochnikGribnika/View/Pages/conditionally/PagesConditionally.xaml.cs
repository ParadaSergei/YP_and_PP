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

namespace spravochnikGribnika.View.Pages.conditionally
{
    /// <summary>
    /// Логика взаимодействия для PagesConditionally.xaml
    /// </summary>
    public partial class PagesConditionally : Page
    {
        private readonly PageViewModel _viewModel;

        public PagesConditionally(string name)
        {
            DataContext = _viewModel = new PageViewModel(name);

            InitializeComponent();

            var info = new DirectoryInfo(@"../../../spravochnikGribnika/Image/conditionally/");

            ObservableCollection<User> userList = new ObservableCollection<User>();

            foreach (var item in info.GetFiles())
            {


                User user = null;

                if (item.Name == "Белянка.jpg")
                {
                    user = new User()
                    {
                        Name = "Белянка",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Валуй.jpg")
                {
                    user = new User()
                    {
                        Name = "Валуй",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Волнушка розовая.jpg")
                {
                    user = new User()
                    {
                        Name = "Волнушка розовая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Гладыш (Млечник)jpg")
                {
                    user = new User()
                    {
                        Name = "Гладыш (Млечник)",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Гладыш (Млечник).jpg")
                {
                    user = new User()
                    {
                        Name = "Гладыш (Млечник)",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Груздь дубовый (подорешник).jpg")
                {
                    user = new User()
                    {
                        Name = "Груздь дубовый (подорешник)",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Груздь желтый (ямчатый).jpg")
                {
                    user = new User()
                    {
                        Name = "Груздь желтый (ямчатый)",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }

                if (item.Name == "Волнушка белая.jpg")
                {
                    user = new User()
                    {
                        Name = "Волнушка белая",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (item.Name == "Груздь осиновый.jpg")
                {
                    user = new User()
                    {
                        Name = "Груздь осиновый",
                        Image = new BitmapImage(new Uri(item.FullName))
                    };
                }
                if (user != null)
                {
                    userList.Add(user);
                }
            }

            ners.ItemsSource = userList;
        }
    }
}
