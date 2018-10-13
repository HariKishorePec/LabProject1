using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject1
{
    public partial class ShowPassenger : Form
    {
        public ShowPassenger()
        {
            InitializeComponent();
        }

        private void ShowPassenger_Load(object sender, EventArgs e)
        {
            string cmdText = "SELECT * FROM passengerTable";
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\LabProDB.mdb";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
