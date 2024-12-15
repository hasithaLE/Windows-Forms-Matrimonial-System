namespace MatrimonialSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            label1 = new Label();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            tbEmail = new TextBox();
            tbPassword = new TextBox();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Centaur", 48F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Orchid;
            label1.Location = new Point(66, 38);
            label1.Name = "label1";
            label1.Size = new Size(521, 72);
            label1.TabIndex = 0;
            label1.Text = "Matrimonial System";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(79, 66);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(490, 466);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Centaur", 27.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Orchid;
            label2.Location = new Point(47, 487);
            label2.Name = "label2";
            label2.Size = new Size(555, 41);
            label2.TabIndex = 2;
            label2.Text = "Connecting Hearts, Crafting Futures.";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Centaur", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Orchid;
            label3.Location = new Point(747, 173);
            label3.Name = "label3";
            label3.Size = new Size(133, 53);
            label3.TabIndex = 3;
            label3.Text = "Login";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Orchid;
            label4.Location = new Point(681, 261);
            label4.Name = "label4";
            label4.Size = new Size(60, 24);
            label4.TabIndex = 4;
            label4.Text = "Email";
            label4.Click += label4_Click_1;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Orchid;
            label5.Location = new Point(650, 308);
            label5.Name = "label5";
            label5.Size = new Size(91, 24);
            label5.TabIndex = 5;
            label5.Text = "Password";
            // 
            // tbEmail
            // 
            tbEmail.Location = new Point(747, 258);
            tbEmail.Name = "tbEmail";
            tbEmail.Size = new Size(212, 27);
            tbEmail.TabIndex = 6;
            tbEmail.TextChanged += textBox1_TextChanged;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(747, 307);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(212, 27);
            tbPassword.TabIndex = 7;
            // 
            // button1
            // 
            button1.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.Orchid;
            button1.Location = new Point(747, 366);
            button1.Name = "button1";
            button1.Size = new Size(91, 37);
            button1.TabIndex = 8;
            button1.Text = "Login";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Font = new Font("Centaur", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.ForeColor = Color.Orchid;
            button2.Location = new Point(868, 366);
            button2.Name = "button2";
            button2.Size = new Size(91, 37);
            button2.TabIndex = 9;
            button2.Text = "Register";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(1029, 600);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(tbPassword);
            Controls.Add(tbEmail);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(pictureBox1);
            Font = new Font("Nirmala UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Margin = new Padding(4);
            MaximizeBox = false;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login - Matrimonial System";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox tbEmail;
        private TextBox tbPassword;
        private Button button1;
        private Button button2;
    }
}
