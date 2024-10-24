using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace EyeClinicManagement.Reports
{
    public partial class frm_reporttable : Form
    {
        private IEnumerable<dynamic> reports; // Store the reports data

        // Constructor accepting report data
        public frm_reporttable(IEnumerable<dynamic> reportData)
        {
            InitializeComponent();
            reports = reportData; // Assign the report data
            LoadData(); // Call method to load data into DataGridView
        }

        // Method to load data into the DataGridView
        private void LoadData()
        {
            dataGridView1.AutoGenerateColumns = true;
            dataGridView1.DataSource = reports.ToList(); // Convert to list for DataGridView
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Handle cell clicks if needed, but no need to set DataSource here
        }
    }
}
