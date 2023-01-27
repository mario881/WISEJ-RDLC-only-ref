
using System;
using System.IO;
using Wisej.Web;

#if NET7_0
using Microsoft.Reporting.NETCore;
#endif

#if NET48
using Microsoft.Reporting.WinForms;
#endif

namespace WisejWebDesktopApplication1
{
    public partial class Window1 : mmForm
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var report = new LocalReport();

            var items = new[] { new ReportItem { Description = "Widget 6000", Price = 104.99m, Qty = 1 }, new ReportItem { Description = "Gizmo MAX", Price = 1.41m, Qty = 25 } };
            var parameters = new[] { new ReportParameter("Title", "Invoice 4/2020") };
            using var fs = new FileStream("Report.rdlc", FileMode.Open);
            report.LoadReportDefinition(fs);
            report.DataSources.Add(new ReportDataSource("Items", items));
            report.SetParameters(parameters);

            byte[] buffer = report.Render("PDF", null);// x.Render("PDF",null); Excel, PDF, Word, and Image
            Application.DownloadAndOpen("_blank", new System.IO.MemoryStream(buffer), "Stampa.pdf");
            //pdfViewer1.PdfStream = new System.IO.MemoryStream(buffer);

            frmPdfViewer viewer= new frmPdfViewer();
            viewer.init(new System.IO.MemoryStream(buffer));
            viewer.Show();
        }

    }
}
