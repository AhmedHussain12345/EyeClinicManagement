namespace EyeClinicManagement.OPD
{
    partial class frm_opdadd
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
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.combo_DoctorsOPD = new System.Windows.Forms.ComboBox();
            this.btn_save = new System.Windows.Forms.Button();
            this.btn_posprint = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.box_amount = new System.Windows.Forms.TextBox();
            this.combo_eye = new System.Windows.Forms.ComboBox();
            this.combo_services = new System.Windows.Forms.ComboBox();
            this.box_cnic = new System.Windows.Forms.TextBox();
            this.box_contact = new System.Windows.Forms.TextBox();
            this.box_remarks = new System.Windows.Forms.TextBox();
            this.box_rate = new System.Windows.Forms.TextBox();
            this.box_patiendR = new System.Windows.Forms.TextBox();
            this.box_age = new System.Windows.Forms.TextBox();
            this.box_slip = new System.Windows.Forms.TextBox();
            this.box_sdh = new System.Windows.Forms.TextBox();
            this.box_name = new System.Windows.Forms.TextBox();
            this.richbox_address = new System.Windows.Forms.RichTextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_date = new System.Windows.Forms.Label();
            this.Back = new System.Windows.Forms.Button();
            this.lbl_addopd = new System.Windows.Forms.Label();
            this.box_gender = new System.Windows.Forms.ComboBox();
            this.btn_upload = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePicker1.Location = new System.Drawing.Point(234, 168);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(163, 30);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // combo_DoctorsOPD
            // 
            this.combo_DoctorsOPD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_DoctorsOPD.FormattingEnabled = true;
            this.combo_DoctorsOPD.Items.AddRange(new object[] {
            "Anwar",
            "Lateef"});
            this.combo_DoctorsOPD.Location = new System.Drawing.Point(431, 212);
            this.combo_DoctorsOPD.Name = "combo_DoctorsOPD";
            this.combo_DoctorsOPD.Size = new System.Drawing.Size(318, 33);
            this.combo_DoctorsOPD.TabIndex = 2;
            // 
            // btn_save
            // 
            this.btn_save.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_save.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_save.Location = new System.Drawing.Point(628, 701);
            this.btn_save.Name = "btn_save";
            this.btn_save.Size = new System.Drawing.Size(161, 52);
            this.btn_save.TabIndex = 14;
            this.btn_save.Text = "Save";
            this.btn_save.UseVisualStyleBackColor = false;
            this.btn_save.Click += new System.EventHandler(this.btn_save_Click);
            // 
            // btn_posprint
            // 
            this.btn_posprint.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_posprint.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_posprint.Location = new System.Drawing.Point(829, 701);
            this.btn_posprint.Name = "btn_posprint";
            this.btn_posprint.Size = new System.Drawing.Size(161, 52);
            this.btn_posprint.TabIndex = 15;
            this.btn_posprint.Text = "POS Print";
            this.btn_posprint.UseVisualStyleBackColor = false;
            this.btn_posprint.Click += new System.EventHandler(this.btn_posprint_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button7.Location = new System.Drawing.Point(1031, 701);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(161, 52);
            this.button7.TabIndex = 107;
            this.button7.Text = "Clear";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(1412, 222);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(335, 204);
            this.pictureBox1.TabIndex = 105;
            this.pictureBox1.TabStop = false;
            // 
            // box_amount
            // 
            this.box_amount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_amount.Location = new System.Drawing.Point(934, 518);
            this.box_amount.Name = "box_amount";
            this.box_amount.Size = new System.Drawing.Size(191, 34);
            this.box_amount.TabIndex = 104;
            // 
            // combo_eye
            // 
            this.combo_eye.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_eye.FormattingEnabled = true;
            this.combo_eye.Items.AddRange(new object[] {
            "Left",
            "Right"});
            this.combo_eye.Location = new System.Drawing.Point(628, 518);
            this.combo_eye.Name = "combo_eye";
            this.combo_eye.Size = new System.Drawing.Size(121, 33);
            this.combo_eye.TabIndex = 13;
            // 
            // combo_services
            // 
            this.combo_services.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combo_services.FormattingEnabled = true;
            this.combo_services.Items.AddRange(new object[] {
            "PHACO+IOL      300.00",
            "ECCE+IOL          300.00",
            "Eye OPD             0.00",
            "Yag Laser           100.00",
            "PTYREGIUM        0.00",
            "CHELAZION        0.00"});
            this.combo_services.Location = new System.Drawing.Point(234, 518);
            this.combo_services.Name = "combo_services";
            this.combo_services.Size = new System.Drawing.Size(388, 33);
            this.combo_services.TabIndex = 12;
            // 
            // box_cnic
            // 
            this.box_cnic.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_cnic.Location = new System.Drawing.Point(234, 427);
            this.box_cnic.Name = "box_cnic";
            this.box_cnic.Size = new System.Drawing.Size(515, 34);
            this.box_cnic.TabIndex = 7;
            // 
            // box_contact
            // 
            this.box_contact.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_contact.Location = new System.Drawing.Point(987, 176);
            this.box_contact.Name = "box_contact";
            this.box_contact.Size = new System.Drawing.Size(367, 34);
            this.box_contact.TabIndex = 8;
            // 
            // box_remarks
            // 
            this.box_remarks.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_remarks.Location = new System.Drawing.Point(987, 354);
            this.box_remarks.Name = "box_remarks";
            this.box_remarks.Size = new System.Drawing.Size(367, 34);
            this.box_remarks.TabIndex = 11;
            // 
            // box_rate
            // 
            this.box_rate.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_rate.Location = new System.Drawing.Point(758, 519);
            this.box_rate.Name = "box_rate";
            this.box_rate.Size = new System.Drawing.Size(170, 34);
            this.box_rate.TabIndex = 97;
            // 
            // box_patiendR
            // 
            this.box_patiendR.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_patiendR.Location = new System.Drawing.Point(987, 305);
            this.box_patiendR.Name = "box_patiendR";
            this.box_patiendR.Size = new System.Drawing.Size(367, 34);
            this.box_patiendR.TabIndex = 10;
            // 
            // box_age
            // 
            this.box_age.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_age.Location = new System.Drawing.Point(234, 343);
            this.box_age.Name = "box_age";
            this.box_age.Size = new System.Drawing.Size(515, 34);
            this.box_age.TabIndex = 5;
            // 
            // box_slip
            // 
            this.box_slip.Enabled = false;
            this.box_slip.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_slip.Location = new System.Drawing.Point(234, 214);
            this.box_slip.Name = "box_slip";
            this.box_slip.Size = new System.Drawing.Size(163, 34);
            this.box_slip.TabIndex = 94;
            // 
            // box_sdh
            // 
            this.box_sdh.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_sdh.Location = new System.Drawing.Point(234, 300);
            this.box_sdh.Name = "box_sdh";
            this.box_sdh.Size = new System.Drawing.Size(515, 34);
            this.box_sdh.TabIndex = 4;
            // 
            // box_name
            // 
            this.box_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_name.Location = new System.Drawing.Point(234, 257);
            this.box_name.Name = "box_name";
            this.box_name.Size = new System.Drawing.Size(515, 34);
            this.box_name.TabIndex = 3;
            // 
            // richbox_address
            // 
            this.richbox_address.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richbox_address.Location = new System.Drawing.Point(987, 222);
            this.richbox_address.Name = "richbox_address";
            this.richbox_address.Size = new System.Drawing.Size(367, 69);
            this.richbox_address.TabIndex = 9;
            this.richbox_address.Text = "";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(1407, 176);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(147, 29);
            this.label20.TabIndex = 90;
            this.label20.Text = "Attach Photo";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(979, 484);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(94, 29);
            this.label19.TabIndex = 89;
            this.label19.Text = "Amount";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(810, 484);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 29);
            this.label18.TabIndex = 88;
            this.label18.Text = "Rate";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(658, 483);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(54, 29);
            this.label16.TabIndex = 86;
            this.label16.Text = "Eye";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(375, 483);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(106, 29);
            this.label15.TabIndex = 85;
            this.label15.Text = "Services";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(792, 357);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 29);
            this.label14.TabIndex = 84;
            this.label14.Text = "Remarks";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(791, 308);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(179, 29);
            this.label13.TabIndex = 83;
            this.label13.Text = "Patient referred";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(30, 343);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 29);
            this.label12.TabIndex = 82;
            this.label12.Text = "Age";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(791, 217);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(108, 29);
            this.label11.TabIndex = 81;
            this.label11.Text = "Address:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(792, 173);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 29);
            this.label10.TabIndex = 80;
            this.label10.Text = "Contact#";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(426, 168);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 29);
            this.label9.TabIndex = 79;
            this.label9.Text = "Dr.OPD";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 518);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(106, 29);
            this.label8.TabIndex = 78;
            this.label8.Text = "Services";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 303);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(153, 29);
            this.label7.TabIndex = 77;
            this.label7.Text = "S/O D/O H/O";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(31, 427);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 29);
            this.label5.TabIndex = 76;
            this.label5.Text = "CNIC:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 387);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(100, 29);
            this.label4.TabIndex = 75;
            this.label4.Text = "Gender:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(30, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 29);
            this.label3.TabIndex = 74;
            this.label3.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 222);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 73;
            this.label2.Text = "Slip No:";
            // 
            // lbl_date
            // 
            this.lbl_date.AutoSize = true;
            this.lbl_date.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_date.Location = new System.Drawing.Point(30, 170);
            this.lbl_date.Name = "lbl_date";
            this.lbl_date.Size = new System.Drawing.Size(69, 29);
            this.lbl_date.TabIndex = 72;
            this.lbl_date.Text = "Date:";
            // 
            // Back
            // 
            this.Back.BackColor = System.Drawing.SystemColors.WindowText;
            this.Back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Back.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Back.ForeColor = System.Drawing.SystemColors.Window;
            this.Back.Location = new System.Drawing.Point(1646, 50);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(101, 50);
            this.Back.TabIndex = 71;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = false;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // lbl_addopd
            // 
            this.lbl_addopd.AutoSize = true;
            this.lbl_addopd.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addopd.Location = new System.Drawing.Point(741, 40);
            this.lbl_addopd.Name = "lbl_addopd";
            this.lbl_addopd.Size = new System.Drawing.Size(247, 54);
            this.lbl_addopd.TabIndex = 70;
            this.lbl_addopd.Text = "OPD Form";
            // 
            // box_gender
            // 
            this.box_gender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.box_gender.FormattingEnabled = true;
            this.box_gender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.box_gender.Location = new System.Drawing.Point(234, 386);
            this.box_gender.Name = "box_gender";
            this.box_gender.Size = new System.Drawing.Size(515, 33);
            this.box_gender.TabIndex = 6;
            // 
            // btn_upload
            // 
            this.btn_upload.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btn_upload.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_upload.Location = new System.Drawing.Point(1586, 450);
            this.btn_upload.Name = "btn_upload";
            this.btn_upload.Size = new System.Drawing.Size(161, 52);
            this.btn_upload.TabIndex = 108;
            this.btn_upload.Text = "Upload";
            this.btn_upload.UseVisualStyleBackColor = false;
            this.btn_upload.Click += new System.EventHandler(this.btn_upload_Click);
            // 
            // frm_opdadd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1784, 797);
            this.Controls.Add(this.btn_upload);
            this.Controls.Add(this.box_gender);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.combo_DoctorsOPD);
            this.Controls.Add(this.btn_save);
            this.Controls.Add(this.btn_posprint);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.box_amount);
            this.Controls.Add(this.combo_eye);
            this.Controls.Add(this.combo_services);
            this.Controls.Add(this.box_cnic);
            this.Controls.Add(this.box_contact);
            this.Controls.Add(this.box_remarks);
            this.Controls.Add(this.box_rate);
            this.Controls.Add(this.box_patiendR);
            this.Controls.Add(this.box_age);
            this.Controls.Add(this.box_slip);
            this.Controls.Add(this.box_sdh);
            this.Controls.Add(this.box_name);
            this.Controls.Add(this.richbox_address);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lbl_date);
            this.Controls.Add(this.Back);
            this.Controls.Add(this.lbl_addopd);
            this.Name = "frm_opdadd";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frm_opdadd";
            this.Load += new System.EventHandler(this.frm_opdadd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.ComboBox combo_DoctorsOPD;
        private System.Windows.Forms.Button btn_save;
        private System.Windows.Forms.Button btn_posprint;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox box_amount;
        private System.Windows.Forms.ComboBox combo_eye;
        private System.Windows.Forms.ComboBox combo_services;
        private System.Windows.Forms.TextBox box_cnic;
        private System.Windows.Forms.TextBox box_contact;
        private System.Windows.Forms.TextBox box_remarks;
        private System.Windows.Forms.TextBox box_rate;
        private System.Windows.Forms.TextBox box_patiendR;
        private System.Windows.Forms.TextBox box_age;
        private System.Windows.Forms.TextBox box_slip;
        private System.Windows.Forms.TextBox box_sdh;
        private System.Windows.Forms.TextBox box_name;
        private System.Windows.Forms.RichTextBox richbox_address;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_date;
        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Label lbl_addopd;
        private System.Windows.Forms.ComboBox box_gender;
        private System.Windows.Forms.Button btn_upload;
    }
}