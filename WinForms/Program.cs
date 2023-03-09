using System;
using System.Windows.Forms;
using DomainModel;
using Presentation.Presenters;
using DBContext.DB;
using UI.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace UI
{
    static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            ApplicationContext ac = new();
            ShoppingContext sc = new();
            
            var loginPresenter = new LoginPresenter(new LoginForm(ac), new LoginService(sc));
            var mainPresenter = new MainPresenter(new MainForm(ac), new MainService(sc));
            loginPresenter.SuccessAuth += (login) =>
            {
                mainPresenter.LoginName = login;
                mainPresenter.Run();
            };
            loginPresenter.ShowRegistration += () => 
                new RegistrationPresenter(new RegistrationForm(), new RegistrationService(sc)).Run();
            loginPresenter.Run();
        }
    }
}
