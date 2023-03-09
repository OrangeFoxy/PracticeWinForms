using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Presentation.Common;
using Presentation.Views;
using DomainModel;
using DBContext.DB.Models;

namespace Presentation.Presenters
{
    public class LoginPresenter : IPresenter
    {
        private readonly ILoginView view;
        private readonly ILoginService service;
        public event Action<string> SuccessAuth;
        public event Action ShowRegistration;
        public LoginPresenter(ILoginView view, ILoginService service)
        {
            this.view = view;
            this.service = service;

            view.Login += () => Login(view.LoginName, view.Pass);
            view.Register += () => Register();
        }
        public void Run()
        {
            view.Show();
        }
        private void Login(string login, string pass)
        {
            if (login == null)
                throw new ArgumentNullException("username");
            if (pass == null)
                throw new ArgumentNullException("password");

            var user = new User { Login = login, Pass = pass };
            if (!service.Login(user))
            {
                view.ShowError("Invalid username or password");
            }
            else
            {
                SuccessAuth?.Invoke(user.Login);
                view.Close();
                //var presenter = new MainPresenter(new Main);
                // успешная авторизация, запуск главного экрана (?)
            }
        }
        private void Register()
        {
            ShowRegistration?.Invoke();
        }
    }
}
