using System;
using System.IO;
using Wisej.Web;

namespace WisejWebDesktopApplication1
{
    public partial class frmPdfViewer : mmForm
    {
        public frmPdfViewer()
        {
            InitializeComponent();
        }

        public void init(Stream s)
        {
            pdfViewer1.PdfStream = s;
        }
    }
}
