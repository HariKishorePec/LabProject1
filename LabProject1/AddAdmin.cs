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
    public partial class AddAdmin : Form
    {
        public AddAdmin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.dbConnection.Open();
                OleDbCommand oleDbCommand = new OleDbCommand();
                string cmdStr = "INSERT into LoginTable (user_name, pass_word) VALUES('" + textBox1.Text + "','" + textBox2.Text + "')";
                oleDbCommand.Connection = Form1.dbConnection;
                oleDbCommand.CommandText = cmdStr;
                oleDbCommand.ExecuteNonQuery();

                MessageBox.Show("User Added Succesfully", "Success");
                Form1.dbConnection.Close();
                this.Dispose();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error " + e2.Message);
            }

        }

        private void AddAdmin_Load(object sender, EventArgs e)
        {
           
        }
    }
}
