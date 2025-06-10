namespace OWL.Forms;
using OWL.Services;



    partial class RegisterPanel
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

    #region Windows Form Designer generated code

    private void InitializeComponent()
    {
        RegisterButton = new Button();
        LoginBox = new TextBox();
        PasswordBox = new TextBox();
        LoginLabel = new Label();
        PasswordLabel = new Label();
        WelcomeLabel1 = new Label();
        WelcomeLabel2 = new Label();
        DownDesignElem = new PictureBox();
        PasswordConfirmBox = new TextBox();
        PasswordConfirmLabel = new Label();
        EmailBox = new TextBox();
        EmailLabel = new Label();
        BackToLoginButton = new Button();
        WelcomeLabel3 = new Label();
        label1 = new Label();
        label2 = new Label();
        tableLayoutPanel1 = new TableLayoutPanel();
        ((System.ComponentModel.ISupportInitialize)DownDesignElem).BeginInit();
        tableLayoutPanel1.SuspendLayout();
        SuspendLayout();
        // 
        // RegisterButton
        // 
        RegisterButton.Anchor = AnchorStyles.None;
        RegisterButton.BackColor = Color.FromArgb(220, 140, 115);
        RegisterButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
        RegisterButton.ForeColor = Color.White;
        RegisterButton.Location = new Point(319, 455);
        RegisterButton.Name = "RegisterButton";
        RegisterButton.Size = new Size(263, 59);
        RegisterButton.TabIndex = 5;
        RegisterButton.Text = "Zarejestruj";
        RegisterButton.UseVisualStyleBackColor = false;
        RegisterButton.Click += RegisterButton_Click;
        // 
        // LoginBox
        // 
        LoginBox.Dock = DockStyle.Fill;
        LoginBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        LoginBox.Location = new Point(226, 133);
        LoginBox.Margin = new Padding(3, 3, 50, 3);
        LoginBox.Name = "LoginBox";
        LoginBox.Size = new Size(402, 40);
        LoginBox.TabIndex = 1;
        // 
        // PasswordBox
        // 
        PasswordBox.Dock = DockStyle.Fill;
        PasswordBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        PasswordBox.Location = new Point(226, 220);
        PasswordBox.Margin = new Padding(3, 3, 50, 3);
        PasswordBox.Name = "PasswordBox";
        PasswordBox.PasswordChar = '*';
        PasswordBox.Size = new Size(402, 40);
        PasswordBox.TabIndex = 2;
        // 
        // LoginLabel
        // 
        LoginLabel.AutoSize = true;
        LoginLabel.Dock = DockStyle.Right;
        LoginLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        LoginLabel.ForeColor = Color.FromArgb(220, 140, 115);
        LoginLabel.Location = new Point(131, 130);
        LoginLabel.Name = "LoginLabel";
        LoginLabel.Size = new Size(89, 60);
        LoginLabel.TabIndex = 3;
        LoginLabel.Text = "Login";
        // 
        // PasswordLabel
        // 
        PasswordLabel.AutoSize = true;
        PasswordLabel.Dock = DockStyle.Right;
        PasswordLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        PasswordLabel.ForeColor = Color.FromArgb(220, 140, 115);
        PasswordLabel.Location = new Point(130, 217);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(90, 62);
        PasswordLabel.TabIndex = 4;
        PasswordLabel.Text = "Hasło";
        // 
        // WelcomeLabel1
        // 
        WelcomeLabel1.AutoSize = true;
        WelcomeLabel1.Font = new Font("Verdana", 25.8113213F, FontStyle.Bold);
        WelcomeLabel1.ForeColor = Color.FromArgb(220, 140, 115);
        WelcomeLabel1.Location = new Point(681, 66);
        WelcomeLabel1.Name = "WelcomeLabel1";
        WelcomeLabel1.Size = new Size(315, 46);
        WelcomeLabel1.TabIndex = 5;
        WelcomeLabel1.Text = "REJESTRACJA";
        // 
        // WelcomeLabel2
        // 
        WelcomeLabel2.AutoSize = true;
        WelcomeLabel2.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold);
        WelcomeLabel2.ForeColor = Color.White;
        WelcomeLabel2.Location = new Point(681, 130);
        WelcomeLabel2.Name = "WelcomeLabel2";
        WelcomeLabel2.Size = new Size(282, 50);
        WelcomeLabel2.TabIndex = 7;
        WelcomeLabel2.Text = "Organizator wydarzeń lokalnych";
        // 
        // DownDesignElem
        // 
        DownDesignElem.BackColor = Color.FromArgb(60, 50, 75);
        DownDesignElem.Location = new Point(-2, 534);
        DownDesignElem.Name = "DownDesignElem";
        DownDesignElem.Size = new Size(1075, 48);
        DownDesignElem.TabIndex = 12;
        DownDesignElem.TabStop = false;
        // 
        // PasswordConfirmBox
        // 
        PasswordConfirmBox.Dock = DockStyle.Fill;
        PasswordConfirmBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        PasswordConfirmBox.Location = new Point(226, 282);
        PasswordConfirmBox.Margin = new Padding(3, 3, 50, 3);
        PasswordConfirmBox.Name = "PasswordConfirmBox";
        PasswordConfirmBox.PasswordChar = '*';
        PasswordConfirmBox.Size = new Size(402, 40);
        PasswordConfirmBox.TabIndex = 3;
        // 
        // PasswordConfirmLabel
        // 
        PasswordConfirmLabel.AutoSize = true;
        PasswordConfirmLabel.Dock = DockStyle.Right;
        PasswordConfirmLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        PasswordConfirmLabel.ForeColor = Color.FromArgb(220, 140, 115);
        PasswordConfirmLabel.Location = new Point(20, 279);
        PasswordConfirmLabel.Name = "PasswordConfirmLabel";
        PasswordConfirmLabel.Size = new Size(200, 55);
        PasswordConfirmLabel.TabIndex = 14;
        PasswordConfirmLabel.Text = "Powtórz hasło";
        // 
        // EmailBox
        // 
        EmailBox.Dock = DockStyle.Fill;
        EmailBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        EmailBox.Location = new Point(226, 69);
        EmailBox.Margin = new Padding(3, 3, 50, 3);
        EmailBox.Name = "EmailBox";
        EmailBox.Size = new Size(402, 40);
        EmailBox.TabIndex = 0;
        // 
        // EmailLabel
        // 
        EmailLabel.AutoSize = true;
        EmailLabel.Dock = DockStyle.Right;
        EmailLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        EmailLabel.ForeColor = Color.FromArgb(220, 140, 115);
        EmailLabel.Location = new Point(133, 66);
        EmailLabel.Name = "EmailLabel";
        EmailLabel.Size = new Size(87, 64);
        EmailLabel.TabIndex = 16;
        EmailLabel.Text = "Email";
        EmailLabel.Click += EmailLabel_Click;
        // 
        // BackToLoginButton
        // 
        BackToLoginButton.Anchor = AnchorStyles.None;
        BackToLoginButton.FlatStyle = FlatStyle.System;
        BackToLoginButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
        BackToLoginButton.Location = new Point(743, 455);
        BackToLoginButton.Name = "BackToLoginButton";
        BackToLoginButton.Size = new Size(263, 58);
        BackToLoginButton.TabIndex = 6;
        BackToLoginButton.Text = "Powrót do logowania";
        BackToLoginButton.UseVisualStyleBackColor = true;
        BackToLoginButton.Click += BackToLoginButton_Click;
        // 
        // WelcomeLabel3
        // 
        WelcomeLabel3.Anchor = AnchorStyles.Bottom;
        WelcomeLabel3.AutoSize = true;
        WelcomeLabel3.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold);
        WelcomeLabel3.ForeColor = Color.White;
        WelcomeLabel3.Location = new Point(774, 413);
        WelcomeLabel3.Name = "WelcomeLabel3";
        WelcomeLabel3.Size = new Size(201, 25);
        WelcomeLabel3.TabIndex = 18;
        WelcomeLabel3.Text = "Masz już konto?";
        // 
        // label1
        // 
        label1.AutoSize = true;
        label1.Font = new Font("Segoe UI Semibold", 8.150944F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 238);
        label1.ForeColor = Color.FromArgb(220, 140, 115);
        label1.Location = new Point(226, 190);
        label1.Name = "label1";
        label1.Size = new Size(304, 17);
        label1.TabIndex = 19;
        label1.Text = "Login powinien skłądać sie z conajmniej 4 znaków";
        label1.Click += label1_Click;
        // 
        // label2
        // 
        label2.AutoSize = true;
        label2.Dock = DockStyle.Fill;
        label2.FlatStyle = FlatStyle.System;
        label2.Font = new Font("Segoe UI Semibold", 8.150944F, FontStyle.Bold | FontStyle.Italic);
        label2.ForeColor = Color.FromArgb(220, 140, 115);
        label2.Location = new Point(226, 334);
        label2.Name = "label2";
        label2.Size = new Size(449, 77);
        label2.TabIndex = 20;
        label2.Text = "Hasło powinno składać się z minimum 8 znaków  w tym jednej cyfry i znaku specjalnego";
        label2.Click += label2_Click;
        // 
        // tableLayoutPanel1
        // 
        tableLayoutPanel1.ColumnCount = 3;
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.8928032F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.10719F));
        tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 393F));
        tableLayoutPanel1.Controls.Add(WelcomeLabel2, 2, 2);
        tableLayoutPanel1.Controls.Add(WelcomeLabel1, 2, 1);
        tableLayoutPanel1.Controls.Add(RegisterButton, 1, 8);
        tableLayoutPanel1.Controls.Add(label2, 1, 6);
        tableLayoutPanel1.Controls.Add(PasswordConfirmBox, 1, 5);
        tableLayoutPanel1.Controls.Add(PasswordBox, 1, 4);
        tableLayoutPanel1.Controls.Add(label1, 1, 3);
        tableLayoutPanel1.Controls.Add(LoginBox, 1, 2);
        tableLayoutPanel1.Controls.Add(EmailBox, 1, 1);
        tableLayoutPanel1.Controls.Add(PasswordConfirmLabel, 0, 5);
        tableLayoutPanel1.Controls.Add(PasswordLabel, 0, 4);
        tableLayoutPanel1.Controls.Add(LoginLabel, 0, 2);
        tableLayoutPanel1.Controls.Add(EmailLabel, 0, 1);
        tableLayoutPanel1.Controls.Add(BackToLoginButton, 2, 8);
        tableLayoutPanel1.Controls.Add(WelcomeLabel3, 2, 7);
        tableLayoutPanel1.Dock = DockStyle.Fill;
        tableLayoutPanel1.Location = new Point(0, 0);
        tableLayoutPanel1.Name = "tableLayoutPanel1";
        tableLayoutPanel1.RowCount = 9;
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 16.08911F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.5555553F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 14.5679016F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 6.66666651F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 15.0851583F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.3819952F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 18.7347927F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 27F));
        tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 89F));
        tableLayoutPanel1.Size = new Size(1072, 531);
        tableLayoutPanel1.TabIndex = 22;
        // 
        // RegisterPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(120, 115, 150);
        ClientSize = new Size(1072, 531);
        Controls.Add(tableLayoutPanel1);
        Controls.Add(DownDesignElem);
        Name = "RegisterPanel";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "OWL - Rejestracja";
        ((System.ComponentModel.ISupportInitialize)DownDesignElem).EndInit();
        tableLayoutPanel1.ResumeLayout(false);
        tableLayoutPanel1.PerformLayout();
        ResumeLayout(false);
    }

    #endregion

    private Button RegisterButton;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label WelcomeLabel1;
        private Label WelcomeLabel2;
        private PictureBox DownDesignElem;
        private TextBox PasswordConfirmBox;
        private Label PasswordConfirmLabel;
        private TextBox EmailBox;
        private Label EmailLabel;
        private Button BackToLoginButton;
        private Label WelcomeLabel3;
    private Label label1;
    private Label label2;
    private TableLayoutPanel tableLayoutPanel1;
}
