using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
//using Newtonsoft.Json.Linq;

namespace pdf_manager_app
{
    internal class AlbumsDAO
    {
        string connectionString = "datasource=localhost;port=3306; username=root; password=root;database=pdf_manager;";

        public List<Catalog> getAllAlbums()
        {
            //start with empty list
            List<Catalog> returnThese = new List<Catalog>();
            // connect to mysql server

            int selectedIndex = ComboBoxHelper.SelectedIndex + 1;

            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            //deefine sql statement to fetch albums
            MySqlCommand command = new MySqlCommand("SELECT ID, NAME, DESCRIPTION, IMAGE FROM CATALOGS WHERE USERS_ID LIKE @user_id", connection);
            command.Parameters.AddWithValue("@user_id", selectedIndex);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Catalog a = new Catalog()
                    {
                        ID = reader.GetInt32(0),
                        NAME = reader.GetString(1),
                        DESCRIPTION = reader.GetString(2),
                        IMAGE = reader.GetString(3),
                        
                    };
                    
                    a.Tracks = getTracksForAlbum(a.ID);
                    returnThese.Add(a);
                   
                }
            }

            connection.Close();
            return returnThese;

        }

        public List<Catalog> searchTitles(String searchTerm)
        {
            //start with empty list
            List<Catalog> returnThese = new List<Catalog>();
            // connect to mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();

            String searchWildPhrase = "%" + searchTerm + "%";

            //deefine sql statement to fetch albums
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT ID, NAME, DESCRIPTION, IMAGE FROM CATALOGS WHERE NAME LIKE @search";
            command.Parameters.AddWithValue("@search", searchWildPhrase);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    Catalog a = new Catalog()
                    {
                        ID = reader.GetInt32(0),
                        NAME = reader.GetString(1),
                        DESCRIPTION = reader.GetString(2),
                        IMAGE = reader.GetString(3),
                    };
                    returnThese.Add(a);
                }
            }

            connection.Close();
            return returnThese;

        }

        internal int addOneAlbum(Catalog album)
        {
            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            int selectedIndex = ComboBoxHelper.SelectedIndex + 1;

            //deefine sql statement to fetch albums
            MySqlCommand command = new MySqlCommand("INSERT INTO `catalogs`(`NAME`, `DESCRIPTION`, `IMAGE`, `USERS_ID`) " +
                "VALUES (@catalogname, @catalog_description, @catalog_image, @users_id)", connection);

            command.Parameters.AddWithValue("@catalogname", album.NAME);
            command.Parameters.AddWithValue("@catalog_description", album.DESCRIPTION);
            command.Parameters.AddWithValue("@catalog_image", album.IMAGE);
            command.Parameters.AddWithValue("@users_id", selectedIndex);

            int newRows = command.ExecuteNonQuery();

            connection.Close();
            return newRows;


        }

        public List<File> getTracksForAlbum(int albumID)
        {
            //start with empty list
            List<File> returnThese = new List<File>();
            // connect to mysql server

            MySqlConnection connection = new MySqlConnection(connectionString);
            connection.Open();



            //deefine sql statement to fetch albums
            MySqlCommand command = new MySqlCommand();

            command.CommandText = "SELECT * FROM FILES WHERE CATALOGS_ID = @catalogid";
            command.Parameters.AddWithValue("@catalogid", albumID);
            command.Connection = connection;
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    File f = new File()
                    {
                        ID = reader.GetInt32(0),
                        NAME = reader.GetString(1),
                        FILEPATH = reader.GetString(2),
                        DESCRIPTION = reader.GetString(3),
                        
                    };
                    returnThese.Add(f);
                }
            }

            connection.Close();
            return returnThese;

        }

        public List<User> getAllUsers()
        {
            //start with empty list
            List<User> returnThese = new List<User>();
            // connect to mysql server

            MySqlConnection connection = new MySqlConnection
                (connectionString);
            connection.Open();

            //deefine sql statement to fetch albums
            MySqlCommand command = new MySqlCommand("SELECT ID, NAME FROM USERS", connection);
            using (MySqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    User u = new User()
                    {
                           ID = reader.GetInt32(0),
                           NAME = reader.GetString(1),

                    };
                   
                    returnThese.Add(u);

                }
            }

            connection.Close();
            return returnThese;

        }

    }
}
