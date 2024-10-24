namespace EyeClinicManagement.MainScreen
{
    partial class frm_mainscreen
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
            this.btn_settings = new System.Windows.Forms.Button();
            this.btn_reports = new System.Windows.Forms.Button();
            this.btn_surgery = new System.Windows.Forms.Button();
            this.btn_opd = new System.Windows.Forms.Button();
            this.btn_doctors = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_settings
            // 
            this.btn_settings.BackColor = System.Drawing.SystemColors.InfoText;
            this.btn_settings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_settings.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_settings.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_settings.Location = new System.Drawing.Point(78, 582);
            this.btn_settings.Name = "btn_settings";
            this.btn_settings.Size = new System.Drawing.Size(311, 82);
            this.btn_settings.TabIndex = 18;
            this.btn_settings.Text = "Services";
            this.btn_settings.UseVisualStyleBackColor = false;
            this.btn_settings.Click += new System.EventHandler(this.btn_settings_Click);
            // 
            // btn_reports
            // 
            this.btn_reports.BackColor = System.Drawing.Color.Red;
            this.btn_reports.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_reports.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_reports.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_reports.Location = new System.Drawing.Point(78, 454);
            this.btn_reports.Name = "btn_reports";
            this.btn_reports.Size = new System.Drawing.Size(311, 82);
            this.btn_reports.TabIndex = 17;
            this.btn_reports.Text = "Reports";
            this.btn_reports.UseVisualStyleBackColor = false;
            this.btn_reports.Click += new System.EventHandler(this.btn_reports_Click);
            // 
            // btn_surgery
            // 
            this.btn_surgery.BackColor = System.Drawing.Color.Blue;
            this.btn_surgery.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_surgery.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_surgery.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_surgery.Location = new System.Drawing.Point(78, 329);
            this.btn_surgery.Name = "btn_surgery";
            this.btn_surgery.Size = new System.Drawing.Size(311, 82);
            this.btn_surgery.TabIndex = 16;
            this.btn_surgery.Text = "Surgery";
            this.btn_surgery.UseVisualStyleBackColor = false;
            // 
            // btn_opd
            // 
            this.btn_opd.BackColor = System.Drawing.Color.Chocolate;
            this.btn_opd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_opd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_opd.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_opd.Location = new System.Drawing.Point(78, 198);
            this.btn_opd.Name = "btn_opd";
            this.btn_opd.Size = new System.Drawing.Size(311, 82);
            this.btn_opd.TabIndex = 15;
            this.btn_opd.Text = "OPD";
            this.btn_opd.UseVisualStyleBackColor = false;
            this.btn_opd.Click += new System.EventHandler(this.btn_opd_Click);
            // 
            // btn_doctors
            // 
            this.btn_doctors.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_doctors.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_doctors.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_doctors.Location = new System.Drawing.Point(78, 69);
            this.btn_doctors.Name = "btn_doctors";
            this.btn_doctors.Size = new System.Drawing.Size(311, 82);
            this.btn_doctors.TabIndex = 14;
            this.btn_doctors.Text = "Doctors";
            this.btn_doctors.UseVisualStyleBackColor = false;
            this.btn_doctors.Click += new System.EventHandler(this.btn_doctors_Click);
            // 
            // frm_mainscreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ClientSize = new System.Drawing.Size(470, 747);
            this.Controls.Add(this.btn_settings);
            this.Controls.Add(this.btn_reports);
            this.Controls.Add(this.btn_surgery);
            this.Controls.Add(this.btn_opd);
            this.Controls.Add(this.btn_doctors);
            this.Name = "frm_mainscreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_mainscreen";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_settings;
        private System.Windows.Forms.Button btn_reports;
        private System.Windows.Forms.Button btn_surgery;
        private System.Windows.Forms.Button btn_opd;
        private System.Windows.Forms.Button btn_doctors;
    }
}