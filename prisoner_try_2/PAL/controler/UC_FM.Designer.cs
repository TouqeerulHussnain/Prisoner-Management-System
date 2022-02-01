namespace prisoner_try_2.PAL.controler
{
    partial class UC_FM
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panalFoodmanager = new System.Windows.Forms.Panel();
            this.btnFM_Update = new System.Windows.Forms.Button();
            this.btnFM_Del = new System.Windows.Forms.Button();
            this.btnFM_View = new System.Windows.Forms.Button();
            this.btnFM_Add = new System.Windows.Forms.Button();
            this.pnlExternalMerge = new System.Windows.Forms.Panel();
            this.panalFoodmanager.SuspendLayout();
            this.SuspendLayout();
            // 
            // panalFoodmanager
            // 
            this.panalFoodmanager.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panalFoodmanager.Controls.Add(this.btnFM_Update);
            this.panalFoodmanager.Controls.Add(this.btnFM_Del);
            this.panalFoodmanager.Controls.Add(this.btnFM_View);
            this.panalFoodmanager.Controls.Add(this.btnFM_Add);
            this.panalFoodmanager.Location = new System.Drawing.Point(27, 3);
            this.panalFoodmanager.Name = "panalFoodmanager";
            this.panalFoodmanager.Size = new System.Drawing.Size(149, 244);
            this.panalFoodmanager.TabIndex = 37;
            // 
            // btnFM_Update
            // 
            this.btnFM_Update.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFM_Update.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFM_Update.ForeColor = System.Drawing.Color.White;
            this.btnFM_Update.Location = new System.Drawing.Point(12, 183);
            this.btnFM_Update.Name = "btnFM_Update";
            this.btnFM_Update.Size = new System.Drawing.Size(125, 48);
            this.btnFM_Update.TabIndex = 7;
            this.btnFM_Update.Text = "Update Food  Manager";
            this.btnFM_Update.UseVisualStyleBackColor = false;
            this.btnFM_Update.Click += new System.EventHandler(this.btnFM_Update_Click);
            // 
            // btnFM_Del
            // 
            this.btnFM_Del.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFM_Del.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFM_Del.ForeColor = System.Drawing.Color.White;
            this.btnFM_Del.Location = new System.Drawing.Point(12, 129);
            this.btnFM_Del.Name = "btnFM_Del";
            this.btnFM_Del.Size = new System.Drawing.Size(125, 48);
            this.btnFM_Del.TabIndex = 6;
            this.btnFM_Del.Text = "Delete Food Manager";
            this.btnFM_Del.UseVisualStyleBackColor = false;
            this.btnFM_Del.Click += new System.EventHandler(this.btnFM_Del_Click);
            // 
            // btnFM_View
            // 
            this.btnFM_View.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFM_View.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFM_View.ForeColor = System.Drawing.Color.White;
            this.btnFM_View.Location = new System.Drawing.Point(12, 75);
            this.btnFM_View.Name = "btnFM_View";
            this.btnFM_View.Size = new System.Drawing.Size(125, 48);
            this.btnFM_View.TabIndex = 5;
            this.btnFM_View.Text = "View Food Manager";
            this.btnFM_View.UseVisualStyleBackColor = false;
            this.btnFM_View.Click += new System.EventHandler(this.btnFM_View_Click);
            // 
            // btnFM_Add
            // 
            this.btnFM_Add.BackColor = System.Drawing.Color.DarkGreen;
            this.btnFM_Add.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnFM_Add.FlatAppearance.BorderSize = 0;
            this.btnFM_Add.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFM_Add.ForeColor = System.Drawing.Color.White;
            this.btnFM_Add.Location = new System.Drawing.Point(12, 21);
            this.btnFM_Add.Name = "btnFM_Add";
            this.btnFM_Add.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnFM_Add.Size = new System.Drawing.Size(125, 48);
            this.btnFM_Add.TabIndex = 4;
            this.btnFM_Add.Text = "Add Food Manager";
            this.btnFM_Add.UseVisualStyleBackColor = false;
            this.btnFM_Add.Click += new System.EventHandler(this.btnFM_Add_Click);
            // 
            // pnlExternalMerge
            // 
            this.pnlExternalMerge.BackColor = System.Drawing.Color.Transparent;
            this.pnlExternalMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlExternalMerge.Location = new System.Drawing.Point(195, -1);
            this.pnlExternalMerge.Name = "pnlExternalMerge";
            this.pnlExternalMerge.Size = new System.Drawing.Size(775, 507);
            this.pnlExternalMerge.TabIndex = 38;
            // 
            // UC_FM
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlExternalMerge);
            this.Controls.Add(this.panalFoodmanager);
            this.Name = "UC_FM";
            this.Size = new System.Drawing.Size(973, 506);
            this.Load += new System.EventHandler(this.UC_FM_Load);
            this.panalFoodmanager.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panalFoodmanager;
        private System.Windows.Forms.Button btnFM_Update;
        private System.Windows.Forms.Button btnFM_Del;
        private System.Windows.Forms.Button btnFM_View;
        private System.Windows.Forms.Button btnFM_Add;
        private System.Windows.Forms.Panel pnlExternalMerge;
    }
}
