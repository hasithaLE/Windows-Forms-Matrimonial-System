using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MatrimonialSystem
{
    public partial class UserProfile : Form
    {
        private string email;
        public UserProfile(string email)
        {
            InitializeComponent();
            this.email = email;
            loadUserProfile();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feed feed = new Feed();
            feed.Show();
        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void loadUserProfile()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=MatrimonialSystem;Integrated Security=True;Trust Server Certificate=True");
                con.Open();
                string query = "SELECT * FROM [User] WHERE email = @email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@email", email);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    labelFullName.Text = reader["fullName"].ToString();
                    labelAge.Text = DateTime.Now.Year - Convert.ToDateTime(reader["dateOfBirth"]).Year + " years";
                    labelGender.Text = reader["gender"].ToString();
                    labelEmail.Text = reader["email"].ToString();
                    labelPhone.Text = reader["phone"].ToString();
                    labelOccupation.Text = reader["occupation"].ToString();
                    labelHeight.Text = reader["height"].ToString();
                    labelHobbies.Text = reader["hobbies"].ToString();
                    string imagePath = reader["profileLocation"].ToString() ?? string.Empty;

                    if (System.IO.File.Exists(imagePath))
                    {
                        pbProfile.Image = new Bitmap(imagePath);
                    }
                    else
                    {
                        pbProfile.Image = null;
                        MessageBox.Show("Image not found or invalid path.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }

                    con.Close();
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

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Are you sure you want to logout?", "Logout", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dialogResult == DialogResult.Yes)
            {
                this.Hide();
                Login login = new Login();
                login.Show();
            }
        }
    }
}
