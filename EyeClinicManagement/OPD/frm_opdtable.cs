using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EyeClinicManagement.OPD
{
    public partial class frm_opdtable : Form
    {
        public frm_opdtable()
        {
            InitializeComponent();
        }

        private void btn_addopd_Click(object sender, EventArgs e)
        {
            OPD.frm_opdadd form = new OPD.frm_opdadd();
            form.ShowDialog();
        }

        private void btn_backopd_Click(object sender, EventArgs e)
        {
            MainScreen.frm_mainscreen form = new MainScreen.frm_mainscreen();
            form.ShowDialog();
        }
    }
}
