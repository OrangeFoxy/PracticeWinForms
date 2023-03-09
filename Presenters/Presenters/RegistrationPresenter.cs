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
    public class RegistrationPresenter : IPresenter
    {
        private readonly IRegistrationView view;
        private readonly IRegistrationService service;

        public RegistrationPresenter(IRegistrationView view, IRegistrationService service)
        {
            this.view = view;
            this.service = service;

            view.Register += () => Register(view.LoginName, view.Pass, view.UserName, view.Admin);
        }
        public void Run()
        {
            view.Show();
        }
        private void Register(string login, string pass, string name, bool admin)
        {
            //if (login == null)
            //    throw new ArgumentNullException("login");
            //if (pass == null)
            //    throw new ArgumentNullException("pass");

            var user = new User { Login = login, Pass = pass, Name = name, Admin = admin };
            try
            {
                service.Register(user);
                view.Close();
            }
            catch
            {
                view.ShowError("Логин уже используется");
            }
        }
    }
}
