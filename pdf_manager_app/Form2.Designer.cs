namespace pdf_manager_app
{
    partial class Form2
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            pdfViewer1 = new Spire.PdfViewer.Forms.PdfViewer();
            SuspendLayout();
            // 
            // pdfViewer1
            // 
            pdfViewer1.Dock = DockStyle.Fill;
            pdfViewer1.FindTextHighLightColor = Color.FromArgb(200, 153, 193, 218);
            pdfViewer1.FormFillEnabled = false;
            pdfViewer1.IgnoreCase = false;
            pdfViewer1.IsToolBarVisible = true;
            pdfViewer1.Location = new Point(0, 0);
            pdfViewer1.MultiPagesThreshold = 60;
            pdfViewer1.Name = "pdfViewer1";
            pdfViewer1.OnRenderPageExceptionEvent = null;
            pdfViewer1.Size = new Size(751, 387);
            pdfViewer1.TabIndex = 0;
            pdfViewer1.Text = "pdfViewer1";
            pdfViewer1.Threshold = 60;
            pdfViewer1.ViewerBackgroundColor = Color.FromArgb(229, 229, 229);
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(751, 387);
            Controls.Add(pdfViewer1);
            Name = "Form2";
            Text = "PDF_View";
            ResumeLayout(false);
        }

        #endregion

        private Spire.PdfViewer.Forms.PdfViewer pdfViewer1;
    }
}