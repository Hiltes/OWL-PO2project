namespace OWL.Forms
{
    partial class MainPage
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
            MainFlowPanel = new FlowLayoutPanel();
            MainPagePanel = new Panel();
            label1 = new Label();
            EventDescMain = new Label();
            EventTitleMain = new Label();
            MainLabel1 = new Label();
            MainLabel2 = new Label();
            MainPanel = new Panel();
            label4 = new Label();
            LogoutBtn = new Button();
            EmailMainLabel = new Label();
            label3 = new Label();
            NameMainLabel = new Label();
            CreateEButton = new Button();
            MainFlowPanel.SuspendLayout();
            MainPagePanel.SuspendLayout();
            MainPanel.SuspendLayout();
            SuspendLayout();
            // 
            // MainFlowPanel
            // 
            MainFlowPanel.BackColor = Color.FromArgb(105, 100, 135);
            MainFlowPanel.Controls.Add(MainPagePanel);
            MainFlowPanel.Location = new Point(12, 85);
            MainFlowPanel.Name = "MainFlowPanel";
            MainFlowPanel.Padding = new Padding(5);
            MainFlowPanel.Size = new Size(834, 423);
            MainFlowPanel.TabIndex = 0;
            MainFlowPanel.Paint += MainFlowPanel_Paint;
            // 
            // MainPagePanel
            // 
            MainPagePanel.BackColor = Color.FromArgb(60, 50, 75);
            MainPagePanel.Controls.Add(label1);
            MainPagePanel.Controls.Add(EventDescMain);
            MainPagePanel.Controls.Add(EventTitleMain);
            MainPagePanel.Location = new Point(8, 8);
            MainPagePanel.Name = "MainPagePanel";
            MainPagePanel.Size = new Size(367, 116);
            MainPagePanel.TabIndex = 0;
            MainPagePanel.Paint += MainPagePanel_Visible;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Verdana", 10.8113213F, FontStyle.Bold);
            label1.ForeColor = Color.FromArgb(220, 140, 115);
            label1.Location = new Point(3, 87);
            label1.Name = "label1";
            label1.Size = new Size(111, 18);
            label1.TabIndex = 2;
            label1.Text = "Localization";
            // 
            // EventDescMain
            // 
            EventDescMain.AutoSize = true;
            EventDescMain.Font = new Font("Verdana", 8.811321F, FontStyle.Bold);
            EventDescMain.Location = new Point(9, 31);
            EventDescMain.Name = "EventDescMain";
            EventDescMain.Size = new Size(89, 16);
            EventDescMain.TabIndex = 1;
            EventDescMain.Text = "Description";
            EventDescMain.Click += EventDescMain_Click;
            // 
            // EventTitleMain
            // 
            EventTitleMain.AutoSize = true;
            EventTitleMain.Font = new Font("Verdana", 14.8113213F, FontStyle.Bold);
            EventTitleMain.ForeColor = Color.White;
            EventTitleMain.Location = new Point(3, 0);
            EventTitleMain.Name = "EventTitleMain";
            EventTitleMain.Size = new Size(146, 26);
            EventTitleMain.TabIndex = 0;
            EventTitleMain.Text = "Event Title";
            EventTitleMain.Click += EventTitle_Click;
            // 
            // MainLabel1
            // 
            MainLabel1.AutoSize = true;
            MainLabel1.BackColor = Color.FromArgb(105, 100, 135);
            MainLabel1.BorderStyle = BorderStyle.FixedSingle;
            MainLabel1.Font = new Font("Verdana", 18.8113213F, FontStyle.Bold);
            MainLabel1.ForeColor = Color.Black;
            MainLabel1.Location = new Point(12, 26);
            MainLabel1.MinimumSize = new Size(0, 50);
            MainLabel1.Name = "MainLabel1";
            MainLabel1.Size = new Size(512, 50);
            MainLabel1.TabIndex = 1;
            MainLabel1.Text = "Organizer Wydarzeń Lokalnych";
            MainLabel1.TextAlign = ContentAlignment.MiddleCenter;
            MainLabel1.Click += MainLabel1_Click;
            // 
            // MainLabel2
            // 
            MainLabel2.AutoSize = true;
            MainLabel2.Font = new Font("Verdana", 12.8113213F, FontStyle.Bold);
            MainLabel2.Location = new Point(25, 14);
            MainLabel2.Name = "MainLabel2";
            MainLabel2.Size = new Size(145, 23);
            MainLabel2.TabIndex = 0;
            MainLabel2.Text = "Twoje konto";
            MainLabel2.Click += label2_Click;
            // 
            // MainPanel
            // 
            MainPanel.BackColor = Color.FromArgb(105, 100, 135);
            MainPanel.Controls.Add(label4);
            MainPanel.Controls.Add(LogoutBtn);
            MainPanel.Controls.Add(EmailMainLabel);
            MainPanel.Controls.Add(label3);
            MainPanel.Controls.Add(NameMainLabel);
            MainPanel.Controls.Add(MainLabel2);
            MainPanel.Location = new Point(863, 12);
            MainPanel.Name = "MainPanel";
            MainPanel.Size = new Size(194, 496);
            MainPanel.TabIndex = 2;
            MainPanel.Paint += MainPanel_Paint;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8.811321F, FontStyle.Bold);
            label4.Location = new Point(4, 141);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 4;
            label4.Text = "NONE";
            label4.Paint += label4_download_data;
            // 
            // LogoutBtn
            // 
            LogoutBtn.BackColor = Color.FromArgb(60, 50, 75);
            LogoutBtn.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(14, 457);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(167, 37);
            LogoutBtn.TabIndex = 5;
            LogoutBtn.Text = "Wyloguj";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // EmailMainLabel
            // 
            EmailMainLabel.AutoSize = true;
            EmailMainLabel.Font = new Font("Verdana", 10.8113213F, FontStyle.Bold);
            EmailMainLabel.Location = new Point(0, 117);
            EmailMainLabel.Name = "EmailMainLabel";
            EmailMainLabel.Size = new Size(73, 18);
            EmailMainLabel.TabIndex = 3;
            EmailMainLabel.Text = "E-mail: ";
            EmailMainLabel.Click += EmailMainLabel_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Verdana", 8.811321F, FontStyle.Bold);
            label3.Location = new Point(3, 88);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 2;
            label3.Text = "NONE";
            label3.Paint += label3_download_data;
            // 
            // NameMainLabel
            // 
            NameMainLabel.AutoSize = true;
            NameMainLabel.Font = new Font("Verdana", 10.8113213F, FontStyle.Bold);
            NameMainLabel.Location = new Point(0, 59);
            NameMainLabel.Name = "NameMainLabel";
            NameMainLabel.Size = new Size(193, 18);
            NameMainLabel.TabIndex = 1;
            NameMainLabel.Text = "Nazwa Użytkownika:";
            NameMainLabel.Click += UsnameMain_Click;
            // 
            // CreateEButton
            // 
            CreateEButton.BackColor = Color.FromArgb(220, 140, 115);
            CreateEButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            CreateEButton.ForeColor = Color.White;
            CreateEButton.Location = new Point(543, 27);
            CreateEButton.Name = "CreateEButton";
            CreateEButton.Size = new Size(303, 49);
            CreateEButton.TabIndex = 3;
            CreateEButton.Text = "Utwórz wydarzenie";
            CreateEButton.UseVisualStyleBackColor = false;
            CreateEButton.Click += CreateEButton_Click;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 115, 150);
            ClientSize = new Size(1072, 531);
            Controls.Add(CreateEButton);
            Controls.Add(MainPanel);
            Controls.Add(MainLabel1);
            Controls.Add(MainFlowPanel);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "MainPage";
            Text = "OWL";
            MainFlowPanel.ResumeLayout(false);
            MainPagePanel.ResumeLayout(false);
            MainPagePanel.PerformLayout();
            MainPanel.ResumeLayout(false);
            MainPanel.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FlowLayoutPanel MainFlowPanel;
        private Panel MainPagePanel;
        private Label EventTitleMain;
        private Label EventDescMain;
        private Label label1;
        private Label MainLabel1;
        private Label MainLabel2;
        private Panel MainPanel;
        private Label NameMainLabel;
        private Label label3;
        private Label label4;
        private Label EmailMainLabel;
        private Button LogoutBtn;
        private Button CreateEButton;
    }
}