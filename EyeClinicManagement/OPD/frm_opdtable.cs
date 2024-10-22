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

namespace EyeClinicManagement.OPD
{
    public partial class frm_opdtable : Form
    {
        tblOpd model = new tblOpd();
        EyeClinicEntities1 db = new EyeClinicEntities1();
        int id = 0;
        public frm_opdtable()
        {
            InitializeComponent();
            DataGrid();
        }

        private void btn_addopd_Click(object sender, EventArgs e)
        {
            OPD.frm_opdadd form = new OPD.frm_opdadd(0);
            form.ShowDialog();
            DataGrid();
        }

        private void btn_backopd_Click(object sender, EventArgs e)
        {
            MainScreen.frm_mainscreen form = new MainScreen.frm_mainscreen();
            form.ShowDialog();
        }

        void DataGrid()
        {
            tbl_opd.DataSource = db.tblOpds.ToList();
        }

        private void tbl_opd_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(tbl_opd.Rows[e.RowIndex].Cells[0].Value);
        }

        private void Update_Click(object sender, EventArgs e)
        {
            OPD.frm_opdadd form = new OPD.frm_opdadd(id);
            form.ShowDialog();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete it?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                model = db.tblOpds.Where(x => x.ID == id).FirstOrDefault();
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
