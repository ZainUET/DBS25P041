namespace DB_Mid_Project
{
    partial class Login
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
            groupBox1 = new GroupBox();
            labelPlaceholder = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            linkLabel1 = new LinkLabel();
            signup = new Button();
            role = new ComboBox();
            heading1 = new Label();
            groupBox2 = new GroupBox();
            linkLabel2 = new LinkLabel();
            label2 = new Label();
            label1 = new Label();
            groupBox1.SuspendLayout();
            groupBox2.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.BackColor = Color.Transparent;
            groupBox1.BackgroundImageLayout = ImageLayout.Stretch;
            groupBox1.Controls.Add(labelPlaceholder);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Controls.Add(linkLabel1);
            groupBox1.Controls.Add(signup);
            groupBox1.Controls.Add(role);
            groupBox1.Controls.Add(heading1);
            groupBox1.Location = new Point(488, 97);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(350, 382);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            // 
            // labelPlaceholder
            // 
            labelPlaceholder.AutoSize = true;
            labelPlaceholder.Font = new Font("Arial", 9F);
            labelPlaceholder.ForeColor = Color.Gray;
            labelPlaceholder.Location = new Point(60, 213);
            labelPlaceholder.Name = "labelPlaceholder";
            labelPlaceholder.Size = new Size(33, 15);
            labelPlaceholder.TabIndex = 2;
            labelPlaceholder.Text = "Role";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 12F);
            label5.Location = new Point(21, 209);
            label5.Name = "label5";
            label5.Size = new Size(32, 21);
            label5.TabIndex = 2;
            label5.Text = "💼";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 12F);
            label4.Location = new Point(21, 104);
            label4.Name = "label4";
            label4.Size = new Size(29, 21);
            label4.TabIndex = 2;
            label4.Text = "👨🏻‍💼";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 12F);
            label3.Location = new Point(21, 154);
            label3.Name = "label3";
            label3.Size = new Size(30, 21);
            label3.TabIndex = 2;
            label3.Text = "🗝";
            // 
            // textBox2
            // 
            textBox2.BackColor = Color.White;
            textBox2.Font = new Font("Arial", 9F);
            textBox2.Location = new Point(57, 154);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.PlaceholderText = "Password";
            textBox2.Size = new Size(267, 21);
            textBox2.TabIndex = 6;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.White;
            textBox1.Font = new Font("Arial", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(57, 104);
            textBox1.Name = "textBox1";
            textBox1.PlaceholderText = "Name";
            textBox1.Size = new Size(267, 21);
            textBox1.TabIndex = 5;
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.DisabledLinkColor = Color.LightGray;
            linkLabel1.Font = new Font("Arial Rounded MT Bold", 9F);
            linkLabel1.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel1.Location = new Point(122, 335);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(114, 14);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "Forgot Password?";
            linkLabel1.Click += linkLabel1_Click;
            // 
            // signup
            // 
            signup.Cursor = Cursors.Hand;
            signup.Font = new Font("Arial Rounded MT Bold", 10F);
            signup.Location = new Point(24, 274);
            signup.Name = "signup";
            signup.Size = new Size(297, 31);
            signup.TabIndex = 2;
            signup.Text = "Log In";
            signup.UseVisualStyleBackColor = true;
            // 
            // role
            // 
            role.Cursor = Cursors.Hand;
            role.Font = new Font("Arial", 9F);
            role.FormattingEnabled = true;
            role.Items.AddRange(new object[] { "Department Head", "Faculty Member", "Administrative Staff" });
            role.Location = new Point(57, 209);
            role.Name = "role";
            role.Size = new Size(267, 23);
            role.TabIndex = 10;
            role.Enter += role_Enter_1;
            role.Leave += role_Leave;
            // 
            // heading1
            // 
            heading1.AutoSize = true;
            heading1.Font = new Font("Arial Rounded MT Bold", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            heading1.Location = new Point(28, 49);
            heading1.Name = "heading1";
            heading1.Size = new Size(298, 24);
            heading1.TabIndex = 1;
            heading1.Text = "Faculty Management System";
            heading1.Click += heading1_Click;
            // 
            // groupBox2
            // 
            groupBox2.BackColor = Color.Transparent;
            groupBox2.Controls.Add(linkLabel2);
            groupBox2.Controls.Add(label2);
            groupBox2.Controls.Add(label1);
            groupBox2.Location = new Point(488, 512);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(350, 100);
            groupBox2.TabIndex = 1;
            groupBox2.TabStop = false;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Cursor = Cursors.Hand;
            linkLabel2.Font = new Font("Arial Rounded MT Bold", 9F);
            linkLabel2.LinkBehavior = LinkBehavior.HoverUnderline;
            linkLabel2.Location = new Point(212, 50);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(53, 14);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "Sign Up";
            linkLabel2.Click += linkLabel2_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 9F);
            label2.Location = new Point(69, 50);
            label2.Name = "label2";
            label2.Size = new Size(150, 14);
            label2.TabIndex = 1;
            label2.Text = "Don't Have An Account? ";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(3, 19);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1350, 729);
            Controls.Add(groupBox2);
            Controls.Add(groupBox1);
            Name = "Login";
            Text = "Login";
            Load += Login_Load_1;
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBox1;
        private Label heading1;
        private ComboBox role;
        private Button signup;
        private LinkLabel linkLabel1;
        private TextBox textBox2;
        private TextBox textBox1;
        private GroupBox groupBox2;
        private Label label1;
        private LinkLabel linkLabel2;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label4;
        private Label labelPlaceholder;
    }
}
