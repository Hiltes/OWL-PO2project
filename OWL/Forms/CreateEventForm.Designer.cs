namespace OWL.Forms
{
    partial class CreateEventForm
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
            CEFMainLabel = new Label();
            WithoutLocCheckbox = new CheckBox();
            label1NAME_CEF = new Label();
            label3DATE_CEF = new Label();
            label3LOC_CEF = new Label();
            label2DES_CEF = new Label();
            DaBox = new TextBox();
            OpnCalBtn = new Button();
            textBox1 = new TextBox();
            LocBox = new TextBox();
            DescBoxCEF = new TextBox();
            DelBtn = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel4 = new TableLayoutPanel();
            tableLayoutPanel5 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel3 = new TableLayoutPanel();
            tableLayoutPanel6 = new TableLayoutPanel();
            CrtEVBtm = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel4.SuspendLayout();
            tableLayoutPanel5.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            tableLayoutPanel3.SuspendLayout();
            tableLayoutPanel6.SuspendLayout();
            SuspendLayout();
            // 
            // CEFMainLabel
            // 
            CEFMainLabel.AutoSize = true;
            CEFMainLabel.Dock = DockStyle.Fill;
            CEFMainLabel.Font = new Font("Verdana", 18.8113213F, FontStyle.Bold);
            CEFMainLabel.ForeColor = Color.White;
            CEFMainLabel.Location = new Point(3, 0);
            CEFMainLabel.Name = "CEFMainLabel";
            CEFMainLabel.Size = new Size(1066, 58);
            CEFMainLabel.TabIndex = 0;
            CEFMainLabel.Text = "Edytuj swoje wydarzenie";
            CEFMainLabel.TextAlign = ContentAlignment.MiddleCenter;
            CEFMainLabel.Click += CEFMainLabel_Click;
            // 
            // WithoutLocCheckbox
            // 
            WithoutLocCheckbox.Anchor = AnchorStyles.Left;
            WithoutLocCheckbox.AutoSize = true;
            WithoutLocCheckbox.FlatStyle = FlatStyle.Popup;
            WithoutLocCheckbox.Font = new Font("Verdana", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WithoutLocCheckbox.ForeColor = Color.White;
            WithoutLocCheckbox.Location = new Point(322, 61);
            WithoutLocCheckbox.Name = "WithoutLocCheckbox";
            WithoutLocCheckbox.Size = new Size(217, 22);
            WithoutLocCheckbox.TabIndex = 2;
            WithoutLocCheckbox.Text = "Wydarzenie jest zdalne";
            WithoutLocCheckbox.UseVisualStyleBackColor = true;
            WithoutLocCheckbox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // label1NAME_CEF
            // 
            label1NAME_CEF.AutoSize = true;
            label1NAME_CEF.Dock = DockStyle.Top;
            label1NAME_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label1NAME_CEF.ForeColor = Color.White;
            label1NAME_CEF.Location = new Point(3, 0);
            label1NAME_CEF.Name = "label1NAME_CEF";
            label1NAME_CEF.Size = new Size(313, 22);
            label1NAME_CEF.TabIndex = 3;
            label1NAME_CEF.Text = "Nazwa wydarzenia:";
            label1NAME_CEF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3DATE_CEF
            // 
            label3DATE_CEF.AutoSize = true;
            label3DATE_CEF.Dock = DockStyle.Top;
            label3DATE_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label3DATE_CEF.ForeColor = Color.White;
            label3DATE_CEF.Location = new Point(3, 337);
            label3DATE_CEF.Name = "label3DATE_CEF";
            label3DATE_CEF.Size = new Size(313, 22);
            label3DATE_CEF.TabIndex = 6;
            label3DATE_CEF.Text = "Data wydarzenia:";
            label3DATE_CEF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label3LOC_CEF
            // 
            label3LOC_CEF.AutoSize = true;
            label3LOC_CEF.Dock = DockStyle.Top;
            label3LOC_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label3LOC_CEF.ForeColor = Color.White;
            label3LOC_CEF.Location = new Point(3, 96);
            label3LOC_CEF.Name = "label3LOC_CEF";
            label3LOC_CEF.Size = new Size(313, 22);
            label3LOC_CEF.TabIndex = 5;
            label3LOC_CEF.Text = "Lokalizacja:";
            label3LOC_CEF.TextAlign = ContentAlignment.MiddleRight;
            // 
            // label2DES_CEF
            // 
            label2DES_CEF.AutoSize = true;
            label2DES_CEF.Dock = DockStyle.Top;
            label2DES_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label2DES_CEF.ForeColor = Color.White;
            label2DES_CEF.Location = new Point(3, 144);
            label2DES_CEF.Name = "label2DES_CEF";
            label2DES_CEF.Size = new Size(313, 22);
            label2DES_CEF.TabIndex = 4;
            label2DES_CEF.Text = "Opis wydarzenia:";
            label2DES_CEF.TextAlign = ContentAlignment.MiddleRight;
            label2DES_CEF.Click += label1_Click;
            // 
            // DaBox
            // 
            DaBox.Anchor = AnchorStyles.None;
            DaBox.BackColor = SystemColors.ControlDark;
            DaBox.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DaBox.Location = new Point(6, 3);
            DaBox.MaximumSize = new Size(200, 40);
            DaBox.MinimumSize = new Size(200, 40);
            DaBox.Name = "DaBox";
            DaBox.Size = new Size(200, 40);
            DaBox.TabIndex = 4;
            DaBox.TextAlign = HorizontalAlignment.Center;
            DaBox.TextChanged += EnableBtn;
            // 
            // OpnCalBtn
            // 
            OpnCalBtn.Anchor = AnchorStyles.Left;
            OpnCalBtn.AutoSize = true;
            OpnCalBtn.BackColor = Color.FromArgb(220, 140, 115);
            OpnCalBtn.Font = new Font("Verdana", 8.150944F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpnCalBtn.ForeColor = Color.White;
            OpnCalBtn.Location = new Point(216, 5);
            OpnCalBtn.Name = "OpnCalBtn";
            OpnCalBtn.Size = new Size(120, 34);
            OpnCalBtn.TabIndex = 3;
            OpnCalBtn.Text = "Kalendarz";
            OpnCalBtn.UseVisualStyleBackColor = false;
            OpnCalBtn.Click += OpnCalBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(105, 100, 135);
            textBox1.Dock = DockStyle.Fill;
            textBox1.Font = new Font("Verdana", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(319, 5);
            textBox1.Margin = new Padding(0, 5, 40, 5);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(707, 29);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += EnableBtn;
            // 
            // LocBox
            // 
            LocBox.BackColor = Color.FromArgb(105, 100, 135);
            LocBox.Dock = DockStyle.Fill;
            LocBox.Font = new Font("Verdana", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LocBox.ForeColor = Color.White;
            LocBox.Location = new Point(319, 101);
            LocBox.Margin = new Padding(0, 5, 40, 5);
            LocBox.Name = "LocBox";
            LocBox.Size = new Size(707, 29);
            LocBox.TabIndex = 1;
            LocBox.TextChanged += EnableBtn;
            // 
            // DescBoxCEF
            // 
            DescBoxCEF.AcceptsReturn = true;
            DescBoxCEF.BackColor = Color.FromArgb(105, 100, 135);
            DescBoxCEF.Dock = DockStyle.Fill;
            DescBoxCEF.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DescBoxCEF.ForeColor = Color.White;
            DescBoxCEF.Location = new Point(319, 149);
            DescBoxCEF.Margin = new Padding(0, 5, 40, 5);
            DescBoxCEF.Multiline = true;
            DescBoxCEF.Name = "DescBoxCEF";
            DescBoxCEF.Size = new Size(707, 183);
            DescBoxCEF.TabIndex = 0;
            DescBoxCEF.TextChanged += EnableBtn;
            // 
            // DelBtn
            // 
            DelBtn.Anchor = AnchorStyles.Right;
            DelBtn.BackColor = Color.FromArgb(220, 140, 115);
            DelBtn.Enabled = false;
            DelBtn.Font = new Font("Verdana", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(3, 7);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(181, 47);
            DelBtn.TabIndex = 6;
            DelBtn.Text = "Usuń";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(CEFMainLabel, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel4, 0, 1);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 3;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.8603106F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 87.13969F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 79F));
            tableLayoutPanel1.Size = new Size(1072, 531);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel4
            // 
            tableLayoutPanel4.ColumnCount = 2;
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 30F));
            tableLayoutPanel4.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 70F));
            tableLayoutPanel4.Controls.Add(label1NAME_CEF, 0, 0);
            tableLayoutPanel4.Controls.Add(WithoutLocCheckbox, 1, 1);
            tableLayoutPanel4.Controls.Add(textBox1, 1, 0);
            tableLayoutPanel4.Controls.Add(LocBox, 1, 2);
            tableLayoutPanel4.Controls.Add(DescBoxCEF, 1, 3);
            tableLayoutPanel4.Controls.Add(label3LOC_CEF, 0, 2);
            tableLayoutPanel4.Controls.Add(tableLayoutPanel5, 1, 4);
            tableLayoutPanel4.Controls.Add(label3DATE_CEF, 0, 4);
            tableLayoutPanel4.Controls.Add(label2DES_CEF, 0, 3);
            tableLayoutPanel4.Dock = DockStyle.Fill;
            tableLayoutPanel4.Location = new Point(3, 61);
            tableLayoutPanel4.Name = "tableLayoutPanel4";
            tableLayoutPanel4.RowCount = 5;
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Percent, 12.5F));
            tableLayoutPanel4.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel4.Size = new Size(1066, 387);
            tableLayoutPanel4.TabIndex = 1;
            // 
            // tableLayoutPanel5
            // 
            tableLayoutPanel5.ColumnCount = 2;
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 36.99115F));
            tableLayoutPanel5.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 63.00885F));
            tableLayoutPanel5.Controls.Add(OpnCalBtn, 1, 0);
            tableLayoutPanel5.Controls.Add(DaBox, 0, 0);
            tableLayoutPanel5.Dock = DockStyle.Left;
            tableLayoutPanel5.Location = new Point(322, 340);
            tableLayoutPanel5.Name = "tableLayoutPanel5";
            tableLayoutPanel5.RowCount = 1;
            tableLayoutPanel5.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel5.Size = new Size(577, 44);
            tableLayoutPanel5.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Controls.Add(tableLayoutPanel3, 1, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 454);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(1066, 74);
            tableLayoutPanel2.TabIndex = 5;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 73.69439F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.3056087F));
            tableLayoutPanel3.Controls.Add(tableLayoutPanel6, 0, 0);
            tableLayoutPanel3.Dock = DockStyle.Fill;
            tableLayoutPanel3.Location = new Point(526, 3);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(517, 68);
            tableLayoutPanel3.TabIndex = 0;
            // 
            // tableLayoutPanel6
            // 
            tableLayoutPanel6.ColumnCount = 2;
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Controls.Add(DelBtn, 0, 0);
            tableLayoutPanel6.Controls.Add(CrtEVBtm, 1, 0);
            tableLayoutPanel6.Dock = DockStyle.Fill;
            tableLayoutPanel6.Location = new Point(3, 3);
            tableLayoutPanel6.Name = "tableLayoutPanel6";
            tableLayoutPanel6.RowCount = 1;
            tableLayoutPanel6.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel6.Size = new Size(375, 62);
            tableLayoutPanel6.TabIndex = 6;
            // 
            // CrtEVBtm
            // 
            CrtEVBtm.Anchor = AnchorStyles.Left;
            CrtEVBtm.BackColor = Color.FromArgb(220, 140, 115);
            CrtEVBtm.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            CrtEVBtm.ForeColor = Color.White;
            CrtEVBtm.Location = new Point(190, 9);
            CrtEVBtm.Name = "CrtEVBtm";
            CrtEVBtm.Size = new Size(182, 44);
            CrtEVBtm.TabIndex = 5;
            CrtEVBtm.Text = "Zapisz";
            CrtEVBtm.UseVisualStyleBackColor = false;
            CrtEVBtm.Click += CrtEVBtm_Click;
            // 
            // CreateEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 50, 75);
            ClientSize = new Size(1072, 531);
            Controls.Add(tableLayoutPanel1);
            Name = "CreateEventForm";
            Text = "OWL";
            Load += CreateEventForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel4.ResumeLayout(false);
            tableLayoutPanel4.PerformLayout();
            tableLayoutPanel5.ResumeLayout(false);
            tableLayoutPanel5.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel3.ResumeLayout(false);
            tableLayoutPanel6.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label CEFMainLabel;
        private CheckBox WithoutLocCheckbox;
        private Label label1NAME_CEF;
        private TextBox DescBoxCEF;
        private Label label2DES_CEF;
        private Label label3LOC_CEF;
        private TextBox textBox1;
        private TextBox LocBox;
        private Label label3DATE_CEF;
        private Button OpnCalBtn;
        private TextBox DaBox;
        private Button DelBtn;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
        private TableLayoutPanel tableLayoutPanel3;
        private Button CrtEVBtm;
        private TableLayoutPanel tableLayoutPanel4;
        private TableLayoutPanel tableLayoutPanel5;
        private TableLayoutPanel tableLayoutPanel6;
    }
}