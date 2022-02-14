namespace prisoner_try_2.PAL.Home
{
    partial class AdminLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AdminLogin));
            this.btnAddJailer = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btnAddJailer
            // 
            this.btnAddJailer.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddJailer.Location = new System.Drawing.Point(173, 262);
            this.btnAddJailer.Name = "btnAddJailer";
            this.btnAddJailer.Size = new System.Drawing.Size(230, 46);
            this.btnAddJailer.TabIndex = 119;
            this.btnAddJailer.Text = "Login";
            this.btnAddJailer.UseVisualStyleBackColor = true;
            this.btnAddJailer.Click += new System.EventHandler(this.btnAddJailer_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label2.Location = new System.Drawing.Point(117, 196);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(106, 25);
            this.label2.TabIndex = 117;
            this.label2.Text = "Password";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPassword.Location = new System.Drawing.Point(239, 196);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(230, 20);
            this.txtPassword.TabIndex = 116;
            this.txtPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtPassword_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(117, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 25);
            this.label1.TabIndex = 115;
            this.label1.Text = "ID";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(233, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 31);
            this.label3.TabIndex = 129;
            this.label3.Text = "Login ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // btnExit
            // 
            this.btnExit.FlatAppearance.BorderSize = 2;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Image = ((System.Drawing.Image)(resources.GetObject("btnExit.Image")));
            this.btnExit.Location = new System.Drawing.Point(15, 26);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(52, 34);
            this.btnExit.TabIndex = 130;
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtName.Location = new System.Drawing.Point(239, 150);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 114;
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // AdminLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(546, 370);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnAddJailer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtName);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AdminLogin";
            this.Text = "AdminLogin";
            this.Load += new System.EventHandler(this.AdminLogin_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAddJailer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtName;
    }
}