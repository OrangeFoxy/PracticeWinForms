
namespace UI.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameLabel = new System.Windows.Forms.Label();
            this.clickButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.topListView = new System.Windows.Forms.ListView();
            this.nameColumn = new System.Windows.Forms.ColumnHeader();
            this.ScoreTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nameLabel.Location = new System.Drawing.Point(599, 28);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(158, 89);
            this.nameLabel.TabIndex = 0;
            this.nameLabel.Text = "Ник";
            // 
            // clickButton
            // 
            this.clickButton.Font = new System.Drawing.Font("Segoe UI", 40F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.clickButton.Location = new System.Drawing.Point(171, 285);
            this.clickButton.Name = "clickButton";
            this.clickButton.Size = new System.Drawing.Size(322, 165);
            this.clickButton.TabIndex = 1;
            this.clickButton.Text = "Нажми";
            this.clickButton.UseVisualStyleBackColor = true;
            this.clickButton.Click += new System.EventHandler(this.clickButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.scoreLabel.Location = new System.Drawing.Point(97, 79);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(135, 67);
            this.scoreLabel.TabIndex = 2;
            this.scoreLabel.Text = "Счет";
            // 
            // topListView
            // 
            this.topListView.BackColor = System.Drawing.SystemColors.Control;
            this.topListView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.topListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.nameColumn});
            this.topListView.Enabled = false;
            this.topListView.Font = new System.Drawing.Font("Tempus Sans ITC", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.topListView.HideSelection = false;
            this.topListView.Location = new System.Drawing.Point(599, 146);
            this.topListView.MultiSelect = false;
            this.topListView.Name = "topListView";
            this.topListView.Scrollable = false;
            this.topListView.Size = new System.Drawing.Size(372, 450);
            this.topListView.TabIndex = 3;
            this.topListView.UseCompatibleStateImageBehavior = false;
            this.topListView.View = System.Windows.Forms.View.List;
            // 
            // nameColumn
            // 
            this.nameColumn.Width = 1000;
            // 
            // ScoreTextBox
            // 
            this.ScoreTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ScoreTextBox.Location = new System.Drawing.Point(398, 126);
            this.ScoreTextBox.Name = "ScoreTextBox";
            this.ScoreTextBox.Size = new System.Drawing.Size(125, 20);
            this.ScoreTextBox.TabIndex = 4;
            this.ScoreTextBox.Visible = false;
            this.ScoreTextBox.TextChanged += new System.EventHandler(this.ScoreTextBox_TextChanged);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(997, 626);
            this.Controls.Add(this.topListView);
            this.Controls.Add(this.ScoreTextBox);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.clickButton);
            this.Controls.Add(this.nameLabel);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Button clickButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.ListView topListView;
        private System.Windows.Forms.ColumnHeader nameColumn;
        private System.Windows.Forms.TextBox ScoreTextBox;
    }
}