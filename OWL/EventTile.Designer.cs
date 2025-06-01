namespace OWL
{
    partial class EventTile
    {
        /// <summary> 
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod wygenerowany przez Projektanta składników

        /// <summary> 
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować 
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            tableLayoutPanel1 = new TableLayoutPanel();
            lblTitle = new Label();
            lblDate = new Label();
            lblLocation = new Label();
            txtDesc = new TextBox();
            tableLayoutPanel2 = new TableLayoutPanel();
            button1 = new Button();
            button2 = new Button();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = Color.FromArgb(120, 115, 150);
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblTitle, 0, 0);
            tableLayoutPanel1.Controls.Add(lblDate, 0, 1);
            tableLayoutPanel1.Controls.Add(lblLocation, 0, 3);
            tableLayoutPanel1.Controls.Add(txtDesc, 0, 2);
            tableLayoutPanel1.Location = new Point(-1, 8);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 20F));
            tableLayoutPanel1.Size = new Size(252, 185);
            tableLayoutPanel1.TabIndex = 0;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Verdana", 10.18868F, FontStyle.Bold, GraphicsUnit.Point, 238);
            lblTitle.Location = new Point(3, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(61, 18);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "lblTitle";
            // 
            // lblDate
            // 
            lblDate.AutoSize = true;
            lblDate.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            lblDate.Location = new Point(3, 37);
            lblDate.Name = "lblDate";
            lblDate.Size = new Size(52, 16);
            lblDate.TabIndex = 1;
            lblDate.Text = "lblDate";
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Verdana", 10.18868F, FontStyle.Bold);
            lblLocation.Location = new Point(3, 147);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(95, 18);
            lblLocation.TabIndex = 3;
            lblLocation.Text = "lblLocation";
            // 
            // txtDesc
            // 
            txtDesc.BackColor = Color.FromArgb(120, 115, 150);
            txtDesc.BorderStyle = BorderStyle.None;
            txtDesc.ForeColor = SystemColors.InactiveBorder;
            txtDesc.ImeMode = ImeMode.NoControl;
            txtDesc.Location = new Point(3, 58);
            txtDesc.MaximumSize = new Size(245, 90);
            txtDesc.MinimumSize = new Size(245, 90);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ReadOnly = true;
            txtDesc.Size = new Size(245, 90);
            txtDesc.TabIndex = 2;
            txtDesc.Text = "txtDesc";
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 2;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            tableLayoutPanel2.Controls.Add(button1, 1, 0);
            tableLayoutPanel2.Controls.Add(button2, 0, 0);
            tableLayoutPanel2.Location = new Point(1, 194);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle());
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel2.Size = new Size(248, 29);
            tableLayoutPanel2.TabIndex = 1;
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(220, 140, 115);
            button1.Dock = DockStyle.Fill;
            button1.Font = new Font("Verdana", 8.150944F, FontStyle.Regular, GraphicsUnit.Point, 238);
            button1.ForeColor = Color.White;
            button1.Location = new Point(127, 3);
            button1.Name = "button1";
            button1.Size = new Size(118, 26);
            button1.TabIndex = 0;
            button1.Text = "Szczegóły";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(220, 140, 115);
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.Font = new Font("Verdana", 8.150944F);
            button2.ForeColor = Color.White;
            button2.Location = new Point(3, 3);
            button2.Name = "button2";
            button2.Size = new Size(118, 26);
            button2.TabIndex = 1;
            button2.Text = "Edytuj";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // EventTile
            // 
            AutoScaleDimensions = new SizeF(7F, 17F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(60, 50, 75);
            BorderStyle = BorderStyle.FixedSingle;
            Controls.Add(tableLayoutPanel2);
            Controls.Add(tableLayoutPanel1);
            Name = "EventTile";
            Padding = new Padding(5);
            Size = new Size(250, 230);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TableLayoutPanel tableLayoutPanel1;
        private Label lblTitle;
        private Label lblDate;
        private TextBox txtDesc;
        private Label lblLocation;
        private TableLayoutPanel tableLayoutPanel2;
        private Button button1;
        private Button button2;
    }
}
