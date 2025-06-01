namespace OWL.Forms
{
    partial class EventDetailsForm
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
            components = new System.ComponentModel.Container();
            tableLayoutPanel1 = new TableLayoutPanel();
            NLabl1 = new Label();
            NameLabel = new Label();
            label1 = new Label();
            DescBox = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            NLab3 = new Label();
            Nlab4 = new Label();
            EventDateLabel = new Label();
            LocLabel = new Label();
            dataGridView1 = new DataGridView();
            tableLayoutPanel3 = new TableLayoutPanel();
            AddtoPartBTN = new Button();
            REMfromPartBTN = new Button();
            participationBindingSource = new BindingSource(components);
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)participationBindingSource).BeginInit();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(60, 50, 75);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(NLabl1, 0, 1);
            tableLayoutPanel1.Controls.Add(NameLabel, 0, 2);
            tableLayoutPanel1.Controls.Add(label1, 0, 3);
            tableLayoutPanel1.Controls.Add(DescBox, 0, 4);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 6);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 5);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel3, 0, 7);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Margin = new Padding(4, 2, 4, 2);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 8;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5.316435F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10.63287F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 7.91666651F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 9.166667F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 27.5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 25.833334F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 13.75F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 48F));
            tableLayoutPanel1.Size = new Size(1072, 531);
            tableLayoutPanel1.TabIndex = 1;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // NLabl1
            // 
            NLabl1.Anchor = AnchorStyles.Top;
            NLabl1.AutoSize = true;
            NLabl1.BackColor = Color.FromArgb(105, 100, 135);
            NLabl1.Font = new Font("Verdana", 16.3018875F, FontStyle.Bold, GraphicsUnit.Point, 238);
            NLabl1.ForeColor = Color.White;
            NLabl1.Location = new Point(372, 25);
            NLabl1.Name = "NLabl1";
            NLabl1.Size = new Size(328, 31);
            NLabl1.TabIndex = 0;
            NLabl1.Text = "Szczegóły Wydarzenia";
            // 
            // NameLabel
            // 
            NameLabel.AutoSize = true;
            NameLabel.Dock = DockStyle.Top;
            NameLabel.Font = new Font("Verdana", 12.2264156F, FontStyle.Regular, GraphicsUnit.Point, 238);
            NameLabel.ForeColor = Color.White;
            NameLabel.Location = new Point(3, 76);
            NameLabel.Name = "NameLabel";
            NameLabel.Size = new Size(1066, 22);
            NameLabel.TabIndex = 1;
            NameLabel.Text = "label2";
            NameLabel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top;
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(105, 100, 135);
            label1.Font = new Font("Verdana", 14.2641506F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label1.ForeColor = Color.White;
            label1.Location = new Point(432, 114);
            label1.Name = "label1";
            label1.Size = new Size(208, 25);
            label1.TabIndex = 2;
            label1.Text = "Opis wydarzenia";
            // 
            // DescBox
            // 
            DescBox.Anchor = AnchorStyles.Top;
            DescBox.BackColor = Color.FromArgb(105, 100, 135);
            DescBox.ForeColor = Color.White;
            DescBox.Location = new Point(44, 161);
            DescBox.Margin = new Padding(20, 3, 3, 20);
            DescBox.MaximumSize = new Size(1000, 120);
            DescBox.MinimumSize = new Size(1000, 120);
            DescBox.Multiline = true;
            DescBox.Name = "DescBox";
            DescBox.ReadOnly = true;
            DescBox.Size = new Size(1000, 120);
            DescBox.TabIndex = 3;
            DescBox.TextChanged += textBox1_TextChanged;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.Anchor = AnchorStyles.Top;
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 25F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 75F));
            tableLayoutPanel2.Controls.Add(NLab3, 0, 0);
            tableLayoutPanel2.Controls.Add(Nlab4, 0, 1);
            tableLayoutPanel2.Controls.Add(EventDateLabel, 1, 1);
            tableLayoutPanel2.Controls.Add(LocLabel, 1, 0);
            tableLayoutPanel2.Location = new Point(89, 417);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 2;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Size = new Size(893, 54);
            tableLayoutPanel2.TabIndex = 5;
            tableLayoutPanel2.Paint += tableLayoutPanel2_Paint;
            // 
            // NLab3
            // 
            NLab3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            NLab3.AutoSize = true;
            NLab3.BackColor = Color.FromArgb(105, 100, 135);
            NLab3.Font = new Font("Verdana", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 238);
            NLab3.ForeColor = Color.White;
            NLab3.Location = new Point(115, 0);
            NLab3.Name = "NLab3";
            NLab3.Size = new Size(105, 18);
            NLab3.TabIndex = 0;
            NLab3.Text = "Lokalizacja:";
            // 
            // Nlab4
            // 
            Nlab4.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            Nlab4.AutoSize = true;
            Nlab4.BackColor = Color.FromArgb(105, 100, 135);
            Nlab4.Font = new Font("Verdana", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 238);
            Nlab4.ForeColor = Color.White;
            Nlab4.Location = new Point(50, 27);
            Nlab4.Name = "Nlab4";
            Nlab4.Size = new Size(170, 18);
            Nlab4.TabIndex = 1;
            Nlab4.Text = "Termin wydarzenia:";
            // 
            // EventDateLabel
            // 
            EventDateLabel.Anchor = AnchorStyles.Top;
            EventDateLabel.AutoSize = true;
            EventDateLabel.ForeColor = Color.White;
            EventDateLabel.Location = new Point(535, 27);
            EventDateLabel.Name = "EventDateLabel";
            EventDateLabel.Size = new Size(45, 16);
            EventDateLabel.TabIndex = 3;
            EventDateLabel.Text = "label5";
            // 
            // LocLabel
            // 
            LocLabel.Anchor = AnchorStyles.Top;
            LocLabel.AutoSize = true;
            LocLabel.ForeColor = Color.White;
            LocLabel.Location = new Point(535, 0);
            LocLabel.Name = "LocLabel";
            LocLabel.Size = new Size(45, 16);
            LocLabel.TabIndex = 2;
            LocLabel.Text = "label4";
            LocLabel.Click += LocLabel_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;
            dataGridView1.Anchor = AnchorStyles.Top;
            dataGridView1.BackgroundColor = Color.FromArgb(105, 100, 135);
            dataGridView1.ColumnHeadersHeight = 25;
            dataGridView1.Location = new Point(15, 293);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowHeadersWidth = 45;
            dataGridView1.ScrollBars = ScrollBars.None;
            dataGridView1.Size = new Size(1041, 115);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // tableLayoutPanel3
            // 
            tableLayoutPanel3.Anchor = AnchorStyles.Top;
            tableLayoutPanel3.ColumnCount = 2;
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Controls.Add(AddtoPartBTN, 1, 0);
            tableLayoutPanel3.Controls.Add(REMfromPartBTN, 0, 0);
            tableLayoutPanel3.Location = new Point(90, 483);
            tableLayoutPanel3.Name = "tableLayoutPanel3";
            tableLayoutPanel3.RowCount = 1;
            tableLayoutPanel3.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel3.Size = new Size(892, 41);
            tableLayoutPanel3.TabIndex = 6;
            // 
            // AddtoPartBTN
            // 
            AddtoPartBTN.Anchor = AnchorStyles.Top;
            AddtoPartBTN.BackColor = Color.FromArgb(220, 140, 115);
            AddtoPartBTN.ForeColor = Color.White;
            AddtoPartBTN.Location = new Point(463, 3);
            AddtoPartBTN.Name = "AddtoPartBTN";
            AddtoPartBTN.Size = new Size(411, 35);
            AddtoPartBTN.TabIndex = 0;
            AddtoPartBTN.Text = "Weź udział";
            AddtoPartBTN.UseVisualStyleBackColor = false;
            AddtoPartBTN.Click += AddtoPartBTN_Click;
            // 
            // REMfromPartBTN
            // 
            REMfromPartBTN.Anchor = AnchorStyles.Top;
            REMfromPartBTN.BackColor = Color.FromArgb(220, 140, 115);
            REMfromPartBTN.Enabled = false;
            REMfromPartBTN.ForeColor = Color.White;
            REMfromPartBTN.Location = new Point(17, 3);
            REMfromPartBTN.Name = "REMfromPartBTN";
            REMfromPartBTN.Size = new Size(411, 35);
            REMfromPartBTN.TabIndex = 1;
            REMfromPartBTN.Text = "Rezygnuj";
            REMfromPartBTN.UseVisualStyleBackColor = false;
            REMfromPartBTN.Click += REMfromPartBTN_Click;
            // 
            // participationBindingSource
            // 
            participationBindingSource.DataSource = typeof(Models.Participation);
            // 
            // EventDetailsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 14F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(195, 193, 193);
            ClientSize = new Size(1072, 531);
            Controls.Add(tableLayoutPanel1);
            Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Margin = new Padding(4, 2, 4, 2);
            Name = "EventDetailsForm";
            Text = "OWL";
            Load += EventDetailsForm_Load;
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)participationBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label NLabl1;
        private Label NameLabel;
        private Label label1;
        private TextBox DescBox;
        private DataGridView dataGridView1;
        private TableLayoutPanel tableLayoutPanel2;
        private Label NLab3;
        private Label Nlab4;
        private Label LocLabel;
        private Label EventDateLabel;
        private TableLayoutPanel tableLayoutPanel3;
        private Button AddtoPartBTN;
        private Button REMfromPartBTN;
        private BindingSource participationBindingSource;
    }
}