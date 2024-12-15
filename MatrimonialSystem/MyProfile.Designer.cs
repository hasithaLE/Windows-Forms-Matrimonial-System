namespace MatrimonialSystem
{
    partial class MyProfile
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MyProfile));
            label12 = new Label();
            label7 = new Label();
            label8 = new Label();
            label10 = new Label();
            label3 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            pbMyProfile = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            cbGender = new ComboBox();
            dtpDateOfBirth = new DateTimePicker();
            tbEmail = new TextBox();
            tbFullName = new TextBox();
            tbHobbies = new TextBox();
            tbHeight = new TextBox();
            tbOccupation = new TextBox();
            tbPhone = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            bUploadProfile = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pbMyProfile).BeginInit();
            SuspendLayout();
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Orchid;
            label12.Location = new Point(63, 531);
            label12.Name = "label12";
            label12.Size = new Size(83, 24);
            label12.TabIndex = 74;
            label12.Text = "Hobbies";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Orchid;
            label7.Location = new Point(639, 336);
            label7.Name = "label7";
            label7.Size = new Size(70, 24);
            label7.TabIndex = 73;
            label7.Text = "Height";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Orchid;
            label8.Location = new Point(598, 270);
            label8.Name = "label8";
            label8.Size = new Size(111, 24);
            label8.TabIndex = 72;
            label8.Text = "Occupation";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Orchid;
            label10.Location = new Point(567, 399);
            label10.Name = "label10";
            label10.Size = new Size(142, 24);
            label10.TabIndex = 71;
            label10.Text = "Phone Number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orchid;
            label3.Location = new Point(12, 466);
            label3.Name = "label3";
            label3.Size = new Size(135, 24);
            label3.TabIndex = 70;
            label3.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Orchid;
            label6.Location = new Point(73, 402);
            label6.Name = "label6";
            label6.Size = new Size(73, 24);
            label6.TabIndex = 69;
            label6.Text = "Gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Orchid;
            label5.Location = new Point(21, 339);
            label5.Name = "label5";
            label5.Size = new Size(125, 24);
            label5.TabIndex = 68;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Orchid;
            label4.Location = new Point(44, 273);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 67;
            label4.Text = "Full Name";
            // 
            // pbMyProfile
            // 
            pbMyProfile.Image = (Image)resources.GetObject("pbMyProfile.Image");
            pbMyProfile.Location = new Point(418, 16);
            pbMyProfile.Name = "pbMyProfile";
            pbMyProfile.Size = new Size(189, 183);
            pbMyProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMyProfile.TabIndex = 66;
            pbMyProfile.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(925, 12);
            button1.Name = "button1";
            button1.Size = new Size(92, 37);
            button1.TabIndex = 65;
            button1.Text = "Logout";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Black;
            button2.Location = new Point(12, 12);
            button2.Name = "button2";
            button2.Size = new Size(92, 37);
            button2.TabIndex = 64;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(153, 398);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(378, 28);
            cbGender.TabIndex = 85;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(153, 336);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(378, 27);
            dtpDateOfBirth.TabIndex = 84;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(153, 463);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(378, 27);
            tbEmail.TabIndex = 83;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(153, 268);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(378, 27);
            tbFullName.TabIndex = 82;
            // 
            // tbHobbies
            // 
            tbHobbies.Location = new Point(153, 528);
            tbHobbies.Name = "tbHobbies";
            tbHobbies.Size = new Size(378, 27);
            tbHobbies.TabIndex = 86;
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(718, 333);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(267, 27);
            tbHeight.TabIndex = 88;
            // 
            // tbOccupation
            // 
            tbOccupation.Location = new Point(718, 268);
            tbOccupation.Name = "tbOccupation";
            tbOccupation.Size = new Size(267, 27);
            tbOccupation.TabIndex = 87;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(718, 399);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(267, 27);
            tbPhone.TabIndex = 89;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(718, 462);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(267, 27);
            tbPassword.TabIndex = 91;
            tbPassword.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orchid;
            label1.Location = new Point(618, 461);
            label1.Name = "label1";
            label1.Size = new Size(91, 24);
            label1.TabIndex = 90;
            label1.Text = "Password";
            // 
            // bUploadProfile
            // 
            bUploadProfile.Font = new Font("Centaur", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bUploadProfile.ForeColor = Color.Black;
            bUploadProfile.Location = new Point(613, 148);
            bUploadProfile.Name = "bUploadProfile";
            bUploadProfile.Size = new Size(75, 51);
            bUploadProfile.TabIndex = 92;
            bUploadProfile.Text = "Change\r\nImage";
            bUploadProfile.UseVisualStyleBackColor = true;
            bUploadProfile.Click += bUploadProfile_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Centaur", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Black;
            button3.Location = new Point(718, 519);
            button3.Name = "button3";
            button3.Size = new Size(141, 36);
            button3.TabIndex = 93;
            button3.Text = "Update Profile";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // MyProfile
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 600);
            Controls.Add(button3);
            Controls.Add(bUploadProfile);
            Controls.Add(tbPassword);
            Controls.Add(label1);
            Controls.Add(tbPhone);
            Controls.Add(tbHeight);
            Controls.Add(tbOccupation);
            Controls.Add(tbHobbies);
            Controls.Add(cbGender);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(tbEmail);
            Controls.Add(tbFullName);
            Controls.Add(label12);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(label10);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(pbMyProfile);
            Controls.Add(button1);
            Controls.Add(button2);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            Name = "MyProfile";
            Text = "My Profile - Matrimonial System";
            Load += MyProfile_Load;
            ((System.ComponentModel.ISupportInitialize)pbMyProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label12;
        private Label label7;
        private Label label8;
        private Label label10;
        private Label label3;
        private Label label6;
        private Label label5;
        private Label label4;
        private PictureBox pbMyProfile;
        private Button button1;
        private Button button2;
        private ComboBox cbGender;
        private DateTimePicker dtpDateOfBirth;
        private TextBox tbEmail;
        private TextBox tbFullName;
        private TextBox tbHobbies;
        private TextBox tbHeight;
        private TextBox tbOccupation;
        private TextBox tbPhone;
        private TextBox tbPassword;
        private Label label1;
        private Button bUploadProfile;
        private Button button3;
    }
}