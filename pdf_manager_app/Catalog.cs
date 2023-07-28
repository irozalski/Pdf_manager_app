using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace pdf_manager_app
{
    internal class Catalog
    {
        public int ID { get; set; }
        public String NAME { get; set; }
        public String DESCRIPTION { get; set; }
        public String IMAGE { get; set; }


        public List<File> Tracks { get; set; }
    }
}
