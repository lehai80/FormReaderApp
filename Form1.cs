using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace FormReaderApp
{
    public partial class Form1 : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public Form1()
        {
          
            InitializeComponent();
            try
            {
                connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Alignment\\Ini\\ALIGNMENT.mdb;Persist Security Info=False;";
                connection.Open();
                connectionchecking.Text = "Succesfully Connected";
              
            }
            catch (Exception er)
            {
                MessageBox.Show("An error has occurred: " + er);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form btn_datainsert = new btn_datainsert();
            btn_datainsert.ShowDialog();
        }
        #region This is a Test
        private void loadDatabaseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            { 
                OleDbCommand command = new OleDbCommand();
               

                command.Connection = connection;
              
                string query = " select * from TOR_STANDARD_VALUE_MST";
                command.CommandText = query;
                OleDbDataAdapter da = new OleDbDataAdapter(command);

                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception er)
            {
                MessageBox.Show("An error has occurred: " + er);
            }
        }
        #endregion
    }
}
