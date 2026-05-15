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
            label2 = new Label();
            lblPrice = new Label();
            lblTotal = new Label();
            btnPurchase = new Button();
            ((System.ComponentModel.ISupportInitialize)nudQty).BeginInit();
            SuspendLayout();
            // 
            // txtFullname
            // 
            txtFullname.Location = new Point(224, 60);
            txtFullname.Name = "txtFullname";
            txtFullname.Size = new Size(224, 27);
            txtFullname.TabIndex = 0;
            // 
            // cmbEquipment
            // 
            cmbEquipment.FormattingEnabled = true;
            cmbEquipment.Location = new Point(224, 133);
            cmbEquipment.Name = "cmbEquipment";
            cmbEquipment.Size = new Size(224, 28);
            cmbEquipment.TabIndex = 1;
            // 
            // nudQty
            // 
            nudQty.Location = new Point(225, 208);
            nudQty.Name = "nudQty";
            nudQty.Size = new Size(223, 27);
            nudQty.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(224, 273);
            label1.Name = "label1";
            label1.Size = new Size(44, 20);
            label1.TabIndex = 3;
            label1.Text = "Price:";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(225, 311);
            label2.Name = "label2";
            label2.Size = new Size(45, 20);
            label2.TabIndex = 4;
            label2.Text = "Total:";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(293, 273);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(41, 20);
            lblPrice.TabIndex = 5;
            lblPrice.Text = "Price";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(293, 311);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 6;
            lblTotal.Text = "Total";
            // 
            // btnPurchase
            // 
            btnPurchase.Location = new Point(276, 368);
            btnPurchase.Name = "btnPurchase";
            btnPurchase.Size = new Size(138, 33);
            btnPurchase.TabIndex = 7;
            btnPurchase.Text = "PURCHASE";
            btnPurchase.UseVisualStyleBackColor = true;
            btnPurchase.Click += btnPurchase_Click;
            // 
            // items
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnPurchase);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(nudQty);
            Controls.Add(cmbEquipment);
            Controls.Add(txtFullname);
            Name = "items";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "items";
            ((System.ComponentModel.ISupportInitialize)nudQty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtFullname;
        private ComboBox cmbEquipment;
        private NumericUpDown nudQty;
        private Label label1;
        private Label label2;
        private Label lblPrice;
        private Label lblTotal;
        private Button btnPurchase;
    }
}