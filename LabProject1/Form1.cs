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
    public partial class Form1 : Form
    {
        public static OleDbConnection dbConnection = new OleDbConnection();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String conStr = @"Provider=Microsoft.Jet.OLEDB.4.0;Data Source=.\LabProDB.mdb";
            dbConnection.ConnectionString = conStr;
            try
            {
                dbConnection.Open();
                //MessageBox.Show("Database connected", "Message");
                
                //String passWord = String.Empty;
                
                dbConnection.Close();
            }catch(Exception e1)
            {
                MessageBox.Show("Error " + e1.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String cmdStr1 = "SELECT user_name, pass_word FROM LoginTable WHERE user_name = @p1 and pass_word = @p2";
            OleDbCommand oleDbCommand = new OleDbCommand(cmdStr1, dbConnection);
            try
            {
                dbConnection.Open();
                oleDbCommand.CommandType = CommandType.Text;
                oleDbCommand.CommandText = cmdStr1;
                oleDbCommand.Parameters.AddWithValue("@p1", textBox1.Text);
                oleDbCommand.Parameters.AddWithValue("@p2", textBox2.Text);
                OleDbDataReader reader = oleDbCommand.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Login Successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    new HomeForm().Show();
                    this.Hide();
                }
                else MessageBox.Show("Wrong username or password!","Invalid credential!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                dbConnection.Close();
            }catch(Exception e2)
            {
                MessageBox.Show(e2.Message, "Error");
            }
        }
    }
}
