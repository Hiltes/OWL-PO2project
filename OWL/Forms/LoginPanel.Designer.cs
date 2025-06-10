
namespace OWL
{
    partial class LoginPanel : Form
    {


        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            LoginButton = new Button();
            LoginBox = new TextBox();
            PasswordBox = new TextBox();
            LoginLabel = new Label();
            PasswordLabel = new Label();
            WelcomeLabel1 = new Label();
            label4 = new Label();
            WelcomeLabel2 = new Label();
            LogToRegisterButon = new Button();
            WelcomeLabel3 = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.Anchor = AnchorStyles.None;
            LoginButton.BackColor = Color.FromArgb(220, 140, 115);
            LoginButton.BackgroundImageLayout = ImageLayout.None;
            LoginButton.FlatStyle = FlatStyle.System;
            LoginButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginButton.ForeColor = Color.White;
            LoginButton.ImageAlign = ContentAlignment.BottomCenter;
            LoginButton.Location = new Point(658, 3);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(263, 59);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Zaloguj";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginBox
            // 
            LoginBox.Dock = DockStyle.Fill;
            LoginBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
            LoginBox.Location = new Point(331, 3);
            LoginBox.Margin = new Padding(3, 3, 100, 3);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(635, 40);
            LoginBox.TabIndex = 1;
            LoginBox.TextChanged += ValidateFields;
            // 
            // PasswordBox
            // 
            PasswordBox.Dock = DockStyle.Fill;
            PasswordBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PasswordBox.Location = new Point(331, 88);
            PasswordBox.Margin = new Padding(3, 3, 100, 3);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(635, 40);
            PasswordBox.TabIndex = 2;
            PasswordBox.Click += ValidateFields;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Dock = DockStyle.Right;
            LoginLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginLabel.ForeColor = Color.FromArgb(220, 140, 115);
            LoginLabel.Location = new Point(236, 0);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(89, 85);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Dock = DockStyle.Right;
            PasswordLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PasswordLabel.ForeColor = Color.FromArgb(220, 140, 115);
            PasswordLabel.Location = new Point(235, 85);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(90, 86);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Hasło";
            // 
            // WelcomeLabel1
            // 
            WelcomeLabel1.Anchor = AnchorStyles.Bottom;
            WelcomeLabel1.AutoSize = true;
            WelcomeLabel1.Font = new Font("Verdana", 25.8113213F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WelcomeLabel1.ForeColor = Color.FromArgb(220, 140, 115);
            WelcomeLabel1.Location = new Point(368, 42);
            WelcomeLabel1.Name = "WelcomeLabel1";
            WelcomeLabel1.Size = new Size(329, 46);
            WelcomeLabel1.TabIndex = 5;
            WelcomeLabel1.Text = "WITAJ W OWL";
            WelcomeLabel1.Click += WelcomeLabel1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 23.7735844F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.White;
            label4.Location = new Point(-12, 159);
            label4.Name = "label4";
            label4.Size = new Size(0, 42);
            label4.TabIndex = 6;
            // 
            // WelcomeLabel2
            // 
            WelcomeLabel2.Anchor = AnchorStyles.Top;
            WelcomeLabel2.AutoSize = true;
            WelcomeLabel2.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WelcomeLabel2.ForeColor = Color.White;
            WelcomeLabel2.Location = new Point(336, 88);
            WelcomeLabel2.Name = "WelcomeLabel2";
            WelcomeLabel2.Size = new Size(394, 25);
            WelcomeLabel2.TabIndex = 7;
            WelcomeLabel2.Text = "Organizator wydarzeń lokalnych";
            // 
            // LogToRegisterButon
            // 
            LogToRegisterButon.Anchor = AnchorStyles.None;
            LogToRegisterButon.FlatStyle = FlatStyle.System;
            LogToRegisterButon.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            LogToRegisterButon.Location = new Point(125, 70);
            LogToRegisterButon.Name = "LogToRegisterButon";
            LogToRegisterButon.Size = new Size(263, 54);
            LogToRegisterButon.TabIndex = 10;
            LogToRegisterButon.Text = "Rejestracja";
            LogToRegisterButon.UseVisualStyleBackColor = true;
            LogToRegisterButon.Click += ToRegButtonClick;
            // 
            // WelcomeLabel3
            // 
            WelcomeLabel3.Anchor = AnchorStyles.Bottom;
            WelcomeLabel3.AutoSize = true;
            WelcomeLabel3.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WelcomeLabel3.ForeColor = Color.White;
            WelcomeLabel3.Location = new Point(107, 40);
            WelcomeLabel3.Name = "WelcomeLabel3";
            WelcomeLabel3.Size = new Size(299, 25);
            WelcomeLabel3.TabIndex = 11;
            WelcomeLabel3.Text = "Nie masz jeszcze konta?";
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel1.Size = new Size(1072, 531);
            tableLayoutPanel1.TabIndex = 13;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30.82077F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 69.17923F));
            tableLayoutPanel3.Controls.Add(PasswordLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(LoginLabel, 0, 0);
            tableLayoutPanel3.Controls.Add(LoginBox, 1, 0);
            tableLayoutPanel3.Controls.Add(PasswordBox, 1, 1);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 180);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 2;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(1066, 171);
            tableLayoutPanel3.TabIndex = 14;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(WelcomeLabel2, 0, 1);
            tableLayoutPanel2.Controls.Add(WelcomeLabel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 51.53374F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 48.46626F));
            tableLayoutPanel2.Size = new Size(1066, 171);
            tableLayoutPanel2.TabIndex = 14;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.AutoSize = true;
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 552F));
            tableLayoutPanel4.Controls.Add(LogToRegisterButon, 0, 1);
            tableLayoutPanel4.Controls.Add(WelcomeLabel3, 0, 0);
            tableLayoutPanel4.Controls.Add(LoginButton, 1, 0);
            tableLayoutPanel4.Dock = DockStyle.Bottom;
            tableLayoutPanel4.Location = new Point(3, 378);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 3;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1066, 150);
            tableLayoutPanel4.TabIndex = 14;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(106F, 106F);
            AutoScaleMode = AutoScaleMode.Dpi;
            AutoSize = true;
            BackColor = Color.FromArgb(120, 115, 150);
            ClientSize = new Size(1072, 531);
            Controls.Add(tableLayoutPanel1);
            Controls.Add(label4);
            Name = "LoginPanel";
            Text = "OWL";
            Load += LoginPanel_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button LoginButton;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label WelcomeLabel1;
        private Label label4;
        private Label WelcomeLabel2;
        private Button LogToRegisterButon;
        private Label WelcomeLabel3;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
