namespace DB_Mid_Project.UI
{
    partial class ScheduleCourseForFaculty
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ScheduleCourseForFaculty));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            label8 = new Label();
            label7 = new Label();
            startTimePicker = new DateTimePicker();
            endTimePicker = new DateTimePicker();
            label5 = new Label();
            dayOfWeekComboBox = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            courseComboBox = new ComboBox();
            roomComboBox = new ComboBox();
            scheduleButton = new Button();
            facultyComboBox = new ComboBox();
            fnameicon = new Label();
            H1 = new Label();
            backLinkLabel = new LinkLabel();
            label1 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
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
            panel4.Controls.Add(label8);
            panel4.Controls.Add(label7);
            panel4.Controls.Add(startTimePicker);
            panel4.Controls.Add(endTimePicker);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(dayOfWeekComboBox);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(courseComboBox);
            panel4.Controls.Add(roomComboBox);
            panel4.Controls.Add(scheduleButton);
            panel4.Controls.Add(facultyComboBox);
            panel4.Controls.Add(fnameicon);
            panel4.Controls.Add(H1);
            panel4.Location = new Point(507, 169);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 496);
            panel4.TabIndex = 13;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial", 10F, FontStyle.Bold);
            label8.Location = new Point(70, 348);
            label8.Name = "label8";
            label8.Size = new Size(75, 16);
            label8.TabIndex = 52;
            label8.Text = "End Time:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Arial", 10F, FontStyle.Bold);
            label7.Location = new Point(69, 286);
            label7.Name = "label7";
            label7.Size = new Size(81, 16);
            label7.TabIndex = 51;
            label7.Text = "Start Time:";
            // 
            // startTimePicker
            // 
            startTimePicker.Format = DateTimePickerFormat.Time;
            startTimePicker.Location = new Point(70, 305);
            startTimePicker.Name = "startTimePicker";
            startTimePicker.ShowUpDown = true;
            startTimePicker.Size = new Size(267, 23);
            startTimePicker.TabIndex = 50;
            // 
            // endTimePicker
            // 
            endTimePicker.Format = DateTimePickerFormat.Time;
            endTimePicker.Location = new Point(69, 367);
            endTimePicker.Name = "endTimePicker";
            endTimePicker.ShowUpDown = true;
            endTimePicker.Size = new Size(267, 23);
            endTimePicker.TabIndex = 49;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial", 10F, FontStyle.Bold);
            label5.Location = new Point(70, 222);
            label5.Name = "label5";
            label5.Size = new Size(36, 16);
            label5.TabIndex = 48;
            label5.Text = "Day:";
            // 
            // dayOfWeekComboBox
            // 
            dayOfWeekComboBox.Cursor = Cursors.Hand;
            dayOfWeekComboBox.Font = new Font("Arial", 9F);
            dayOfWeekComboBox.FormattingEnabled = true;
            dayOfWeekComboBox.Location = new Point(70, 241);
            dayOfWeekComboBox.Name = "dayOfWeekComboBox";
            dayOfWeekComboBox.Size = new Size(267, 23);
            dayOfWeekComboBox.TabIndex = 47;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial", 10F, FontStyle.Bold);
            label4.Location = new Point(68, 160);
            label4.Name = "label4";
            label4.Size = new Size(62, 16);
            label4.TabIndex = 46;
            label4.Text = "Course:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial", 10F, FontStyle.Bold);
            label3.Location = new Point(68, 101);
            label3.Name = "label3";
            label3.Size = new Size(51, 16);
            label3.TabIndex = 45;
            label3.Text = "Room:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10F, FontStyle.Bold);
            label2.Location = new Point(69, 47);
            label2.Name = "label2";
            label2.Size = new Size(50, 16);
            label2.TabIndex = 44;
            label2.Text = "Name:";
            // 
            // courseComboBox
            // 
            courseComboBox.Cursor = Cursors.Hand;
            courseComboBox.Font = new Font("Arial", 9F);
            courseComboBox.FormattingEnabled = true;
            courseComboBox.Location = new Point(69, 179);
            courseComboBox.Name = "courseComboBox";
            courseComboBox.Size = new Size(267, 23);
            courseComboBox.TabIndex = 43;
            // 
            // roomComboBox
            // 
            roomComboBox.Cursor = Cursors.Hand;
            roomComboBox.Font = new Font("Arial", 9F);
            roomComboBox.FormattingEnabled = true;
            roomComboBox.Location = new Point(70, 120);
            roomComboBox.Name = "roomComboBox";
            roomComboBox.Size = new Size(267, 23);
            roomComboBox.TabIndex = 42;
            // 
            // scheduleButton
            // 
            scheduleButton.Cursor = Cursors.Hand;
            scheduleButton.Font = new Font("Arial Rounded MT Bold", 10F);
            scheduleButton.Location = new Point(70, 422);
            scheduleButton.Name = "scheduleButton";
            scheduleButton.Size = new Size(267, 31);
            scheduleButton.TabIndex = 41;
            scheduleButton.Text = "Schedule Course";
            scheduleButton.UseVisualStyleBackColor = true;
            scheduleButton.Click += scheduleButton_Click_1;
            // 
            // facultyComboBox
            // 
            facultyComboBox.Cursor = Cursors.Hand;
            facultyComboBox.Font = new Font("Arial", 9F);
            facultyComboBox.FormattingEnabled = true;
            facultyComboBox.Location = new Point(70, 64);
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
            H1.Location = new Point(91, 7);
            H1.Name = "H1";
            H1.Size = new Size(228, 30);
            H1.TabIndex = 26;
            H1.Text = "Schedule Course";
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
            // ScheduleCourseForFaculty
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
            Name = "ScheduleCourseForFaculty";
            Text = "Schedule Course For Faculty";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
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
        private Button scheduleButton;
        private ComboBox facultyComboBox;
        private Label fnameicon;
        private Label H1;
        private LinkLabel backLinkLabel;
        private Label label1;
        private ComboBox courseComboBox;
        private ComboBox roomComboBox;
        private Label label4;
        private Label label3;
        private Label label2;
        private DateTimePicker startTimePicker;
        private DateTimePicker endTimePicker;
        private Label label5;
        private ComboBox dayOfWeekComboBox;
        private Label label8;
        private Label label7;
    }
}