using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FGolf
{
    public partial class GolfBD : Form
    {
        private string connectionString = @"Data Source=DESKTOP-89NTJEN\SQLEXPRESS;Initial Catalog = TestDB; Integrated Security = True";
        SqlConnection Con = new SqlConnection();
        DataTable GolfTable = new DataTable();
        public GolfBD()
        {
            InitializeComponent();
            loaddb();

        }

        private void GolfBD_Load(object sender, EventArgs e)
        {

        }

        public void loaddb()
        {
            //load datatable columns
            datatablecolumns();
            //Wrap your code in a Using statement to dispose of it later
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                //Ask a question
                string QueryString = @"SELECT * FROM Golf order by ID";
                //Open your connection
                connection.Open();
                SqlCommand Command = new SqlCommand(QueryString, connection);
                //Start your DB reader
                SqlDataReader reader = Command.ExecuteReader();
                while (reader.Read())
                {
                    //add in each row to the datatable
                    GolfTable.Rows.Add(
                        reader["ID"],
                        reader["Title"],
                        reader["Firstname"],
                        reader["Surname"],
                        reader["Gender"],
                        reader["DOB"],      
                        reader["Street"],
                        reader["Suburb"],
                        reader["City"],
                        reader["Available week days"],
                        reader["Handicap"]);
                }
                //Close your DB reader
                reader.Close();
                //Close your connection
                connection.Close();
              //  btnCountMembers.Visible = true;
                //add the datatable to the Data Grid View
                golf_GDV.DataSource = GolfTable;
            }
        }
        public void datatablecolumns()
        {
            //clear the old data
            GolfTable.Clear();
            //add in the column titles to the datatable
            try
            {
                GolfTable.Columns.Add("ID");
                GolfTable.Columns.Add("Title");
                GolfTable.Columns.Add("Firstname");
                GolfTable.Columns.Add("Surname");
                GolfTable.Columns.Add("Gender");
                GolfTable.Columns.Add("DOB");
                GolfTable.Columns.Add("Street");
                GolfTable.Columns.Add("Suburb");
                GolfTable.Columns.Add("City");
                GolfTable.Columns.Add("Available week days");
                GolfTable.Columns.Add("Handicap");
            }
            catch
            {
                MessageBox.Show("Datatable not loading");

            }
        }

        private void Btn_loaddata_Click(object sender, EventArgs e)
        {

        }
    }
}
