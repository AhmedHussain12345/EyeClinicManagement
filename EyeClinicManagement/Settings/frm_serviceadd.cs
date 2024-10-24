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

namespace EyeClinicManagement.Settings
{
    public partial class frm_serviceadd : Form
    {
        tblService model = new tblService();
        EyeClinicEntities1 db = new EyeClinicEntities1();
        int studentId = 0;
        public frm_serviceadd(int id)
        {
            InitializeComponent();
            studentId = id;
            PopulateData();
        }

        public void PopulateData()
        {
            if (studentId > 0)
            {
                btn_docsubmit.Text = "Update";
                var student = db.tblServices.Find(studentId);
                textBox_service.Text = student.opdservice;
                textBox_price.Text = student.Price.ToString();
                comboBox1.SelectedValue = student.Enabled;
            }
        }


        private void btn_docsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (ValidateForm())
                {
                    model.opdservice = textBox_service.Text.Trim();
                    model.Price = int.Parse(textBox_price.Text.Trim());
                    model.Enabled = comboBox1.SelectedItem?.ToString() == "Yes" ? true : false;
                    //model.Enabled = comboBox1.Enabled.Equals(true);
                  


                    if (studentId > 0)
                    {
                        model.ID = studentId;
                        db.tblServices.AddOrUpdate(model);

                    }
                    else
                    {
                        db.tblServices.Add(model);
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
            if (string.IsNullOrWhiteSpace(textBox_service.Text))
            {
                MessageBox.Show("Name is required.");
                return false;
            }

            if (string.IsNullOrWhiteSpace(textBox_price.Text))
            {
                MessageBox.Show("Phone is required.");
                return false;
            }
            return true;
        }

        private void Clear_Click(object sender, EventArgs e)
        {
            textBox_service.Clear();
            textBox_price.Clear();
            comboBox1.Enabled = false;
        }
    }
}
