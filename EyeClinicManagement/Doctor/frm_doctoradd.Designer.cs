namespace EyeClinicManagement.Doctor
{
    partial class frm_doctoradd
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
            this.lbl_docfrmheading = new System.Windows.Forms.Label();
            this.btn_docsubmit = new System.Windows.Forms.Button();
            this.richTextBox_address = new System.Windows.Forms.RichTextBox();
            this.richTextBox_msg = new System.Windows.Forms.RichTextBox();
            this.textBox_specialization = new System.Windows.Forms.TextBox();
            this.textBox_age = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.doc_msg = new System.Windows.Forms.Label();
            this.doc_address = new System.Windows.Forms.Label();
            this.doc_phone = new System.Windows.Forms.Label();
            this.doc_age = new System.Windows.Forms.Label();
            this.doc_specialization = new System.Windows.Forms.Label();
            this.doc_name = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_docfrmheading
            // 
            this.lbl_docfrmheading.AutoSize = true;
            this.lbl_docfrmheading.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_docfrmheading.Location = new System.Drawing.Point(172, 27);
            this.lbl_docfrmheading.Name = "lbl_docfrmheading";
            this.lbl_docfrmheading.Size = new System.Drawing.Size(308, 54);
            this.lbl_docfrmheading.TabIndex = 27;
            this.lbl_docfrmheading.Text = "Doctors Form";
            // 
            // btn_docsubmit
            // 
            this.btn_docsubmit.BackColor = System.Drawing.Color.CornflowerBlue;
            this.btn_docsubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_docsubmit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_docsubmit.ForeColor = System.Drawing.SystemColors.Window;
            this.btn_docsubmit.Location = new System.Drawing.Point(344, 571);
            this.btn_docsubmit.Name = "btn_docsubmit";
            this.btn_docsubmit.Size = new System.Drawing.Size(158, 51);
            this.btn_docsubmit.TabIndex = 7;
            this.btn_docsubmit.Text = "Submit";
            this.btn_docsubmit.UseVisualStyleBackColor = false;
            this.btn_docsubmit.Click += new System.EventHandler(this.btn_docsubmit_Click);
            // 
            // richTextBox_address
            // 
            this.richTextBox_address.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox_address.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_address.Location = new System.Drawing.Point(234, 322);
            this.richTextBox_address.Name = "richTextBox_address";
            this.richTextBox_address.Size = new System.Drawing.Size(385, 96);
            this.richTextBox_address.TabIndex = 5;
            this.richTextBox_address.Text = "";
            // 
            // richTextBox_msg
            // 
            this.richTextBox_msg.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.richTextBox_msg.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.richTextBox_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBox_msg.Location = new System.Drawing.Point(234, 433);
            this.richTextBox_msg.Name = "richTextBox_msg";
            this.richTextBox_msg.Size = new System.Drawing.Size(385, 96);
            this.richTextBox_msg.TabIndex = 6;
            this.richTextBox_msg.Text = "";
            // 
            // textBox_specialization
            // 
            this.textBox_specialization.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_specialization.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_specialization.Location = new System.Drawing.Point(234, 276);
            this.textBox_specialization.Name = "textBox_specialization";
            this.textBox_specialization.Size = new System.Drawing.Size(385, 34);
            this.textBox_specialization.TabIndex = 4;
            // 
            // textBox_age
            // 
            this.textBox_age.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_age.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_age.Location = new System.Drawing.Point(234, 179);
            this.textBox_age.Name = "textBox_age";
            this.textBox_age.Size = new System.Drawing.Size(385, 34);
            this.textBox_age.TabIndex = 2;
            // 
            // textBox_phone
            // 
            this.textBox_phone.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_phone.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_phone.Location = new System.Drawing.Point(234, 228);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(385, 34);
            this.textBox_phone.TabIndex = 3;
            // 
            // textBox_name
            // 
            this.textBox_name.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox_name.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_name.Location = new System.Drawing.Point(234, 135);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(385, 34);
            this.textBox_name.TabIndex = 1;
            // 
            // doc_msg
            // 
            this.doc_msg.AutoSize = true;
            this.doc_msg.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_msg.Location = new System.Drawing.Point(34, 438);
            this.doc_msg.Name = "doc_msg";
            this.doc_msg.Size = new System.Drawing.Size(112, 29);
            this.doc_msg.TabIndex = 19;
            this.doc_msg.Text = "Message";
            // 
            // doc_address
            // 
            this.doc_address.AutoSize = true;
            this.doc_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_address.Location = new System.Drawing.Point(34, 327);
            this.doc_address.Name = "doc_address";
            this.doc_address.Size = new System.Drawing.Size(102, 29);
            this.doc_address.TabIndex = 18;
            this.doc_address.Text = "Address";
            // 
            // doc_phone
            // 
            this.doc_phone.AutoSize = true;
            this.doc_phone.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_phone.Location = new System.Drawing.Point(34, 233);
            this.doc_phone.Name = "doc_phone";
            this.doc_phone.Size = new System.Drawing.Size(83, 29);
            this.doc_phone.TabIndex = 17;
            this.doc_phone.Text = "Phone";
            // 
            // doc_age
            // 
            this.doc_age.AutoSize = true;
            this.doc_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_age.Location = new System.Drawing.Point(34, 184);
            this.doc_age.Name = "doc_age";
            this.doc_age.Size = new System.Drawing.Size(56, 29);
            this.doc_age.TabIndex = 16;
            this.doc_age.Text = "Age";
            // 
            // doc_specialization
            // 
            this.doc_specialization.AutoSize = true;
            this.doc_specialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_specialization.Location = new System.Drawing.Point(34, 281);
            this.doc_specialization.Name = "doc_specialization";
            this.doc_specialization.Size = new System.Drawing.Size(163, 29);
            this.doc_specialization.TabIndex = 15;
            this.doc_specialization.Text = "Specialization";
            // 
            // doc_name
            // 
            this.doc_name.AutoSize = true;
            this.doc_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.doc_name.Location = new System.Drawing.Point(34, 140);
            this.doc_name.Name = "doc_name";
            this.doc_name.Size = new System.Drawing.Size(78, 29);
            this.doc_name.TabIndex = 14;
            this.doc_name.Text = "Name";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(683, 198);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(306, 283);
            this.pictureBox1.TabIndex = 28;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(678, 140);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(172, 29);
            this.label1.TabIndex = 29;
            this.label1.Text = "Upload Picture";
            // 
            // frm_doctoradd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1023, 663);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lbl_docfrmheading);
            this.Controls.Add(this.btn_docsubmit);
            this.Controls.Add(this.richTextBox_address);
            this.Controls.Add(this.richTextBox_msg);
            this.Controls.Add(this.textBox_specialization);
            this.Controls.Add(this.textBox_age);
            this.Controls.Add(this.textBox_phone);
            this.Controls.Add(this.textBox_name);
            this.Controls.Add(this.doc_msg);
            this.Controls.Add(this.doc_address);
            this.Controls.Add(this.doc_phone);
            this.Controls.Add(this.doc_age);
            this.Controls.Add(this.doc_specialization);
            this.Controls.Add(this.doc_name);
            this.Name = "frm_doctoradd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_doctoradd";
            this.Load += new System.EventHandler(this.frm_doctoradd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_docfrmheading;
        private System.Windows.Forms.Button btn_docsubmit;
        private System.Windows.Forms.RichTextBox richTextBox_address;
        private System.Windows.Forms.RichTextBox richTextBox_msg;
        private System.Windows.Forms.TextBox textBox_specialization;
        private System.Windows.Forms.TextBox textBox_age;
        private System.Windows.Forms.TextBox textBox_phone;
        private System.Windows.Forms.TextBox textBox_name;
        private System.Windows.Forms.Label doc_msg;
        private System.Windows.Forms.Label doc_address;
        private System.Windows.Forms.Label doc_phone;
        private System.Windows.Forms.Label doc_age;
        private System.Windows.Forms.Label doc_specialization;
        private System.Windows.Forms.Label doc_name;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
    }
}