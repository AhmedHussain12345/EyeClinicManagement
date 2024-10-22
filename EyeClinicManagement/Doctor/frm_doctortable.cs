using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;





namespace EyeClinicManagement.Doctor
{
    public partial class frm_doctortable : Form
    {
        int id = 0;
        tblDoctor model = new tblDoctor();
        EyeClinicEntities1 db = new EyeClinicEntities1();
       
        public frm_doctortable()
        {
            InitializeComponent();
            DataGrid();
        }

        private void btn_adddoctor_Click(object sender, EventArgs e)
        {
            Doctor.frm_doctoradd form = new Doctor.frm_doctoradd(0);
            form.ShowDialog();
            DataGrid();
        }

        private void btn_backdoctor_Click(object sender, EventArgs e)
        {
            MainScreen.frm_mainscreen form= new MainScreen.frm_mainscreen();
            form.ShowDialog();
        }

        void DataGrid()
        {
            tbl_doctor.DataSource = db.tblDoctors.ToList<tblDoctor>();
        }

        private void tbl_doctor_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(tbl_doctor.Rows[e.RowIndex].Cells[0].Value);
            
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Doctor.frm_doctoradd form = new Doctor.frm_doctoradd(id);
            form.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete it?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                model = db.tblDoctors.Where(x => x.ID == id).FirstOrDefault();
                db.Entry(model).State = EntityState.Deleted;
                int a = db.SaveChanges();

                if (a > 0)
                {
                    MessageBox.Show("Deleted Successfullty", "Message");
                }
                else
                {
                    MessageBox.Show("Delete Failed!", "Message");
                }
                DataGrid();
            }
            else
            {
                MessageBox.Show("You have cancel the delete operation", "Message");
            }
            DataGrid();

        }
    }
}
