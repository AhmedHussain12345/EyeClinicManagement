using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeClinicManagement.Settings
{
    public partial class frm_servicetable : Form
    {
        tblService model = new tblService();
        EyeClinicEntities1 db = new EyeClinicEntities1();
        public frm_servicetable()
        {
            InitializeComponent();
            DataGrid();
        }

        void DataGrid()
        {
            tbl_service.DataSource = db.tblServices.ToList<tblService>();
        }

        private void tbl_service_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_addopd_Click(object sender, EventArgs e)
        {
            Settings.frm_serviceadd form = new Settings.frm_serviceadd();
            form.ShowDialog();
            DataGrid();
        }
    }
}
