namespace DB_Mid_Project.UI
{
    partial class FacultyManagementUpdate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyManagementUpdate));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel4 = new Panel();
            btnUpdate = new Button();
            cmbDesignation = new ComboBox();
            txtResearchArea = new TextBox();
            txtContact = new TextBox();
            txtEmail = new TextBox();
            txtTeachingHours = new TextBox();
            txtName = new TextBox();
            cmbFaculty = new ComboBox();
            Heading = new Label();
            fnameicon = new Label();
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
            panel2.Location = new Point(1, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1349, 134);
            panel2.TabIndex = 10;
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
            panel1.Location = new Point(1, 133);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 597);
            panel1.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BackColor = Color.AliceBlue;
            panel4.Controls.Add(btnUpdate);
            panel4.Controls.Add(cmbDesignation);
            panel4.Controls.Add(txtResearchArea);
            panel4.Controls.Add(txtContact);
            panel4.Controls.Add(txtEmail);
            panel4.Controls.Add(txtTeachingHours);
            panel4.Controls.Add(txtName);
            panel4.Controls.Add(cmbFaculty);
            panel4.Controls.Add(Heading);
            panel4.Controls.Add(fnameicon);
            panel4.Location = new Point(524, 181);
            panel4.Name = "panel4";
            panel4.Size = new Size(400, 503);
            panel4.TabIndex = 13;
            // 
            // btnUpdate
            // 
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 13F);
            btnUpdate.Location = new Point(58, 444);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(277, 34);
            btnUpdate.TabIndex = 37;
            btnUpdate.Text = "Update";
            btnUpdate.UseVisualStyleBackColor = true;
            btnUpdate.Click += btnUpdate_Click;
            // 
            // cmbDesignation
            // 
            cmbDesignation.FormattingEnabled = true;
            cmbDesignation.Location = new Point(58, 394);
            cmbDesignation.Name = "cmbDesignation";
            cmbDesignation.Size = new Size(277, 23);
            cmbDesignation.TabIndex = 36;
            // 
            // txtResearchArea
            // 
            txtResearchArea.Location = new Point(58, 289);
            txtResearchArea.Name = "txtResearchArea";
            txtResearchArea.PlaceholderText = "Research Area";
            txtResearchArea.Size = new Size(277, 23);
            txtResearchArea.TabIndex = 35;
            // 
            // txtContact
            // 
            txtContact.Location = new Point(58, 242);
            txtContact.Name = "txtContact";
            txtContact.PlaceholderText = "Contact";
            txtContact.Size = new Size(277, 23);
            txtContact.TabIndex = 34;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(58, 190);
            txtEmail.Name = "txtEmail";
            txtEmail.PlaceholderText = "Email";
            txtEmail.Size = new Size(277, 23);
            txtEmail.TabIndex = 33;
            // 
            // txtTeachingHours
            // 
            txtTeachingHours.Location = new Point(58, 341);
            txtTeachingHours.Name = "txtTeachingHours";
            txtTeachingHours.PlaceholderText = "Teaching Hours";
            txtTeachingHours.Size = new Size(277, 23);
            txtTeachingHours.TabIndex = 32;
            // 
            // txtName
            // 
            txtName.Location = new Point(58, 138);
            txtName.Name = "txtName";
            txtName.PlaceholderText = "Name";
            txtName.Size = new Size(277, 23);
            txtName.TabIndex = 31;
            // 
            // cmbFaculty
            // 
            cmbFaculty.FormattingEnabled = true;
            cmbFaculty.Location = new Point(58, 89);
            cmbFaculty.Name = "cmbFaculty";
            cmbFaculty.Size = new Size(277, 23);
            cmbFaculty.TabIndex = 30;
            // 
            // Heading
            // 
            Heading.Font = new Font("Arial Rounded MT Bold", 19.25F);
            Heading.Location = new Point(17, 24);
            Heading.Name = "Heading";
            Heading.Size = new Size(360, 38);
            Heading.TabIndex = 29;
            Heading.Text = "🛠️ Update Faculty Member";
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
            // logout
            // 
            logout.BackColor = Color.AliceBlue;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 10.75F);
            logout.LinkBehavior = LinkBehavior.NeverUnderline;
            logout.LinkColor = Color.Black;
            logout.Location = new Point(1093, 551);
            logout.Name = "logout";
            logout.Size = new Size(147, 133);
            logout.TabIndex = 35;
            logout.TabStop = true;
            logout.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Back\r\n\r\n            ";
            logout.LinkClicked += logout_LinkClicked;
            // 
            // FacultyManagementUpdate
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(logout);
            Controls.Add(panel4);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FacultyManagementUpdate";
            Text = "FacultyManagementUpdate";
            Load += FacultyManagementUpdate_Load;
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
        private Panel panel4;
        private ComboBox cmbFaculty;
        private Label Heading;
        private Label fnameicon;
        private ComboBox cmbDesignation;
        private TextBox txtResearchArea;
        private TextBox txtContact;
        private TextBox txtEmail;
        private TextBox txtTeachingHours;
        private TextBox txtName;
        private Button btnUpdate;
        private LinkLabel logout;
    }
}