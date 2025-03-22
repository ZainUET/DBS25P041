namespace DB_Mid_Project.UI
{
    partial class AddRoom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddRoom));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            add_course = new Button();
            label5 = new Label();
            room_type = new ComboBox();
            femailicon = new Label();
            credit_hours = new TextBox();
            fnameicon = new Label();
            course_name = new TextBox();
            H1 = new Label();
            logout = new LinkLabel();
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
            panel4.Controls.Add(add_course);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(room_type);
            panel4.Controls.Add(femailicon);
            panel4.Controls.Add(credit_hours);
            panel4.Controls.Add(fnameicon);
            panel4.Controls.Add(course_name);
            panel4.Controls.Add(H1);
            panel4.Location = new Point(475, 201);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 377);
            panel4.TabIndex = 12;
            // 
            // add_course
            // 
            add_course.Cursor = Cursors.Hand;
            add_course.Font = new Font("Arial Rounded MT Bold", 10F);
            add_course.Location = new Point(52, 306);
            add_course.Name = "add_course";
            add_course.Size = new Size(297, 31);
            add_course.TabIndex = 40;
            add_course.Text = "Add Room";
            add_course.UseVisualStyleBackColor = true;
            add_course.Click += add_course_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(46, 241);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 39;
            label5.Text = "💼";
            // 
            // room_type
            // 
            room_type.Cursor = Cursors.Hand;
            room_type.Font = new Font("Arial", 9F);
            room_type.FormattingEnabled = true;
            room_type.Location = new Point(84, 239);
            room_type.Name = "room_type";
            room_type.Size = new Size(260, 23);
            room_type.TabIndex = 37;
            // 
            // femailicon
            // 
            femailicon.AutoSize = true;
            femailicon.Font = new Font("Segoe UI", 12F);
            femailicon.Location = new Point(46, 163);
            femailicon.Name = "femailicon";
            femailicon.Size = new Size(32, 21);
            femailicon.TabIndex = 30;
            femailicon.Text = "✉️";
            // 
            // credit_hours
            // 
            credit_hours.Font = new Font("Arial", 9F);
            credit_hours.Location = new Point(84, 163);
            credit_hours.Name = "credit_hours";
            credit_hours.PlaceholderText = "Capacity";
            credit_hours.Size = new Size(260, 21);
            credit_hours.TabIndex = 29;
            // 
            // fnameicon
            // 
            fnameicon.AutoSize = true;
            fnameicon.Font = new Font("Segoe UI", 12F);
            fnameicon.Location = new Point(52, 74);
            fnameicon.Name = "fnameicon";
            fnameicon.Size = new Size(29, 21);
            fnameicon.TabIndex = 28;
            fnameicon.Text = "👨🏻‍💼";
            // 
            // course_name
            // 
            course_name.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            course_name.Location = new Point(84, 75);
            course_name.Name = "course_name";
            course_name.PlaceholderText = "Room Name";
            course_name.Size = new Size(260, 21);
            course_name.TabIndex = 27;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.BackColor = Color.AliceBlue;
            H1.Font = new Font("Arial Rounded MT Bold", 19.25F);
            H1.Location = new Point(84, 18);
            H1.Name = "H1";
            H1.Size = new Size(219, 30);
            H1.TabIndex = 26;
            H1.Text = "➕ Add Room➕ ";
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
            // AddRoom
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(logout);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "AddRoom";
            Text = "AddCourse";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
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
        private Label femailicon;
        private TextBox credit_hours;
        private Label fnameicon;
        private TextBox course_name;
        private Label H1;
        private LinkLabel logout;
    }
}