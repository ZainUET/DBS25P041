namespace DB_Mid_Project.UI
{
    partial class FacultyAdminRoleManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyAdminRoleManagement));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            H1 = new Label();
            addmember = new LinkLabel();
            removemember = new LinkLabel();
            showfaculty = new LinkLabel();
            Home = new LinkLabel();
            label2 = new Label();
            label4 = new Label();
            label7 = new Label();
            label3 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
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
            label6.Location = new Point(330, 56);
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
            // H1
            // 
            H1.AutoSize = true;
            H1.BorderStyle = BorderStyle.Fixed3D;
            H1.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Italic);
            H1.Location = new Point(462, 177);
            H1.Name = "H1";
            H1.Size = new Size(547, 40);
            H1.TabIndex = 10;
            H1.Text = "Faculty Admin Role Management";
            // 
            // addmember
            // 
            addmember.BackColor = Color.AliceBlue;
            addmember.Cursor = Cursors.Hand;
            addmember.Font = new Font("Arial Rounded MT Bold", 10.75F);
            addmember.LinkBehavior = LinkBehavior.NeverUnderline;
            addmember.LinkColor = Color.Black;
            addmember.Location = new Point(329, 307);
            addmember.Name = "addmember";
            addmember.Size = new Size(147, 131);
            addmember.TabIndex = 21;
            addmember.TabStop = true;
            addmember.Text = "\r\n\r\n               \r\n\r\n\r\n           Assign\r\n             Role\r\n           ";
            addmember.LinkClicked += addmember_LinkClicked;
            // 
            // removemember
            // 
            removemember.BackColor = Color.AliceBlue;
            removemember.Cursor = Cursors.Hand;
            removemember.Font = new Font("Arial Rounded MT Bold", 10.75F);
            removemember.LinkBehavior = LinkBehavior.NeverUnderline;
            removemember.LinkColor = Color.Black;
            removemember.Location = new Point(656, 307);
            removemember.Name = "removemember";
            removemember.Size = new Size(147, 131);
            removemember.TabIndex = 22;
            removemember.TabStop = true;
            removemember.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n          Remove\r\n            ";
            removemember.LinkClicked += removemember_LinkClicked;
            // 
            // showfaculty
            // 
            showfaculty.BackColor = Color.AliceBlue;
            showfaculty.Cursor = Cursors.Hand;
            showfaculty.Font = new Font("Arial Rounded MT Bold", 10.75F);
            showfaculty.LinkBehavior = LinkBehavior.NeverUnderline;
            showfaculty.LinkColor = Color.Black;
            showfaculty.Location = new Point(976, 308);
            showfaculty.Name = "showfaculty";
            showfaculty.Size = new Size(147, 131);
            showfaculty.TabIndex = 31;
            showfaculty.TabStop = true;
            showfaculty.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Show\r\n           ";
            showfaculty.LinkClicked += showfaculty_LinkClicked;
            // 
            // Home
            // 
            Home.BackColor = Color.AliceBlue;
            Home.Cursor = Cursors.Hand;
            Home.Font = new Font("Arial Rounded MT Bold", 10.75F);
            Home.LinkBehavior = LinkBehavior.NeverUnderline;
            Home.LinkColor = Color.Black;
            Home.Location = new Point(656, 527);
            Home.Name = "Home";
            Home.Size = new Size(147, 131);
            Home.TabIndex = 32;
            Home.TabStop = true;
            Home.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Home\r\n\r\n            ";
            Home.LinkClicked += Home_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label2.Location = new Point(362, 329);
            label2.Name = "label2";
            label2.Size = new Size(77, 54);
            label2.TabIndex = 33;
            label2.Text = "➕";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label4.Location = new Point(688, 345);
            label4.Name = "label4";
            label4.Size = new Size(77, 54);
            label4.TabIndex = 34;
            label4.Text = "➖";
            label4.Click += label4_Click;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label7.Location = new Point(1011, 344);
            label7.Name = "label7";
            label7.Size = new Size(77, 54);
            label7.TabIndex = 36;
            label7.Text = "👀";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label3.Location = new Point(694, 558);
            label3.Name = "label3";
            label3.Size = new Size(71, 54);
            label3.TabIndex = 37;
            label3.Text = "🏠︎";
            // 
            // FacultyAdminRoleManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(label3);
            Controls.Add(label7);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(Home);
            Controls.Add(showfaculty);
            Controls.Add(removemember);
            Controls.Add(addmember);
            Controls.Add(H1);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "FacultyAdminRoleManagement";
            Text = "Faculty Admin Role Management";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel1;
        private Label H1;
        private LinkLabel addmember;
        private LinkLabel removemember;
        private LinkLabel showfaculty;
        private LinkLabel Home;
        private Label label2;
        private Label label4;
        private Label label7;
        private Label label3;
    }
}