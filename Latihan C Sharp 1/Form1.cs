using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;

namespace Latihan_C_Sharp_1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Database NewConnection = new Database();
            NewConnection.Connection_Today();

            SQLiteCommand comm = new SQLiteCommand();
            comm.Connection = Database.conn;
            comm.CommandText = "select * from DataRandom";

            using (SQLiteDataReader rd = comm.ExecuteReader())
            {
                DataTable dt = new DataTable();
                dt.Load(rd);
                rd.Close();
                dataGridView1.DataSource = dt;
            }
        }
    }
}
