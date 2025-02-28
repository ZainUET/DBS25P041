namespace DB_Mid_Project
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void heading1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void role_Enter_1(object sender, EventArgs e)
        {
            labelPlaceholder.Visible = false;
        }

        private void role_Leave(object sender, EventArgs e)
        {
            if (role.SelectedIndex == -1)
            {
                labelPlaceholder.Visible = true;
            }
        }

        private void Login_Load_1(object sender, EventArgs e)
        {

            labelPlaceholder.ForeColor = Color.Gray;
            labelPlaceholder.BackColor = role.BackColor;
            labelPlaceholder.BringToFront();

        }

        private void linkLabel2_Click(object sender, EventArgs e)
        {
            Register signupForm = new Register();
            signupForm.Show();
            this.Show();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            forgotPassword Form = new forgotPassword(); 
            Form.Show();
            this.Show();
        }
    }
}
