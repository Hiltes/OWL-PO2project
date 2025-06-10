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
            flowLayoutPanel1 = new FlowLayoutPanel();
            MainLabel2 = new Label();
            label4 = new Label();
            LogoutBtn = new Button();
            EmailMainLabel = new Label();
            label3 = new Label();
            NameMainLabel = new Label();
            tableLayoutPanel1 = new TableLayoutPanel();
            CreateEButton = new Button();
            tableLayoutPanel2 = new TableLayoutPanel();
            ReloadBtn = new Button();
            MainLabel1 = new Label();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.BackColor = Color.FromArgb(105, 100, 135);
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.Location = new Point(3, 108);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(824, 420);
            flowLayoutPanel1.TabIndex = 0;
            flowLayoutPanel1.Paint += flowLayoutPanel1_Paint;
            // 
            // MainLabel2
            // 
            MainLabel2.AutoSize = true;
            MainLabel2.Font = new Font("Verdana", 12.8113213F, FontStyle.Bold);
            MainLabel2.Location = new Point(3, 0);
            MainLabel2.Name = "MainLabel2";
            MainLabel2.Size = new Size(145, 23);
            MainLabel2.TabIndex = 0;
            MainLabel2.Text = "Twoje konto";
            MainLabel2.Click += label2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Verdana", 8.811321F, FontStyle.Bold);
            label4.Location = new Point(3, 168);
            label4.Name = "label4";
            label4.Size = new Size(47, 16);
            label4.TabIndex = 4;
            label4.Text = "NONE";
            label4.Paint += label4_download_data;
            // 
            // LogoutBtn
            // 
            LogoutBtn.Anchor = AnchorStyles.Bottom;
            LogoutBtn.BackColor = Color.FromArgb(60, 50, 75);
            LogoutBtn.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            LogoutBtn.ForeColor = Color.White;
            LogoutBtn.Location = new Point(34, 349);
            LogoutBtn.Name = "LogoutBtn";
            LogoutBtn.Size = new Size(167, 68);
            LogoutBtn.TabIndex = 5;
            LogoutBtn.Text = "Wyloguj";
            LogoutBtn.UseVisualStyleBackColor = false;
            LogoutBtn.Click += LogoutBtn_Click;
            // 
            // EmailMainLabel
            // 
            EmailMainLabel.AutoSize = true;
            EmailMainLabel.Font = new Font("Verdana", 10.8113213F, FontStyle.Bold);
            EmailMainLabel.Location = new Point(3, 129);
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
            label3.Location = new Point(3, 96);
            label3.Name = "label3";
            label3.Size = new Size(47, 16);
            label3.TabIndex = 2;
            label3.Text = "NONE";
            label3.Paint += label3_download_data;
            // 
            // NameMainLabel
            // 
            NameMainLabel.AutoSize = true;
            NameMainLabel.Dock = DockStyle.Fill;
            NameMainLabel.Font = new Font("Verdana", 10.8113213F, FontStyle.Bold);
            NameMainLabel.Location = new Point(3, 48);
            NameMainLabel.Name = "NameMainLabel";
            NameMainLabel.Size = new Size(224, 48);
            NameMainLabel.TabIndex = 1;
            NameMainLabel.Text = "Nazwa Użytkownika:";
            NameMainLabel.Click += UsnameMain_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 77.42538F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 22.5746269F));
            tableLayoutPanel1.Controls.Add(CreateEButton, 1, 0);
            tableLayoutPanel1.Controls.Add(flowLayoutPanel1, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 1, 1);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 19.7740116F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 80.22599F));
            tableLayoutPanel1.Size = new Size(1072, 531);
            tableLayoutPanel1.TabIndex = 6;
            // 
            // CreateEButton
            // 
            CreateEButton.Anchor = AnchorStyles.None;
            CreateEButton.BackColor = Color.FromArgb(220, 140, 115);
            CreateEButton.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            CreateEButton.ForeColor = Color.White;
            CreateEButton.Location = new Point(857, 19);
            CreateEButton.Name = "CreateEButton";
            CreateEButton.Size = new Size(188, 67);
            CreateEButton.TabIndex = 3;
            CreateEButton.Text = "Utwórz wydarzenie";
            CreateEButton.UseVisualStyleBackColor = false;
            CreateEButton.Click += CreateEButton_Click;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 67.35437F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 32.64563F));
            tableLayoutPanel2.Controls.Add(ReloadBtn, 1, 0);
            tableLayoutPanel2.Controls.Add(MainLabel1, 0, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(824, 99);
            tableLayoutPanel2.TabIndex = 0;
            // 
            // ReloadBtn
            // 
            ReloadBtn.Anchor = AnchorStyles.None;
            ReloadBtn.BackColor = Color.FromArgb(220, 140, 115);
            ReloadBtn.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ReloadBtn.ForeColor = Color.White;
            ReloadBtn.Location = new Point(562, 16);
            ReloadBtn.Name = "ReloadBtn";
            ReloadBtn.Size = new Size(254, 67);
            ReloadBtn.TabIndex = 4;
            ReloadBtn.Text = "Odśwież";
            ReloadBtn.UseVisualStyleBackColor = false;
            ReloadBtn.Click += ReloadBtn_Click;
            // 
            // MainLabel1
            // 
            MainLabel1.Anchor = AnchorStyles.None;
            MainLabel1.AutoSize = true;
            MainLabel1.BackColor = Color.FromArgb(105, 100, 135);
            MainLabel1.BorderStyle = BorderStyle.FixedSingle;
            MainLabel1.Font = new Font("Verdana", 18.8113213F, FontStyle.Bold);
            MainLabel1.ForeColor = Color.Black;
            MainLabel1.Location = new Point(21, 24);
            MainLabel1.MinimumSize = new Size(0, 50);
            MainLabel1.Name = "MainLabel1";
            MainLabel1.Size = new Size(512, 50);
            MainLabel1.TabIndex = 1;
            MainLabel1.Text = "Organizer Wydarzeń Lokalnych";
            MainLabel1.TextAlign = ContentAlignment.MiddleCenter;
            MainLabel1.Click += MainLabel1_Click;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.BackColor = Color.FromArgb(105, 100, 135);
            tableLayoutPanel4.ColumnCount = 1;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Controls.Add(tableLayoutPanel3, 0, 0);
            tableLayoutPanel4.Controls.Add(LogoutBtn, 0, 1);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(833, 108);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 2;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.Size = new Size(236, 420);
            tableLayoutPanel4.TabIndex = 6;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.BackColor = Color.FromArgb(105, 100, 135);
            tableLayoutPanel3.ColumnCount = 1;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(label4, 0, 4);
            tableLayoutPanel3.Controls.Add(MainLabel2, 0, 0);
            tableLayoutPanel3.Controls.Add(NameMainLabel, 0, 1);
            tableLayoutPanel3.Controls.Add(EmailMainLabel, 0, 3);
            tableLayoutPanel3.Controls.Add(label3, 0, 2);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(3, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 5;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 33F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 39F));
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            tableLayoutPanel3.Size = new Size(230, 204);
            tableLayoutPanel3.TabIndex = 7;
            tableLayoutPanel3.Paint += tableLayoutPanel3_Paint;
            // 
            // MainPage
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(120, 115, 150);
            ClientSize = new Size(1072, 531);
            Controls.Add(tableLayoutPanel1);
            Name = "MainPage";
            Text = "OWL";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label MainLabel2;
        private Label NameMainLabel;
        private Label label3;
        private Label label4;
        private Label EmailMainLabel;
        private Button LogoutBtn;
        private FlowLayoutPanel flowLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private Button CreateEButton;
        private Button ReloadBtn;
        private Label MainLabel1;
        private TableLayoutPanel tableLayoutPanel3;
        private TableLayoutPanel tableLayoutPanel4;
    }
}