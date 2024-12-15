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
using System.Xml.Linq;

namespace MatrimonialSystem
{
    public partial class Feed : Form
    {
        private string userImagePath;
        private int userId;
        private string email;
        private bool isSelected = false;
        SqlConnection con = new SqlConnection("Data Source=THAMARA;Initial Catalog=MatrimonialSystem;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public Feed()
        {
            InitializeComponent();
            this.userImagePath = GlobalVariables.GlobUserImagePath;
            this.userId = GlobalVariables.GlobUserID;

            if (File.Exists(userImagePath))
            {
                pbMyProfile.Image = new Bitmap(userImagePath);
            }
            else
            {
                pictureBox1.Image = null;
                MessageBox.Show("Image not found or invalid path.", "Image Load Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void populateGrid()
        {
            con.Open();
            string query = "SELECT fullName, dateOfBirth, gender, occupation, height, hobbies FROM [User]";
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(query, con);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(sqlDataAdapter);
            var dataSet = new DataSet();
            sqlDataAdapter.Fill(dataSet);
            dataGridView1.DataSource = dataSet.Tables[0];
            con.Close();
        }
        private void Feed_Load(object sender, EventArgs e)
        {

        }


        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                // Read input values
                string name = tbName.Text.Trim();
                string gender = cbGender.Text;
                DateTime birthYear = dtpDateOfBirth.Value;

                // Build the SQL query with parameters
                string connectionString = "Data Source=THAMARA;Initial Catalog=MatrimonialSystem;Integrated Security=True;Trust Server Certificate=True";
                string query = "SELECT fullName, gender, dateOfBirth, email, profileLocation FROM [User] WHERE " +
                               "(fullName LIKE @name OR @name = '') AND " +
                               "(gender = @gender OR @gender = '') AND " +
                               "(YEAR(dateOfBirth) = @birthYear OR @birthYear = 0) AND " +
                               "userId != @userId";

                // Fetch data from database
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@name", "%" + name + "%");
                    cmd.Parameters.AddWithValue("@gender", gender);
                    cmd.Parameters.AddWithValue("@birthYear", birthYear.Year == 2024 ? 0 : birthYear.Year); // 2024 is default
                    cmd.Parameters.AddWithValue("@userId", userId);

                    SqlDataAdapter da = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    // Bind results to DataGridView
                    dataGridView1.DataSource = dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                // Get selected row
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    isSelected = true;
                    string imagePath = dataGridView1.SelectedRows[0].Cells["profileLocation"].Value.ToString() ?? string.Empty;
                    string name = dataGridView1.SelectedRows[0].Cells["fullName"].Value.ToString() ?? string.Empty;
                    string gender = dataGridView1.SelectedRows[0].Cells["gender"].Value.ToString() ?? string.Empty;
                    email = dataGridView1.SelectedRows[0].Cells["email"].Value.ToString() ?? string.Empty;
                    string dOfBirth = dataGridView1.SelectedRows[0].Cells["dateOfBirth"].Value.ToString() ?? string.Empty;
                    int age = DateTime.Now.Year - Convert.ToDateTime(dOfBirth).Year;

                    labelFullName.Text = name;
                    labelGender.Text = gender;
                    labelBirthYear.Text = age.ToString();

                    // Check if file exists
                    if (File.Exists(imagePath))
                    {
                        pictureBox3.Image = new Bitmap(imagePath);
                    }
                    else
                    {
                        pictureBox3.Image = null;
                        MessageBox.Show("Image not found at the specified path.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (isSelected)
            {
                this.Hide();
                UserProfile userProfile = new UserProfile(email);
                userProfile.Show();
            }
            else
            {
                MessageBox.Show("Please select a user to view profile.");
                return;
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            MyProfile myProfile = new MyProfile();
            myProfile.Show();
        }

        private void Feed_Load_1(object sender, EventArgs e)
        {

        }
    }
}
