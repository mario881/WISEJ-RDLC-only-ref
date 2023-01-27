namespace WisejWebDesktopApplication1
{
    partial class Window1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Wisej Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new Wisej.Web.Button();
            this.iFramePanel1 = new Wisej.Web.IFramePanel();
            this.pdfViewer1 = new Wisej.Web.PdfViewer();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(64, 40);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 37);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iFramePanel1
            // 
            this.iFramePanel1.BorderStyle = Wisej.Web.BorderStyle.Solid;
            this.iFramePanel1.Location = new System.Drawing.Point(258, 24);
            this.iFramePanel1.Name = "iFramePanel1";
            this.iFramePanel1.Size = new System.Drawing.Size(286, 238);
            this.iFramePanel1.TabIndex = 3;
            this.iFramePanel1.Text = "iFramePanel1";
            this.iFramePanel1.Url = "htmlpage.html";
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.Location = new System.Drawing.Point(75, 215);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.Size = new System.Drawing.Size(311, 175);
            this.pdfViewer1.TabIndex = 4;
            // 
            // Window1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 19F);
            this.AutoScaleMode = Wisej.Web.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 432);
            this.Controls.Add(this.pdfViewer1);
            this.Controls.Add(this.iFramePanel1);
            this.Controls.Add(this.button1);
            this.Name = "Window1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Wisej.Web.Button button1;
        private Wisej.Web.IFramePanel iFramePanel1;
        private Wisej.Web.PdfViewer pdfViewer1;
    }
}

