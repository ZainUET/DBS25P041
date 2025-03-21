namespace DB_Mid_Project.UI
{
    partial class RemoveFacultyCourse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RemoveFacultyCourse));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            H1 = new Label();
            backLinkLabel = new LinkLabel();
            label1 = new Label();
            dataGridViewFacultyCourses = new DataGridView();
            removeButton = new Button();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacultyCourses).BeginInit();
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
            H1.Location = new Point(551, 178);
            H1.Name = "H1";
            H1.Size = new Size(312, 30);
            H1.TabIndex = 26;
            H1.Text = "Remove Faculty Course";
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
            backLinkLabel.LinkClicked += this.backLinkLabel_LinkClicked_1;
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
            // dataGridViewFacultyCourses
            // 
            dataGridViewFacultyCourses.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewFacultyCourses.BorderStyle = BorderStyle.None;
            dataGridViewFacultyCourses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFacultyCourses.Location = new Point(403, 289);
            dataGridViewFacultyCourses.Name = "dataGridViewFacultyCourses";
            dataGridViewFacultyCourses.Size = new Size(544, 150);
            dataGridViewFacultyCourses.TabIndex = 41;
            // 
            // removeButton
            // 
            removeButton.BackColor = Color.AliceBlue;
            removeButton.Cursor = Cursors.Hand;
            removeButton.FlatAppearance.BorderColor = Color.Black;
            removeButton.FlatAppearance.MouseDownBackColor = Color.AliceBlue;
            removeButton.FlatAppearance.MouseOverBackColor = Color.AliceBlue;
            removeButton.FlatStyle = FlatStyle.Flat;
            removeButton.Font = new Font("Arial Rounded MT Bold", 14.75F);
            removeButton.Location = new Point(587, 498);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(178, 33);
            removeButton.TabIndex = 43;
            removeButton.Text = "Remove";
            removeButton.UseVisualStyleBackColor = false;
            removeButton.Click += this.removeButton_Click_1;
            // 
            // RemoveFacultyCourse
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(removeButton);
            Controls.Add(dataGridViewFacultyCourses);
            Controls.Add(label1);
            Controls.Add(backLinkLabel);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Controls.Add(H1);
            Name = "RemoveFacultyCourse";
            Text = "Remove Faculty Course";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFacultyCourses).EndInit();
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
        private DataGridView dataGridViewFacultyCourses;
        private Button removeButton;
    }
}