namespace DB_Mid_Project
{
    public partial class Register : Form
    {
        public Register()
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

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void role_Enter(object sender, EventArgs e)
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

        private void Register_Load(object sender, EventArgs e)
        {
            labelPlaceholder.ForeColor = Color.Gray;
            labelPlaceholder.BackColor = role.BackColor;
            labelPlaceholder.BringToFront();
        }

        private void linkLabel1_Click(object sender, EventArgs e)
        {
            Login Form = new Login(); 
            Form.Show();
            this.Hide();
        }
    }
}
