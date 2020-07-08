namespace WindowsFormsApplication1
{
    partial class PurchaseMaster
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
            this.lblProductName = new System.Windows.Forms.Label();
            this.lblProductQty = new System.Windows.Forms.Label();
            this.lblProductPrice = new System.Windows.Forms.Label();
            this.lblProductTotal = new System.Windows.Forms.Label();
            this.lblPurchaseDate = new System.Windows.Forms.Label();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.lblPurchaseType = new System.Windows.Forms.Label();
            this.lblExpiryDate = new System.Windows.Forms.Label();
            this.lblProfit = new System.Windows.Forms.Label();
            this.Product_NamecomboBox = new System.Windows.Forms.ComboBox();
            this.txtProductQty = new System.Windows.Forms.TextBox();
            this.lblUnit = new System.Windows.Forms.Label();
            this.txtProductPrice = new System.Windows.Forms.TextBox();
            this.txtProductTotal = new System.Windows.Forms.TextBox();
            this.PurchasedateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Dealer_NamecomboBox = new System.Windows.Forms.ComboBox();
            this.Purchase_TypecomboBox = new System.Windows.Forms.ComboBox();
            this.ExpirydateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.txtProfit = new System.Windows.Forms.TextBox();
            this.btnPurchaseItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(32, 31);
            this.lblProductName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(146, 20);
            this.lblProductName.TabIndex = 0;
            this.lblProductName.Text = "Product Name : ";
            this.lblProductName.Click += new System.EventHandler(this.lblProductName_Click);
            // 
            // lblProductQty
            // 
            this.lblProductQty.AutoSize = true;
            this.lblProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductQty.Location = new System.Drawing.Point(32, 73);
            this.lblProductQty.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductQty.Name = "lblProductQty";
            this.lblProductQty.Size = new System.Drawing.Size(168, 20);
            this.lblProductQty.TabIndex = 1;
            this.lblProductQty.Text = "Product Quantity : ";
            this.lblProductQty.Click += new System.EventHandler(this.lblProductQty_Click);
            // 
            // lblProductPrice
            // 
            this.lblProductPrice.AutoSize = true;
            this.lblProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductPrice.Location = new System.Drawing.Point(32, 116);
            this.lblProductPrice.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductPrice.Name = "lblProductPrice";
            this.lblProductPrice.Size = new System.Drawing.Size(142, 20);
            this.lblProductPrice.TabIndex = 2;
            this.lblProductPrice.Text = "Product Price : ";
            this.lblProductPrice.Click += new System.EventHandler(this.lblProductPrice_Click);
            // 
            // lblProductTotal
            // 
            this.lblProductTotal.AutoSize = true;
            this.lblProductTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductTotal.Location = new System.Drawing.Point(32, 158);
            this.lblProductTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProductTotal.Name = "lblProductTotal";
            this.lblProductTotal.Size = new System.Drawing.Size(140, 20);
            this.lblProductTotal.TabIndex = 3;
            this.lblProductTotal.Text = "Product Total : ";
            this.lblProductTotal.Click += new System.EventHandler(this.lblProductTotal_Click);
            // 
            // lblPurchaseDate
            // 
            this.lblPurchaseDate.AutoSize = true;
            this.lblPurchaseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseDate.Location = new System.Drawing.Point(32, 200);
            this.lblPurchaseDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseDate.Name = "lblPurchaseDate";
            this.lblPurchaseDate.Size = new System.Drawing.Size(152, 20);
            this.lblPurchaseDate.TabIndex = 4;
            this.lblPurchaseDate.Text = "Purchase Date : ";
            this.lblPurchaseDate.Click += new System.EventHandler(this.lblPurchaseDate_Click);
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerName.Location = new System.Drawing.Point(32, 241);
            this.lblDealerName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(137, 20);
            this.lblDealerName.TabIndex = 5;
            this.lblDealerName.Text = "Dealer Name : ";
            this.lblDealerName.Click += new System.EventHandler(this.lblDealerName_Click);
            // 
            // lblPurchaseType
            // 
            this.lblPurchaseType.AutoSize = true;
            this.lblPurchaseType.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPurchaseType.Location = new System.Drawing.Point(32, 285);
            this.lblPurchaseType.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPurchaseType.Name = "lblPurchaseType";
            this.lblPurchaseType.Size = new System.Drawing.Size(152, 20);
            this.lblPurchaseType.TabIndex = 6;
            this.lblPurchaseType.Text = "Purchase Type : ";
            this.lblPurchaseType.Click += new System.EventHandler(this.lblPurchaseType_Click);
            // 
            // lblExpiryDate
            // 
            this.lblExpiryDate.AutoSize = true;
            this.lblExpiryDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpiryDate.Location = new System.Drawing.Point(32, 330);
            this.lblExpiryDate.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpiryDate.Name = "lblExpiryDate";
            this.lblExpiryDate.Size = new System.Drawing.Size(125, 20);
            this.lblExpiryDate.TabIndex = 7;
            this.lblExpiryDate.Text = "Expiry Date : ";
            this.lblExpiryDate.Click += new System.EventHandler(this.lblExpiryDate_Click);
            // 
            // lblProfit
            // 
            this.lblProfit.AutoSize = true;
            this.lblProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfit.Location = new System.Drawing.Point(32, 374);
            this.lblProfit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblProfit.Name = "lblProfit";
            this.lblProfit.Size = new System.Drawing.Size(95, 20);
            this.lblProfit.TabIndex = 8;
            this.lblProfit.Text = "Profit % : ";
            this.lblProfit.Click += new System.EventHandler(this.lblProfit_Click);
            // 
            // Product_NamecomboBox
            // 
            this.Product_NamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Product_NamecomboBox.FormattingEnabled = true;
            this.Product_NamecomboBox.Location = new System.Drawing.Point(240, 28);
            this.Product_NamecomboBox.Name = "Product_NamecomboBox";
            this.Product_NamecomboBox.Size = new System.Drawing.Size(200, 28);
            this.Product_NamecomboBox.TabIndex = 9;
            this.Product_NamecomboBox.SelectedIndexChanged += new System.EventHandler(this.Product_NamecomboBox_SelectedIndexChanged);
            // 
            // txtProductQty
            // 
            this.txtProductQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductQty.Location = new System.Drawing.Point(240, 73);
            this.txtProductQty.Name = "txtProductQty";
            this.txtProductQty.Size = new System.Drawing.Size(200, 26);
            this.txtProductQty.TabIndex = 10;
            // 
            // lblUnit
            // 
            this.lblUnit.AutoSize = true;
            this.lblUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUnit.Location = new System.Drawing.Point(447, 79);
            this.lblUnit.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUnit.Name = "lblUnit";
            this.lblUnit.Size = new System.Drawing.Size(56, 20);
            this.lblUnit.TabIndex = 11;
            this.lblUnit.Text = "units ";
            // 
            // txtProductPrice
            // 
            this.txtProductPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductPrice.Location = new System.Drawing.Point(240, 116);
            this.txtProductPrice.Name = "txtProductPrice";
            this.txtProductPrice.Size = new System.Drawing.Size(200, 26);
            this.txtProductPrice.TabIndex = 12;
            this.txtProductPrice.Leave += new System.EventHandler(this.txtProductPrice_Leave);
            // 
            // txtProductTotal
            // 
            this.txtProductTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProductTotal.Location = new System.Drawing.Point(240, 158);
            this.txtProductTotal.Name = "txtProductTotal";
            this.txtProductTotal.Size = new System.Drawing.Size(200, 26);
            this.txtProductTotal.TabIndex = 13;
            // 
            // PurchasedateTimePicker
            // 
            this.PurchasedateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PurchasedateTimePicker.Location = new System.Drawing.Point(240, 200);
            this.PurchasedateTimePicker.Name = "PurchasedateTimePicker";
            this.PurchasedateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.PurchasedateTimePicker.TabIndex = 14;
            // 
            // Dealer_NamecomboBox
            // 
            this.Dealer_NamecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dealer_NamecomboBox.FormattingEnabled = true;
            this.Dealer_NamecomboBox.Location = new System.Drawing.Point(240, 241);
            this.Dealer_NamecomboBox.Name = "Dealer_NamecomboBox";
            this.Dealer_NamecomboBox.Size = new System.Drawing.Size(200, 28);
            this.Dealer_NamecomboBox.TabIndex = 15;
            // 
            // Purchase_TypecomboBox
            // 
            this.Purchase_TypecomboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Purchase_TypecomboBox.FormattingEnabled = true;
            this.Purchase_TypecomboBox.Items.AddRange(new object[] {
            "CASH",
            "DEBIT"});
            this.Purchase_TypecomboBox.Location = new System.Drawing.Point(240, 285);
            this.Purchase_TypecomboBox.Name = "Purchase_TypecomboBox";
            this.Purchase_TypecomboBox.Size = new System.Drawing.Size(200, 28);
            this.Purchase_TypecomboBox.TabIndex = 16;
            // 
            // ExpirydateTimePicker
            // 
            this.ExpirydateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExpirydateTimePicker.Location = new System.Drawing.Point(240, 330);
            this.ExpirydateTimePicker.Name = "ExpirydateTimePicker";
            this.ExpirydateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.ExpirydateTimePicker.TabIndex = 17;
            // 
            // txtProfit
            // 
            this.txtProfit.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtProfit.Location = new System.Drawing.Point(240, 374);
            this.txtProfit.Name = "txtProfit";
            this.txtProfit.Size = new System.Drawing.Size(200, 26);
            this.txtProfit.TabIndex = 18;
            // 
            // btnPurchaseItem
            // 
            this.btnPurchaseItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPurchaseItem.Location = new System.Drawing.Point(240, 424);
            this.btnPurchaseItem.Name = "btnPurchaseItem";
            this.btnPurchaseItem.Size = new System.Drawing.Size(125, 33);
            this.btnPurchaseItem.TabIndex = 19;
            this.btnPurchaseItem.Text = "Purchase Item";
            this.btnPurchaseItem.UseVisualStyleBackColor = true;
            this.btnPurchaseItem.Click += new System.EventHandler(this.btnPurchaseItem_Click);
            // 
            // PurchaseMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1536, 682);
            this.Controls.Add(this.btnPurchaseItem);
            this.Controls.Add(this.txtProfit);
            this.Controls.Add(this.ExpirydateTimePicker);
            this.Controls.Add(this.Purchase_TypecomboBox);
            this.Controls.Add(this.Dealer_NamecomboBox);
            this.Controls.Add(this.PurchasedateTimePicker);
            this.Controls.Add(this.txtProductTotal);
            this.Controls.Add(this.txtProductPrice);
            this.Controls.Add(this.lblUnit);
            this.Controls.Add(this.txtProductQty);
            this.Controls.Add(this.Product_NamecomboBox);
            this.Controls.Add(this.lblProfit);
            this.Controls.Add(this.lblExpiryDate);
            this.Controls.Add(this.lblPurchaseType);
            this.Controls.Add(this.lblDealerName);
            this.Controls.Add(this.lblPurchaseDate);
            this.Controls.Add(this.lblProductTotal);
            this.Controls.Add(this.lblProductPrice);
            this.Controls.Add(this.lblProductQty);
            this.Controls.Add(this.lblProductName);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PurchaseMaster";
            this.Text = "PurchaseMaster";
            this.Load += new System.EventHandler(this.PurchaseMaster_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Label lblProductQty;
        private System.Windows.Forms.Label lblProductPrice;
        private System.Windows.Forms.Label lblProductTotal;
        private System.Windows.Forms.Label lblPurchaseDate;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.Label lblPurchaseType;
        private System.Windows.Forms.Label lblExpiryDate;
        private System.Windows.Forms.Label lblProfit;
        private System.Windows.Forms.ComboBox Product_NamecomboBox;
        private System.Windows.Forms.TextBox txtProductQty;
        private System.Windows.Forms.Label lblUnit;
        private System.Windows.Forms.TextBox txtProductPrice;
        private System.Windows.Forms.TextBox txtProductTotal;
        private System.Windows.Forms.DateTimePicker PurchasedateTimePicker;
        private System.Windows.Forms.ComboBox Dealer_NamecomboBox;
        private System.Windows.Forms.ComboBox Purchase_TypecomboBox;
        private System.Windows.Forms.DateTimePicker ExpirydateTimePicker;
        private System.Windows.Forms.TextBox txtProfit;
        private System.Windows.Forms.Button btnPurchaseItem;
    }
}