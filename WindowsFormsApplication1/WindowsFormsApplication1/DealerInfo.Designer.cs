namespace WindowsFormsApplication1
{
    partial class DealerInfo
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.InsertDealerInfo = new System.Windows.Forms.Button();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.lblAddress = new System.Windows.Forms.Label();
            this.txtDealerContact = new System.Windows.Forms.TextBox();
            this.lblDealerContact = new System.Windows.Forms.Label();
            this.txtCompanyName = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.txtDealerName = new System.Windows.Forms.TextBox();
            this.lblDealerName = new System.Windows.Forms.Label();
            this.dealer_infoGridView = new System.Windows.Forms.DataGridView();
            this.lblheading = new System.Windows.Forms.Label();
            this.btnDeleteDealerInfo = new System.Windows.Forms.Button();
            this.btnUpdateDealerInfo = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_infoGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.InsertDealerInfo);
            this.panel1.Controls.Add(this.txtCity);
            this.panel1.Controls.Add(this.lblCity);
            this.panel1.Controls.Add(this.txtAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.txtDealerContact);
            this.panel1.Controls.Add(this.lblDealerContact);
            this.panel1.Controls.Add(this.txtCompanyName);
            this.panel1.Controls.Add(this.lblCompanyName);
            this.panel1.Controls.Add(this.txtDealerName);
            this.panel1.Controls.Add(this.lblDealerName);
            this.panel1.Location = new System.Drawing.Point(13, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(480, 366);
            this.panel1.TabIndex = 1;
            // 
            // InsertDealerInfo
            // 
            this.InsertDealerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.InsertDealerInfo.Location = new System.Drawing.Point(184, 296);
            this.InsertDealerInfo.Name = "InsertDealerInfo";
            this.InsertDealerInfo.Size = new System.Drawing.Size(212, 40);
            this.InsertDealerInfo.TabIndex = 22;
            this.InsertDealerInfo.Text = "Insert Dealer Info";
            this.InsertDealerInfo.UseVisualStyleBackColor = true;
            this.InsertDealerInfo.Click += new System.EventHandler(this.InsertDealerInfo_Click);
            // 
            // txtCity
            // 
            this.txtCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCity.Location = new System.Drawing.Point(184, 244);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(245, 30);
            this.txtCity.TabIndex = 19;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCity.Location = new System.Drawing.Point(7, 247);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(62, 25);
            this.lblCity.TabIndex = 18;
            this.lblCity.Text = "City : ";
            // 
            // txtAddress
            // 
            this.txtAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(184, 190);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(245, 30);
            this.txtAddress.TabIndex = 17;
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddress.Location = new System.Drawing.Point(8, 193);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(101, 25);
            this.lblAddress.TabIndex = 16;
            this.lblAddress.Text = "Address : ";
            // 
            // txtDealerContact
            // 
            this.txtDealerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerContact.Location = new System.Drawing.Point(184, 131);
            this.txtDealerContact.Name = "txtDealerContact";
            this.txtDealerContact.Size = new System.Drawing.Size(245, 30);
            this.txtDealerContact.TabIndex = 15;
            // 
            // lblDealerContact
            // 
            this.lblDealerContact.AutoSize = true;
            this.lblDealerContact.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerContact.Location = new System.Drawing.Point(8, 134);
            this.lblDealerContact.Name = "lblDealerContact";
            this.lblDealerContact.Size = new System.Drawing.Size(96, 25);
            this.lblDealerContact.TabIndex = 14;
            this.lblDealerContact.Text = "Contact : ";
            // 
            // txtCompanyName
            // 
            this.txtCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCompanyName.Location = new System.Drawing.Point(184, 71);
            this.txtCompanyName.Name = "txtCompanyName";
            this.txtCompanyName.Size = new System.Drawing.Size(245, 30);
            this.txtCompanyName.TabIndex = 13;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCompanyName.Location = new System.Drawing.Point(8, 74);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(170, 25);
            this.lblCompanyName.TabIndex = 12;
            this.lblCompanyName.Text = "Company Name : ";
            // 
            // txtDealerName
            // 
            this.txtDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDealerName.Location = new System.Drawing.Point(184, 14);
            this.txtDealerName.Name = "txtDealerName";
            this.txtDealerName.Size = new System.Drawing.Size(245, 30);
            this.txtDealerName.TabIndex = 3;
            // 
            // lblDealerName
            // 
            this.lblDealerName.AutoSize = true;
            this.lblDealerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDealerName.Location = new System.Drawing.Point(8, 15);
            this.lblDealerName.Name = "lblDealerName";
            this.lblDealerName.Size = new System.Drawing.Size(142, 25);
            this.lblDealerName.TabIndex = 2;
            this.lblDealerName.Text = "Dealer Name : ";
            // 
            // dealer_infoGridView
            // 
            this.dealer_infoGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dealer_infoGridView.Location = new System.Drawing.Point(532, 81);
            this.dealer_infoGridView.Name = "dealer_infoGridView";
            this.dealer_infoGridView.RowTemplate.Height = 24;
            this.dealer_infoGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dealer_infoGridView.Size = new System.Drawing.Size(561, 366);
            this.dealer_infoGridView.TabIndex = 8;
            this.dealer_infoGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dealer_infoGridView_CellClick);
            this.dealer_infoGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dealer_infoGridView_CellContentClick);
            // 
            // lblheading
            // 
            this.lblheading.AutoSize = true;
            this.lblheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblheading.Location = new System.Drawing.Point(390, 19);
            this.lblheading.Name = "lblheading";
            this.lblheading.Size = new System.Drawing.Size(311, 46);
            this.lblheading.TabIndex = 9;
            this.lblheading.Text = "Add Dealer Info";
            // 
            // btnDeleteDealerInfo
            // 
            this.btnDeleteDealerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDealerInfo.Location = new System.Drawing.Point(532, 472);
            this.btnDeleteDealerInfo.Name = "btnDeleteDealerInfo";
            this.btnDeleteDealerInfo.Size = new System.Drawing.Size(212, 40);
            this.btnDeleteDealerInfo.TabIndex = 23;
            this.btnDeleteDealerInfo.Text = "Delete Dealer Info";
            this.btnDeleteDealerInfo.UseVisualStyleBackColor = true;
            this.btnDeleteDealerInfo.Click += new System.EventHandler(this.btnDeleteDealerInfo_Click);
            // 
            // btnUpdateDealerInfo
            // 
            this.btnUpdateDealerInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateDealerInfo.Location = new System.Drawing.Point(881, 472);
            this.btnUpdateDealerInfo.Name = "btnUpdateDealerInfo";
            this.btnUpdateDealerInfo.Size = new System.Drawing.Size(212, 40);
            this.btnUpdateDealerInfo.TabIndex = 24;
            this.btnUpdateDealerInfo.Text = "Update Dealer Info";
            this.btnUpdateDealerInfo.UseVisualStyleBackColor = true;
            this.btnUpdateDealerInfo.Click += new System.EventHandler(this.btnUpdateDealerInfo_Click);
            // 
            // DealerInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1119, 543);
            this.Controls.Add(this.btnUpdateDealerInfo);
            this.Controls.Add(this.btnDeleteDealerInfo);
            this.Controls.Add(this.lblheading);
            this.Controls.Add(this.dealer_infoGridView);
            this.Controls.Add(this.panel1);
            this.Name = "DealerInfo";
            this.Text = "DealerInfo";
            this.Load += new System.EventHandler(this.DealerInfo_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dealer_infoGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button InsertDealerInfo;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label lblCity;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.TextBox txtDealerContact;
        private System.Windows.Forms.Label lblDealerContact;
        private System.Windows.Forms.TextBox txtCompanyName;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox txtDealerName;
        private System.Windows.Forms.Label lblDealerName;
        private System.Windows.Forms.DataGridView dealer_infoGridView;
        private System.Windows.Forms.Label lblheading;
        private System.Windows.Forms.Button btnDeleteDealerInfo;
        private System.Windows.Forms.Button btnUpdateDealerInfo;
    }
}