using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Migrations;
using System.Drawing;
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
        EyeClinicEntities db = new EyeClinicEntities();
        int studentId = 0;

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


            }
        }


        private void btn_docsubmit_Click(object sender, EventArgs e)
        {
            model.Name = textBox_name.Text.Trim();
            model.Age = int.Parse(textBox_age.Text.Trim());
            model.Phone = textBox_phone.Text.Trim();
            model.Specialization = textBox_specialization.Text.Trim();
            model.Address = richTextBox_address.Text.Trim();
            model.Message = richTextBox_msg.Text.Trim();
            
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

        private void frm_doctoradd_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
