using diplomnayarrrr.Models;
using diplomnayarrrr.Views;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace diplomnayarrrr.ViewModels
{
    public class AuthorizationViewModel : ViewModelBase
    {
        private string _login=null!;
        private string _password=null!;

        public string Login { get => _login; set => Set(ref _login, value, nameof(Login)); }
        public string Password { get => _password; set => Set(ref _password, value, nameof(Password)); }

        internal void Authorization()
        {
            using (var context = new ApplicationDbContext())
            {
                var IsExist = context.Users.Any(u=>u.Login==Login && u.Password==Password);
                if (IsExist)
                {
                       new MainWindow(context.Users.Include(r=>r.Role).Where(u=>u.Login==Login && u.Password==Password).First()).ShowDialog();
                }
                else
                {
                    MessageBox.Show("Такой пользователь отсутсвует!");
                }
            }
        }
    }
}
