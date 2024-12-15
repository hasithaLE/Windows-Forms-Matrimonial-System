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
    public partial class Registration : System.Windows.Forms.Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            String imageLocation = "";
            try
            {
                OpenFileDialog dialog = new OpenFileDialog();
                dialog.Filter = "jpg files(*.jpg)|*.jpg| PNG files(*.png)|*.png| All Files(*.*)|*.*";
                if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    imageLocation = dialog.FileName;
                    pbProfile.ImageLocation = imageLocation;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("An Error Occured", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login login = new Login();
            login.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=MatrimonialSystem;Integrated Security=True;Trust Server Certificate=True");
                con.Open();
                string query = "INSERT INTO [User] (fullName, dateOfBirth, gender, email, phone, password, occupation, height, hobbies, profileLocation) VALUES (@fullName, @dateOfBirth, @gender, @email, @phone, @password, @occupation, @height, @hobbies, @profileLocation)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@fullName", tbFullName.Text);
                cmd.Parameters.AddWithValue("@dateOfBirth", dtpDateOfBirth.Value);
                cmd.Parameters.AddWithValue("@gender", cbGender.Text);
                cmd.Parameters.AddWithValue("@email", tbEmail.Text);
                cmd.Parameters.AddWithValue("@phone", tbPhone.Text);
                cmd.Parameters.AddWithValue("@password", tbPassword.Text);
                cmd.Parameters.AddWithValue("@occupation", tbOccupation.Text);
                cmd.Parameters.AddWithValue("@height", tbHeight.Text);
                cmd.Parameters.AddWithValue("@hobbies", tbHobbies.Text);
                cmd.Parameters.AddWithValue("@profileLocation", pbProfile.ImageLocation);
                if (cmd.ExecuteNonQuery() == 1)
                {
                    MessageBox.Show("Register Succesfully. Login Now", "Register User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    clearFields();
                    this.Hide();
                    Login login = new Login();
                    login.Show();
                }
                else
                {
                    MessageBox.Show("Please Enter All fields", "Invalid Student Details", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }
        }

        //clear fields method to clear all the fields
        private void clearFields()
        {
            tbFullName.Text = "";
            dtpDateOfBirth.Value = DateTime.Now;
            cbGender.Text = "";
            tbEmail.Text = "";
            tbPhone.Text = "";
            tbPassword.Text = "";
            tbOccupation.Text = "";
            tbHeight.Text = "";
            tbHobbies.Text = "";
            tbFullName.Focus();
        }
    }
}
