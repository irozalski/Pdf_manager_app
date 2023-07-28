using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pdf_manager_app
{
    internal class MainControl
    {
        public static void show_control(System.Windows.Forms.Control control, System.Windows.Forms.Control Content)
        {
            Content.Show();
            Content.BringToFront();
            Content.Controls.Clear();
            Content.Controls.Add(control);
            control.Dock = DockStyle.Fill;
            control.BringToFront();
            control.Focus();
            
        }

        public static void hide_control(System.Windows.Forms.Control Content)
        {
            Content.Hide();
            //Content.Controls.Add(control);
            // control.Dock = DockStyle.Fill;
            //control.BringToFront();
            //control.Focus();

        }
    }
}
