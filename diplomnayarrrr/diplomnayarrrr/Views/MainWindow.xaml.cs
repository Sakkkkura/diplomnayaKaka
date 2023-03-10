using diplomnayarrrr.Entities;
using diplomnayarrrr.ViewModels;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace diplomnayarrrr.Views
{
    public partial class MainWindow : Window
    {
        private MainViewModel _viewModel;
        public MainWindow(User user)
        {
            InitializeComponent();
            _viewModel = new MainViewModel(user);
            DataContext = _viewModel;

            this.Title = $"{user.Role.Title}";
        }
    }
}
