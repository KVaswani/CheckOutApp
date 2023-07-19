namespace CheckOutApp
{
    partial class Checkout
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
            panel1 = new Panel();
            lblTotalValue = new Label();
            lblDiscountValue = new Label();
            lblSubTotalValue = new Label();
            lblTotal = new Label();
            lblDiscount = new Label();
            lblSubTotal = new Label();
            dgvShoppingCart = new DataGridView();
            btnItemA = new Button();
            btnItemB = new Button();
            btnItemC = new Button();
            btnItemD = new Button();
            btnReset = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(lblTotalValue);
            panel1.Controls.Add(lblDiscountValue);
            panel1.Controls.Add(lblSubTotalValue);
            panel1.Controls.Add(lblTotal);
            panel1.Controls.Add(lblDiscount);
            panel1.Controls.Add(lblSubTotal);
            panel1.Controls.Add(dgvShoppingCart);
            panel1.Location = new Point(64, 32);
            panel1.Name = "panel1";
            panel1.Size = new Size(320, 376);
            panel1.TabIndex = 0;
            // 
            // lblTotalValue
            // 
            lblTotalValue.AutoSize = true;
            lblTotalValue.Location = new Point(202, 323);
            lblTotalValue.Name = "lblTotalValue";
            lblTotalValue.Size = new Size(17, 20);
            lblTotalValue.TabIndex = 6;
            lblTotalValue.Text = "0";
            // 
            // lblDiscountValue
            // 
            lblDiscountValue.AutoSize = true;
            lblDiscountValue.Location = new Point(202, 286);
            lblDiscountValue.Name = "lblDiscountValue";
            lblDiscountValue.Size = new Size(17, 20);
            lblDiscountValue.TabIndex = 5;
            lblDiscountValue.Text = "0";
            // 
            // lblSubTotalValue
            // 
            lblSubTotalValue.AutoSize = true;
            lblSubTotalValue.Location = new Point(202, 251);
            lblSubTotalValue.Name = "lblSubTotalValue";
            lblSubTotalValue.Size = new Size(17, 20);
            lblSubTotalValue.TabIndex = 4;
            lblSubTotalValue.Text = "0";
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(7, 323);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(42, 20);
            lblTotal.TabIndex = 3;
            lblTotal.Text = "Total";
            // 
            // lblDiscount
            // 
            lblDiscount.AutoSize = true;
            lblDiscount.Location = new Point(7, 286);
            lblDiscount.Name = "lblDiscount";
            lblDiscount.Size = new Size(67, 20);
            lblDiscount.TabIndex = 2;
            lblDiscount.Text = "Discount";
            // 
            // lblSubTotal
            // 
            lblSubTotal.AutoSize = true;
            lblSubTotal.Location = new Point(7, 255);
            lblSubTotal.Name = "lblSubTotal";
            lblSubTotal.Size = new Size(71, 20);
            lblSubTotal.TabIndex = 1;
            lblSubTotal.Text = "Sub Total";
            // 
            // dgvShoppingCart
            // 
            dgvShoppingCart.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvShoppingCart.Location = new Point(3, 0);
            dgvShoppingCart.Name = "dgvShoppingCart";
            dgvShoppingCart.RowHeadersWidth = 51;
            dgvShoppingCart.RowTemplate.Height = 29;
            dgvShoppingCart.Size = new Size(300, 220);
            dgvShoppingCart.TabIndex = 0;
            // 
            // btnItemA
            // 
            btnItemA.Location = new Point(424, 32);
            btnItemA.Name = "btnItemA";
            btnItemA.Size = new Size(151, 90);
            btnItemA.TabIndex = 1;
            btnItemA.Text = "Item A Buy 1@ $50 Offer Buy 3 @ $130";
            btnItemA.UseVisualStyleBackColor = true;
            btnItemA.Click += btnItemA_Click;
            // 
            // btnItemB
            // 
            btnItemB.Location = new Point(638, 32);
            btnItemB.Name = "btnItemB";
            btnItemB.Size = new Size(127, 90);
            btnItemB.TabIndex = 2;
            btnItemB.Text = "Item B Buy 1@30 Offer Buy 2@45";
            btnItemB.UseVisualStyleBackColor = true;
            btnItemB.Click += btnItemB_Click;
            // 
            // btnItemC
            // 
            btnItemC.Location = new Point(424, 166);
            btnItemC.Name = "btnItemC";
            btnItemC.Size = new Size(151, 86);
            btnItemC.TabIndex = 3;
            btnItemC.Text = "Item C Buy @20";
            btnItemC.UseVisualStyleBackColor = true;
            btnItemC.Click += btnItemC_Click;
            // 
            // btnItemD
            // 
            btnItemD.Location = new Point(638, 166);
            btnItemD.Name = "btnItemD";
            btnItemD.Size = new Size(127, 86);
            btnItemD.TabIndex = 4;
            btnItemD.Text = "Item D Buy @15";
            btnItemD.UseVisualStyleBackColor = true;
            btnItemD.Click += btnItemD_Click;
            // 
            // btnReset
            // 
            btnReset.Location = new Point(561, 287);
            btnReset.Name = "btnReset";
            btnReset.Size = new Size(94, 29);
            btnReset.TabIndex = 5;
            btnReset.Text = "Reset";
            btnReset.UseVisualStyleBackColor = true;
            btnReset.Click += btnReset_Click;
            // 
            // Checkout
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnReset);
            Controls.Add(btnItemD);
            Controls.Add(btnItemC);
            Controls.Add(btnItemB);
            Controls.Add(btnItemA);
            Controls.Add(panel1);
            Name = "Checkout";
            Text = "CheckOut";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvShoppingCart).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private DataGridView dgvShoppingCart;
        private Button btnItemA;
        private Button btnItemB;
        private Button btnItemC;
        private Button btnItemD;
        private Button btnReset;
        private Label lblSubTotalValue;
        private Label lblTotal;
        private Label lblDiscount;
        private Label lblSubTotal;
        private Label lblTotalValue;
        private Label lblDiscountValue;
    }
}