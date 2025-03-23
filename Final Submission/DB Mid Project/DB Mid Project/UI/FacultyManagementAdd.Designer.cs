namespace DB_Mid_Project.UI
{
    partial class FacultyManagementAdd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyManagementAdd));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            panel4 = new Panel();
            Submit = new Button();
            label5 = new Label();
            Designation = new ComboBox();
            label2 = new Label();
            label1 = new Label();
            fTeachingHours = new TextBox();
            fResearchArea = new TextBox();
            fcontact = new TextBox();
            fcontacticon = new Label();
            femailicon = new Label();
            femail = new TextBox();
            fnameicon = new Label();
            fname = new TextBox();
            H1 = new Label();
            logout = new LinkLabel();
            label4 = new Label();
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
            panel2.Location = new Point(1, -2);
            panel2.Name = "panel2";
            panel2.Size = new Size(1349, 134);
            panel2.TabIndex = 8;
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
            panel1.Location = new Point(-1, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 597);
            panel1.TabIndex = 9;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Location = new Point(1178, 132);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 597);
            panel3.TabIndex = 10;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(Submit);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(Designation);
            panel4.Controls.Add(label2);
            panel4.Controls.Add(label1);
            panel4.Controls.Add(fTeachingHours);
            panel4.Controls.Add(fResearchArea);
            panel4.Controls.Add(fcontact);
            panel4.Controls.Add(fcontacticon);
            panel4.Controls.Add(femailicon);
            panel4.Controls.Add(femail);
            panel4.Controls.Add(fnameicon);
            panel4.Controls.Add(fname);
            panel4.Controls.Add(H1);
            panel4.Location = new Point(497, 197);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 430);
            panel4.TabIndex = 11;
            // 
            // Submit
            // 
            Submit.Cursor = Cursors.Hand;
            Submit.FlatStyle = FlatStyle.Flat;
            Submit.Font = new Font("Arial Rounded MT Bold", 10F);
            Submit.Location = new Point(55, 364);
            Submit.Name = "Submit";
            Submit.Size = new Size(297, 31);
            Submit.TabIndex = 40;
            Submit.Text = "Submit";
            Submit.UseVisualStyleBackColor = true;
            Submit.Click += Submit_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(49, 312);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 39;
            label5.Text = "💼";
            // 
            // Designation
            // 
            Designation.Cursor = Cursors.Hand;
            Designation.Font = new Font("Arial", 9F);
            Designation.FormattingEnabled = true;
            Designation.Location = new Point(84, 310);
            Designation.Name = "Designation";
            Designation.Size = new Size(267, 23);
            Designation.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(49, 258);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 36;
            label2.Text = "👨🏻‍🏫";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(49, 212);
            label1.Name = "label1";
            label1.Size = new Size(32, 21);
            label1.TabIndex = 35;
            label1.Text = "🎓";
            // 
            // fTeachingHours
            // 
            fTeachingHours.Font = new Font("Arial", 9F);
            fTeachingHours.Location = new Point(84, 258);
            fTeachingHours.Name = "fTeachingHours";
            fTeachingHours.PlaceholderText = "Total Teaching Hours";
            fTeachingHours.Size = new Size(260, 21);
            fTeachingHours.TabIndex = 34;
            // 
            // fResearchArea
            // 
            fResearchArea.Font = new Font("Arial", 9F);
            fResearchArea.Location = new Point(84, 212);
            fResearchArea.Name = "fResearchArea";
            fResearchArea.PlaceholderText = "Research Area";
            fResearchArea.Size = new Size(260, 21);
            fResearchArea.TabIndex = 33;
            // 
            // fcontact
            // 
            fcontact.Font = new Font("Arial", 9F);
            fcontact.Location = new Point(84, 170);
            fcontact.Name = "fcontact";
            fcontact.PlaceholderText = "Contact";
            fcontact.Size = new Size(260, 21);
            fcontact.TabIndex = 32;
            // 
            // fcontacticon
            // 
            fcontacticon.AutoSize = true;
            fcontacticon.Font = new Font("Segoe UI", 15F);
            fcontacticon.Location = new Point(49, 165);
            fcontacticon.Name = "fcontacticon";
            fcontacticon.Size = new Size(32, 28);
            fcontacticon.TabIndex = 31;
            fcontacticon.Text = "☏";
            // 
            // femailicon
            // 
            femailicon.AutoSize = true;
            femailicon.Font = new Font("Segoe UI", 12F);
            femailicon.Location = new Point(49, 121);
            femailicon.Name = "femailicon";
            femailicon.Size = new Size(32, 21);
            femailicon.TabIndex = 30;
            femailicon.Text = "✉️";
            // 
            // femail
            // 
            femail.Font = new Font("Arial", 9F);
            femail.Location = new Point(84, 121);
            femail.Name = "femail";
            femail.PlaceholderText = "Email";
            femail.Size = new Size(260, 21);
            femail.TabIndex = 29;
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
            // fname
            // 
            fname.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            fname.Location = new Point(84, 75);
            fname.Name = "fname";
            fname.PlaceholderText = "Name";
            fname.Size = new Size(260, 21);
            fname.TabIndex = 27;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.BackColor = Color.AliceBlue;
            H1.Font = new Font("Arial Rounded MT Bold", 19.25F);
            H1.Location = new Point(32, 18);
            H1.Name = "H1";
            H1.Size = new Size(346, 30);
            H1.TabIndex = 26;
            H1.Text = "➕ Add Faculty Member➕ ";
            // 
            // logout
            // 
            logout.BackColor = Color.AliceBlue;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 10.75F);
            logout.LinkBehavior = LinkBehavior.NeverUnderline;
            logout.LinkColor = Color.Black;
            logout.Location = new Point(986, 568);
            logout.Name = "logout";
            logout.Size = new Size(147, 132);
            logout.TabIndex = 37;
            logout.TabStop = true;
            logout.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Back\r\n            ";
            logout.LinkClicked += logout_LinkClicked;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Arial", 35.25F);
            label4.Location = new Point(1027, 604);
            label4.Name = "label4";
            label4.Size = new Size(62, 53);
            label4.TabIndex = 41;
            label4.Text = "⬅";
            // 
            // FacultyManagementAdd
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
            Name = "FacultyManagementAdd";
            Text = "FacultyManagementAdd";
            Load += FacultyManagementAdd_Load;
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
        private Label H1;
        private TextBox fname;
        private Label fnameicon;
        private TextBox femail;
        private Label femailicon;
        private TextBox fcontact;
        private Label fcontacticon;
        private Label label2;
        private Label label1;
        private TextBox fTeachingHours;
        private TextBox fResearchArea;
        private ComboBox Designation;
        private Label label5;
        private Button Submit;
        private LinkLabel logout;
        private Label label4;
    }
}