namespace Ordering_System
{
    partial class purchase
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
            dgvList = new DataGridView();
            btnOrder = new Button();
            gradientPanel1 = new GradientPanel();
            pictureBox3 = new PictureBox();
            btnOrderList = new Button();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            gradientPanel2 = new GradientPanel();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvList).BeginInit();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            gradientPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // dgvList
            // 
            dgvList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvList.Location = new Point(282, 117);
            dgvList.Margin = new Padding(4);
            dgvList.Name = "dgvList";
            dgvList.RowHeadersWidth = 51;
            dgvList.Size = new Size(994, 440);
            dgvList.TabIndex = 0;
            // 
            // btnOrder
            // 
            btnOrder.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrder.Location = new Point(12, 296);
            btnOrder.Margin = new Padding(4);
            btnOrder.Name = "btnOrder";
            btnOrder.Size = new Size(246, 63);
            btnOrder.TabIndex = 1;
            btnOrder.Text = "Purchase";
            btnOrder.UseVisualStyleBackColor = true;
            btnOrder.Click += btnOrder_Click;
            // 
            // gradientPanel1
            // 
            gradientPanel1.BottomColor = Color.SteelBlue;
            gradientPanel1.Controls.Add(pictureBox3);
            gradientPanel1.Controls.Add(btnOrderList);
            gradientPanel1.Controls.Add(pictureBox2);
            gradientPanel1.Controls.Add(pictureBox4);
            gradientPanel1.Controls.Add(btnLogout);
            gradientPanel1.Controls.Add(pictureBox1);
            gradientPanel1.Controls.Add(btnOrder);
            gradientPanel1.Dock = DockStyle.Left;
            gradientPanel1.Location = new Point(0, 0);
            gradientPanel1.Name = "gradientPanel1";
            gradientPanel1.Size = new Size(272, 562);
            gradientPanel1.TabIndex = 10;
            gradientPanel1.TopColor = Color.FromArgb(0, 102, 204);
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.Transparent;
            pictureBox3.Image = Properties.Resources.logs;
            pictureBox3.Location = new Point(16, 220);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(55, 49);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 10;
            pictureBox3.TabStop = false;
            // 
            // btnOrderList
            // 
            btnOrderList.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnOrderList.Location = new Point(12, 213);
            btnOrderList.Name = "btnOrderList";
            btnOrderList.Size = new Size(246, 63);
            btnOrderList.TabIndex = 9;
            btnOrderList.Text = "        Order History";
            btnOrderList.UseVisualStyleBackColor = true;
            btnOrderList.Click += btnOrderList_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.Transparent;
            pictureBox2.Image = Properties.Resources.logs;
            pictureBox2.Location = new Point(16, 304);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(55, 49);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 8;
            pictureBox2.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.BackColor = Color.Transparent;
            pictureBox4.Image = Properties.Resources.logs;
            pictureBox4.Location = new Point(18, 495);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(55, 49);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // btnLogout
            // 
            btnLogout.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogout.Location = new Point(14, 487);
            btnLogout.Name = "btnLogout";
            btnLogout.Size = new Size(246, 63);
            btnLogout.TabIndex = 5;
            btnLogout.Text = "Logout";
            btnLogout.UseVisualStyleBackColor = true;
            btnLogout.Click += btnLogout_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.Transparent;
            pictureBox1.Image = Properties.Resources.logs;
            pictureBox1.Location = new Point(14, 3);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(244, 173);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BottomColor = Color.Black;
            gradientPanel2.Controls.Add(label1);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(272, 0);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(1014, 89);
            gradientPanel2.TabIndex = 11;
            gradientPanel2.TopColor = Color.Transparent;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.ButtonFace;
            label1.Location = new Point(6, 19);
            label1.Name = "label1";
            label1.Size = new Size(184, 48);
            label1.TabIndex = 0;
            label1.Text = "Order List";
            // 
            // purchase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1286, 562);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            Controls.Add(dgvList);
            Margin = new Padding(4);
            Name = "purchase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "purchase";
            Load += purchase_Load;
            ((System.ComponentModel.ISupportInitialize)dgvList).EndInit();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dgvList;
        private Button btnOrder;
        private GradientPanel gradientPanel1;
        private PictureBox pictureBox4;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnOrderList;
        private PictureBox pictureBox2;
        private GradientPanel gradientPanel2;
        private Label label1;
    }
}