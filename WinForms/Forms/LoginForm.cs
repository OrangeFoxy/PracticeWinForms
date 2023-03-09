using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Presentation.Views;

namespace UI.Forms
{
    public partial class LoginForm : Form, ILoginView
    {
        protected ApplicationContext context;
        public event Action Login;
        public event Action Register;
        public LoginForm(ApplicationContext context)
        {
            this.context = context;
            KeyPreview = true;
            InitializeComponent();
        }
        public string LoginName
        {
            get => loginBox.Text;
        }
        public string Pass
        {
            get => passBox.Text;
        }
        public void ShowError(string mes)
        {
            //MessageBox.Show(mes);
            new ErrorForm(mes).Show();
        }
        public new void Show()
        {
            context.MainForm = this;
            Application.Run(context);
        }
        private void loginButton_Click(object sender, EventArgs e)
        {
            Login?.Invoke();
        }

        //private void registerLabel_Enter(object sender, EventArgs e)
        //{
        //    registerLabel.Font = new Font(registerLabel.Font, FontStyle.Underline);
        //}

        private void registerLabel_Click(object sender, EventArgs e)
        {
            Register?.Invoke();
        }

        private void LoginForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyValue == (char)Keys.Enter)
                loginButton_Click(sender, e);

        }
    }
}
