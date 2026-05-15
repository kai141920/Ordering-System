namespace Ordering_System
{
    partial class register
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
            gradientPanel2 = new GradientPanel();
            label3 = new Label();
            label1 = new Label();
            txtfullname = new TextBox();
            label2 = new Label();
            btnCreate = new Button();
            label4 = new Label();
            txtPassword = new TextBox();
            txtAddress = new TextBox();
            txtEmail = new TextBox();
            pictureBox1 = new PictureBox();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // gradientPanel2
            // 
            gradientPanel2.BottomColor = Color.CornflowerBlue;
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(txtfullname);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(btnCreate);
            gradientPanel2.Controls.Add(label4);
            gradientPanel2.Controls.Add(txtPassword);
            gradientPanel2.Controls.Add(txtAddress);
            gradientPanel2.Controls.Add(txtEmail);
            gradientPanel2.Location = new Point(282, 51);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(446, 462);
            gradientPanel2.TabIndex = 10;
            gradientPanel2.TopColor = Color.MediumTurquoise;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label3.Location = new Point(275, 300);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(112, 25);
            label3.TabIndex = 15;
            label3.Text = "PASSWORD";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(279, 73);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(111, 25);
            label1.TabIndex = 13;
            label1.Text = "FULL NAME";
            // 
            // txtfullname
            // 
            txtfullname.Location = new Point(69, 38);
            txtfullname.Margin = new Padding(4);
            txtfullname.Name = "txtfullname";
            txtfullname.Size = new Size(314, 31);
            txtfullname.TabIndex = 9;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(293, 146);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(93, 25);
            label2.TabIndex = 14;
            label2.Text = "ADDRESS";
            // 
            // btnCreate
            // 
            btnCreate.BackColor = Color.DeepSkyBlue;
            btnCreate.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreate.Location = new Point(162, 379);
            btnCreate.Margin = new Padding(4);
            btnCreate.Name = "btnCreate";
            btnCreate.Size = new Size(135, 55);
            btnCreate.TabIndex = 17;
            btnCreate.Text = "CREATE";
            btnCreate.UseVisualStyleBackColor = false;
            btnCreate.Click += btnCreate_Click_1;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(321, 222);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(67, 25);
            label4.TabIndex = 16;
            label4.Text = "EMAIL";
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(69, 265);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(314, 31);
            txtPassword.TabIndex = 12;
            // 
            // txtAddress
            // 
            txtAddress.Location = new Point(69, 111);
            txtAddress.Margin = new Padding(4);
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(314, 31);
            txtAddress.TabIndex = 10;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(69, 187);
            txtEmail.Margin = new Padding(4);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(314, 31);
            txtEmail.TabIndex = 11;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Dock = DockStyle.Fill;
            pictureBox1.Image = Properties.Resources.wallpaper;
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1000, 562);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 11;
            pictureBox1.TabStop = false;
            // 
            // register
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1000, 562);
            Controls.Add(gradientPanel2);
            Controls.Add(pictureBox1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "register";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "register";
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private GradientPanel gradientPanel2;
        private Label label3;
        private Label label1;
        private TextBox txtfullname;
        private Label label2;
        private Button btnCreate;
        private Label label4;
        private TextBox txtPassword;
        private TextBox txtAddress;
        private TextBox txtEmail;
        private PictureBox pictureBox1;
    }
}