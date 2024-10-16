namespace EyeClinicManagement.OPD
{
    partial class frm_opdtable
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
            this.btn_backopd = new System.Windows.Forms.Button();
            this.btn_addopd = new System.Windows.Forms.Button();
            this.lbl_opd = new System.Windows.Forms.Label();
            this.tbl_opd = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.tbl_opd)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_backopd
            // 
            this.btn_backopd.BackColor = System.Drawing.SystemColors.MenuText;
            this.btn_backopd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backopd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backopd.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_backopd.Location = new System.Drawing.Point(1603, 102);
            this.btn_backopd.Name = "btn_backopd";
            this.btn_backopd.Size = new System.Drawing.Size(147, 59);
            this.btn_backopd.TabIndex = 6;
            this.btn_backopd.Text = "Back";
            this.btn_backopd.UseVisualStyleBackColor = false;
            this.btn_backopd.Click += new System.EventHandler(this.btn_backopd_Click);
            // 
            // btn_addopd
            // 
            this.btn_addopd.BackColor = System.Drawing.Color.Chocolate;
            this.btn_addopd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_addopd.Font = new System.Drawing.Font("Microsoft Sans Serif", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_addopd.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_addopd.Location = new System.Drawing.Point(31, 102);
            this.btn_addopd.Name = "btn_addopd";
            this.btn_addopd.Size = new System.Drawing.Size(313, 59);
            this.btn_addopd.TabIndex = 5;
            this.btn_addopd.Text = "Add New OPD";
            this.btn_addopd.UseVisualStyleBackColor = false;
            this.btn_addopd.Click += new System.EventHandler(this.btn_addopd_Click);
            // 
            // lbl_opd
            // 
            this.lbl_opd.AutoSize = true;
            this.lbl_opd.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_opd.Location = new System.Drawing.Point(19, 16);
            this.lbl_opd.Name = "lbl_opd";
            this.lbl_opd.Size = new System.Drawing.Size(160, 69);
            this.lbl_opd.TabIndex = 4;
            this.lbl_opd.Text = "OPD";
            // 
            // tbl_opd
            // 
            this.tbl_opd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tbl_opd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tbl_opd.Location = new System.Drawing.Point(31, 193);
            this.tbl_opd.Name = "tbl_opd";
            this.tbl_opd.RowHeadersWidth = 51;
            this.tbl_opd.RowTemplate.Height = 24;
            this.tbl_opd.Size = new System.Drawing.Size(1719, 616);
            this.tbl_opd.TabIndex = 8;
            // 
            // frm_opdtable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1781, 821);
            this.Controls.Add(this.tbl_opd);
            this.Controls.Add(this.btn_backopd);
            this.Controls.Add(this.btn_addopd);
            this.Controls.Add(this.lbl_opd);
            this.Name = "frm_opdtable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_opdtable";
            ((System.ComponentModel.ISupportInitialize)(this.tbl_opd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_backopd;
        private System.Windows.Forms.Button btn_addopd;
        private System.Windows.Forms.Label lbl_opd;
        private System.Windows.Forms.DataGridView tbl_opd;
    }
}