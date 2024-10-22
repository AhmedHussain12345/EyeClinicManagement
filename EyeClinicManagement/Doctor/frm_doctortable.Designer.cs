namespace EyeClinicManagement.Doctor
{
    partial class frm_doctortable
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
            this.btn_backdoctor = new System.Windows.Forms.Button();
            this.btn_adddoctor = new System.Windows.Forms.Button();
            this.lbl_doctors = new System.Windows.Forms.Label();
            this.tbl_doctor = new System.Windows.Forms.DataGridView();
            this.Update = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_doctor)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backdoctor
            // 
            this.btn_backdoctor.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_backdoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backdoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backdoctor.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_backdoctor.Location = new System.Drawing.Point(1601, 96);
            this.btn_backdoctor.Name = "btn_backdoctor";
            this.btn_backdoctor.Size = new System.Drawing.Size(147, 60);
            this.btn_backdoctor.TabIndex = 5;
            this.btn_backdoctor.Text = "Back";
            this.btn_backdoctor.UseVisualStyleBackColor = false;
            this.btn_backdoctor.Click += new System.EventHandler(this.btn_backdoctor_Click);
            // 
            // btn_adddoctor
            // 
            this.btn_adddoctor.BackColor = System.Drawing.Color.DarkViolet;
            this.btn_adddoctor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_adddoctor.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_adddoctor.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_adddoctor.Location = new System.Drawing.Point(29, 96);
            this.btn_adddoctor.Name = "btn_adddoctor";
            this.btn_adddoctor.Size = new System.Drawing.Size(335, 60);
            this.btn_adddoctor.TabIndex = 4;
            this.btn_adddoctor.Text = "Add New Doctor";
            this.btn_adddoctor.UseVisualStyleBackColor = false;
            this.btn_adddoctor.Click += new System.EventHandler(this.btn_adddoctor_Click);
            // 
            // lbl_doctors
            // 
            this.lbl_doctors.AutoSize = true;
            this.lbl_doctors.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_doctors.Location = new System.Drawing.Point(17, 10);
            this.lbl_doctors.Name = "lbl_doctors";
            this.lbl_doctors.Size = new System.Drawing.Size(236, 69);
            this.lbl_doctors.TabIndex = 3;
            this.lbl_doctors.Text = "Doctors";
            // 
            // tbl_doctor
            // 
            this.tbl_doctor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_doctor.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_doctor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_doctor.Location = new System.Drawing.Point(29, 194);
            this.tbl_doctor.Name = "tbl_doctor";
            this.tbl_doctor.RowHeadersWidth = 51;
            this.tbl_doctor.RowTemplate.Height = 24;
            this.tbl_doctor.Size = new System.Drawing.Size(1719, 616);
            this.tbl_doctor.TabIndex = 7;
            this.tbl_doctor.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_doctor_CellEnter);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Green;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.Window;
            this.Update.Location = new System.Drawing.Point(483, 96);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(175, 60);
            this.Update.TabIndex = 9;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.Window;
            this.Delete.Location = new System.Drawing.Point(676, 95);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(175, 61);
            this.Delete.TabIndex = 10;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // frm_doctortable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1777, 822);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.tbl_doctor);
            this.Controls.Add(this.btn_backdoctor);
            this.Controls.Add(this.btn_adddoctor);
            this.Controls.Add(this.lbl_doctors);
            this.Name = "frm_doctortable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doctortable";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_doctor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backdoctor;
        private System.Windows.Forms.Button btn_adddoctor;
        private System.Windows.Forms.Label lbl_doctors;
        private System.Windows.Forms.DataGridView tbl_doctor;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.Button Delete;
    }
}