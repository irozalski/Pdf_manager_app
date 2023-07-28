using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Runtime.InteropServices;
using Spire.Pdf.Exporting.XPS.Schema;
using Microsoft.VisualBasic.ApplicationServices;

namespace pdf_manager_app
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        public void Form2_Load(string pdf_path)
        {
            //OpenFileDialog opf = new OpenFileDialog();
            //opf.Filter = "Pdf File|*.pdf";
            string pdfDoc = pdf_path;

            this.pdfViewer1.LoadFromFile(pdfDoc);

        }

    }
}
