namespace prisoner_try_2.PAL.Prisoner
{
    partial class viewPrisoners
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnshowall = new System.Windows.Forms.Button();
            this.btnSearchPrisoner = new System.Windows.Forms.Button();
            this.txtSearchID = new System.Windows.Forms.TextBox();
            this.lblID = new System.Windows.Forms.Label();
            this.grdPrisoner = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdPrisoner)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumBlue;
            this.label1.Location = new System.Drawing.Point(253, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(253, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "View all Prisoners Data";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DarkBlue;
            this.label2.Location = new System.Drawing.Point(476, 87);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(228, 28);
            this.label2.TabIndex = 11;
            this.label2.Text = "To Show all Prisoner";
            // 
            // btnshowall
            // 
            this.btnshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.ForeColor = System.Drawing.Color.Blue;
            this.btnshowall.Location = new System.Drawing.Point(481, 132);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(256, 31);
            this.btnshowall.TabIndex = 10;
            this.btnshowall.Text = "Show all Data";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // btnSearchPrisoner
            // 
            this.btnSearchPrisoner.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchPrisoner.ForeColor = System.Drawing.Color.Blue;
            this.btnSearchPrisoner.Location = new System.Drawing.Point(40, 128);
            this.btnSearchPrisoner.Name = "btnSearchPrisoner";
            this.btnSearchPrisoner.Size = new System.Drawing.Size(264, 31);
            this.btnSearchPrisoner.TabIndex = 9;
            this.btnSearchPrisoner.Text = "Search ";
            this.btnSearchPrisoner.UseVisualStyleBackColor = true;
            this.btnSearchPrisoner.Click += new System.EventHandler(this.btnsrchgaurd_Click);
            // 
            // txtSearchID
            // 
            this.txtSearchID.Location = new System.Drawing.Point(204, 87);
            this.txtSearchID.Name = "txtSearchID";
            this.txtSearchID.Size = new System.Drawing.Size(100, 20);
            this.txtSearchID.TabIndex = 8;
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(36, 87);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(159, 24);
            this.lblID.TabIndex = 7;
            this.lblID.Text = "Enter ID to search";
            // 
            // grdPrisoner
            // 
            this.grdPrisoner.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdPrisoner.Location = new System.Drawing.Point(30, 187);
            this.grdPrisoner.Name = "grdPrisoner";
            this.grdPrisoner.Size = new System.Drawing.Size(707, 298);
            this.grdPrisoner.TabIndex = 12;
            // 
            // viewPrisoners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 507);
            this.Controls.Add(this.grdPrisoner);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnSearchPrisoner);
            this.Controls.Add(this.txtSearchID);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "viewPrisoners";
            this.Text = "viewPrisoners";
            ((System.ComponentModel.ISupportInitialize)(this.grdPrisoner)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Button btnSearchPrisoner;
        private System.Windows.Forms.TextBox txtSearchID;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.DataGridView grdPrisoner;
    }
}