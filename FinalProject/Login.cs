using Microsoft.Data.SqlClient;

namespace FinalProject
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=Student;Integrated Security=True;TrustServerCertificate=True");
            con.Open();
            string query = "SELECT COUNT(*) from Logins WHERE username = @username and password = @password";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@username", tbUsername.Text);
            cmd.Parameters.AddWithValue("@password", tbPassword.Text);
            int count = (int)cmd.ExecuteScalar();
            con.Close();
            if (count > 0)
            {
                this.Hide();
                var mainForm = new studentRegistration();
                mainForm.Show();
            }
            else
            {
                MessageBox.Show("Invalid Login credentials, please check Username and Password and try again", "Invalid login Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            tbUsername.Text = "";
            tbPassword.Text = "";
            tbUsername.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // Show a confirmation message box with Yes and No buttons
            DialogResult result = MessageBox.Show(
                "Are you sure, Do you really want to exit...?",
                "Exit",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            // If the user clicks Yes, close the application
            if (result == DialogResult.Yes)
            {
                Application.Exit();  // Exits the application
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void tbUsername_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
