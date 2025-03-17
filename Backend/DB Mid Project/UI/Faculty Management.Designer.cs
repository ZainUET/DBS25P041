namespace DB_Mid_Project
{
    partial class FacultyManagement
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacultyManagement));
            panel1 = new Panel();
            H1 = new Label();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            addmember = new LinkLabel();
            removemember = new LinkLabel();
            updatemember = new LinkLabel();
            Home = new LinkLabel();
            logout = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Location = new Point(0, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 597);
            panel1.TabIndex = 0;
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Italic);
            H1.Location = new Point(594, 180);
            H1.Name = "H1";
            H1.Size = new Size(353, 38);
            H1.TabIndex = 1;
            H1.Text = "Faculty Management";
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, -1);
            panel2.Name = "panel2";
            panel2.Size = new Size(1349, 134);
            panel2.TabIndex = 7;
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
            // addmember
            // 
            addmember.BackColor = Color.AliceBlue;
            addmember.Cursor = Cursors.Hand;
            addmember.Font = new Font("Arial Rounded MT Bold", 10.75F);
            addmember.LinkBehavior = LinkBehavior.NeverUnderline;
            addmember.LinkColor = Color.Black;
            addmember.Location = new Point(446, 299);
            addmember.Name = "addmember";
            addmember.Size = new Size(147, 131);
            addmember.TabIndex = 20;
            addmember.TabStop = true;
            addmember.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n              Add\r\n           ";
            addmember.LinkClicked += addmember_LinkClicked;
            // 
            // removemember
            // 
            removemember.BackColor = Color.AliceBlue;
            removemember.Cursor = Cursors.Hand;
            removemember.Font = new Font("Arial Rounded MT Bold", 10.75F);
            removemember.LinkBehavior = LinkBehavior.NeverUnderline;
            removemember.LinkColor = Color.Black;
            removemember.Location = new Point(688, 299);
            removemember.Name = "removemember";
            removemember.Size = new Size(147, 131);
            removemember.TabIndex = 21;
            removemember.TabStop = true;
            removemember.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n          Remove\r\n            ";
            // 
            // updatemember
            // 
            updatemember.BackColor = Color.AliceBlue;
            updatemember.Cursor = Cursors.Hand;
            updatemember.Font = new Font("Arial Rounded MT Bold", 10.75F);
            updatemember.LinkBehavior = LinkBehavior.NeverUnderline;
            updatemember.LinkColor = Color.Black;
            updatemember.Location = new Point(953, 299);
            updatemember.Name = "updatemember";
            updatemember.Size = new Size(147, 131);
            updatemember.TabIndex = 22;
            updatemember.TabStop = true;
            updatemember.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n          Update\r\n\r\n            ";
            // 
            // Home
            // 
            Home.BackColor = Color.AliceBlue;
            Home.Cursor = Cursors.Hand;
            Home.Font = new Font("Arial Rounded MT Bold", 10.75F);
            Home.LinkBehavior = LinkBehavior.NeverUnderline;
            Home.LinkColor = Color.Black;
            Home.Location = new Point(565, 482);
            Home.Name = "Home";
            Home.Size = new Size(147, 131);
            Home.TabIndex = 23;
            Home.TabStop = true;
            Home.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Home\r\n\r\n            ";
            // 
            // logout
            // 
            logout.BackColor = Color.AliceBlue;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 10.75F);
            logout.LinkBehavior = LinkBehavior.NeverUnderline;
            logout.LinkColor = Color.Black;
            logout.Location = new Point(830, 482);
            logout.Name = "logout";
            logout.Size = new Size(147, 131);
            logout.TabIndex = 24;
            logout.TabStop = true;
            logout.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n          Log Out\r\n\r\n            ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label2.Location = new Point(482, 335);
            label2.Name = "label2";
            label2.Size = new Size(77, 54);
            label2.TabIndex = 25;
            label2.Text = "🙋🏻‍♂️";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label1.Location = new Point(863, 521);
            label1.Name = "label1";
            label1.Size = new Size(67, 54);
            label1.TabIndex = 26;
            label1.Text = "🏃";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.AliceBlue;
            label3.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label3.Location = new Point(603, 521);
            label3.Name = "label3";
            label3.Size = new Size(71, 54);
            label3.TabIndex = 27;
            label3.Text = "🏠︎";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.AliceBlue;
            label4.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label4.Location = new Point(724, 335);
            label4.Name = "label4";
            label4.Size = new Size(77, 54);
            label4.TabIndex = 28;
            label4.Text = "➖";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label5.Location = new Point(986, 335);
            label5.Name = "label5";
            label5.Size = new Size(77, 54);
            label5.TabIndex = 29;
            label5.Text = "🛠️";
            // 
            // FacultyManagement
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(logout);
            Controls.Add(Home);
            Controls.Add(updatemember);
            Controls.Add(removemember);
            Controls.Add(addmember);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(H1);
            Name = "FacultyManagement";
            Text = "Faculty";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label H1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private LinkLabel addmember;
        private LinkLabel removemember;
        private LinkLabel updatemember;
        private LinkLabel Home;
        private LinkLabel logout;
        private Label label2;
        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}