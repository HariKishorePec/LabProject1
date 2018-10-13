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

namespace LabProject1
{
    public partial class ShowLoginTable : Form
    {
        public ShowLoginTable()
        {
            InitializeComponent();
        }

        private void ShowLoginTable_Load(object sender, EventArgs e)
        {
            string cmdText = "SELECT ID, user_name, pass_word FROM LoginTable";
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\LabProDB.mdb";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
