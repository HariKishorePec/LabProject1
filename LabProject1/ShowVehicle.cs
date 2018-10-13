﻿using System;
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
    public partial class ShowVehicle : Form
    {
        public ShowVehicle()
        {
            InitializeComponent();
        }

        private void ShowVehicle_Load(object sender, EventArgs e)
        {
            string cmdText = "SELECT * FROM vehicleTable";
            string connStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\LabProDB.mdb";
            OleDbDataAdapter dataAdapter = new OleDbDataAdapter(cmdText, connStr);
            DataSet ds = new DataSet();
            dataAdapter.Fill(ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
        }
    }
}
