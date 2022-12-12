using spravochnikGribnika.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spravochnikGribnika.ViewModel
{
    public class PageViewModel : BaseViewModel
    {
        private readonly FileWorker _fileWorker;

        private string _category;

        private User _selectedUser;

        private string text;
        public string Text
        {
            get => text;
            set
            {
                text = value;
                OnPrpertyChanged(nameof(Text));
            }
        }
        public User SelectedUser
        {
            get => _selectedUser;
            set
            {
                _selectedUser = value;
                OnPrpertyChanged(nameof(SelectedUser));

                LoadInfo();
            }
        }

        public PageViewModel(string name)
        {
            _category = name;

            _fileWorker = new FileWorker();
        }

        private async void LoadInfo()
        {
            Text = await _fileWorker.ReadFile(_category, SelectedUser.Name);
        }
    }
}

