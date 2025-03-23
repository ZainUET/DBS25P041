namespace DB_Mid_Project.UI
{
    partial class AddSemester
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddSemester));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            numericUpDown1 = new NumericUpDown();
            add_course = new Button();
            label5 = new Label();
            room_type = new ComboBox();
            H1 = new Label();
            logout = new LinkLabel();
            label3 = new Label();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(-1, -1);
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
            label6.Location = new Point(399, 55);
            label6.Name = "label6";
            label6.Size = new Size(566, 38);
            label6.TabIndex = 1;
            label6.Text = "FACULTY MANAGEMENT SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-1, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Location = new Point(-1, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 597);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Location = new Point(1176, 133);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 597);
            panel3.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(numericUpDown1);
            panel4.Controls.Add(add_course);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(room_type);
            panel4.Controls.Add(H1);
            panel4.Location = new Point(475, 201);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 330);
            panel4.TabIndex = 12;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(84, 189);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(260, 23);
            numericUpDown1.TabIndex = 41;
            // 
            // add_course
            // 
            add_course.Cursor = Cursors.Hand;
            add_course.FlatStyle = FlatStyle.Flat;
            add_course.Font = new Font("Arial Rounded MT Bold", 10F);
            add_course.Location = new Point(51, 264);
            add_course.Name = "add_course";
            add_course.Size = new Size(297, 31);
            add_course.TabIndex = 40;
            add_course.Text = "Add Semester";
            add_course.UseVisualStyleBackColor = true;
            add_course.Click += add_course_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(52, 99);
            label5.Name = "label5";
            label5.Size = new Size(29, 21);
            label5.TabIndex = 39;
            label5.Text = "👨‍🎓";
            // 
            // room_type
            // 
            room_type.Cursor = Cursors.Hand;
            room_type.Font = new Font("Arial", 9F);
            room_type.FormattingEnabled = true;
            room_type.Location = new Point(84, 99);
            room_type.Name = "room_type";
            room_type.Size = new Size(260, 23);
            room_type.TabIndex = 37;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.BackColor = Color.AliceBlue;
            H1.Font = new Font("Arial Rounded MT Bold", 19.25F);
            H1.Location = new Point(84, 18);
            H1.Name = "H1";
            H1.Size = new Size(264, 30);
            H1.TabIndex = 26;
            H1.Text = "➕ Add Semester➕ ";
            // 
            // logout
            // 
            logout.BackColor = Color.AliceBlue;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 10.75F);
            logout.LinkBehavior = LinkBehavior.NeverUnderline;
            logout.LinkColor = Color.Black;
            logout.Location = new Point(972, 523);
            logout.Name = "logout";
            logout.Size = new Size(147, 133);
            logout.TabIndex = 36;
            logout.TabStop = true;
            logout.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Back\r\n            ";
            logout.LinkClicked += logout_LinkClicked;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(52, 189);
            label3.Name = "label3";
            label3.Size = new Size(32, 21);
            label3.TabIndex = 42;
            label3.Text = "🕖";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Arial", 35.25F);
            label4.Location = new Point(1009, 560);
            label4.Name = "label4";
            label4.Size = new Size(62, 53);
            label4.TabIndex = 43;
            label4.Text = "⬅";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial", 10.25F, FontStyle.Bold);
            label1.Location = new Point(80, 83);
            label1.Name = "label1";
            label1.Size = new Size(45, 16);
            label1.TabIndex = 44;
            label1.Text = "Term:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial", 10.25F, FontStyle.Bold);
            label2.Location = new Point(82, 172);
            label2.Name = "label2";
            label2.Size = new Size(43, 16);
            label2.TabIndex = 45;
            label2.Text = "Year:";
            // 
            // AddSemester
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(label4);
            Controls.Add(logout);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AddSemester";
            Text = "AddCourse";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
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
        private Button add_course;
        private Label label5;
        private ComboBox room_type;
        private Label label2;
        private Label label1;
        private TextBox fTeachingHours;
        private TextBox fResearchArea;
        private Label H1;
        private LinkLabel logout;
        private NumericUpDown numericUpDown1;
        private Label label3;
        private Label label4;
    }
}