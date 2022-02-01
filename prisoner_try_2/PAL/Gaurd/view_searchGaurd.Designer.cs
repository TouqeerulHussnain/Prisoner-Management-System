namespace prisoner_try_2.PAL.Gaurd
{
    partial class view_searchGaurd
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
            this.lblviewgaurd = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.btnsrchgaurd = new System.Windows.Forms.Button();
            this.btnshowall = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.grdGuard = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdGuard)).BeginInit();
            this.SuspendLayout();
            // 
            // lblviewgaurd
            // 
            this.lblviewgaurd.AutoSize = true;
            this.lblviewgaurd.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblviewgaurd.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblviewgaurd.Location = new System.Drawing.Point(268, 9);
            this.lblviewgaurd.Name = "lblviewgaurd";
            this.lblviewgaurd.Size = new System.Drawing.Size(257, 28);
            this.lblviewgaurd.TabIndex = 0;
            this.lblviewgaurd.Text = "View and Search Gaurd";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(472, 52);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(159, 24);
            this.lblID.TabIndex = 1;
            this.lblID.Text = "Enter ID to search";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(640, 52);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(100, 20);
            this.txtsearch.TabIndex = 2;
            // 
            // btnsrchgaurd
            // 
            this.btnsrchgaurd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsrchgaurd.ForeColor = System.Drawing.Color.Blue;
            this.btnsrchgaurd.Location = new System.Drawing.Point(476, 93);
            this.btnsrchgaurd.Name = "btnsrchgaurd";
            this.btnsrchgaurd.Size = new System.Drawing.Size(264, 31);
            this.btnsrchgaurd.TabIndex = 3;
            this.btnsrchgaurd.Text = "Search Gaurd";
            this.btnsrchgaurd.UseVisualStyleBackColor = true;
            this.btnsrchgaurd.Click += new System.EventHandler(this.btnsrchgaurd_Click);
            // 
            // btnshowall
            // 
            this.btnshowall.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnshowall.ForeColor = System.Drawing.Color.Blue;
            this.btnshowall.Location = new System.Drawing.Point(24, 93);
            this.btnshowall.Name = "btnshowall";
            this.btnshowall.Size = new System.Drawing.Size(256, 31);
            this.btnshowall.TabIndex = 4;
            this.btnshowall.Text = "Show all Data";
            this.btnshowall.UseVisualStyleBackColor = true;
            this.btnshowall.Click += new System.EventHandler(this.btnshowall_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(19, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(261, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "To Show all Gaurd Data";
            // 
            // grdGuard
            // 
            this.grdGuard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdGuard.Location = new System.Drawing.Point(24, 145);
            this.grdGuard.Name = "grdGuard";
            this.grdGuard.Size = new System.Drawing.Size(730, 339);
            this.grdGuard.TabIndex = 6;
            // 
            // view_searchGaurd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 507);
            this.Controls.Add(this.grdGuard);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnshowall);
            this.Controls.Add(this.btnsrchgaurd);
            this.Controls.Add(this.txtsearch);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.lblviewgaurd);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "view_searchGaurd";
            this.Text = "view_searchGaurd";
            this.Load += new System.EventHandler(this.view_searchGaurd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdGuard)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblviewgaurd;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.Button btnsrchgaurd;
        private System.Windows.Forms.Button btnshowall;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdGuard;
    }
}