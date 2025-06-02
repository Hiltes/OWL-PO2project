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
        UpDesignElem = new PictureBox();
        DownDesignElem = new PictureBox();
        PasswordConfirmBox = new TextBox();
        PasswordConfirmLabel = new Label();
        EmailBox = new TextBox();
        EmailLabel = new Label();
        BackToLoginButton = new Button();
        WelcomeLabel3 = new Label();
        ((System.ComponentModel.ISupportInitialize)UpDesignElem).BeginInit();
        ((System.ComponentModel.ISupportInitialize)DownDesignElem).BeginInit();
        SuspendLayout();
        // 
        // RegisterButton
        // 
        RegisterButton.BackColor = Color.FromArgb(220, 140, 115);
        RegisterButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
        RegisterButton.ForeColor = Color.White;
        RegisterButton.Location = new Point(325, 420);
        RegisterButton.Name = "RegisterButton";
        RegisterButton.Size = new Size(263, 59);
        RegisterButton.TabIndex = 5;
        RegisterButton.Text = "Zarejestruj";
        RegisterButton.UseVisualStyleBackColor = false;
        RegisterButton.Click += RegisterButton_Click;
        // 
        // LoginBox
        // 
        LoginBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        LoginBox.Location = new Point(233, 192);
        LoginBox.Name = "LoginBox";
        LoginBox.Size = new Size(355, 40);
        LoginBox.TabIndex = 1;
        // 
        // PasswordBox
        // 
        PasswordBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        PasswordBox.Location = new Point(233, 267);
        PasswordBox.Name = "PasswordBox";
        PasswordBox.PasswordChar = '*';
        PasswordBox.Size = new Size(355, 40);
        PasswordBox.TabIndex = 2;
        // 
        // LoginLabel
        // 
        LoginLabel.AutoSize = true;
        LoginLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        LoginLabel.ForeColor = Color.FromArgb(220, 140, 115);
        LoginLabel.Location = new Point(84, 189);
        LoginLabel.Name = "LoginLabel";
        LoginLabel.Size = new Size(89, 37);
        LoginLabel.TabIndex = 3;
        LoginLabel.Text = "Login";
        // 
        // PasswordLabel
        // 
        PasswordLabel.AutoSize = true;
        PasswordLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        PasswordLabel.ForeColor = Color.FromArgb(220, 140, 115);
        PasswordLabel.Location = new Point(81, 267);
        PasswordLabel.Name = "PasswordLabel";
        PasswordLabel.Size = new Size(90, 37);
        PasswordLabel.TabIndex = 4;
        PasswordLabel.Text = "Hasło";
        // 
        // WelcomeLabel1
        // 
        WelcomeLabel1.AutoSize = true;
        WelcomeLabel1.Font = new Font("Verdana", 25.8113213F, FontStyle.Bold);
        WelcomeLabel1.ForeColor = Color.FromArgb(220, 140, 115);
        WelcomeLabel1.Location = new Point(683, 115);
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
        WelcomeLabel2.Location = new Point(650, 161);
        WelcomeLabel2.Name = "WelcomeLabel2";
        WelcomeLabel2.Size = new Size(394, 25);
        WelcomeLabel2.TabIndex = 7;
        WelcomeLabel2.Text = "Organizator wydarzeń lokalnych";
        // 
        // UpDesignElem
        // 
        UpDesignElem.BackColor = Color.FromArgb(60, 50, 75);
        UpDesignElem.Location = new Point(1, 1);
        UpDesignElem.Name = "UpDesignElem";
        UpDesignElem.Size = new Size(1072, 55);
        UpDesignElem.TabIndex = 8;
        UpDesignElem.TabStop = false;
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
        PasswordConfirmBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        PasswordConfirmBox.Location = new Point(233, 345);
        PasswordConfirmBox.Name = "PasswordConfirmBox";
        PasswordConfirmBox.PasswordChar = '*';
        PasswordConfirmBox.Size = new Size(355, 40);
        PasswordConfirmBox.TabIndex = 3;
        // 
        // PasswordConfirmLabel
        // 
        PasswordConfirmLabel.AutoSize = true;
        PasswordConfirmLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        PasswordConfirmLabel.ForeColor = Color.FromArgb(220, 140, 115);
        PasswordConfirmLabel.Location = new Point(27, 345);
        PasswordConfirmLabel.Name = "PasswordConfirmLabel";
        PasswordConfirmLabel.Size = new Size(200, 37);
        PasswordConfirmLabel.TabIndex = 14;
        PasswordConfirmLabel.Text = "Powtórz hasło";
        // 
        // EmailBox
        // 
        EmailBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
        EmailBox.Location = new Point(233, 115);
        EmailBox.Name = "EmailBox";
        EmailBox.Size = new Size(355, 40);
        EmailBox.TabIndex = 0;
        // 
        // EmailLabel
        // 
        EmailLabel.AutoSize = true;
        EmailLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold);
        EmailLabel.ForeColor = Color.FromArgb(220, 140, 115);
        EmailLabel.Location = new Point(84, 115);
        EmailLabel.Name = "EmailLabel";
        EmailLabel.Size = new Size(87, 37);
        EmailLabel.TabIndex = 16;
        EmailLabel.Text = "Email";
        // 
        // BackToLoginButton
        // 
        BackToLoginButton.FlatStyle = FlatStyle.System;
        BackToLoginButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
        BackToLoginButton.Location = new Point(771, 405);
        BackToLoginButton.Name = "BackToLoginButton";
        BackToLoginButton.Size = new Size(263, 58);
        BackToLoginButton.TabIndex = 6;
        BackToLoginButton.Text = "Powrót do logowania";
        BackToLoginButton.UseVisualStyleBackColor = true;
        BackToLoginButton.Click += BackToLoginButton_Click;
        // 
        // WelcomeLabel3
        // 
        WelcomeLabel3.AutoSize = true;
        WelcomeLabel3.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold);
        WelcomeLabel3.ForeColor = Color.White;
        WelcomeLabel3.Location = new Point(797, 360);
        WelcomeLabel3.Name = "WelcomeLabel3";
        WelcomeLabel3.Size = new Size(201, 25);
        WelcomeLabel3.TabIndex = 18;
        WelcomeLabel3.Text = "Masz już konto?";
        // 
        // RegisterPanel
        // 
        AutoScaleDimensions = new SizeF(7F, 17F);
        AutoScaleMode = AutoScaleMode.Font;
        BackColor = Color.FromArgb(120, 115, 150);
        ClientSize = new Size(1072, 531);
        Controls.Add(WelcomeLabel3);
        Controls.Add(BackToLoginButton);
        Controls.Add(EmailLabel);
        Controls.Add(EmailBox);
        Controls.Add(PasswordConfirmLabel);
        Controls.Add(PasswordConfirmBox);
        Controls.Add(DownDesignElem);
        Controls.Add(UpDesignElem);
        Controls.Add(WelcomeLabel2);
        Controls.Add(WelcomeLabel1);
        Controls.Add(PasswordLabel);
        Controls.Add(LoginLabel);
        Controls.Add(PasswordBox);
        Controls.Add(LoginBox);
        Controls.Add(RegisterButton);
        FormBorderStyle = FormBorderStyle.FixedSingle;
        Name = "RegisterPanel";
        StartPosition = FormStartPosition.CenterScreen;
        Text = "OWL - Rejestracja";
        ((System.ComponentModel.ISupportInitialize)UpDesignElem).EndInit();
        ((System.ComponentModel.ISupportInitialize)DownDesignElem).EndInit();
        ResumeLayout(false);
        PerformLayout();
    }

    #endregion

    private Button RegisterButton;
        private TextBox LoginBox;
        private TextBox PasswordBox;
        private Label LoginLabel;
        private Label PasswordLabel;
        private Label WelcomeLabel1;
        private Label WelcomeLabel2;
        private PictureBox UpDesignElem;
        private PictureBox DownDesignElem;
        private TextBox PasswordConfirmBox;
        private Label PasswordConfirmLabel;
        private TextBox EmailBox;
        private Label EmailLabel;
        private Button BackToLoginButton;
        private Label WelcomeLabel3;
    }
