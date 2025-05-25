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
            SuspendLayout();
            // 
            // monthCalendar
            // 
            monthCalendar.BackColor = SystemColors.WindowFrame;
            monthCalendar.Location = new Point(298, 18);
            monthCalendar.Name = "monthCalendar";
            monthCalendar.TabIndex = 0;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(224, 224, 224);
            textBox1.Location = new Point(7, 96);
            textBox1.MaximumSize = new Size(230, 40);
            textBox1.MinimumSize = new Size(230, 40);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(230, 40);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // CalLabel1
            // 
            CalLabel1.AutoSize = true;
            CalLabel1.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CalLabel1.Location = new Point(7, 18);
            CalLabel1.Name = "CalLabel1";
            CalLabel1.Size = new Size(279, 22);
            CalLabel1.TabIndex = 2;
            CalLabel1.Text = "Wybierz datę z kalendarza";
            // 
            // CalLabel2
            // 
            CalLabel2.AutoSize = true;
            CalLabel2.Font = new Font("Verdana", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 238);
            CalLabel2.Location = new Point(7, 60);
            CalLabel2.Name = "CalLabel2";
            CalLabel2.Size = new Size(168, 22);
            CalLabel2.TabIndex = 3;
            CalLabel2.Text = "Wybrana data to:";
            CalLabel2.Click += CalLabel2_Click;
            // 
            // ApplyButtonCal
            // 
            ApplyButtonCal.BackColor = Color.FromArgb(220, 140, 115);
            ApplyButtonCal.Font = new Font("Verdana", 12.2264156F, FontStyle.Bold);
            ApplyButtonCal.ForeColor = Color.White;
            ApplyButtonCal.Location = new Point(399, 207);
            ApplyButtonCal.Name = "ApplyButtonCal";
            ApplyButtonCal.Size = new Size(189, 39);
            ApplyButtonCal.TabIndex = 4;
            ApplyButtonCal.Text = "Zatwierdź";
            ApplyButtonCal.UseVisualStyleBackColor = false;
            ApplyButtonCal.Click += ApplyButtonCal_Click;
            // 
            // Calendar
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(105, 100, 135);
            ClientSize = new Size(628, 258);
            Controls.Add(ApplyButtonCal);
            Controls.Add(CalLabel2);
            Controls.Add(CalLabel1);
            Controls.Add(textBox1);
            Controls.Add(monthCalendar);
            Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 3, 4, 3);
            Name = "Calendar";
            Text = "Calendar";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar monthCalendar;
        private TextBox textBox1;
        private Label CalLabel1;
        private Label CalLabel2;
        private Button ApplyButtonCal;
    }
}