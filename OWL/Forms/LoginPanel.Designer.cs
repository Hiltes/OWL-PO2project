
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
            UpDesignElem = new PictureBox();
            pictureBox2 = new PictureBox();
            LogToRegisterButon = new Button();
            WelcomeLabel3 = new Label();
            DownDesignElem = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)UpDesignElem).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DownDesignElem).BeginInit();
            SuspendLayout();
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(220, 140, 115);
            LoginButton.BackgroundImageLayout = ImageLayout.None;
            LoginButton.FlatStyle = FlatStyle.System;
            LoginButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginButton.ForeColor = Color.White;
            LoginButton.ImageAlign = ContentAlignment.BottomCenter;
            LoginButton.Location = new Point(176, 353);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(263, 59);
            LoginButton.TabIndex = 0;
            LoginButton.Text = "Zaloguj";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // LoginBox
            // 
            LoginBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold);
            LoginBox.Location = new Point(132, 186);
            LoginBox.Name = "LoginBox";
            LoginBox.Size = new Size(355, 40);
            LoginBox.TabIndex = 1;
            LoginBox.TextChanged += ValidateFields;
            // 
            // PasswordBox
            // 
            PasswordBox.Font = new Font("Verdana", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PasswordBox.Location = new Point(132, 267);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PasswordChar = '*';
            PasswordBox.Size = new Size(355, 40);
            PasswordBox.TabIndex = 2;
            PasswordBox.Click += ValidateFields;
            PasswordBox.TextChanged += PasswordBox_TextChanged;
            // 
            // LoginLabel
            // 
            LoginLabel.AutoSize = true;
            LoginLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 238);
            LoginLabel.ForeColor = Color.FromArgb(220, 140, 115);
            LoginLabel.Location = new Point(37, 186);
            LoginLabel.Name = "LoginLabel";
            LoginLabel.Size = new Size(89, 37);
            LoginLabel.TabIndex = 3;
            LoginLabel.Text = "Login";
            // 
            // PasswordLabel
            // 
            PasswordLabel.AutoSize = true;
            PasswordLabel.Font = new Font("Segoe UI", 18.3396225F, FontStyle.Bold, GraphicsUnit.Point, 238);
            PasswordLabel.ForeColor = Color.FromArgb(220, 140, 115);
            PasswordLabel.Location = new Point(37, 267);
            PasswordLabel.Name = "PasswordLabel";
            PasswordLabel.Size = new Size(90, 37);
            PasswordLabel.TabIndex = 4;
            PasswordLabel.Text = "Hasło";
            // 
            // WelcomeLabel1
            // 
            WelcomeLabel1.AutoSize = true;
            WelcomeLabel1.Font = new Font("Verdana", 25.8113213F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WelcomeLabel1.ForeColor = Color.FromArgb(220, 140, 115);
            WelcomeLabel1.Location = new Point(653, 152);
            WelcomeLabel1.Name = "WelcomeLabel1";
            WelcomeLabel1.Size = new Size(329, 46);
            WelcomeLabel1.TabIndex = 5;
            WelcomeLabel1.Text = "WITAJ W OWL";
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
            WelcomeLabel2.AutoSize = true;
            WelcomeLabel2.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WelcomeLabel2.ForeColor = Color.White;
            WelcomeLabel2.Location = new Point(619, 201);
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
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(60, 50, 75);
            pictureBox2.Location = new Point(-1, 534);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(1074, 48);
            pictureBox2.TabIndex = 9;
            pictureBox2.TabStop = false;
            // 
            // LogToRegisterButon
            // 
            LogToRegisterButon.FlatStyle = FlatStyle.System;
            LogToRegisterButon.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            LogToRegisterButon.Location = new Point(771, 405);
            LogToRegisterButon.Name = "LogToRegisterButon";
            LogToRegisterButon.Size = new Size(263, 58);
            LogToRegisterButon.TabIndex = 10;
            LogToRegisterButon.Text = "Rejestracja";
            LogToRegisterButon.UseVisualStyleBackColor = true;
            LogToRegisterButon.Click += ToRegButtonClick;
            // 
            // WelcomeLabel3
            // 
            WelcomeLabel3.AutoSize = true;
            WelcomeLabel3.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WelcomeLabel3.ForeColor = Color.White;
            WelcomeLabel3.Location = new Point(751, 377);
            WelcomeLabel3.Name = "WelcomeLabel3";
            WelcomeLabel3.Size = new Size(299, 25);
            WelcomeLabel3.TabIndex = 11;
            WelcomeLabel3.Text = "Nie masz jeszcze konta?";
            // 
            // DownDesignElem
            // 
            DownDesignElem.BackColor = Color.FromArgb(60, 50, 75);
            DownDesignElem.Location = new Point(-2, 479);
            DownDesignElem.Name = "DownDesignElem";
            DownDesignElem.Size = new Size(1075, 55);
            DownDesignElem.TabIndex = 12;
            DownDesignElem.TabStop = false;
            // 
            // LoginPanel
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 115, 150);
            ClientSize = new Size(1072, 531);
            Controls.Add(DownDesignElem);
            Controls.Add(WelcomeLabel3);
            Controls.Add(LogToRegisterButon);
            Controls.Add(pictureBox2);
            Controls.Add(UpDesignElem);
            Controls.Add(WelcomeLabel2);
            Controls.Add(label4);
            Controls.Add(WelcomeLabel1);
            Controls.Add(PasswordLabel);
            Controls.Add(LoginLabel);
            Controls.Add(PasswordBox);
            Controls.Add(LoginBox);
            Controls.Add(LoginButton);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "LoginPanel";
            Text = "OWL";
            ((System.ComponentModel.ISupportInitialize)UpDesignElem).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)DownDesignElem).EndInit();
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
        private PictureBox UpDesignElem;
        private PictureBox pictureBox2;
        private Button LogToRegisterButon;
        private Label WelcomeLabel3;
        private PictureBox DownDesignElem;
    }
}
