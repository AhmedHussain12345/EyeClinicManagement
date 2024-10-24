using iText.Kernel.Exceptions;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;


namespace EyeClinicManagement.Reports
{
    public partial class frm_reportadd : Form
    {
        tblOpd model = new tblOpd();
        tblService model2 = new tblService();
        tblDoctor model3 = new tblDoctor();
        EyeClinicEntities1 db = new EyeClinicEntities1();

        public frm_reportadd()
        {
            InitializeComponent();
            LoadConsultantData();
            LoadServiceData();
            LoadPaymentData();
        }

        private void LoadConsultantData()
        {
            comboBox_doctor.DataSource = db.tblDoctors.ToList();
            comboBox_doctor.ValueMember = "ID";
            comboBox_doctor.DisplayMember = "Name";
        }

        private void LoadServiceData()
        {
            comboBox_service.DataSource = db.tblServices.ToList();
            comboBox_service.ValueMember = "ID";
            comboBox_service.DisplayMember = "opdservice";
        }

        private void LoadPaymentData()
        {
            comboBox_expense.DataSource = db.tblOpds.ToList();
            comboBox_expense.ValueMember = "ID";
            comboBox_expense.DisplayMember = "Amount";
        }

        private void btn_staticalreports_Click(object sender, EventArgs e)
        {
            // Retrieve selected values from the dropdowns and date pickers
            int selectedDoctorId = (int)comboBox_doctor.SelectedValue;
            int selectedServiceId = (int)comboBox_service.SelectedValue;

            // Set the date range for the current month
            DateTime fromDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 1);
            DateTime toDate = fromDate.AddMonths(1); // First day of the next month

            // Query the database for reports
            var reports = (
                from opd in db.tblOpds
                join doc in db.tblDoctors on opd.Doctoropd equals doc.ID
                join svc in db.tblServices on opd.Services equals svc.ID.ToString()
                where opd.Doctoropd == selectedDoctorId &&
                      svc.ID == selectedServiceId &&
                      opd.Date >= fromDate && opd.Date < toDate
                select new
                {
                    DoctorName = doc.Name,
                    ServiceName = svc.opdservice,
                    opd.Amount,
                    opd.Date
                }).ToList();

            // Check if any records were found
            if (!reports.Any())
            {
                MessageBox.Show("No records found for the selected criteria.");
                return;
            }

            // Generate the PDF report
            CreatePdfReport(reports);
        }

        private void CreatePdfReport(IEnumerable<dynamic> reports)
        {
            try
            {
                // Specify the directory to save the PDF
                string pdfDirectory = Path.Combine(Application.StartupPath, "Reports");

                // Create the directory if it doesn't exist
                if (!Directory.Exists(pdfDirectory))
                {
                    Directory.CreateDirectory(pdfDirectory);
                }

                // Set the file name and path for the PDF
                string fileName = "Report.pdf";
                string filePath = Path.Combine(pdfDirectory, fileName);

                // Ensure the file does not already exist before writing
                if (File.Exists(filePath))
                {
                    File.Delete(filePath); // Optionally delete the existing file
                }

                // Create the PDF writer
                using (var writer = new PdfWriter(filePath))
                using (var pdf = new PdfDocument(writer))
                {
                    var document = new Document(pdf);

                    // Add a title
                    document.Add(new Paragraph("Report")
                        .SetFontSize(20).SetBold());

                    // Create a table for the report data
                    var table = new Table(4); // Assuming 4 columns

                    // Add headers
                    table.AddHeaderCell("Doctor Name");
                    table.AddHeaderCell("Service Name");
                    table.AddHeaderCell("Amount");
                    table.AddHeaderCell("Date");

                    // Add rows
                    foreach (var report in reports)
                    {
                        // Validate data before adding to the table
                        if (report.DoctorName == null || report.ServiceName == null)
                        {
                            MessageBox.Show("Report contains invalid data.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        table.AddCell(report.DoctorName ?? "N/A");
                        table.AddCell(report.ServiceName ?? "N/A");
                        table.AddCell(report.Amount.ToString("F2")); // Format to 2 decimal places
                        table.AddCell(report.Date.ToString("d")); // Format the date
                    }

                    document.Add(table);
                    document.Close();
                }

                // Open the PDF file after creation
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo
                {
                    FileName = filePath,
                    UseShellExecute = true
                });
            }
            catch (PdfException pdfEx)
            {
                MessageBox.Show($"PDF error: {pdfEx.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
    }
}
