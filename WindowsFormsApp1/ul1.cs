using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class ul1 : Form
    {
        int AegHetk;
        int AegValitud;
        int Aeg;

        public ul1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Tun.Text == "" || Min.Text == "" || Sek.Text == "")
            {
                label1.Text = "Sisestage aeg!";
                label1.ForeColor = Color.Red;
            }
            else
            {
                int T = Convert.ToInt32(Tun.Text);
                int M = Convert.ToInt32(Min.Text);
                int S = Convert.ToInt32(Sek.Text);

                DateTime Dhetk = DateTime.Now;
                DateTime D = this.dateTimePicker1.Value.Date;

                   AegHetk = calculateSeconds(Dhetk);
                    AegValitud = calculateSeconds(D);
               //AegHetk= 

              //  D = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
               // TimeSpan myDateResult;
               // myDateResult = Dhetk - D;
                //double seconds = myDateResult.TotalSeconds;
               // int Aeg = Convert.ToInt32(seconds);  //Hiljem enda jaoks

               // https://msdn.microsoft.com/en-us/library/system.datetime(v=vs.110).aspx
               // https://stackoverflow.com/questions/11929554/datetime-now-as-timespan-value
                AegValitud = AegValitud + T * 3600 + M * 60 + S;

                

                if (AegValitud > AegHetk)
                {
                    label1.Text = "Korras!";
                    label1.ForeColor = Color.Green;
                    button1.BackColor = Color.Gray;
                    button1.Enabled = false;
                    timer1.Enabled = true;
                }
                else
                {
                    label1.Text = "Vale ajavahemik!";
                    label1.ForeColor = Color.Red;
                }


            }
        }


        public int calculateSeconds(DateTime Dhetk)
        {
            DateTime dt = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Local);
            TimeSpan myDateResult = Dhetk.Subtract(dt);
           // myDateResult = dt - Dhetk;
           // double seconds = myDateResult.TotalSeconds;
            int seconds = Convert.ToInt32(myDateResult.TotalSeconds);
            return seconds;
        } //Vladmir seletas selle osa


        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = (1000) * (1);

               if (labMin.Text == "0" && labSek.Text == "0") {

                 timer1.Stop();
               label1.Text = "Aeg on läbi!";
               label1.ForeColor = Color.Green;
                Tun.Text = "00";
                Min.Text = "00";
                Sek.Text = "00";
                button1.BackColor = Color.Empty;
                button1.Enabled = true;

            }
             else
            {
                AegValitud--;

                Aeg = AegValitud - AegHetk;

                labSek.Text = Aeg.ToString();

                int p2ev = (Aeg / 86400);
                Aeg = Aeg - p2ev * 86400;
                labP.Text = p2ev.ToString();

                int Tund = (Aeg / 3600);
                Aeg = Aeg - Tund * 3600;
                labTun.Text = Tund.ToString();


                int Min = (Aeg / 60);
                Aeg = Aeg - Min * 60;
                labMin.Text = Min.ToString();

                labSek.Text = Aeg.ToString();
            }
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void labSek_Click(object sender, EventArgs e)
        {

        }
    }
}
