namespace DB_Mid_Project.UI
{
    partial class AllocateRoomToFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AllocateRoomToFaculty));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label5 = new Label();
            reservedHoursNumericUpDown = new NumericUpDown();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            semesterComboBox = new ComboBox();
            roomComboBox = new ComboBox();
            allocateButton = new Button();
            facultyComboBox = new ComboBox();
            fnameicon = new Label();
            H1 = new Label();
            backLinkLabel = new LinkLabel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservedHoursNumericUpDown).BeginInit();
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
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(label5);
            panel4.Controls.Add(reservedHoursNumericUpDown);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(semesterComboBox);
            panel4.Controls.Add(roomComboBox);
            panel4.Controls.Add(allocateButton);
            panel4.Controls.Add(facultyComboBox);
            panel4.Controls.Add(fnameicon);
            panel4.Controls.Add(H1);
            panel4.Location = new Point(555, 180);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 439);
            panel4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(67, 285);
            label5.Name = "label5";
            label5.Size = new Size(53, 16);
            label5.TabIndex = 48;
            label5.Text = "Hours:";
            // 
            // reservedHoursNumericUpDown
            // 
            reservedHoursNumericUpDown.Location = new Point(70, 302);
            reservedHoursNumericUpDown.Name = "reservedHoursNumericUpDown";
            reservedHoursNumericUpDown.Size = new Size(267, 23);
            reservedHoursNumericUpDown.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.Location = new Point(69, 211);
            label4.Name = "label4";
            label4.Size = new Size(78, 16);
            label4.TabIndex = 46;
            label4.Text = "Semester:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.Location = new Point(69, 140);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 45;
            label3.Text = "Room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(69, 63);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 44;
            label2.Text = "Name:";
            // 
            // semesterComboBox
            // 
            semesterComboBox.Cursor = Cursors.Hand;
            semesterComboBox.Font = new Font("Arial", 9F);
            semesterComboBox.FormattingEnabled = true;
            semesterComboBox.Location = new Point(70, 230);
            semesterComboBox.Name = "semesterComboBox";
            semesterComboBox.Size = new Size(267, 23);
            semesterComboBox.TabIndex = 43;
            // 
            // roomComboBox
            // 
            roomComboBox.Cursor = Cursors.Hand;
            roomComboBox.Font = new Font("Arial", 9F);
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(70, 158);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(267, 23);
            roomComboBox.TabIndex = 42;
            // 
            // allocateButton
            // 
            allocateButton.Cursor = Cursors.Hand;
            allocateButton.FlatStyle = FlatStyle.Flat;
            allocateButton.Font = new Font("Arial Rounded MT Bold", 10F);
            allocateButton.Location = new Point(70, 363);
            allocateButton.Name = "allocateButton";
            allocateButton.Size = new Size(267, 31);
            allocateButton.TabIndex = 41;
            allocateButton.Text = "Allocate Button";
            allocateButton.UseVisualStyleBackColor = true;
            allocateButton.Click += allocateButton_Click_1;
            // 
            // facultyComboBox
            // 
            facultyComboBox.Cursor = Cursors.Hand;
            facultyComboBox.Font = new Font("Arial", 9F);
            facultyComboBox.FormattingEnabled = true;
            facultyComboBox.Location = new Point(70, 81);
            facultyComboBox.Name = "facultyComboBox";
            facultyComboBox.Size = new Size(267, 23);
            facultyComboBox.TabIndex = 38;
            // 
            // fnameicon
            // 
            fnameicon.AutoSize = true;
            fnameicon.Font = new Font("Segoe UI", 12F);
            fnameicon.Location = new Point(52, 74);
            fnameicon.Name = "fnameicon";
            fnameicon.Size = new Size(0, 21);
            fnameicon.TabIndex = 28;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.BackColor = Color.AliceBlue;
            H1.Font = new Font("Arial Rounded MT Bold", 19.25F);
            H1.Location = new Point(108, 20);
            H1.Name = "H1";
            H1.Size = new Size(211, 30);
            H1.TabIndex = 26;
            H1.Text = "Allocate Rooms";
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
            backLinkLabel.LinkClicked += backLinkLabel_LinkClicked_1;
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
            // AllocateRoomToFaculty
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(label1);
            Controls.Add(backLinkLabel);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AllocateRoomToFaculty";
            Text = "Assign Faculty Course";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)reservedHoursNumericUpDown).EndInit();
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
        private Panel panel4;
        private Button allocateButton;
        private Label label5;
        private ComboBox facultyComboBox;
        private Label fnameicon;
        private Label H1;
        private LinkLabel backLinkLabel;
        private Label label1;
        private ComboBox semesterComboBox;
        private ComboBox roomComboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private NumericUpDown reservedHoursNumericUpDown;
    }
}