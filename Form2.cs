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
    public partial class btn_datainsert : Form
    {
        OleDbConnection connection = new OleDbConnection();
        public btn_datainsert()
        {
            InitializeComponent();
            connection.ConnectionString = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=C:\\Users\Long\source\repos\FormReaderApp\Test.mdb;Persist Security Info=False;";
        }

        private void btn_datainsert_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btn_accept_Click(object sender, EventArgs e)
        {
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = "insert into Test (cotso1,cotso2,cotso3) values ('" + txt_cotso1.Text + "','" + txt_cotso2.Text + "','" + txt_cotso3.Text + "')";
                command.ExecuteNonQuery();
                MessageBox.Show("Finished !");
            }
            catch (Exception er)
            {
                MessageBox.Show("An error has occurred: " + er);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
