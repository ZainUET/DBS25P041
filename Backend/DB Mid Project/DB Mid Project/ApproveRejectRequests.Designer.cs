namespace DB_Mid_Project.UI
{
    partial class ApproveRejectRequests
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ApproveRejectRequests));
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            label6 = new Label();
            pictureBox2 = new PictureBox();
            panel1 = new Panel();
            panel3 = new Panel();
            logout = new LinkLabel();
            label1 = new Label();
            dataGridViewRequests = new DataGridView();
            comboBoxStatus = new ComboBox();
            btnUpdate = new Button();
            label2 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).BeginInit();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.BackColor = Color.AliceBlue;
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(pictureBox2);
            panel2.Location = new Point(0, -2);
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
            label6.Location = new Point(399, 47);
            label6.Name = "label6";
            label6.Size = new Size(566, 38);
            label6.TabIndex = 1;
            label6.Text = "FACULTY MANAGEMENT SYSTEM";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(-2, 0);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(176, 142);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = Color.AliceBlue;
            panel1.Location = new Point(0, 132);
            panel1.Name = "panel1";
            panel1.Size = new Size(175, 597);
            panel1.TabIndex = 10;
            // 
            // panel3
            // 
            panel3.BackColor = Color.AliceBlue;
            panel3.Location = new Point(1177, 134);
            panel3.Name = "panel3";
            panel3.Size = new Size(175, 597);
            panel3.TabIndex = 11;
            // 
            // logout
            // 
            logout.BackColor = Color.AliceBlue;
            logout.Cursor = Cursors.Hand;
            logout.Font = new Font("Arial Rounded MT Bold", 10.75F);
            logout.LinkBehavior = LinkBehavior.NeverUnderline;
            logout.LinkColor = Color.Black;
            logout.Location = new Point(981, 547);
            logout.Name = "logout";
            logout.Size = new Size(147, 133);
            logout.TabIndex = 36;
            logout.TabStop = true;
            logout.Text = "\r\n\r\n               \r\n\r\n\r\n\r\n            Back\r\n            ";
            logout.LinkClicked += logout_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.AliceBlue;
            label1.Font = new Font("Arial Rounded MT Bold", 35.25F);
            label1.Location = new Point(1021, 582);
            label1.Name = "label1";
            label1.Size = new Size(63, 54);
            label1.TabIndex = 38;
            label1.Text = "⬅";
            // 
            // dataGridViewRequests
            // 
            dataGridViewRequests.BackgroundColor = SystemColors.ButtonHighlight;
            dataGridViewRequests.BorderStyle = BorderStyle.None;
            dataGridViewRequests.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRequests.Location = new Point(365, 254);
            dataGridViewRequests.Name = "dataGridViewRequests";
            dataGridViewRequests.Size = new Size(544, 150);
            dataGridViewRequests.TabIndex = 39;
            // 
            // comboBoxStatus
            // 
            comboBoxStatus.FormattingEnabled = true;
            comboBoxStatus.Location = new Point(720, 572);
            comboBoxStatus.Name = "comboBoxStatus";
            comboBoxStatus.Size = new Size(189, 23);
            comboBoxStatus.TabIndex = 40;
            // 
            // btnUpdate
            // 
            btnUpdate.BackColor = Color.AliceBlue;
            btnUpdate.Cursor = Cursors.Hand;
            btnUpdate.FlatAppearance.BorderColor = Color.Black;
            btnUpdate.FlatAppearance.MouseDownBackColor = Color.AliceBlue;
            btnUpdate.FlatAppearance.MouseOverBackColor = Color.AliceBlue;
            btnUpdate.FlatStyle = FlatStyle.Flat;
            btnUpdate.Font = new Font("Arial Rounded MT Bold", 14.75F);
            btnUpdate.Location = new Point(720, 647);
            btnUpdate.Name = "btnUpdate";
            btnUpdate.Size = new Size(189, 33);
            btnUpdate.TabIndex = 41;
            btnUpdate.Text = "Update Status";
            btnUpdate.UseVisualStyleBackColor = false;
            btnUpdate.Click += btnUpdate_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 24.75F, FontStyle.Italic, GraphicsUnit.Point, 0);
            label2.Location = new Point(463, 169);
            label2.Name = "label2";
            label2.Size = new Size(334, 38);
            label2.TabIndex = 42;
            label2.Text = "Resource Requests";
            // 
            // ApproveRejectRequests
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonHighlight;
            ClientSize = new Size(1350, 729);
            Controls.Add(label2);
            Controls.Add(btnUpdate);
            Controls.Add(comboBoxStatus);
            Controls.Add(dataGridViewRequests);
            Controls.Add(label1);
            Controls.Add(logout);
            Controls.Add(panel3);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "ApproveRejectRequests";
            Text = "RemoveRoom";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRequests).EndInit();
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
        private LinkLabel logout;
        private Label label1;
        private DataGridView dataGridViewRequests;
        private ComboBox comboBoxStatus;
        private Button btnUpdate;
        private Label label2;
    }
}