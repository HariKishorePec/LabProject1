using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabProject1
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
            this.IsMdiContainer = true;

        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowLoginTable().Show();
        }

        private void passengerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddPassenger().Show();

        }

        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AddVehicle().Show();

        }

        private void userToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddAdmin aa = new AddAdmin();
            //aa.MdiParent = this;
            aa.Show();
        }

        private void passengersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowPassenger sp = new ShowPassenger();
            //sp.MdiParent = this;
            sp.Show();
        }

        private void vehicleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            new ShowVehicle().Show();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookTicket().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            new AddPassenger().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new AddVehicle().Show();
        }

        private void tickectBookToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new BookTicket().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            new BookTicket().Show();
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }

        private void exitToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            System.Environment.Exit(0);
        }
        int temp = 0;
        private void changeColorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp++;
            if(temp%4==1) label1.ForeColor = System.Drawing.Color.Magenta;
            if (temp % 4 == 2) label1.ForeColor = Color.Red;
            if (temp % 4 == 3) label1.ForeColor = Color.DarkGreen;
            if (temp % 4 == 0) label1.ForeColor = Color.Purple;
        }
        int temp2 = 0;
        private void changeFontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            temp2++;
            if(temp2 % 3==1)label1.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if(temp2 % 3==0)label1.Font = new System.Drawing.Font("Old English Text MT", 11.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            if(temp2 % 3 == 2)label1.Font = new System.Drawing.Font("Algerian", 9.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
        }

        private void ticketBookedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new ShowTicket().Show();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
