namespace WindowsFormsApplication1
{
    partial class AddProductName
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
            this.btnInsert = new System.Windows.Forms.Button();
            this.txtProductName = new System.Windows.Forms.TextBox();
            this.comboBoxSelectUnit = new System.Windows.Forms.ComboBox();
            this.lblSelectUnit = new System.Windows.Forms.Label();
            this.lblProductName = new System.Windows.Forms.Label();
            this.productGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtUpdateProductName = new System.Windows.Forms.TextBox();
            this.lblUpdateProductName = new System.Windows.Forms.Label();
            this.comboBoxUpdateSelectedUnit = new System.Windows.Forms.ComboBox();
            this.lblUpdateSelectedUnit = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnInsert);
            this.panel1.Controls.Add(this.txtProductName);
            this.panel1.Controls.Add(this.comboBoxSelectUnit);
            this.panel1.Controls.Add(this.lblSelectUnit);
            this.panel1.Controls.Add(this.lblProductName);
            this.panel1.Location = new System.Drawing.Point(12, 36);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1092, 100);
            this.panel1.TabIndex = 0;
            // 
            // btnInsert
            // 
            this.btnInsert.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.Location = new System.Drawing.Point(787, 31);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(100, 31);
            this.btnInsert.TabIndex = 6;
            this.btnInsert.Text = "Insert";
            this.btnInsert.UseVisualStyleBackColor = true;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // txtProductName
            // 
            this.txtProductName.Location = new System.Drawing.Point(208, 32);
            this.txtProductName.Name = "txtProductName";
            this.txtProductName.Size = new System.Drawing.Size(185, 22);
            this.txtProductName.TabIndex = 5;
            // 
            // comboBoxSelectUnit
            // 
            this.comboBoxSelectUnit.DropDownHeight = 120;
            this.comboBoxSelectUnit.FormattingEnabled = true;
            this.comboBoxSelectUnit.IntegralHeight = false;
            this.comboBoxSelectUnit.Location = new System.Drawing.Point(538, 33);
            this.comboBoxSelectUnit.Name = "comboBoxSelectUnit";
            this.comboBoxSelectUnit.Size = new System.Drawing.Size(181, 24);
            this.comboBoxSelectUnit.TabIndex = 3;
            // 
            // lblSelectUnit
            // 
            this.lblSelectUnit.AutoSize = true;
            this.lblSelectUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectUnit.Location = new System.Drawing.Point(410, 32);
            this.lblSelectUnit.Name = "lblSelectUnit";
            this.lblSelectUnit.Size = new System.Drawing.Size(122, 25);
            this.lblSelectUnit.TabIndex = 4;
            this.lblSelectUnit.Text = "Select Unit : ";
            // 
            // lblProductName
            // 
            this.lblProductName.AutoSize = true;
            this.lblProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProductName.Location = new System.Drawing.Point(3, 29);
            this.lblProductName.Name = "lblProductName";
            this.lblProductName.Size = new System.Drawing.Size(203, 25);
            this.lblProductName.TabIndex = 2;
            this.lblProductName.Text = "Enter Product Name : ";
            this.lblProductName.Click += new System.EventHandler(this.lblUserName_Click);
            // 
            // productGridView
            // 
            this.productGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.productGridView.Location = new System.Drawing.Point(550, 169);
            this.productGridView.Name = "productGridView";
            this.productGridView.RowTemplate.Height = 24;
            this.productGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.productGridView.Size = new System.Drawing.Size(554, 375);
            this.productGridView.TabIndex = 1;
            this.productGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.productGridView_CellClick);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnUpdate);
            this.panel2.Controls.Add(this.comboBoxUpdateSelectedUnit);
            this.panel2.Controls.Add(this.lblUpdateSelectedUnit);
            this.panel2.Controls.Add(this.txtUpdateProductName);
            this.panel2.Controls.Add(this.lblUpdateProductName);
            this.panel2.Location = new System.Drawing.Point(12, 169);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(505, 375);
            this.panel2.TabIndex = 2;
            this.panel2.Visible = false;
            // 
            // txtUpdateProductName
            // 
            this.txtUpdateProductName.Location = new System.Drawing.Point(224, 55);
            this.txtUpdateProductName.Name = "txtUpdateProductName";
            this.txtUpdateProductName.Size = new System.Drawing.Size(185, 22);
            this.txtUpdateProductName.TabIndex = 8;
            // 
            // lblUpdateProductName
            // 
            this.lblUpdateProductName.AutoSize = true;
            this.lblUpdateProductName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateProductName.Location = new System.Drawing.Point(15, 52);
            this.lblUpdateProductName.Name = "lblUpdateProductName";
            this.lblUpdateProductName.Size = new System.Drawing.Size(203, 25);
            this.lblUpdateProductName.TabIndex = 7;
            this.lblUpdateProductName.Text = "Enter Product Name : ";
            // 
            // comboBoxUpdateSelectedUnit
            // 
            this.comboBoxUpdateSelectedUnit.DropDownHeight = 120;
            this.comboBoxUpdateSelectedUnit.FormattingEnabled = true;
            this.comboBoxUpdateSelectedUnit.IntegralHeight = false;
            this.comboBoxUpdateSelectedUnit.Location = new System.Drawing.Point(224, 125);
            this.comboBoxUpdateSelectedUnit.Name = "comboBoxUpdateSelectedUnit";
            this.comboBoxUpdateSelectedUnit.Size = new System.Drawing.Size(181, 24);
            this.comboBoxUpdateSelectedUnit.TabIndex = 7;
            // 
            // lblUpdateSelectedUnit
            // 
            this.lblUpdateSelectedUnit.AutoSize = true;
            this.lblUpdateSelectedUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUpdateSelectedUnit.Location = new System.Drawing.Point(15, 124);
            this.lblUpdateSelectedUnit.Name = "lblUpdateSelectedUnit";
            this.lblUpdateSelectedUnit.Size = new System.Drawing.Size(122, 25);
            this.lblUpdateSelectedUnit.TabIndex = 8;
            this.lblUpdateSelectedUnit.Text = "Select Unit : ";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(224, 188);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(100, 31);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // AddProductName
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1116, 670);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.productGridView);
            this.Controls.Add(this.panel1);
            this.Name = "AddProductName";
            this.Text = "AddProductName";
            this.Load += new System.EventHandler(this.AddProductName_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.productGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblProductName;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.TextBox txtProductName;
        private System.Windows.Forms.ComboBox comboBoxSelectUnit;
        private System.Windows.Forms.Label lblSelectUnit;
        private System.Windows.Forms.DataGridView productGridView;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.ComboBox comboBoxUpdateSelectedUnit;
        private System.Windows.Forms.Label lblUpdateSelectedUnit;
        private System.Windows.Forms.TextBox txtUpdateProductName;
        private System.Windows.Forms.Label lblUpdateProductName;
    }
}