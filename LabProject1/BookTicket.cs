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
    public partial class BookTicket : Form
    {
        public BookTicket()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1.dbConnection.Open();
            
            OleDbCommand command= new OleDbCommand();
            command.Connection = Form1.dbConnection;
            command.CommandText = "select * from VehicleTable where src='" + textBox5.Text + "' and dest='" + textBox6.Text + "' ";
            try
            {
                OleDbDataReader reader = command.ExecuteReader();
                int count = 0;
               /* while (reader.Read())
                {
                    MessageBox.Show(reader.Read().ToString());
                    richTextBox1.Text += "\n" + reader["src"].ToString();
                    count++;
                }
                if (count == 1)
                {
                    MessageBox.Show("Hurry up! One bus is available.");

                }
                else if (count > 1)
                {
                    MessageBox.Show("Buses are available.");
                }
                else
                {
                    MessageBox.Show("Sorry. No Seats or vehicle available.");
                }*/
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        //MessageBox.Show(reader.Read().ToString());
                        count++;
                        richTextBox1.Text += "\n"+ count+". Source: "+ reader["src"].ToString()+" to "+reader["dest"].ToString()+" Vehicle Number "+reader["vno"].ToString();
                        
                    }
                    MessageBox.Show(richTextBox1.Text, "Available!");
                }
                else
                {
                    MessageBox.Show("Sorry!, Not found.");
                }

            }
            catch (Exception e2)
            {
                MessageBox.Show(e2.Message);
            }
            Form1.dbConnection.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Form1.dbConnection.Open();
                OleDbCommand oleDbCommand = new OleDbCommand();
                string cmdStr = "INSERT into ticketTable (pname, pid, src, dest, total_seat, doj) VALUES('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + int.Parse(textBox7.Text) +"', '"+dateTimePicker1.MaxDate+ "')";
                oleDbCommand.Connection = Form1.dbConnection;
                oleDbCommand.CommandText = cmdStr;
                oleDbCommand.ExecuteNonQuery();

                MessageBox.Show("Data Inserted Succesfully", "Success");
                Form1.dbConnection.Close();
            }
            catch (Exception e2)
            {
                MessageBox.Show("Error " + e2.Message);
            }
        }
    }
}
