namespace MatrimonialSystem
{
    partial class Feed
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Feed));
            pictureBox1 = new PictureBox();
            tbName = new TextBox();
            label4 = new Label();
            cbGender = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            dtpDateOfBirth = new DateTimePicker();
            label3 = new Label();
            pbMyProfile = new PictureBox();
            button1 = new Button();
            button2 = new Button();
            dataGridView1 = new DataGridView();
            pictureBox3 = new PictureBox();
            labelFullName = new Label();
            label6 = new Label();
            pictureBox4 = new PictureBox();
            label5 = new Label();
            labelGender = new Label();
            label8 = new Label();
            labelBirthYear = new Label();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbMyProfile).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(115, 113);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // tbName
            // 
            tbName.Location = new Point(181, 73);
            tbName.Name = "tbName";
            tbName.Size = new Size(165, 27);
            tbName.TabIndex = 8;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Orchid;
            label4.Location = new Point(118, 76);
            label4.Name = "label4";
            label4.Size = new Size(61, 24);
            label4.TabIndex = 7;
            label4.Text = "Name";
            // 
            // cbGender
            // 
            cbGender.FormattingEnabled = true;
            cbGender.Items.AddRange(new object[] { "Male", "Female" });
            cbGender.Location = new Point(434, 72);
            cbGender.Name = "cbGender";
            cbGender.Size = new Size(189, 28);
            cbGender.TabIndex = 35;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orchid;
            label1.Location = new Point(357, 76);
            label1.Name = "label1";
            label1.Size = new Size(73, 24);
            label1.TabIndex = 36;
            label1.Text = "Gender";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orchid;
            label2.Location = new Point(641, 74);
            label2.Name = "label2";
            label2.Size = new Size(101, 24);
            label2.TabIndex = 37;
            label2.Text = "Birth Year";
            // 
            // dtpDateOfBirth
            // 
            dtpDateOfBirth.CalendarFont = new Font("Nirmala UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.CustomFormat = " yyyy";
            dtpDateOfBirth.Font = new Font("Nirmala UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dtpDateOfBirth.Format = DateTimePickerFormat.Custom;
            dtpDateOfBirth.Location = new Point(744, 71);
            dtpDateOfBirth.Name = "dtpDateOfBirth";
            dtpDateOfBirth.Size = new Size(122, 29);
            dtpDateOfBirth.TabIndex = 38;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Centaur", 26.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orchid;
            label3.Location = new Point(118, 12);
            label3.Name = "label3";
            label3.Size = new Size(216, 40);
            label3.TabIndex = 39;
            label3.Text = "Find your love";
            // 
            // pbMyProfile
            // 
            pbMyProfile.Image = (Image)resources.GetObject("pbMyProfile.Image");
            pbMyProfile.Location = new Point(893, 12);
            pbMyProfile.Name = "pbMyProfile";
            pbMyProfile.Size = new Size(124, 100);
            pbMyProfile.SizeMode = PictureBoxSizeMode.StretchImage;
            pbMyProfile.TabIndex = 40;
            pbMyProfile.TabStop = false;
            // 
            // button1
            // 
            button1.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Orchid;
            button1.Location = new Point(893, 118);
            button1.Name = "button1";
            button1.Size = new Size(124, 37);
            button1.TabIndex = 41;
            button1.Text = "My Profile";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Orchid;
            button2.Location = new Point(181, 118);
            button2.Name = "button2";
            button2.Size = new Size(165, 37);
            button2.TabIndex = 43;
            button2.Text = "Search";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 175);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.Size = new Size(569, 413);
            dataGridView1.TabIndex = 44;
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.InitialImage = (Image)resources.GetObject("pictureBox3.InitialImage");
            pictureBox3.Location = new Point(817, 175);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(190, 189);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 45;
            pictureBox3.TabStop = false;
            // 
            // labelFullName
            // 
            labelFullName.AutoSize = true;
            labelFullName.Font = new Font("Centaur", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelFullName.ForeColor = Color.Orchid;
            labelFullName.Location = new Point(700, 383);
            labelFullName.Name = "labelFullName";
            labelFullName.Size = new Size(0, 31);
            labelFullName.TabIndex = 46;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Centaur", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.Orchid;
            label6.Location = new Point(589, 379);
            label6.Name = "label6";
            label6.Size = new Size(91, 36);
            label6.TabIndex = 47;
            label6.Text = "Name";
            label6.Click += label6_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = (Image)resources.GetObject("pictureBox4.Image");
            pictureBox4.Location = new Point(621, 184);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(156, 149);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 48;
            pictureBox4.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Centaur", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Orchid;
            label5.Location = new Point(589, 429);
            label5.Name = "label5";
            label5.Size = new Size(107, 36);
            label5.TabIndex = 49;
            label5.Text = "Gender";
            // 
            // labelGender
            // 
            labelGender.AutoSize = true;
            labelGender.Font = new Font("Centaur", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelGender.ForeColor = Color.Orchid;
            labelGender.Location = new Point(701, 432);
            labelGender.Name = "labelGender";
            labelGender.Size = new Size(0, 31);
            labelGender.TabIndex = 50;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Centaur", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.Orchid;
            label8.Location = new Point(589, 474);
            label8.Name = "label8";
            label8.Size = new Size(63, 36);
            label8.TabIndex = 51;
            label8.Text = "Age";
            // 
            // labelBirthYear
            // 
            labelBirthYear.AutoSize = true;
            labelBirthYear.Font = new Font("Centaur", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelBirthYear.ForeColor = Color.Orchid;
            labelBirthYear.Location = new Point(702, 476);
            labelBirthYear.Name = "labelBirthYear";
            labelBirthYear.Size = new Size(0, 31);
            labelBirthYear.TabIndex = 52;
            labelBirthYear.Click += label9_Click;
            // 
            // button3
            // 
            button3.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.ForeColor = Color.Orchid;
            button3.Location = new Point(686, 541);
            button3.Name = "button3";
            button3.Size = new Size(211, 37);
            button3.TabIndex = 53;
            button3.Text = "View More Details";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Feed
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 600);
            Controls.Add(button3);
            Controls.Add(labelBirthYear);
            Controls.Add(label8);
            Controls.Add(labelGender);
            Controls.Add(label5);
            Controls.Add(pictureBox4);
            Controls.Add(label6);
            Controls.Add(labelFullName);
            Controls.Add(pictureBox3);
            Controls.Add(dataGridView1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(pbMyProfile);
            Controls.Add(label3);
            Controls.Add(dtpDateOfBirth);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cbGender);
            Controls.Add(tbName);
            Controls.Add(label4);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Feed";
            Text = "Feed - Matrimonial System";
            Load += Feed_Load_1;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbMyProfile).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private TextBox tbName;
        private Label label4;
        private ComboBox cbGender;
        private Label label1;
        private Label label2;
        private DateTimePicker dtpDateOfBirth;
        private Label label3;
        private PictureBox pbMyProfile;
        private Button button1;
        private Button button2;
        private DataGridView dataGridView1;
        private PictureBox pictureBox3;
        private Label labelFullName;
        private Label label6;
        private PictureBox pictureBox4;
        private Label label5;
        private Label labelGender;
        private Label label8;
        private Label labelBirthYear;
        private Button button3;
    }
}