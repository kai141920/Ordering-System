namespace Ordering_System
{
    partial class Form1
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
            btnLogin = new Button();
            LinkRegister = new LinkLabel();
            txtUsername = new TextBox();
            txtPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            gradientPanel1 = new GradientPanel();
            gradientPanel2 = new GradientPanel();
            pictureBox1 = new PictureBox();
            gradientPanel1.SuspendLayout();
            gradientPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.DeepSkyBlue;
            btnLogin.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Location = new Point(126, 287);
            btnLogin.Margin = new Padding(4);
            btnLogin.Name = "btnLogin";
            btnLogin.Size = new Size(140, 48);
            btnLogin.TabIndex = 0;
            btnLogin.Text = "LOGIN";
            btnLogin.UseVisualStyleBackColor = false;
            btnLogin.Click += btnLogin_Click;
            // 
            // LinkRegister
            // 
            LinkRegister.AutoSize = true;
            LinkRegister.BackColor = Color.Transparent;
            LinkRegister.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            LinkRegister.LinkColor = Color.Red;
            LinkRegister.Location = new Point(43, 237);
            LinkRegister.Margin = new Padding(4, 0, 4, 0);
            LinkRegister.Name = "LinkRegister";
            LinkRegister.Size = new Size(314, 25);
            LinkRegister.TabIndex = 1;
            LinkRegister.TabStop = true;
            LinkRegister.Text = "Dont Have an Account?  Register Here";
            LinkRegister.LinkClicked += LinkRegister_LinkClicked;
            // 
            // txtUsername
            // 
            txtUsername.Location = new Point(37, 56);
            txtUsername.Margin = new Padding(4);
            txtUsername.Name = "txtUsername";
            txtUsername.Size = new Size(332, 31);
            txtUsername.TabIndex = 2;
            // 
            // txtPassword
            // 
            txtPassword.Location = new Point(37, 142);
            txtPassword.Margin = new Padding(4);
            txtPassword.Name = "txtPassword";
            txtPassword.Size = new Size(332, 31);
            txtPassword.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label1.Location = new Point(258, 176);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(112, 25);
            label1.TabIndex = 4;
            label1.Text = "PASSWORD";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(259, 90);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(111, 25);
            label2.TabIndex = 5;
            label2.Text = "USERNAME";
            // 
            // gradientPanel1
            // 
            gradientPanel1.BottomColor = Color.LightSkyBlue;
            gradientPanel1.Controls.Add(gradientPanel2);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Dock = DockStyle.Fill;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(1000, 562);
            gradientPanel1.TabIndex = 7;
            gradientPanel1.TopColor = Color.DarkTurquoise;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BottomColor = Color.CornflowerBlue;
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Controls.Add(txtPassword);
            gradientPanel2.Controls.Add(label2);
            gradientPanel2.Controls.Add(btnLogin);
            gradientPanel2.Controls.Add(LinkRegister);
            gradientPanel2.Controls.Add(txtUsername);
            gradientPanel2.Location = new Point(309, 80);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(408, 374);
            gradientPanel2.TabIndex = 8;
            gradientPanel2.TopColor = Color.MediumTurquoise;
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
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(1000, 562);
            Controls.Add(gradientPanel1);
            Margin = new Padding(4);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            gradientPanel1.ResumeLayout(false);
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button btnLogin;
        private LinkLabel LinkRegister;
        private TextBox txtUsername;
        private TextBox txtPassword;
        private Label label1;
        private Label label2;
        private GradientPanel gradientPanel1;
        private GradientPanel gradientPanel2;
        private PictureBox pictureBox1;
    }
}
