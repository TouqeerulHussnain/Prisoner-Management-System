namespace prisoner_try_2.PAL.Home
{
    partial class Notification
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
            this.gridNotice = new System.Windows.Forms.DataGridView();
            this.dtpStart = new System.Windows.Forms.DateTimePicker();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.lblrlseDate = new System.Windows.Forms.Label();
            this.lblcrimedate = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tnToday = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridNotice)).BeginInit();
            this.SuspendLayout();
            // 
            // gridNotice
            // 
            this.gridNotice.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridNotice.Location = new System.Drawing.Point(0, 66);
            this.gridNotice.Name = "gridNotice";
            this.gridNotice.Size = new System.Drawing.Size(820, 386);
            this.gridNotice.TabIndex = 0;
            // 
            // dtpStart
            // 
            this.dtpStart.CustomFormat = "yyyy-MM-dd";
            this.dtpStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpStart.Location = new System.Drawing.Point(77, 17);
            this.dtpStart.Name = "dtpStart";
            this.dtpStart.Size = new System.Drawing.Size(192, 29);
            this.dtpStart.TabIndex = 23;
            this.dtpStart.ValueChanged += new System.EventHandler(this.dtpCrime_ValueChanged);
            // 
            // dtpRelease
            // 
            this.dtpRelease.CustomFormat = "yyyy-MM-dd";
            this.dtpRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRelease.Location = new System.Drawing.Point(373, 14);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(192, 29);
            this.dtpRelease.TabIndex = 22;
            // 
            // lblrlseDate
            // 
            this.lblrlseDate.AutoSize = true;
            this.lblrlseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrlseDate.Location = new System.Drawing.Point(307, 18);
            this.lblrlseDate.Name = "lblrlseDate";
            this.lblrlseDate.Size = new System.Drawing.Size(45, 24);
            this.lblrlseDate.TabIndex = 21;
            this.lblrlseDate.Text = "End";
            // 
            // lblcrimedate
            // 
            this.lblcrimedate.AutoSize = true;
            this.lblcrimedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrimedate.Location = new System.Drawing.Point(11, 17);
            this.lblcrimedate.Name = "lblcrimedate";
            this.lblcrimedate.Size = new System.Drawing.Size(43, 24);
            this.lblcrimedate.TabIndex = 20;
            this.lblcrimedate.Text = "start";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(589, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 29);
            this.button1.TabIndex = 24;
            this.button1.Text = "Search";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tnToday
            // 
            this.tnToday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tnToday.Location = new System.Drawing.Point(685, 18);
            this.tnToday.Name = "tnToday";
            this.tnToday.Size = new System.Drawing.Size(75, 29);
            this.tnToday.TabIndex = 25;
            this.tnToday.Text = "Today";
            this.tnToday.UseVisualStyleBackColor = true;
            this.tnToday.Click += new System.EventHandler(this.tnToday_Click);
            // 
            // Notification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 452);
            this.Controls.Add(this.tnToday);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtpStart);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.lblrlseDate);
            this.Controls.Add(this.lblcrimedate);
            this.Controls.Add(this.gridNotice);
            this.Name = "Notification";
            this.Text = "Notification";
            this.Load += new System.EventHandler(this.Notification_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridNotice)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView gridNotice;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.Label lblrlseDate;
        private System.Windows.Forms.Label lblcrimedate;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button tnToday;
    }
}