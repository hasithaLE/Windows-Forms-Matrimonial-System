namespace MatrimonialSystem
{
    partial class Registration
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registration));
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            tbFullName = new TextBox();
            label5 = new Label();
            label4 = new Label();
            tbEmail = new TextBox();
            label3 = new Label();
            label6 = new Label();
            tbHeight = new TextBox();
            tbOccupation = new TextBox();
            label7 = new Label();
            label8 = new Label();
            tbPassword = new TextBox();
            tbPhone = new TextBox();
            label9 = new Label();
            label10 = new Label();
            tbHobbies = new TextBox();
            label12 = new Label();
            pbProfile = new PictureBox();
            bUploadProfile = new Button();
            button1 = new Button();
            button3 = new Button();
            dtpDateOfBirth = new DateTimePicker();
            cbGender = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(34, 153);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(410, 391);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Centaur", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(43, 74);
            label2.Name = "label2";
            label2.Size = new Size(394, 106);
            label2.TabIndex = 3;
            label2.Text = "Join the Journey to\r\nYour Perfect Match";
            label2.TextAlign = ContentAlignment.TopCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Centaur", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(593, 29);
            label1.Name = "label1";
            label1.Size = new Size(229, 72);
            label1.TabIndex = 4;
            label1.Text = "Register";
            label1.TextAlign = ContentAlignment.MiddleLeft;
            // 
            // tbFullName
            // 
            tbFullName.Location = new Point(628, 119);
            tbFullName.Name = "tbFullName";
            tbFullName.Size = new Size(378, 27);
            tbFullName.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(497, 168);
            label5.Name = "label5";
            label5.Size = new Size(125, 24);
            label5.TabIndex = 9;
            label5.Text = "Date of Birth";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(520, 119);
            label4.Name = "label4";
            label4.Size = new Size(102, 24);
            label4.TabIndex = 8;
            label4.Text = "Full Name";
            label4.Click += label4_Click;
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(628, 266);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(378, 27);
            tbEmail.TabIndex = 15;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(487, 266);
            label3.Name = "label3";
            label3.Size = new Size(135, 24);
            label3.TabIndex = 13;
            label3.Text = "Email Address";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Red;
            label6.Location = new Point(549, 220);
            label6.Name = "label6";
            label6.Size = new Size(73, 24);
            label6.TabIndex = 12;
            label6.Text = "Gender";
            // 
            // tbHeight
            // 
            tbHeight.Location = new Point(628, 460);
            tbHeight.Name = "tbHeight";
            tbHeight.Size = new Size(378, 27);
            tbHeight.TabIndex = 23;
            // 
            // tbOccupation
            // 
            tbOccupation.Location = new Point(628, 411);
            tbOccupation.Name = "tbOccupation";
            tbOccupation.Size = new Size(378, 27);
            tbOccupation.TabIndex = 22;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.Red;
            label7.Location = new Point(552, 460);
            label7.Name = "label7";
            label7.Size = new Size(70, 24);
            label7.TabIndex = 21;
            label7.Text = "Height";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Red;
            label8.Location = new Point(511, 412);
            label8.Name = "label8";
            label8.Size = new Size(111, 24);
            label8.TabIndex = 20;
            label8.Text = "Occupation";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(628, 362);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(378, 27);
            tbPassword.TabIndex = 19;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(628, 313);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(378, 27);
            tbPhone.TabIndex = 18;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.Red;
            label9.Location = new Point(531, 363);
            label9.Name = "label9";
            label9.Size = new Size(91, 24);
            label9.TabIndex = 17;
            label9.Text = "Password";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.Red;
            label10.Location = new Point(480, 313);
            label10.Name = "label10";
            label10.Size = new Size(142, 24);
            label10.TabIndex = 16;
            label10.Text = "Phone Number";
            label10.Click += label10_Click;
            // 
            // tbHobbies
            // 
            tbHobbies.Location = new Point(628, 504);
            tbHobbies.Name = "tbHobbies";
            tbHobbies.Size = new Size(378, 27);
            tbHobbies.TabIndex = 26;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label12.ForeColor = Color.Red;
            label12.Location = new Point(539, 505);
            label12.Name = "label12";
            label12.Size = new Size(83, 24);
            label12.TabIndex = 24;
            label12.Text = "Hobbies";
            // 
            // pbProfile
            // 
            pbProfile.Image = (Image)resources.GetObject("pbProfile.Image");
            pbProfile.Location = new Point(920, 21);
            pbProfile.Name = "pbProfile";
            pbProfile.Size = new Size(86, 81);
            pbProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbProfile.TabIndex = 28;
            pbProfile.TabStop = false;
            // 
            // bUploadProfile
            // 
            bUploadProfile.Font = new Font("Centaur", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bUploadProfile.ForeColor = Color.Red;
            bUploadProfile.Location = new Point(839, 51);
            bUploadProfile.Name = "bUploadProfile";
            bUploadProfile.Size = new Size(75, 51);
            bUploadProfile.TabIndex = 30;
            bUploadProfile.Text = "Upload\r\nImage";
            bUploadProfile.UseVisualStyleBackColor = true;
            bUploadProfile.Click += button2_Click;
            // 
            // button1
            // 
            button1.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Red;
            button1.Location = new Point(702, 544);
            button1.Name = "button1";
            button1.Size = new Size(91, 37);
            button1.TabIndex = 32;
            button1.Text = "Register";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Red;
            button3.Location = new Point(823, 544);
            button3.Name = "button3";
            button3.Size = new Size(91, 37);
            button3.TabIndex = 31;
            button3.Text = "Login";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.Location = new Point(628, 165);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(378, 27);
            dtpDateOfBirth.TabIndex = 33;
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(628, 216);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(378, 28);
            cbGender.TabIndex = 34;
            // 
            // Registration
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 600);
            Controls.Add(cbGender);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(button1);
            Controls.Add(button3);
            Controls.Add(bUploadProfile);
            Controls.Add(pbProfile);
            Controls.Add(tbHobbies);
            Controls.Add(label12);
            Controls.Add(tbHeight);
            Controls.Add(tbOccupation);
            Controls.Add(label7);
            Controls.Add(label8);
            Controls.Add(tbPassword);
            Controls.Add(tbPhone);
            Controls.Add(label9);
            Controls.Add(label10);
            Controls.Add(tbEmail);
            Controls.Add(label3);
            Controls.Add(label6);
            Controls.Add(tbFullName);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Registration";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Registration - Matrimonial System";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbProfile).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Label label2;
        private Label label1;
        private TextBox tbFullName;
        private Label label5;
        private Label label4;
        private TextBox tbEmail;
        private Label label3;
        private Label label6;
        private TextBox tbHeight;
        private TextBox tbOccupation;
        private Label label7;
        private Label label8;
        private TextBox tbPassword;
        private TextBox tbPhone;
        private Label label9;
        private Label label10;
        private TextBox tbHobbies;
        private Label label12;
        private PictureBox pbProfile;
        private Button bUploadProfile;
        private Button button1;
        private Button button3;
        private DateTimePicker dtpDateOfBirth;
        private ComboBox cbGender;
    }
}