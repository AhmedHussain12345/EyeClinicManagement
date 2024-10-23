using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EyeClinicManagement.PrintToken;


namespace EyeClinicManagement.OPD
{
    public partial class frm_opdadd : Form
    {

        tblOpd model = new tblOpd();
        tblService model2 = new tblService();
        tblDoctor model3 = new tblDoctor();
        EyeClinicEntities1 db = new EyeClinicEntities1();
        int studentId = 0;
        string dbImagePath = string.Empty;
        //  string dbImagePath = string.Empty;
        public frm_opdadd(int id)
        {
            studentId = id;
            InitializeComponent();
            PopulateData();
            ServiceData();
            DoctorData();
        }

        public void PopulateData()
        {
            if (studentId > 0)
            {
                btn_save.Text = "Update";
                var student = db.tblOpds.Find(studentId);
                box_slip.Text = student.ID.ToString();
                box_name.Text = student.Name;
                box_sdh.Text = student.Relation;
                box_age.Text = student.Age.ToString();
                box_gender.SelectedItem = student.Gender;
                box_cnic.Text = student.Cnic;
                box_contact.Text = student.Contact;
                richbox_address.Text = student.Address;
                combo_DoctorsOPD.SelectedItem = student.Doctoropd;
                box_patiendR.Text = student.Reffered;
                box_remarks.Text = student.Remarks;
                combo_services.SelectedValue = student.Services;
                combo_eye.SelectedItem = student.Eye;
                box_rate.Text = student.Rate.ToString();
                box_amount.Text = student.Amount.ToString();


            }
            else
            {
                box_slip.Text = (db.tblOpds.Count() + 1).ToString();
            }
        }

        private void ServiceData()
        {
            combo_services.DataSource = db.tblServices.ToList<tblService>();
            combo_services.ValueMember = "ID";
            combo_services.DisplayMember = "opdservice";
        }

        private void DoctorData()
        {
            combo_DoctorsOPD.DataSource = db.tblDoctors.ToList<tblDoctor>();
            combo_DoctorsOPD.ValueMember = "ID";
            combo_DoctorsOPD.DisplayMember = "Name";
        }

        private void Back_Click(object sender, EventArgs e)
        {
            OPD.frm_opdtable form = new OPD.frm_opdtable();
            form.ShowDialog();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {
            AddUpdateOPD();
        }

        private void AddUpdateOPD()
        {
            try
            {
                if (ValidateForm())
                {
                    {
                        model.Date = dateTimePicker1.Value;
                        model.Slipno = int.Parse(box_slip.Text.Trim());
                        model.Name = box_name.Text.Trim();
                        model.Relation = box_sdh.Text.Trim();
                        model.Age = int.Parse(box_age.Text.Trim());
                        model.Gender = box_gender.SelectedItem.ToString();
                        model.Cnic = box_cnic.Text.Trim();
                        model.Contact = box_contact.Text.Trim();
                        model.Address = richbox_address.Text.Trim();
                        model.Doctoropd = (int)combo_DoctorsOPD.SelectedValue;
                        model.Reffered = box_patiendR.Text.Trim();
                        model.Remarks = box_remarks.Text.Trim();
                        model.Services = combo_services.SelectedValue.ToString();
                        model.Eye = combo_eye.SelectedItem.ToString();
                        model.Rate = decimal.Parse(box_rate.Text.Trim());
                        model.Amount = decimal.Parse(box_amount.Text.Trim());
                        model.Image = dbImagePath;


                        if (studentId > 0)
                        {
                            model.ID = studentId;
                            db.tblOpds.AddOrUpdate(model);


                        }
                        else
                        {
                            db.tblOpds.Add(model);
                        }
                        int a = db.SaveChanges();
                        
                        if (a > 0)
                        {
                            MessageBox.Show("Data inserted Succsfully", "Message");
                        }
                        else
                        {
                            MessageBox.Show("Insertion Failed", "Message");
                        }

                        this.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(box_name.Text))
            {
                MessageBox.Show("Name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(box_age.Text))
            {
                MessageBox.Show("Age is required.");
                return false;
            }
            if (string.IsNullOrWhiteSpace(box_gender.Text))
            {
                MessageBox.Show("Gender is required.");
                return false;
            }
            return true;
        }


        private void button7_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Today;
            box_slip.Clear();
            box_name.Clear();
            box_sdh.Clear();
            box_age.Clear();
            box_gender.SelectedItem = null;
            box_cnic.Clear();
            box_contact.Clear();
            richbox_address.Clear();
            combo_DoctorsOPD.SelectedItem = null;
            box_patiendR.Clear();
            box_remarks.Clear();
            combo_services.SelectedValue = default;
            combo_eye.SelectedItem = null;
            box_rate.Clear();
            box_amount.Clear();


        }

        private void frm_opdadd_Load(object sender, EventArgs e)
        {

        }

        private void btn_upload_Click(object sender, EventArgs e)
        {

            //New file dialog object:
            OpenFileDialog dialog = new OpenFileDialog();
            //Accept images for files only:
            dialog.Filter = "Image files (*.jpg, *.jpeg, *.jpe, *.jfif, *.png) | *.jpg; *.jpeg; *.jpe; *.jfif; *.png";
            dialog.ShowDialog();
            Image newImage = Image.FromFile(dialog.FileName);
            // now, instead of creating a second instance of Form1,
            // pass the image to the existing instance.

            if (string.IsNullOrEmpty(dialog.FileName))
                return;

            var imagePath = (Application.StartupPath + "opdImage");
            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }

            string fileName = (db.tblOpds.Count() + 1) + Path.GetExtension(dialog.FileName);




            string saveImagePath = imagePath + "/" + fileName;

            // Save the image
            newImage.Save(saveImagePath);
            dbImagePath = saveImagePath;
            pictureBox1.ImageLocation = saveImagePath;

        }

        private void btn_posprint_Click(object sender, EventArgs e)
        {
            try
            {
                // Prepare the receipt details from the model
                AddUpdateOPD();
                PrintDocument printDocument = new PrintDocument();
                printDocument.PrintPage += (s, ev) => PrintHelper.CreateReceipt(s, ev, model);

                PrintDialog printDialog = new PrintDialog
                {
                    Document = printDocument
                };

                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    printDocument.Print();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error printing receipt: " + ex.Message);
            }
        }
    }
}


