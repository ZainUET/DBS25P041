namespace DB_Mid_Project
{
    partial class forgotPassword
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(forgotPassword));
            groupBox1 = new GroupBox();
            textBox1 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            textBox3 = new TextBox();
            label1 = new Label();
            textBox2 = new TextBox();
            linkLabel1 = new LinkLabel();
            reset = new Button();
            heading1 = new Label();
            panel1 = new Panel();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel3 = new Panel();
            groupBox1.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(textBox3);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(reset);
            groupBox1.Controls.Add(heading1);
            groupBox1.Location = new Point(488, 195);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 376);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(58, 208);
            textBox1.Name = "textBox1";
            textBox1.PasswordChar = '*';
            textBox1.PlaceholderText = "Confirm Password";
            textBox1.Size = new Size(260, 23);
            textBox1.TabIndex = 19;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F);
            label2.Location = new Point(28, 208);
            label2.Name = "label2";
            label2.Size = new Size(32, 21);
            label2.TabIndex = 18;
            label2.Text = "🔐";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(24, 108);
            label4.Name = "label4";
            label4.Size = new Size(32, 21);
            label4.TabIndex = 17;
            label4.Text = "✉️";
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Arial", 9F);
            textBox3.Location = new Point(58, 108);
            textBox3.Name = "textBox3";
            textBox3.PlaceholderText = "Email";
            textBox3.Size = new Size(260, 21);
            textBox3.TabIndex = 13;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F);
            label1.Location = new Point(28, 155);
            label1.Name = "label1";
            label1.Size = new Size(30, 21);
            label1.TabIndex = 14;
            label1.Text = "🗝";
            // 
            // textBox2
            // 
            textBox2.Font = new Font("Arial", 9F);
            textBox2.Location = new Point(58, 156);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "New Password";
            textBox2.Size = new Size(260, 21);
            textBox2.TabIndex = 12;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.LightGray;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 9F);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(119, 330);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(101, 14);
            linkLabel1.TabIndex = 10;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "← Back To Login";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            linkLabel1.Click += linkLabel1_Click;
            // 
            // reset
            // 
            reset.Cursor = Cursors.Hand;
            reset.Font = new Font("Arial Rounded MT Bold", 10F);
            reset.Location = new Point(24, 273);
            reset.Name = "reset";
            reset.Size = new Size(297, 31);
            reset.TabIndex = 9;
            reset.Text = "Save";
            reset.UseVisualStyleBackColor = true;
            reset.Click += reset_Click;
            // 
            // heading1
            // 
            heading1.AutoSize = true;
            heading1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heading1.Location = new Point(28, 49);
            heading1.Name = "heading1";
            heading1.Size = new Size(255, 24);
            heading1.TabIndex = 1;
            heading1.Text = "         Password Recovery";
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(pictureBox2);
            panel1.Location = new Point(0, -1);
            panel1.Name = "panel1";
            panel1.Size = new Size(1349, 134);
            panel1.TabIndex = 5;
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Location = new Point(1, 136);
            panel2.Name = "panel2";
            panel2.Size = new Size(35, 600);
            panel2.TabIndex = 6;
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
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Location = new Point(-1, 131);
            panel3.Name = "panel3";
            panel3.Size = new Size(35, 600);
            panel3.TabIndex = 6;
            // 
            // forgotPassword
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1350, 729);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(groupBox1);
            Name = "forgotPassword";
            Text = "Password Recovery";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label heading1;
        private Button reset;
        private LinkLabel linkLabel1;
        private TextBox textBox3;
        private TextBox textBox2;
        private Label label1;
        private Label label4;
        private Label label2;
        private TextBox textBox1;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label label6;
        private PictureBox pictureBox2;
        private Panel panel2;
        private Panel panel3;
    }
}
