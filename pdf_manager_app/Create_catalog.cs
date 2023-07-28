using Spire.Pdf.OPC;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace pdf_manager_app
{
    public partial class Create_catalog : UserControl
    {
        private string[] files;
        public Create_catalog()
        {
            InitializeComponent();
            hints();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Catalog album = new Catalog
            {
                NAME = txt_album_name.Text,
                DESCRIPTION = txt_description.Text,
                IMAGE = files[0],
                //USER_ID = ,
            };

            AlbumsDAO albumsDAO = new AlbumsDAO();
            int result = albumsDAO.addOneAlbum(album);
            MessageBox.Show("News catalog inserted");
        }

        public void panel1_DragDrop(object sender, DragEventArgs e)
        {
            files = (string[])e.Data.GetData(DataFormats.FileDrop);
            listBox1.Items.Clear();
            listBox1.Items.AddRange(files);
            Image image = Image.FromFile(files[0]);
            Image scaledImage = image.GetThumbnailImage(panel1.Width, panel1.Height, null, IntPtr.Zero);
            panel1.BackgroundImage = scaledImage;
            
        }


        private void panel1_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel panel = (Panel)sender;
            string watermarkText = "Drag your image here";
            float fontSize = 13f;

            if (string.IsNullOrEmpty(panel.Text))
            {
                using (Font font = new Font(panel.Font.FontFamily, fontSize, FontStyle.Italic))
                {
                    using (SolidBrush brush = new SolidBrush(Color.Gray))
                    {
                        e.Graphics.DrawString(watermarkText, font, brush, new PointF(8, 60));
                    }
                }
            }
        }

        private void hints()
        {
            string hintText = "-- Enter catalog name here --";
            txt_album_name.Text = hintText;
            txt_album_name.ForeColor = SystemColors.GrayText;

            string hintText1 = "-- Enter catalog description here --";
            txt_description.Text = hintText1;
            txt_description.ForeColor = SystemColors.GrayText;
        }

        private void txt_album_name_Enter(object sender, EventArgs e)
        {
            string hintText = "-- Enter catalog name here --";

            if (txt_album_name.Text == hintText)
            {
                txt_album_name.Text = "";
                txt_album_name.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_album_name_Leave(object sender, EventArgs e)
        {
            string hintText = "-- Enter catalog name here --";

            if (string.IsNullOrWhiteSpace(txt_album_name.Text))
            {
                txt_album_name.Text = hintText;
                txt_album_name.ForeColor = SystemColors.GrayText;
            }
        }

        private void txt_description_Enter(object sender, EventArgs e)
        {
            string hintText = "-- Enter catalog description here --";

            if (txt_description.Text == hintText)
            {
                txt_description.Text = "";
                txt_description.ForeColor = SystemColors.WindowText;
            }
        }

        private void txt_description_Leave(object sender, EventArgs e)
        {
            string hintText = "-- Enter catalog description here --";

            if (string.IsNullOrWhiteSpace(txt_description.Text))
            {
                txt_description.Text = hintText;
                txt_description.ForeColor = SystemColors.GrayText;
            }
        }
    }
}
