using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;

namespace EyeClinicManagement.Doctor
{
    public partial class frm_doctoradd : Form
    {
        tblDoctor model = new tblDoctor();
        EyeClinicEntities1 db = new EyeClinicEntities1();
        int studentId = 0;
        string dbImagePath = string.Empty;
        public frm_doctoradd(int id)
        {
            studentId= id;
            InitializeComponent();
            PopulateData();
        }

        public void PopulateData()
        {
            if (studentId > 0)
            {
                btn_docsubmit.Text = "Update";
                var student = db.tblDoctors.Find(studentId);
                textBox_name.Text = student.Name;
                textBox_age.Text = student.Age.ToString();
                textBox_phone.Text = student.Phone;
                textBox_specialization.Text = student.Specialization;
                richTextBox_address.Text = student.Address;
                richTextBox_msg.Text = student.Message;
                ///  c:llkj/llklj/lkjlkj/bin/1.jpeg
                ///  c:llkj/llklj/lkjlkj/bin/2.jpeg

            }
        }


        private void btn_docsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateForm())
                {
                    model.Name = textBox_name.Text.Trim();
                    model.Age = int.Parse(textBox_age.Text.Trim());
                    model.Phone = textBox_phone.Text.Trim();
                    model.Specialization = textBox_specialization.Text.Trim();
                    model.Address = richTextBox_address.Text.Trim();
                    model.Message = richTextBox_msg.Text.Trim();
                    model.Image = dbImagePath;

                    if (studentId > 0)
                    {
                        model.ID = studentId;
                        db.tblDoctors.AddOrUpdate(model);

                    }
                    else
                    {
                        db.tblDoctors.Add(model);
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message");
            }
        }

        private bool ValidateForm()
        {
            if (string.IsNullOrWhiteSpace(textBox_name.Text))
            {
                MessageBox.Show("Name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox_phone.Text))
            {
                MessageBox.Show("Phone is required.");
                return false;
            }
            return true;
        }

        private void frm_doctoradd_Load(object sender, EventArgs e)
        {
                
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_name.Clear();
            textBox_age.Clear();
            textBox_phone.Clear();
            textBox_specialization.Clear();
            richTextBox_address.Clear();
            richTextBox_msg.Clear();
        }

        private void btnUpload_Click(object sender, EventArgs e)
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

            var imagePath = (Application.StartupPath + "doctorsImage");
            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }

            string fileName = Path.GetFileName(dialog.FileName);

            


            string saveImagePath = imagePath + "/" + fileName;

            // Save the image
            newImage.Save(saveImagePath);
            dbImagePath = saveImagePath;
            pictureBox1.ImageLocation = saveImagePath;

        }
    }
}
