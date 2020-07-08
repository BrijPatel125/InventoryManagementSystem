namespace WindowsFormsApplication1
{
    partial class Unit
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
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.lblAddUnit = new System.Windows.Forms.Label();
            this.btnAddUnit = new System.Windows.Forms.Button();
            this.unitGridView = new System.Windows.Forms.DataGridView();
            this.btndelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.unitGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // txtUnit
            // 
            this.txtUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUnit.Location = new System.Drawing.Point(125, 115);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(232, 30);
            this.txtUnit.TabIndex = 3;
            // 
            // lblAddUnit
            // 
            this.lblAddUnit.AutoSize = true;
            this.lblAddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddUnit.Location = new System.Drawing.Point(5, 115);
            this.lblAddUnit.Name = "lblAddUnit";
            this.lblAddUnit.Size = new System.Drawing.Size(114, 25);
            this.lblAddUnit.TabIndex = 2;
            this.lblAddUnit.Text = "Add Unit : ";
            // 
            // btnAddUnit
            // 
            this.btnAddUnit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddUnit.Location = new System.Drawing.Point(125, 169);
            this.btnAddUnit.Name = "btnAddUnit";
            this.btnAddUnit.Size = new System.Drawing.Size(108, 38);
            this.btnAddUnit.TabIndex = 5;
            this.btnAddUnit.Text = "Add Unit";
            this.btnAddUnit.UseVisualStyleBackColor = true;
            this.btnAddUnit.Click += new System.EventHandler(this.btnAddUnit_Click);
            // 
            // unitGridView
            // 
            this.unitGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.unitGridView.Location = new System.Drawing.Point(409, 115);
            this.unitGridView.Name = "unitGridView";
            this.unitGridView.RowTemplate.Height = 24;
            this.unitGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.unitGridView.Size = new System.Drawing.Size(583, 251);
            this.unitGridView.TabIndex = 8;
            // 
            // btndelete
            // 
            this.btndelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btndelete.Location = new System.Drawing.Point(409, 385);
            this.btndelete.Name = "btndelete";
            this.btndelete.Size = new System.Drawing.Size(233, 38);
            this.btndelete.TabIndex = 9;
            this.btndelete.Text = "Delete Selected Unit";
            this.btndelete.UseVisualStyleBackColor = true;
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // Unit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(1117, 672);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.unitGridView);
            this.Controls.Add(this.btnAddUnit);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.lblAddUnit);
            this.Name = "Unit";
            this.Text = "Unit";
            this.Load += new System.EventHandler(this.Unit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.unitGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.Label lblAddUnit;
        private System.Windows.Forms.Button btnAddUnit;
        private System.Windows.Forms.DataGridView unitGridView;
        private System.Windows.Forms.Button btndelete;
    }
}