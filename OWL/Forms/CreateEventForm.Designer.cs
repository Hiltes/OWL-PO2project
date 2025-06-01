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
            panel1 = new Panel();
            WithoutLocCheckbox = new CheckBox();
            label1NAME_CEF = new Label();
            splitContainer1 = new SplitContainer();
            label3DATE_CEF = new Label();
            label3LOC_CEF = new Label();
            label2DES_CEF = new Label();
            DaBox = new TextBox();
            OpnCalBtn = new Button();
            textBox1 = new TextBox();
            LocBox = new TextBox();
            DescBoxCEF = new TextBox();
            CrtEVBtm = new Button();
            DelBtn = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            SuspendLayout();
            // 
            // CEFMainLabel
            // 
            CEFMainLabel.AutoSize = true;
            CEFMainLabel.Font = new Font("Verdana", 18.8113213F, FontStyle.Bold);
            CEFMainLabel.ForeColor = Color.White;
            CEFMainLabel.Location = new Point(338, 21);
            CEFMainLabel.Name = "CEFMainLabel";
            CEFMainLabel.Size = new Size(412, 34);
            CEFMainLabel.TabIndex = 0;
            CEFMainLabel.Text = "Edytuj swoje wydarzenie";
            CEFMainLabel.Click += CEFMainLabel_Click;
            // 
            // panel1
            // 
            panel1.Controls.Add(CEFMainLabel);
            panel1.Location = new Point(11, 11);
            panel1.Name = "panel1";
            panel1.Size = new Size(1049, 78);
            panel1.TabIndex = 1;
            panel1.Paint += panel1_Paint;
            // 
            // WithoutLocCheckbox
            // 
            WithoutLocCheckbox.AutoSize = true;
            WithoutLocCheckbox.FlatStyle = FlatStyle.Popup;
            WithoutLocCheckbox.Font = new Font("Verdana", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 238);
            WithoutLocCheckbox.ForeColor = Color.White;
            WithoutLocCheckbox.Location = new Point(8, 187);
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
            label1NAME_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label1NAME_CEF.ForeColor = Color.White;
            label1NAME_CEF.Location = new Point(0, 8);
            label1NAME_CEF.Name = "label1NAME_CEF";
            label1NAME_CEF.Size = new Size(209, 22);
            label1NAME_CEF.TabIndex = 3;
            label1NAME_CEF.Text = "Nazwa wydarzenia:";
            // 
            // splitContainer1
            // 
            splitContainer1.Location = new Point(61, 99);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(label3DATE_CEF);
            splitContainer1.Panel1.Controls.Add(label3LOC_CEF);
            splitContainer1.Panel1.Controls.Add(label2DES_CEF);
            splitContainer1.Panel1.Controls.Add(label1NAME_CEF);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(DaBox);
            splitContainer1.Panel2.Controls.Add(OpnCalBtn);
            splitContainer1.Panel2.Controls.Add(textBox1);
            splitContainer1.Panel2.Controls.Add(WithoutLocCheckbox);
            splitContainer1.Panel2.Controls.Add(LocBox);
            splitContainer1.Panel2.Controls.Add(DescBoxCEF);
            splitContainer1.Size = new Size(930, 320);
            splitContainer1.SplitterDistance = 203;
            splitContainer1.TabIndex = 4;
            // 
            // label3DATE_CEF
            // 
            label3DATE_CEF.AutoSize = true;
            label3DATE_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label3DATE_CEF.ForeColor = Color.White;
            label3DATE_CEF.Location = new Point(21, 283);
            label3DATE_CEF.Name = "label3DATE_CEF";
            label3DATE_CEF.Size = new Size(188, 22);
            label3DATE_CEF.TabIndex = 6;
            label3DATE_CEF.Text = "Data wydarzenia:";
            // 
            // label3LOC_CEF
            // 
            label3LOC_CEF.AutoSize = true;
            label3LOC_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label3LOC_CEF.ForeColor = Color.White;
            label3LOC_CEF.Location = new Point(81, 222);
            label3LOC_CEF.Name = "label3LOC_CEF";
            label3LOC_CEF.Size = new Size(129, 22);
            label3LOC_CEF.TabIndex = 5;
            label3LOC_CEF.Text = "Lokalizacja:";
            // 
            // label2DES_CEF
            // 
            label2DES_CEF.AutoSize = true;
            label2DES_CEF.Font = new Font("Verdana", 12.18868F, FontStyle.Bold);
            label2DES_CEF.ForeColor = Color.White;
            label2DES_CEF.Location = new Point(23, 57);
            label2DES_CEF.Name = "label2DES_CEF";
            label2DES_CEF.Size = new Size(186, 22);
            label2DES_CEF.TabIndex = 4;
            label2DES_CEF.Text = "Opis wydarzenia:";
            label2DES_CEF.Click += label1_Click;
            // 
            // DaBox
            // 
            DaBox.BackColor = SystemColors.ControlDark;
            DaBox.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DaBox.Location = new Point(8, 275);
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
            OpnCalBtn.BackColor = Color.FromArgb(220, 140, 115);
            OpnCalBtn.Font = new Font("Verdana", 8.150944F, FontStyle.Bold, GraphicsUnit.Point, 238);
            OpnCalBtn.ForeColor = Color.White;
            OpnCalBtn.Location = new Point(214, 278);
            OpnCalBtn.Name = "OpnCalBtn";
            OpnCalBtn.Size = new Size(93, 34);
            OpnCalBtn.TabIndex = 3;
            OpnCalBtn.Text = "Kalendarz";
            OpnCalBtn.UseVisualStyleBackColor = false;
            OpnCalBtn.Click += OpnCalBtn_Click;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(105, 100, 135);
            textBox1.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.ForeColor = Color.White;
            textBox1.Location = new Point(8, 3);
            textBox1.MaximumSize = new Size(650, 40);
            textBox1.MinimumSize = new Size(650, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(650, 40);
            textBox1.TabIndex = 2;
            textBox1.TextChanged += EnableBtn;
            // 
            // LocBox
            // 
            LocBox.BackColor = Color.FromArgb(105, 100, 135);
            LocBox.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            LocBox.ForeColor = Color.White;
            LocBox.Location = new Point(8, 215);
            LocBox.MaximumSize = new Size(650, 40);
            LocBox.MinimumSize = new Size(650, 40);
            LocBox.Name = "LocBox";
            LocBox.Size = new Size(650, 40);
            LocBox.TabIndex = 1;
            LocBox.TextChanged += EnableBtn;
            // 
            // DescBoxCEF
            // 
            DescBoxCEF.AcceptsReturn = true;
            DescBoxCEF.BackColor = Color.FromArgb(105, 100, 135);
            DescBoxCEF.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DescBoxCEF.ForeColor = Color.White;
            DescBoxCEF.Location = new Point(8, 57);
            DescBoxCEF.MaximumSize = new Size(650, 120);
            DescBoxCEF.MinimumSize = new Size(650, 120);
            DescBoxCEF.Multiline = true;
            DescBoxCEF.Name = "DescBoxCEF";
            DescBoxCEF.Size = new Size(650, 120);
            DescBoxCEF.TabIndex = 0;
            DescBoxCEF.TextChanged += EnableBtn;
            // 
            // CrtEVBtm
            // 
            CrtEVBtm.BackColor = Color.FromArgb(220, 140, 115);
            CrtEVBtm.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            CrtEVBtm.ForeColor = Color.White;
            CrtEVBtm.Location = new Point(712, 455);
            CrtEVBtm.Name = "CrtEVBtm";
            CrtEVBtm.Size = new Size(214, 44);
            CrtEVBtm.TabIndex = 5;
            CrtEVBtm.Text = "Zapisz";
            CrtEVBtm.UseVisualStyleBackColor = false;
            CrtEVBtm.Click += CrtEVBtm_Click;
            // 
            // DelBtn
            // 
            DelBtn.BackColor = Color.FromArgb(220, 140, 115);
            DelBtn.Enabled = false;
            DelBtn.Font = new Font("Verdana", 10.18868F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DelBtn.ForeColor = Color.White;
            DelBtn.Location = new Point(572, 455);
            DelBtn.Name = "DelBtn";
            DelBtn.Size = new Size(134, 44);
            DelBtn.TabIndex = 6;
            DelBtn.Text = "Usuń";
            DelBtn.UseVisualStyleBackColor = false;
            DelBtn.Click += DelBtn_Click;
            // 
            // CreateEventForm
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 50, 75);
            ClientSize = new Size(1072, 531);
            Controls.Add(DelBtn);
            Controls.Add(CrtEVBtm);
            Controls.Add(splitContainer1);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "CreateEventForm";
            Text = "OWL";
            Load += CreateEventForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel1.PerformLayout();
            splitContainer1.Panel2.ResumeLayout(false);
            splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label CEFMainLabel;
        private Panel panel1;
        private CheckBox WithoutLocCheckbox;
        private Label label1NAME_CEF;
        private SplitContainer splitContainer1;
        private TextBox DescBoxCEF;
        private Label label2DES_CEF;
        private Label label3LOC_CEF;
        private TextBox textBox1;
        private TextBox LocBox;
        private Button CrtEVBtm;
        private Label label3DATE_CEF;
        private Button OpnCalBtn;
        private TextBox DaBox;
        private Button DelBtn;
    }
}