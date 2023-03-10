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
using System.Windows.Shapes;

namespace diplomnayarrrr.Views
{
    public partial class AuthorizationWindow : Window
    {
        private AuthorizationViewModel _viewModel;
        public AuthorizationWindow()
        {
            InitializeComponent();
            _viewModel=(AuthorizationViewModel)DataContext;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            _viewModel.Authorization();
        }
    }
}
