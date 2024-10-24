namespace EyeClinicManagement.Settings
{
    partial class frm_servicetable
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
            this.Delete = new System.Windows.Forms.Button();
            this.Update = new System.Windows.Forms.Button();
            this.tbl_service = new System.Windows.Forms.DataGridView();
            this.btn_backservice = new System.Windows.Forms.Button();
            this.btn_addopd = new System.Windows.Forms.Button();
            this.lbl_service = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_service)).BeginInit();
            this.SuspendLayout();
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Delete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.SystemColors.Window;
            this.Delete.Location = new System.Drawing.Point(678, 116);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(175, 60);
            this.Delete.TabIndex = 18;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Update
            // 
            this.Update.BackColor = System.Drawing.Color.Green;
            this.Update.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Update.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Update.ForeColor = System.Drawing.SystemColors.Window;
            this.Update.Location = new System.Drawing.Point(485, 117);
            this.Update.Name = "Update";
            this.Update.Size = new System.Drawing.Size(175, 59);
            this.Update.TabIndex = 17;
            this.Update.Text = "Update";
            this.Update.UseVisualStyleBackColor = false;
            this.Update.Click += new System.EventHandler(this.Update_Click);
            // 
            // tbl_service
            // 
            this.tbl_service.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.tbl_service.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_service.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_service.Location = new System.Drawing.Point(39, 208);
            this.tbl_service.Name = "tbl_service";
            this.tbl_service.RowHeadersWidth = 51;
            this.tbl_service.RowTemplate.Height = 24;
            this.tbl_service.ShowCellErrors = false;
            this.tbl_service.Size = new System.Drawing.Size(1087, 616);
            this.tbl_service.TabIndex = 16;
            this.tbl_service.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_service_CellContentClick);
            this.tbl_service.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.tbl_service_CellEnter);
            // 
            // btn_backservice
            // 
            this.btn_backservice.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_backservice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backservice.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backservice.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_backservice.Location = new System.Drawing.Point(979, 117);
            this.btn_backservice.Name = "btn_backservice";
            this.btn_backservice.Size = new System.Drawing.Size(147, 59);
            this.btn_backservice.TabIndex = 15;
            this.btn_backservice.Text = "Back";
            this.btn_backservice.UseVisualStyleBackColor = false;
            this.btn_backservice.Click += new System.EventHandler(this.btn_backservice_Click);
            // 
            // btn_addopd
            // 
            this.btn_addopd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_addopd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addopd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addopd.ForeColor = System.Drawing.SystemColors.WindowText;
            this.btn_addopd.Location = new System.Drawing.Point(39, 117);
            this.btn_addopd.Name = "btn_addopd";
            this.btn_addopd.Size = new System.Drawing.Size(331, 59);
            this.btn_addopd.TabIndex = 14;
            this.btn_addopd.Text = "Add New Service";
            this.btn_addopd.UseVisualStyleBackColor = false;
            this.btn_addopd.Click += new System.EventHandler(this.btn_addopd_Click);
            // 
            // lbl_service
            // 
            this.lbl_service.AutoSize = true;
            this.lbl_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_service.Location = new System.Drawing.Point(27, 31);
            this.lbl_service.Name = "lbl_service";
            this.lbl_service.Size = new System.Drawing.Size(260, 69);
            this.lbl_service.TabIndex = 13;
            this.lbl_service.Text = "Services";
            // 
            // frm_servicetable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1164, 846);
            this.Controls.Add(this.Delete);
            this.Controls.Add(this.Update);
            this.Controls.Add(this.tbl_service);
            this.Controls.Add(this.btn_backservice);
            this.Controls.Add(this.btn_addopd);
            this.Controls.Add(this.lbl_service);
            this.Name = "frm_servicetable";
            this.Text = "frm_servicetable";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_service)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Update;
        private System.Windows.Forms.DataGridView tbl_service;
        private System.Windows.Forms.Button btn_backservice;
        private System.Windows.Forms.Button btn_addopd;
        private System.Windows.Forms.Label lbl_service;
    }
}