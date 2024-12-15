using Microsoft.Data.SqlClient;

namespace MatrimonialSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=MatrimonialSystem;Integrated Security=True;Trust Server Certificate=True");
                con.Open();
                string query = "SELECT * FROM [User] WHERE email = @email and password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read()) // If a row is returned
                {
                    string imagePath = reader["profileLocation"].ToString() ?? string.Empty;
                    int userId = (int)reader["userId"];
                    GlobalVariables.GlobUserImagePath = imagePath;
                    GlobalVariables.GlobUserID = userId;

                    con.Close();

                    this.Hide();
                    Feed feed = new Feed();
                    feed.Show();
                }
                else
                {
                    con.Close();
                    MessageBox.Show("Invalid Login credentials. Please try again.", "Login Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Registration registration = new Registration();
            registration.Show();
        }

        private void label4_Click_1(object sender, EventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {
            try
            {

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
