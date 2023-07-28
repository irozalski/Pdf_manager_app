
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
    public partial class Catalogs : UserControl
    {
        BindingSource albumBindingSource = new BindingSource();
        BindingSource tracksBindingSource = new BindingSource();
        List<Catalog> albums = new List<Catalog>();
        Add_file ad = new Add_file();

        public Catalogs()
        {
            InitializeComponent();

        }


        public void Load_albums()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            albums = albumsDAO.getAllAlbums();
            // conect the list to the grid

            albumBindingSource.DataSource = albums;


            dataGridView1.DataSource = albumBindingSource;

            pictureBox1.Hide();
            button4.Visible = false;

            if (dataGridView2.Visible == true)
            {
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
            }
            if (dataGridView3.Visible == true)
            {
                dataGridView1.Visible = true;
                dataGridView3.Visible = false;
            }

            //string rowIcon = "C:\\Users\\Igor\\Desktop\\P_różowy.png";

            //dataGridView1.Columns["ID"].Visible = false;

            //DataGridViewImageColumn iconColumn = new DataGridViewImageColumn();
            //iconColumn.Name = "IconColumn";
            //iconColumn.ImageLayout = DataGridViewImageCellLayout.Zoom; // Adjust the layout as per your requirement

            //// Add the icon column to the DataGridView
            //dataGridView1.Columns.Add(iconColumn);

            //// Loop through each row in the DataGridView
            //foreach (DataGridViewRow row in dataGridView1.Rows)
            //{
            //    // Set the icon for the specific cell in the icon column
            //    row.Cells["IconColumn"].Value = rowIcon;
            //}
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Load_albums();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();


            // conect the list to the grid
            albumBindingSource.DataSource = albumsDAO.searchTitles(textBox1.Text);

            dataGridView1.DataSource = albumBindingSource;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;


            String imageURL = dataGridView.Rows[rowClicked].Cells[3].Value.ToString();
            try
            {
                pictureBox1.Load(imageURL);
                pictureBox1.Show();
            }
            catch (ArgumentException ex)
            {
                MessageBox.Show("Invalid image format. Exception: " + ex.Message);
            }
            catch (Exception ex)
            {
                // Obsługa innych wyjątków
                MessageBox.Show("An error occurred while loading the image. Exception: " + ex.Message);
            }

        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;

            tracksBindingSource.DataSource = albums[rowClicked].Tracks;

            tracksBindingSource.DataSource = albums[rowClicked].Tracks;
            dataGridView2.DataSource = tracksBindingSource;
            dataGridView2.Visible = true;
            dataGridView1.Visible = false;
            button4.Visible = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (dataGridView2.Visible == true)
            {
                button4.Visible = false;
                dataGridView2.Visible = false;
                dataGridView1.Visible = true;
            }
            if (dataGridView3.Visible == true)
            {
                dataGridView2.Visible = true;
                dataGridView3.Visible = false;
            }
        }

        private void dataGridView2_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;

            int rowClicked = dataGridView.CurrentRow.Index;



            if (dataGridView.Rows[rowClicked].Cells[2].Value != null)
            {
                string pdfPath = dataGridView.Rows[rowClicked].Cells[2].Value.ToString();
                Form2 form2 = new Form2();
                form2.Show(this);
                //form2.InvokeButton1Click();
                form2.Form2_Load(pdfPath);
            }

            //dataGridView3.Visible = true;
            //dataGridView2.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MainControl.show_control(ad, Add_file_panel);
            
        }
    }
}
