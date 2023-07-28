using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pdf_manager_app
{
    public partial class Front_window : UserControl
    {
        public Front_window()
        {
            InitializeComponent();
            circularPictureBox1.Show();
        }

        public void label1_text(string text)
        {

            label1.Text = text;
        }

        
    }
}
