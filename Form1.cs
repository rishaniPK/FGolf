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
    }
}
