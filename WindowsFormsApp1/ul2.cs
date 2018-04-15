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
    public partial class ul2 : Form
    {
        static Seadmed elektirkeris = new Seadmed();
        static Seadmed kütteradiaator = new Seadmed();
        static Seadmed valgustus = new Seadmed();
        static Seadmed kohvimasin = new Seadmed();
        static Seadmed külmkapp = new Seadmed();
        static double tarve = 0;
        int PeamineAeg;
        int kiirus = 1000;

        public ul2()
        {
            InitializeComponent();
            kas.Text = Convert.ToString(tarve + " kWh");
            elektirkeris = new Seadmed("Lamp", 8000, new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 17, 30, 00), false);
            kütteradiaator = new Seadmed("Kütteradiaator", 2000, new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 14, 00, 00), false);
            valgustus = new Seadmed("Lambid", 20, new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 16, 00, 00), false);
            kohvimasin = new Seadmed("Kohvimasin", 400, new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 17, 15, 00), false);
            külmkapp = new Seadmed("Külmkapp", 110, new DateTime(DateTime.Today.Year, DateTime.Today.Month, DateTime.Today.Day, 12, 00, 00), false);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        { 

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (külmkapp.Lyliti == false)
            {
                tarve = tarve + 2000;
                külmkapp.Lyliti = true;
                KK.BackColor = Color.Green;
                KK.ForeColor = Color.White;
            }
            else
            {
                tarve = tarve - 2000;
                külmkapp.Lyliti = false;
                KK.BackColor = Color.Red;
                KK.ForeColor = Color.White;
            }
            kas.Text = Convert.ToString(tarve + " kWh");
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            kiirus = Convert.ToInt32(KiirusTxt.Text);

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void KR_Click(object sender, EventArgs e)
        {
            if (kütteradiaator.Lyliti == false)
            {
                tarve = tarve + kütteradiaator.Elekter;
                kütteradiaator.Lyliti = true;
                KR.BackColor = Color.Green;
                KR.ForeColor = Color.White;
            }
            else
            {
                tarve = tarve - kütteradiaator.Elekter;
                kütteradiaator.Lyliti = false;
                KR.BackColor = Color.Red;
                KR.ForeColor = Color.White;
            }
            kas.Text = Convert.ToString(tarve + " kWh");
        }

        private void EK_Click(object sender, EventArgs e)
        {
            
                  if (elektirkeris.Lyliti == false)
            {
                tarve = tarve + elektirkeris.Elekter;
                elektirkeris.Lyliti = true;
                EK.BackColor = Color.Green;
                EK.ForeColor = Color.White;
            }
            else
            {
                tarve = tarve - elektirkeris.Elekter;
                elektirkeris.Lyliti = false;
                EK.BackColor = Color.Red;
                EK.ForeColor = Color.White;
            }
            kas.Text = Convert.ToString(tarve + " kWh");
        }

        private void Val_Click(object sender, EventArgs e)
        {
            if (valgustus.Lyliti == false)
            {
                tarve = tarve + valgustus.Elekter;
                valgustus.Lyliti = true;
                Val.BackColor = Color.Green;
                Val.ForeColor = Color.White;
            }
            else
            {
                tarve = tarve - valgustus.Elekter;
                valgustus.Lyliti = false;
                Val.BackColor = Color.Red;
                Val.ForeColor = Color.White;
            }
            kas.Text = Convert.ToString(tarve + " kWh");
        }

        private void Kohv_Click(object sender, EventArgs e)
        {
            if (kohvimasin.Lyliti == false)
            {
                tarve = tarve + kohvimasin.Elekter;
                kohvimasin.Lyliti = true;
                Kohv.BackColor = Color.Green;
                Kohv.ForeColor = Color.White;
            }
            else
            {
                tarve = tarve - kohvimasin.Elekter;
                kohvimasin.Lyliti = false;
                Kohv.BackColor = Color.Red;
                Kohv.ForeColor = Color.White;
            }
            kas.Text = Convert.ToString(tarve + " kWh");
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            PeamineAeg ++;
            int time = PeamineAeg;

            int days = (time / 1440);
            time = time - days * 1440;

            int hours = (time / 60);
            time = time - hours * 60;
            hh.Text = hours.ToString();

            int minutes = (time);
            mm.Text = minutes.ToString();

            timer1.Interval = kiirus;
            kas.Text = Convert.ToString(tarve + " kWh");

         

            KKH.Text = Convert.ToString(külmkapp.Aeg.Hour);
            KKM.Text = Convert.ToString(külmkapp.Aeg.Minute);

            ValH.Text = Convert.ToString(valgustus.Aeg.Hour);
            ValM.Text = Convert.ToString(valgustus.Aeg.Minute);

            KohvH.Text = Convert.ToString(kohvimasin.Aeg.Hour);
            KohvM.Text = Convert.ToString(kohvimasin.Aeg.Minute);

            KRH.Text = Convert.ToString(kütteradiaator.Aeg.Hour);
            KRM.Text = Convert.ToString(kütteradiaator.Aeg.Minute);

            EKH.Text = Convert.ToString(elektirkeris.Aeg.Hour);
            EKM.Text = Convert.ToString(elektirkeris.Aeg.Minute);

            if (PeamineAeg == Convert.ToInt32(külmkapp.Aeg.Hour) * 60 + Convert.ToInt32(külmkapp.Aeg.Minute) && checkBox1.Checked)
            {
                if (KK.BackColor != Color.Green)
                {
                    KK.BackColor = Color.Green;
                    KK.ForeColor = Color.White;
                    tarve = tarve + külmkapp.Elekter;
                    
                }


            }
            else if (PeamineAeg == Convert.ToInt32(kütteradiaator.Aeg.Hour) * 60 + Convert.ToInt32(kütteradiaator.Aeg.Minute) && checkBox2.Checked)
            {
                if (KR.BackColor != Color.Green)
                {
                    KR.BackColor = Color.Green;
                    KR.ForeColor = Color.White;
                    tarve = tarve + kütteradiaator.Elekter;
                }

            }
            else if (PeamineAeg == Convert.ToInt32(elektirkeris.Aeg.Hour) * 60 + Convert.ToInt32(elektirkeris.Aeg.Minute) && checkBox3.Checked)
            {
                if (EK.BackColor != Color.Green)
                {
                    EK.BackColor = Color.Green;
                    EK.ForeColor = Color.White;
                    tarve = tarve + elektirkeris.Elekter;
                }

            }
            else if (PeamineAeg == Convert.ToInt32(kohvimasin.Aeg.Hour) * 60 + Convert.ToInt32(kohvimasin.Aeg.Minute) && checkBox5.Checked)
            {
                if (Kohv.BackColor != Color.Green)
                {
                    Kohv.BackColor = Color.Green;
                    Kohv.ForeColor = Color.White;
                    tarve = tarve + kohvimasin.Elekter;
                }

            }
            else if (PeamineAeg == Convert.ToInt32(valgustus.Aeg.Hour) * 60 + Convert.ToInt32(valgustus.Aeg.Minute) && checkBox4.Checked)
            {
                if (Val.BackColor != Color.Green)
                {
                    Val.BackColor = Color.Green;
                    Val.ForeColor = Color.White;
                    tarve = tarve + valgustus.Elekter;
                }

            }
            else if (PeamineAeg >= 24 * 60)
            {
                KK.BackColor = Color.Red;
                KR.BackColor = Color.Red;
                EK.BackColor = Color.Red;
                Kohv.BackColor = Color.Red;
                Val.BackColor = Color.Red;

                // elektritarbe = 0;
                PeamineAeg = 0;
            }
            
        }

        private void label3_Click_1(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }
    }
    }

