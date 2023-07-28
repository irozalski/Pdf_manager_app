using System.Data;
using System.Windows.Forms;

namespace pdf_manager_app
{
    public partial class Form1 : Form
    {
        private Catalogs catalogs1 = new Catalogs();
        private Front_window front_window1 = new Front_window();
        private Create_catalog create_catalog1 = new Create_catalog();
        private Button currentButton;
        List<User> users = new List<User>();
        public Form1()
        {
            InitializeComponent();
            MainControl.show_control(front_window1, ContentPanel);
            load_users();
            comboBox1.SelectedIndex = 0;



        }
        private void ActivateButton(object btnsender)
        {
            if (btnsender != null)
            {
                if (currentButton != (Button)btnsender)
                {
                    BackButton();
                    Color color = Color.DeepSkyBlue;
                    currentButton = (Button)btnsender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Microsoft Sans Serif", 10.5F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }

        private void BackButton()
        {
            foreach (Control previousBtn in panel1.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            label2.Text = "CATALOGS";
            MainControl.show_control(catalogs1, ContentPanel);
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            label2.Text = "ADD CATALOG";  
            MainControl.show_control(create_catalog1, ContentPanel);
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            catalogs1.Load_albums();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ActivateButton(sender);
            label2.Text = "MAIN MENU";         
            MainControl.show_control(front_window1, ContentPanel);
     
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ComboBoxHelper.SelectedIndex = comboBox1.SelectedIndex;
            catalogs1.Load_albums();
            label1.Focus();

            if (comboBox1.SelectedItem != null)
            {
                User selectedUser = (User)comboBox1.SelectedItem;
                front_window1.label1_text(selectedUser.NAME);
            }

        }

        private void load_users()
        {
            AlbumsDAO albumsDAO = new AlbumsDAO();

            users = albumsDAO.getAllUsers();
            comboBox1.DataSource = users;
            comboBox1.DisplayMember = "NAME";
            comboBox1.ValueMember = "ID";


        }

        public void add_file_window()
        {
            //add_file1.Show();
            create_catalog1.Hide();
            catalogs1.Hide();
            front_window1.Hide();
            //add_file1.BringToFront();
        }

        public void show_catalog_btn()
        {
            MainControl.show_control(catalogs1, ContentPanel);
        }


    }

    public static class ComboBoxHelper
    {
        private static int selectedIndex;

        public static int SelectedIndex
        {
            get { return selectedIndex; }
            set { selectedIndex = value; }
        }
    }
}