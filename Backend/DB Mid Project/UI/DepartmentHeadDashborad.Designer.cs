namespace DB_Mid_Project.UI
{
    partial class DepartmentHeadDashborad
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentHeadDashborad));
            panel1 = new Panel();
            pictureBox1 = new PictureBox();
            label1 = new Label();
            pictureBox2 = new PictureBox();
            panel2 = new Panel();
            Heading = new Label();
            panel3 = new Panel();
            linkLabel8 = new LinkLabel();
            label8 = new Label();
            linkLabel1 = new LinkLabel();
            label7 = new Label();
            linkLabel3 = new LinkLabel();
            label5 = new Label();
            logout = new LinkLabel();
            label2 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 134);
            panel1.TabIndex = 4;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(1176, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(173, 142);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label1.Location = new Point(330, 56);
            label1.Name = "label1";
            label1.Size = new Size(566, 38);
            label1.TabIndex = 1;
            label1.Text = "FACULTY MANAGEMENT SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Location = new Point(0, 131);
            panel2.Name = "panel2";
            panel2.Size = new Size(176, 601);
            panel2.TabIndex = 5;
            // 
            // Heading
            // 
            Heading.AutoSize = true;
            Heading.BorderStyle = BorderStyle.Fixed3D;
            Heading.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Italic);
            Heading.Location = new Point(544, 194);
            Heading.Name = "Heading";
            Heading.Size = new Size(305, 40);
            Heading.TabIndex = 6;
            Heading.Text = "Department Head";
            Heading.Click += label2_Click;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Location = new Point(1176, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(176, 601);
            panel3.TabIndex = 7;
            // 
            // linkLabel8
            // 
            linkLabel8.BackColor = Color.AliceBlue;
            linkLabel8.Cursor = Cursors.Hand;
            linkLabel8.Font = new Font("Arial Rounded MT Bold", 10.75F);
            linkLabel8.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel8.LinkColor = Color.Black;
            linkLabel8.Location = new Point(626, 299);
            linkLabel8.Name = "linkLabel8";
            linkLabel8.Size = new Size(147, 131);
            linkLabel8.TabIndex = 22;
            linkLabel8.TabStop = true;
            linkLabel8.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n          Requests\r\n        ";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.BackColor = Color.AliceBlue;
            label8.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label8.Location = new Point(659, 336);
            label8.Name = "label8";
            label8.Size = new Size(77, 54);
            label8.TabIndex = 27;
            label8.Text = "🙋🏻‍♂️";
            label8.Click += label8_Click;
            // 
            // linkLabel1
            // 
            linkLabel1.BackColor = Color.AliceBlue;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 10.75F);
            linkLabel1.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(393, 299);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(144, 131);
            linkLabel1.TabIndex = 28;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "\r\n\r\n               \r\n\r\n\r\n         Workload\r\n       Assignment";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.AliceBlue;
            label7.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label7.Location = new Point(428, 326);
            label7.Name = "label7";
            label7.Size = new Size(77, 54);
            label7.TabIndex = 29;
            label7.Text = "💼";
            // 
            // linkLabel3
            // 
            linkLabel3.BackColor = Color.AliceBlue;
            linkLabel3.Cursor = Cursors.Hand;
            linkLabel3.Font = new Font("Arial Rounded MT Bold", 10.75F);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(844, 299);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(144, 131);
            linkLabel3.TabIndex = 30;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "\r\n\r\n               \r\n\r\n\r\n        Resource\r\n        Allocation\r\n";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.AliceBlue;
            label5.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label5.Location = new Point(876, 326);
            label5.Name = "label5";
            label5.Size = new Size(77, 54);
            label5.TabIndex = 31;
            label5.Text = "🏛️";
            // 
            // logout
            // 
            logout.BackColor = Color.AliceBlue;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 10.75F);
            logout.LinkBehavior = LinkBehavior.NeverUnderline;
            logout.LinkColor = Color.Black;
            logout.Location = new Point(626, 513);
            logout.Name = "logout";
            logout.Size = new Size(147, 131);
            logout.TabIndex = 32;
            logout.TabStop = true;
            logout.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n          Log Out\r\n\r\n            ";
            logout.LinkClicked += logout_LinkClicked;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.AliceBlue;
            label2.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label2.Location = new Point(661, 544);
            label2.Name = "label2";
            label2.Size = new Size(67, 54);
            label2.TabIndex = 33;
            label2.Text = "🏃";
            // 
            // DepartmentHeadDashborad
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(label2);
            Controls.Add(logout);
            Controls.Add(label5);
            Controls.Add(linkLabel3);
            Controls.Add(label7);
            Controls.Add(linkLabel1);
            Controls.Add(label8);
            Controls.Add(linkLabel8);
            Controls.Add(panel3);
            Controls.Add(Heading);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "DepartmentHeadDashborad";
            Text = "DepartmentHeadDashborad";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label1;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Label Heading;
        private Panel panel3;
        private LinkLabel linkLabel8;
        private Label label8;
        private LinkLabel linkLabel1;
        private Label label7;
        private LinkLabel linkLabel3;
        private Label label5;
        private LinkLabel logout;
        private Label label2;
    }
}