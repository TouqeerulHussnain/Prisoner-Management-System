namespace prisoner_try_2.PAL.controler
{
    partial class UC_Prisoner
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
            System.Windows.Forms.Button btnupdPrisoner;
            System.Windows.Forms.Button btnviewPrisoner;
            System.Windows.Forms.Button btnaddprisoner;
            this.panalPisoner = new System.Windows.Forms.Panel();
            this.pnlExternalMerge = new System.Windows.Forms.Panel();
            btnupdPrisoner = new System.Windows.Forms.Button();
            btnviewPrisoner = new System.Windows.Forms.Button();
            btnaddprisoner = new System.Windows.Forms.Button();
            this.panalPisoner.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnupdPrisoner
            // 
            btnupdPrisoner.BackColor = System.Drawing.Color.DarkGreen;
            btnupdPrisoner.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnupdPrisoner.ForeColor = System.Drawing.Color.White;
            btnupdPrisoner.Location = new System.Drawing.Point(12, 69);
            btnupdPrisoner.Name = "btnupdPrisoner";
            btnupdPrisoner.Size = new System.Drawing.Size(121, 48);
            btnupdPrisoner.TabIndex = 51;
            btnupdPrisoner.Text = "Update Prisoner";
            btnupdPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            btnupdPrisoner.UseVisualStyleBackColor = false;
            btnupdPrisoner.Click += new System.EventHandler(this.btnupdPrisoner_Click);
            // 
            // btnviewPrisoner
            // 
            btnviewPrisoner.BackColor = System.Drawing.Color.DarkGreen;
            btnviewPrisoner.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnviewPrisoner.ForeColor = System.Drawing.Color.White;
            btnviewPrisoner.Location = new System.Drawing.Point(12, 123);
            btnviewPrisoner.Name = "btnviewPrisoner";
            btnviewPrisoner.Size = new System.Drawing.Size(121, 48);
            btnviewPrisoner.TabIndex = 49;
            btnviewPrisoner.Text = "View/Search Prisoners";
            btnviewPrisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            btnviewPrisoner.UseVisualStyleBackColor = false;
            btnviewPrisoner.Click += new System.EventHandler(this.btnviewPrisoner_Click);
            // 
            // btnaddprisoner
            // 
            btnaddprisoner.BackColor = System.Drawing.Color.DarkGreen;
            btnaddprisoner.FlatAppearance.BorderSize = 0;
            btnaddprisoner.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            btnaddprisoner.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            btnaddprisoner.ForeColor = System.Drawing.Color.White;
            btnaddprisoner.Location = new System.Drawing.Point(12, 15);
            btnaddprisoner.Name = "btnaddprisoner";
            btnaddprisoner.Size = new System.Drawing.Size(121, 48);
            btnaddprisoner.TabIndex = 52;
            btnaddprisoner.Text = "Add Prisoner";
            btnaddprisoner.TextImageRelation = System.Windows.Forms.TextImageRelation.TextAboveImage;
            btnaddprisoner.UseVisualStyleBackColor = false;
            btnaddprisoner.Click += new System.EventHandler(this.btnaddprisoner_Click);
            // 
            // panalPisoner
            // 
            this.panalPisoner.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panalPisoner.Controls.Add(btnaddprisoner);
            this.panalPisoner.Controls.Add(btnupdPrisoner);
            this.panalPisoner.Controls.Add(btnviewPrisoner);
            this.panalPisoner.Location = new System.Drawing.Point(23, 3);
            this.panalPisoner.Name = "panalPisoner";
            this.panalPisoner.Size = new System.Drawing.Size(149, 244);
            this.panalPisoner.TabIndex = 38;
            // 
            // pnlExternalMerge
            // 
            this.pnlExternalMerge.BackColor = System.Drawing.Color.LightGoldenrodYellow;
            this.pnlExternalMerge.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pnlExternalMerge.Location = new System.Drawing.Point(191, -1);
            this.pnlExternalMerge.Name = "pnlExternalMerge";
            this.pnlExternalMerge.Size = new System.Drawing.Size(775, 507);
            this.pnlExternalMerge.TabIndex = 39;
            // 
            // UC_Prisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.pnlExternalMerge);
            this.Controls.Add(this.panalPisoner);
            this.Name = "UC_Prisoner";
            this.Size = new System.Drawing.Size(973, 506);
            this.Load += new System.EventHandler(this.UC_Prisoner_Load);
            this.panalPisoner.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panalPisoner;
        private System.Windows.Forms.Panel pnlExternalMerge;
    }
}
