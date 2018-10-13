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
    public partial class AddVehicle : Form
    {
        public AddVehicle()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.dbConnection.Open();
                OleDbCommand oleDbCommand = new OleDbCommand();
                string cmdStr = "INSERT into vehicleTable (vno, src, dest, seatno) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "')";
                oleDbCommand.Connection = Form1.dbConnection;
                oleDbCommand.CommandText = cmdStr;
                oleDbCommand.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Succesfully", "Success");
                Form1.dbConnection.Close();
                this.Hide();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error " + e2.Message);
            }
        }
    }
}
