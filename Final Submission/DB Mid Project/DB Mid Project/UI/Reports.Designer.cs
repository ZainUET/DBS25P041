namespace DB_Mid_Project.UI
{
    partial class Reports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Reports));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            H1 = new Label();
            backLinkLabel = new LinkLabel();
            label1 = new Label();
            dataGridViewReport = new DataGridView();
            reportTypeComboBox = new ComboBox();
            generateButton = new Button();
            exportButton = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1349, 134);
            panel2.TabIndex = 9;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1177, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label6.Location = new Point(399, 47);
            label6.Name = "label6";
            label6.Size = new Size(566, 38);
            label6.TabIndex = 1;
            label6.Text = "FACULTY MANAGEMENT SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Location = new Point(0, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 597);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Location = new Point(1177, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 597);
            panel3.TabIndex = 11;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.BackColor = Color.Transparent;
            H1.Font = new Font("Arial Rounded MT Bold", 19.25F);
            H1.Location = new Point(668, 174);
            H1.Name = "H1";
            H1.Size = new Size(113, 30);
            H1.TabIndex = 26;
            H1.Text = "Reports";
            // 
            // backLinkLabel
            // 
            backLinkLabel.BackColor = Color.AliceBlue;
            backLinkLabel.Cursor = Cursors.Hand;
            backLinkLabel.Font = new Font("Arial Rounded MT Bold", 10.75F);
            backLinkLabel.LinkBehavior = LinkBehavior.NeverUnderline;
            backLinkLabel.LinkColor = Color.Black;
            backLinkLabel.Location = new Point(983, 543);
            backLinkLabel.Name = "backLinkLabel";
            backLinkLabel.Size = new Size(147, 133);
            backLinkLabel.TabIndex = 36;
            backLinkLabel.TabStop = true;
            backLinkLabel.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Back\r\n            ";
            backLinkLabel.LinkClicked += backLinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label1.Location = new Point(1021, 579);
            label1.Name = "label1";
            label1.Size = new Size(63, 54);
            label1.TabIndex = 38;
            label1.Text = "⬅";
            // 
            // dataGridViewReport
            // 
            dataGridViewReport.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewReport.BorderStyle = BorderStyle.None;
            dataGridViewReport.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewReport.Location = new Point(399, 357);
            dataGridViewReport.Name = "dataGridViewReport";
            dataGridViewReport.Size = new Size(544, 150);
            dataGridViewReport.TabIndex = 41;
            // 
            // reportTypeComboBox
            // 
            reportTypeComboBox.FormattingEnabled = true;
            reportTypeComboBox.Location = new Point(348, 234);
            reportTypeComboBox.Name = "reportTypeComboBox";
            reportTypeComboBox.Size = new Size(204, 23);
            reportTypeComboBox.TabIndex = 4;
            // 
            // generateButton
            // 
            generateButton.BackColor = Color.AliceBlue;
            generateButton.FlatStyle = FlatStyle.Flat;
            generateButton.Font = new Font("Arial", 10.25F, FontStyle.Bold);
            generateButton.Location = new Point(348, 274);
            generateButton.Name = "generateButton";
            generateButton.Size = new Size(204, 26);
            generateButton.TabIndex = 42;
            generateButton.Text = "Generate";
            generateButton.UseVisualStyleBackColor = false;
            generateButton.Click += generateButton_Click_1;
            // 
            // exportButton
            // 
            exportButton.BackColor = Color.AliceBlue;
            exportButton.FlatStyle = FlatStyle.Flat;
            exportButton.Font = new Font("Arial", 10.25F, FontStyle.Bold);
            exportButton.Location = new Point(348, 316);
            exportButton.Name = "exportButton";
            exportButton.Size = new Size(204, 26);
            exportButton.TabIndex = 43;
            exportButton.Text = "Export";
            exportButton.UseVisualStyleBackColor = false;
            exportButton.Click += exportButton_Click_1;
            // 
            // Reports
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(exportButton);
            Controls.Add(generateButton);
            Controls.Add(reportTypeComboBox);
            Controls.Add(dataGridViewReport);
            Controls.Add(label1);
            Controls.Add(backLinkLabel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(H1);
            Name = "Reports";
            Text = "Reports";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewReport).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Panel panel3;
        private Label label5;
        private Label H1;
        private LinkLabel backLinkLabel;
        private Label label1;
        private DataGridView dataGridViewReport;
        private ComboBox reportTypeComboBox;
        private Button generateButton;
        private Button exportButton;
    }
}