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
    public partial class RegistrationForm : Form, IRegistrationView
    {
        public event Action Register;
        public RegistrationForm()
        {
            InitializeComponent();
        }
        public string LoginName
        {
            get => loginBox.Text.Trim();
        }
        public string Pass
        {
            get => passBox.Text.Trim();
        }
        public string UserName
        {
            get => nameBox.Text.Trim();
        }
        public bool Admin
        {
            get => adminBox.Checked;
        }
        public void ShowError(string mes)
        {
            //MessageBox.Show(errorMessage);
            new ErrorForm(mes).Show();
        }
        public new void Show()
        {
            ShowDialog();
        }
        private void registerButton_Click(object sender, EventArgs e)
        {
            if (Pass != "" && LoginName != "")
                Register?.Invoke();
            else
                ShowError("Обязательные поля не заполнены");
        }
    }
}
