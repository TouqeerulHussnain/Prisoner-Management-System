namespace prisoner_try_2.PAL.Prisoner
{
    partial class addPrisoner
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
            this.txtID = new System.Windows.Forms.TextBox();
            this.btnaddRecord = new System.Windows.Forms.Button();
            this.lblprisonerid = new System.Windows.Forms.Label();
            this.lblcrimedate = new System.Windows.Forms.Label();
            this.lblrlseDate = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpRelease = new System.Windows.Forms.DateTimePicker();
            this.dtpCrime = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtPunishment = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAge = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtCrime = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtID
            // 
            this.txtID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtID.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtID.Location = new System.Drawing.Point(392, 91);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(230, 20);
            this.txtID.TabIndex = 0;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtID.TextChanged += new System.EventHandler(this.txtID_TextChanged);
            // 
            // btnaddRecord
            // 
            this.btnaddRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnaddRecord.ForeColor = System.Drawing.Color.MediumBlue;
            this.btnaddRecord.Location = new System.Drawing.Point(303, 432);
            this.btnaddRecord.Name = "btnaddRecord";
            this.btnaddRecord.Size = new System.Drawing.Size(148, 43);
            this.btnaddRecord.TabIndex = 1;
            this.btnaddRecord.Text = "Add Record";
            this.btnaddRecord.UseVisualStyleBackColor = true;
            this.btnaddRecord.Click += new System.EventHandler(this.btnaddRecord_Click);
            // 
            // lblprisonerid
            // 
            this.lblprisonerid.AutoSize = true;
            this.lblprisonerid.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprisonerid.Location = new System.Drawing.Point(188, 87);
            this.lblprisonerid.Name = "lblprisonerid";
            this.lblprisonerid.Size = new System.Drawing.Size(27, 24);
            this.lblprisonerid.TabIndex = 2;
            this.lblprisonerid.Text = "ID";
            // 
            // lblcrimedate
            // 
            this.lblcrimedate.AutoSize = true;
            this.lblcrimedate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcrimedate.Location = new System.Drawing.Point(190, 330);
            this.lblcrimedate.Name = "lblcrimedate";
            this.lblcrimedate.Size = new System.Drawing.Size(103, 24);
            this.lblcrimedate.TabIndex = 15;
            this.lblcrimedate.Text = "Crime Date";
            // 
            // lblrlseDate
            // 
            this.lblrlseDate.AutoSize = true;
            this.lblrlseDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblrlseDate.Location = new System.Drawing.Point(190, 375);
            this.lblrlseDate.Name = "lblrlseDate";
            this.lblrlseDate.Size = new System.Drawing.Size(122, 24);
            this.lblrlseDate.TabIndex = 16;
            this.lblrlseDate.Text = "Release Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(245, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Add Prisoner Record";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dtpRelease
            // 
            this.dtpRelease.CustomFormat = "yyyy-MM-dd";
            this.dtpRelease.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpRelease.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpRelease.Location = new System.Drawing.Point(392, 370);
            this.dtpRelease.Name = "dtpRelease";
            this.dtpRelease.Size = new System.Drawing.Size(192, 29);
            this.dtpRelease.TabIndex = 18;
            this.dtpRelease.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // dtpCrime
            // 
            this.dtpCrime.CustomFormat = "yyyy-MM-dd";
            this.dtpCrime.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpCrime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpCrime.Location = new System.Drawing.Point(392, 325);
            this.dtpCrime.Name = "dtpCrime";
            this.dtpCrime.Size = new System.Drawing.Size(192, 29);
            this.dtpCrime.TabIndex = 19;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(175, 91);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(118, 25);
            this.label6.TabIndex = 129;
            this.label6.Text = "Prisoner ID";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(180, 269);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(125, 25);
            this.label7.TabIndex = 128;
            this.label7.Text = "Punishment";
            // 
            // txtPunishment
            // 
            this.txtPunishment.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtPunishment.Location = new System.Drawing.Point(392, 269);
            this.txtPunishment.Name = "txtPunishment";
            this.txtPunishment.Size = new System.Drawing.Size(230, 20);
            this.txtPunishment.TabIndex = 127;
            this.txtPunishment.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(240, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 25);
            this.label4.TabIndex = 126;
            this.label4.Text = "Age";
            // 
            // txtAge
            // 
            this.txtAge.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtAge.Location = new System.Drawing.Point(392, 178);
            this.txtAge.Name = "txtAge";
            this.txtAge.Size = new System.Drawing.Size(230, 20);
            this.txtAge.TabIndex = 125;
            this.txtAge.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label8.Location = new System.Drawing.Point(222, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 25);
            this.label8.TabIndex = 124;
            this.label8.Text = "Crime";
            // 
            // txtCrime
            // 
            this.txtCrime.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtCrime.Location = new System.Drawing.Point(392, 220);
            this.txtCrime.Name = "txtCrime";
            this.txtCrime.Size = new System.Drawing.Size(230, 20);
            this.txtCrime.TabIndex = 123;
            this.txtCrime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(222, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(68, 25);
            this.label9.TabIndex = 122;
            this.label9.Text = "Name";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.MenuText;
            this.txtName.Location = new System.Drawing.Point(392, 138);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(230, 20);
            this.txtName.TabIndex = 121;
            this.txtName.Text = " ";
            this.txtName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(657, 263);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(79, 25);
            this.label15.TabIndex = 137;
            this.label15.Text = "(string)";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(657, 220);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(79, 25);
            this.label10.TabIndex = 134;
            this.label10.Text = "(string)";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(657, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(49, 25);
            this.label11.TabIndex = 133;
            this.label11.Text = "(int)";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(657, 46);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(94, 25);
            this.label16.TabIndex = 132;
            this.label16.Text = "For Help";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(657, 135);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(79, 25);
            this.label14.TabIndex = 131;
            this.label14.Text = "(string)";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(657, 86);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(49, 25);
            this.label13.TabIndex = 130;
            this.label13.Text = "(int)";
            // 
            // addPrisoner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 507);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtPunishment);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAge);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCrime);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.dtpCrime);
            this.Controls.Add(this.dtpRelease);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblrlseDate);
            this.Controls.Add(this.lblcrimedate);
            this.Controls.Add(this.lblprisonerid);
            this.Controls.Add(this.btnaddRecord);
            this.Controls.Add(this.txtID);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "addPrisoner";
            this.Tag = "";
            this.Text = "addPrisoner";
            this.Load += new System.EventHandler(this.addPrisoner_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Button btnaddRecord;
        private System.Windows.Forms.Label lblprisonerid;
        private System.Windows.Forms.Label lblcrimedate;
        private System.Windows.Forms.Label lblrlseDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpRelease;
        private System.Windows.Forms.DateTimePicker dtpCrime;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtPunishment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAge;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtCrime;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
    }
}