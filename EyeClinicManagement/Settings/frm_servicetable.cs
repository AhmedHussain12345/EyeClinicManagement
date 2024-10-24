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

namespace EyeClinicManagement.Settings
{
    public partial class frm_servicetable : Form
    {
        int id = 0;
        tblService model = new tblService();
        EyeClinicEntities1 db = new EyeClinicEntities1();
        public frm_servicetable()
        {
            InitializeComponent();
            DataGrid();
        }

        void DataGrid()
        {
            tbl_service.DataSource = db.tblServices.Select(service => new { service.ID, Title = service.opdservice, service.Price, Enabled = service.Enabled ? "Yes" : "No" }).ToList();
        }

        private void tbl_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addopd_Click(object sender, EventArgs e)
        {
            Settings.frm_serviceadd form = new Settings.frm_serviceadd(0);
            form.ShowDialog();
            DataGrid();
        }

        private void btn_backservice_Click(object sender, EventArgs e)
        {
            MainScreen.frm_mainscreen form = new MainScreen.frm_mainscreen();
            form.ShowDialog();
        }

        private void Update_Click(object sender, EventArgs e)
        {
            Settings.frm_serviceadd frm = new Settings.frm_serviceadd(id);
            frm.ShowDialog();
        }

        private void tbl_service_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            id = Convert.ToInt32(tbl_service.Rows[e.RowIndex].Cells[0].Value);
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Are you sure to delete it?", "Alert", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dr == DialogResult.Yes)
            {
                model = db.tblServices.Where(x => x.ID == id).FirstOrDefault();
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
