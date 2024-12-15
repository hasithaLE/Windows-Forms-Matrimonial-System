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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace MatrimonialSystem
{
    public partial class MyProfile : Form
    {
        public MyProfile()
        {
            InitializeComponent();
            loadUserProfile();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
            Feed feed = new Feed();
            feed.Show();
        }

        private void loadUserProfile()
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=MatrimonialSystem;Integrated Security=True;Trust Server Certificate=True");
                con.Open();
                string query = "SELECT * FROM [User] WHERE userId = @userId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", GlobalVariables.GlobUserID);
                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    tbFullName.Text = reader["fullName"].ToString();
                    dtpDateOfBirth.Value = Convert.ToDateTime(reader["dateOfBirth"]);
                    cbGender.Text = reader["gender"].ToString();
                    tbEmail.Text = reader["email"].ToString();
                    tbPhone.Text = reader["phone"].ToString();
                    tbOccupation.Text = reader["occupation"].ToString();
                    tbHeight.Text = reader["height"].ToString();
                    tbHobbies.Text = reader["hobbies"].ToString();
                    tbPassword.Text = reader["password"].ToString();
                    string imagePath = reader["profileLocation"].ToString() ?? string.Empty;

                    if (System.IO.File.Exists(imagePath))
                    {
                        pbMyProfile.Image = new Bitmap(imagePath);
                    }
                    else
                    {
                        pbMyProfile.Image = null;
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

        private void bUploadProfile_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pbMyProfile.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=MatrimonialSystem;Integrated Security=True;Trust Server Certificate=True");
                con.Open();
                string query = "UPDATE [User] SET fullName = @fullName, dateOfBirth = @dateOfBirth, gender = @gender, email = @email, phone = @phone, password = @password, occupation = @occupation, height = @height, hobbies = @hobbies, profileLocation = @profileLocation WHERE userId = @userId";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@userId", GlobalVariables.GlobUserID);
                cmd.Parameters.AddWithValue("@fullName", tbFullName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@gender", cbGender.Text);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                cmd.Parameters.AddWithValue("@occupation", tbOccupation.Text);
                cmd.Parameters.AddWithValue("@height", tbHeight.Text);
                cmd.Parameters.AddWithValue("@hobbies", tbHobbies.Text);
                cmd.Parameters.AddWithValue("@profileLocation", pbMyProfile.ImageLocation);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Profile updated successfully.", "Update Profile", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    con.Close();
                }
                else
                {
                    MessageBox.Show("Please Enter All fields", "Invalid Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    con.Close();
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

        private void MyProfile_Load(object sender, EventArgs e)
        {

        }
    }
}
