using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DBContext.DB.Models;
using Presentation.Views;

namespace UI.Forms
{
    public partial class MainForm : Form, IMainView
    {
        ApplicationContext context;
        public event Action UpdateScore;
        public MainForm(ApplicationContext context)
        {
            this.context = context;
            InitializeComponent();
        }
        public new void Show()
        {
            context.MainForm = this;
            base.Show();
        }
        public void ShowError(string mes)
        {
            MessageBox.Show(mes);
        }
        public int Score
        {
            set => scoreLabel.Text = value.ToString();
        }
        public string UserName
        {
            set => nameLabel.Text = value;
        }
        public bool Admin
        {
            set => ScoreTextBox.Visible = value;
        }
        public List<string> TopList
        {
            set
            {
                topListView.Items.Clear();
                foreach (var i in value)
                {
                    var e = new ListViewItem(i);
                    topListView.Items.Add(e);
                }
            }
        }
        private void clickButton_Click(object sender, EventArgs e)
        {
            UpdateScore?.Invoke();
        }

        private void ScoreTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(ScoreTextBox.Text, "[^0-9]"))
            {
                ScoreTextBox.Text = ScoreTextBox.Text.Remove(ScoreTextBox.Text.Length - 1);
            }
            else
            {
                UpdateScore?.Invoke();
            }
        }
    }
}
