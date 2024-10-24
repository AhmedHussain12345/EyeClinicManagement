namespace EyeClinicManagement.Settings
{
    partial class frm_serviceadd
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
            this.Clear = new System.Windows.Forms.Button();
            this.lbl_docfrmheading = new System.Windows.Forms.Label();
            this.btn_docsubmit = new System.Windows.Forms.Button();
            this.textBox_price = new System.Windows.Forms.TextBox();
            this.textBox_service = new System.Windows.Forms.TextBox();
            this.enable = new System.Windows.Forms.Label();
            this.price = new System.Windows.Forms.Label();
            this.service = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // Clear
            // 
            this.Clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Clear.ForeColor = System.Drawing.SystemColors.InfoText;
            this.Clear.Location = new System.Drawing.Point(452, 262);
            this.Clear.Name = "Clear";
            this.Clear.Size = new System.Drawing.Size(92, 51);
            this.Clear.TabIndex = 45;
            this.Clear.Text = "Clear";
            this.Clear.UseVisualStyleBackColor = false;
            this.Clear.Click += new System.EventHandler(this.Clear_Click);
            // 
            // lbl_docfrmheading
            // 
            this.lbl_docfrmheading.AutoSize = true;
            this.lbl_docfrmheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docfrmheading.Location = new System.Drawing.Point(120, 36);
            this.lbl_docfrmheading.Name = "lbl_docfrmheading";
            this.lbl_docfrmheading.Size = new System.Drawing.Size(326, 54);
            this.lbl_docfrmheading.TabIndex = 44;
            this.lbl_docfrmheading.Text = "Services Form";
            // 
            // btn_docsubmit
            // 
            this.btn_docsubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.btn_docsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docsubmit.ForeColor = System.Drawing.SystemColors.InfoText;
            this.btn_docsubmit.Location = new System.Drawing.Point(288, 262);
            this.btn_docsubmit.Name = "btn_docsubmit";
            this.btn_docsubmit.Size = new System.Drawing.Size(158, 51);
            this.btn_docsubmit.TabIndex = 37;
            this.btn_docsubmit.Text = "Submit";
            this.btn_docsubmit.UseVisualStyleBackColor = false;
            this.btn_docsubmit.Click += new System.EventHandler(this.btn_docsubmit_Click);
            // 
            // textBox_price
            // 
            this.textBox_price.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_price.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_price.Location = new System.Drawing.Point(159, 166);
            this.textBox_price.Name = "textBox_price";
            this.textBox_price.Size = new System.Drawing.Size(385, 34);
            this.textBox_price.TabIndex = 32;
            // 
            // textBox_service
            // 
            this.textBox_service.BackColor = System.Drawing.SystemColors.Window;
            this.textBox_service.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_service.Location = new System.Drawing.Point(159, 126);
            this.textBox_service.Name = "textBox_service";
            this.textBox_service.Size = new System.Drawing.Size(385, 34);
            this.textBox_service.TabIndex = 31;
            // 
            // enable
            // 
            this.enable.AutoSize = true;
            this.enable.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enable.Location = new System.Drawing.Point(30, 214);
            this.enable.Name = "enable";
            this.enable.Size = new System.Drawing.Size(103, 29);
            this.enable.TabIndex = 41;
            this.enable.Text = "Enabled";
            // 
            // price
            // 
            this.price.AutoSize = true;
            this.price.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.price.Location = new System.Drawing.Point(30, 171);
            this.price.Name = "price";
            this.price.Size = new System.Drawing.Size(69, 29);
            this.price.TabIndex = 40;
            this.price.Text = "Price";
            // 
            // service
            // 
            this.service.AutoSize = true;
            this.service.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.service.Location = new System.Drawing.Point(30, 131);
            this.service.Name = "service";
            this.service.Size = new System.Drawing.Size(94, 29);
            this.service.TabIndex = 38;
            this.service.Text = "Service";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.SystemColors.Window;
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.comboBox1.Location = new System.Drawing.Point(159, 206);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(385, 37);
            this.comboBox1.TabIndex = 46;
            // 
            // frm_serviceadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(586, 341);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.Clear);
            this.Controls.Add(this.lbl_docfrmheading);
            this.Controls.Add(this.btn_docsubmit);
            this.Controls.Add(this.textBox_price);
            this.Controls.Add(this.textBox_service);
            this.Controls.Add(this.enable);
            this.Controls.Add(this.price);
            this.Controls.Add(this.service);
            this.Name = "frm_serviceadd";
            this.Text = "frm_serviceadd";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Clear;
        private System.Windows.Forms.Label lbl_docfrmheading;
        private System.Windows.Forms.Button btn_docsubmit;
        private System.Windows.Forms.TextBox textBox_price;
        private System.Windows.Forms.TextBox textBox_service;
        private System.Windows.Forms.Label enable;
        private System.Windows.Forms.Label price;
        private System.Windows.Forms.Label service;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}