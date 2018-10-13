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
    public partial class AddPassenger : Form
    {
        public AddPassenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.dbConnection.Open();
                OleDbCommand oleDbCommand = new OleDbCommand();
                string cmdStr = "INSERT into passengerTable (fname, sname, city, pid, addr) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "')";
                oleDbCommand.Connection = Form1.dbConnection;
                oleDbCommand.CommandText = cmdStr;
                oleDbCommand.ExecuteNonQuery();
               
                MessageBox.Show("Data Inserted Succesfully", "Success");
                Form1.dbConnection.Close();
            }catch(Exception e2)
            {
                MessageBox.Show("Error " + e2.Message);
            }
            
        }
    }
}
