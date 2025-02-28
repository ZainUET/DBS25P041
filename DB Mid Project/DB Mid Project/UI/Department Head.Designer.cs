namespace DB_Mid_Project
{
    partial class DepartmentHead
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DepartmentHead));
            panel1 = new Panel();
            linkLabel5 = new LinkLabel();
            linkLabel4 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel1 = new LinkLabel();
            H1 = new Label();
            pictureBox1 = new PictureBox();
            Faculty = new GroupBox();
            groupBox2 = new GroupBox();
            Resources = new GroupBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.Controls.Add(linkLabel5);
            panel1.Controls.Add(linkLabel4);
            panel1.Controls.Add(linkLabel3);
            panel1.Controls.Add(linkLabel2);
            panel1.Controls.Add(linkLabel1);
            panel1.Controls.Add(H1);
            panel1.Controls.Add(pictureBox1);
            panel1.Location = new Point(0, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(353, 729);
            panel1.TabIndex = 0;
            // 
            // linkLabel5
            // 
            linkLabel5.AutoSize = true;
            linkLabel5.Font = new Font("Arial Rounded MT Bold", 17.25F);
            linkLabel5.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel5.LinkColor = SystemColors.MenuHighlight;
            linkLabel5.Location = new Point(94, 659);
            linkLabel5.Name = "linkLabel5";
            linkLabel5.Size = new Size(100, 27);
            linkLabel5.TabIndex = 1;
            linkLabel5.TabStop = true;
            linkLabel5.Text = "Log Out";
            // 
            // linkLabel4
            // 
            linkLabel4.AutoSize = true;
            linkLabel4.BorderStyle = BorderStyle.Fixed3D;
            linkLabel4.Font = new Font("Arial Rounded MT Bold", 17.25F);
            linkLabel4.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel4.LinkColor = Color.Black;
            linkLabel4.Location = new Point(94, 608);
            linkLabel4.Name = "linkLabel4";
            linkLabel4.Size = new Size(141, 29);
            linkLabel4.TabIndex = 5;
            linkLabel4.TabStop = true;
            linkLabel4.Text = "Resources ";
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.BorderStyle = BorderStyle.Fixed3D;
            linkLabel3.Font = new Font("Arial Rounded MT Bold", 17.25F);
            linkLabel3.LinkBehavior = LinkBehavior.NeverUnderline;
            linkLabel3.LinkColor = Color.Black;
            linkLabel3.Location = new Point(94, 550);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(207, 29);
            linkLabel3.TabIndex = 4;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "Faculty Requests";
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.BorderStyle = BorderStyle.Fixed3D;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Arial Rounded MT Bold", 17.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.LinkColor = Color.Black;
            linkLabel2.Location = new Point(94, 491);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(121, 29);
            linkLabel2.TabIndex = 3;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Workload";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.BorderStyle = BorderStyle.Fixed3D;
            linkLabel1.Cursor = Cursors.Hand;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 17.25F);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.LinkColor = Color.Black;
            linkLabel1.Location = new Point(94, 433);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(79, 29);
            linkLabel1.TabIndex = 2;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Home";
            // 
            // H1
            // 
            H1.AutoSize = true;
            H1.Font = new Font("Arial", 20F, FontStyle.Bold);
            H1.Location = new Point(48, 347);
            H1.Name = "H1";
            H1.Size = new Size(243, 32);
            H1.TabIndex = 1;
            H1.Text = "Department Head";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-16, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(369, 325);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // Faculty
            // 
            Faculty.BackColor = Color.Transparent;
            Faculty.Location = new Point(472, 81);
            Faculty.Name = "Faculty";
            Faculty.Size = new Size(282, 256);
            Faculty.TabIndex = 1;
            Faculty.TabStop = false;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Location = new Point(930, 81);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(278, 256);
            groupBox2.TabIndex = 2;
            groupBox2.TabStop = false;
            // 
            // Resources
            // 
            Resources.BackColor = Color.Transparent;
            Resources.Location = new Point(699, 375);
            Resources.Name = "Resources";
            Resources.Size = new Size(272, 244);
            Resources.TabIndex = 3;
            Resources.TabStop = false;
            // 
            // DepartmentHead
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(Resources);
            Controls.Add(groupBox2);
            Controls.Add(Faculty);
            Controls.Add(panel1);
            Name = "DepartmentHead";
            Text = "Department Head";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private PictureBox pictureBox1;
        private Label H1;
        private LinkLabel linkLabel4;
        private LinkLabel linkLabel3;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel5;
        private GroupBox Faculty;
        private GroupBox groupBox2;
        private GroupBox Resources;
    }
}