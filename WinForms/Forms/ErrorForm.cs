using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UI.Forms
{
    public partial class ErrorForm : Form
    {
        public ErrorForm(string mes)
        {
            KeyPreview = true;
            InitializeComponent();
            Message = mes;
        }
        public string Message
        {
            set => errorLabel.Text = value;
        }
        public new void Show()
        {
            ShowDialog();
        }

        private void ErrorForm_KeyDown(object sender, KeyEventArgs e)
        {
            Close();
        }
    }
}
