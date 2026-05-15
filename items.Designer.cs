namespace Ordering_System
{
    partial class items
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
            txtFullname = new TextBox();
            cmbEquipment = new ComboBox();
            nudQty = new NumericUpDown();
            label1 = new Label();
            lblPrice = new Label();
            lblTotal = new Label();
            btnPurchase = new Button();
            gradientPanel2 = new GradientPanel();
            label3 = new Label();
            gradientPanel1 = new GradientPanel();
            pictureBox3 = new PictureBox();
            btnOrderList = new Button();
            pictureBox2 = new PictureBox();
            pictureBox4 = new PictureBox();
            btnLogout = new Button();
            pictureBox1 = new PictureBox();
            btnOrder = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            cmbCategory = new ComboBox();
            label7 = new Label();
            label8 = new Label();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            gradientPanel2.SuspendLayout();
            gradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(547, 128);
            txtFullname.Margin = new Padding(4);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(318, 31);
            txtFullname.TabIndex = 0;
            // 
            // cmbEquipment
            // 
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(547, 188);
            cmbEquipment.Margin = new Padding(4);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(318, 33);
            cmbEquipment.TabIndex = 1;
            cmbEquipment.SelectedIndexChanged += cmbEquipment_SelectedIndexChanged_1;
            // 
            // nudQty
            // 
            nudQty.Location = new Point(547, 313);
            nudQty.Margin = new Padding(4);
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(318, 31);
            nudQty.TabIndex = 2;
            nudQty.ValueChanged += nudQty_ValueChanged_1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(683, 358);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 25);
            label1.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPrice.Location = new Point(547, 379);
            lblPrice.Margin = new Padding(4, 0, 4, 0);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(54, 28);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(546, 433);
            lblTotal.Margin = new Padding(4, 0, 4, 0);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(54, 28);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // btnPurchase
            // 
            btnPurchase.BackColor = Color.SpringGreen;
            btnPurchase.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPurchase.Location = new Point(643, 485);
            btnPurchase.Margin = new Padding(4);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(151, 59);
            btnPurchase.TabIndex = 7;
            btnPurchase.Text = "PURCHASE";
            btnPurchase.UseVisualStyleBackColor = false;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // gradientPanel2
            // 
            gradientPanel2.BottomColor = Color.Black;
            gradientPanel2.Controls.Add(label3);
            gradientPanel2.Dock = DockStyle.Top;
            gradientPanel2.Location = new Point(272, 0);
            gradientPanel2.Name = "gradientPanel2";
            gradientPanel2.Size = new Size(728, 89);
            gradientPanel2.TabIndex = 13;
            gradientPanel2.TopColor = Color.Transparent;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = SystemColors.ButtonFace;
            label3.Location = new Point(6, 19);
            label3.Name = "label3";
            label3.Size = new Size(274, 48);
            label3.TabIndex = 0;
            label3.Text = "Purchase Items";
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
            gradientPanel1.TabIndex = 12;
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
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(420, 129);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(122, 30);
            label4.TabIndex = 14;
            label4.Text = "Full Name:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(410, 191);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(132, 30);
            label5.TabIndex = 15;
            label5.Text = "Equipment:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(427, 253);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(115, 30);
            label6.TabIndex = 17;
            label6.Text = "Category:";
            // 
            // cmbCategory
            // 
            cmbCategory.FormattingEnabled = true;
            cmbCategory.Location = new Point(547, 250);
            cmbCategory.Margin = new Padding(4);
            cmbCategory.Name = "cmbCategory";
            cmbCategory.Size = new Size(318, 33);
            cmbCategory.TabIndex = 16;
            cmbCategory.SelectedIndexChanged += cmbCategory_SelectedIndexChanged_1;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label7.Location = new Point(432, 314);
            label7.Margin = new Padding(4, 0, 4, 0);
            label7.Name = "label7";
            label7.Size = new Size(110, 30);
            label7.TabIndex = 18;
            label7.Text = "Quantity:";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label8.Location = new Point(471, 379);
            label8.Margin = new Padding(4, 0, 4, 0);
            label8.Name = "label8";
            label8.Size = new Size(71, 30);
            label8.TabIndex = 19;
            label8.Text = "Price:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(383, 431);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(159, 30);
            label2.TabIndex = 20;
            label2.Text = "Total Amount:";
            // 
            // items
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ActiveBorder;
            ClientSize = new Size(1000, 562);
            Controls.Add(label2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(cmbCategory);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(gradientPanel2);
            Controls.Add(gradientPanel1);
            Controls.Add(btnPurchase);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(label1);
            Controls.Add(nudQty);
            Controls.Add(cmbEquipment);
            Controls.Add(txtFullname);
            Margin = new Padding(4);
            Name = "items";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "items";
            Load += items_Load_1;
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            gradientPanel2.ResumeLayout(false);
            gradientPanel2.PerformLayout();
            gradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private ComboBox cmbEquipment;
        private NumericUpDown nudQty;
        private Label label1;
        private Label lblPrice;
        private Label lblTotal;
        private Button btnPurchase;
        private GradientPanel gradientPanel2;
        private Label label3;
        private GradientPanel gradientPanel1;
        private PictureBox pictureBox3;
        private Button btnOrderList;
        private PictureBox pictureBox2;
        private PictureBox pictureBox4;
        private Button btnLogout;
        private PictureBox pictureBox1;
        private Button btnOrder;
        private Label label4;
        private Label label5;
        private Label label6;
        private ComboBox cmbCategory;
        private Label label7;
        private Label label8;
        private Label label2;
    }
}