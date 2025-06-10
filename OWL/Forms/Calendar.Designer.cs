namespace OWL.Forms
{
    partial class Calendar
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
            monthCalendar = new MonthCalendar();
            textBox1 = new TextBox();
            CalLabel1 = new Label();
            CalLabel2 = new Label();
            ApplyButtonCal = new Button();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.Anchor = AnchorStyles.None;
            monthCalendar.BackColor = SystemColors.WindowFrame;
            monthCalendar.Location = new Point(326, 9);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Font = new Font("Verdana", 16.3018875F, FontStyle.Regular, GraphicsUnit.Point, 238);
            textBox1.Location = new Point(100, 83);
            textBox1.Margin = new Padding(3, 3, 3, 100);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(205, 37);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // CalLabel1
            // 
            CalLabel1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            CalLabel1.AutoSize = true;
            CalLabel1.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CalLabel1.Location = new Point(26, 18);
            CalLabel1.Name = "CalLabel1";
            CalLabel1.Size = new Size(279, 22);
            CalLabel1.TabIndex = 2;
            CalLabel1.Text = "Wybierz datę z kalendarza";
            // 
            // CalLabel2
            // 
            CalLabel2.Anchor = AnchorStyles.Right;
            CalLabel2.AutoSize = true;
            CalLabel2.Font = new Font("Verdana", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CalLabel2.Location = new Point(137, 49);
            CalLabel2.Name = "CalLabel2";
            CalLabel2.Size = new Size(168, 22);
            CalLabel2.TabIndex = 3;
            CalLabel2.Text = "Wybrana data to:";
            // 
            // ApplyButtonCal
            // 
            ApplyButtonCal.Anchor = AnchorStyles.None;
            ApplyButtonCal.AutoSize = true;
            ApplyButtonCal.BackColor = Color.FromArgb(220, 140, 115);
            ApplyButtonCal.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            ApplyButtonCal.ForeColor = Color.White;
            ApplyButtonCal.Location = new Point(376, 208);
            ApplyButtonCal.Name = "ApplyButtonCal";
            ApplyButtonCal.Size = new Size(189, 39);
            ApplyButtonCal.TabIndex = 4;
            ApplyButtonCal.Text = "Zatwierdź";
            ApplyButtonCal.UseVisualStyleBackColor = false;
            ApplyButtonCal.Click += ApplyButtonCal_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.AutoSize = true;
            tableLayoutPanel1.ColumnCount = 2;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 0);
            tableLayoutPanel1.Controls.Add(ApplyButtonCal, 1, 1);
            tableLayoutPanel1.Controls.Add(monthCalendar, 1, 0);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 2;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 76.35659F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 23.6434116F));
            tableLayoutPanel1.Size = new Size(628, 258);
            tableLayoutPanel1.TabIndex = 5;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.AutoSize = true;
            tableLayoutPanel2.ColumnCount = 1;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(CalLabel1, 0, 0);
            tableLayoutPanel2.Controls.Add(CalLabel2, 0, 1);
            tableLayoutPanel2.Controls.Add(textBox1, 0, 2);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 3);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 3;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 110F));
            tableLayoutPanel2.Size = new Size(308, 191);
            tableLayoutPanel2.TabIndex = 6;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 100, 135);
            ClientSize = new Size(628, 258);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Margin = new Padding(4, 3, 4, 3);
            Name = "Calendar";
            Text = "Calendar";
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private TextBox textBox1;
        private Label CalLabel1;
        private Label CalLabel2;
        private Button ApplyButtonCal;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}