using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reactiontest
{
    public partial class mainokno2 : Form
    {
        
        public mainokno2()
        {
            InitializeComponent();
        }
        public mainokno2(string NickGracza)
        {
            InitializeComponent();
            this.label1.Text = "Nick: " + NickGracza;
            this.button1.Visible = false;
            this.button1.Enabled = false;
            flag = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false & attempts == 0)
            {
                flag = true;
                message = " ";
                this.textBox1.Text = " ";
                attempts++;
                MessageBox.Show("PODEJSCIE TESTOWE");
                this.groupBox1.Text = "Podejście: " + (attempts - 1).ToString();
                this.button2.Enabled = false;
                Task.Delay(rnd.Next(500, 1000)).Wait();
                init_test(rnd);
                stopw.Start();

            }
            else if (attempts != 0 | flag != false)
            {
                flag = true;
                attempts++;
                this.groupBox1.Text = "Podejście: " + (attempts - 1).ToString();
                this.button2.Enabled = false;
                Task.Delay(rnd.Next(500, 1000)).Wait();
                init_test(rnd);
                stopw.Start();
            }
            else
            {
                MessageBox.Show("Cos poszlo nie tak");

            }
        }
        private void init_test(Random rnd)
        {
            stopw.Reset();
            timesButtonPressed = 0;
            Point rnd_loc = new Point(rnd.Next(100,700),
                                rnd.Next(100,380));

            this.button1.Location = rnd_loc;
            this.button1.Visible = true;
            this.button1.Enabled = true;
            this.button1.BackColor = Color.Green;
        }
        private void next_loc(Random rnd)
        {
            if (timesButtonPressed != 3)
            {
                stopw.Reset();
                Point rnd_loc = new Point(rnd.Next(100, 700),
                                                rnd.Next(100, 380));
                this.button1.Location = rnd_loc;
                this.button1.Visible = true;
                this.button1.Enabled = true;
                this.button1.BackColor = Color.Green;
                stopw.Start();
            }
            else {

                this.button2.Enabled = true;
                this.button1.Enabled = false;
                this.button1.Visible = false;
                flag = false;
                MessageBox.Show("Gratulacje! Wyniki zobaczysz po kliknięciu przycisku 'Wyniki'");

            }
            

        }
        private void button1_Click(object sender, EventArgs e)
        {
            stopw.Stop();
            if (attempts == 2)
            {
                reactionTime.Add(stopw.ElapsedMilliseconds);
                timesButtonPressed++;
                this.button1.BackColor = Color.Red;
                this.textBox1.Text += string.Format("czas reakcji: {0}", reactionTime[timesButtonPressed - 1]).ToString() + " ms\r\n";
                Task.Delay(rnd.Next(150, 450)).Wait();
                next_loc(rnd);
            }
            else
            {
                reactionTime.Add(stopw.ElapsedMilliseconds);
                timesButtonPressed++;
                this.button1.BackColor = Color.Red;
                Task.Delay(rnd.Next(150, 450)).Wait();
                next_loc(rnd);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string wyniki;
            wyniki = string.Format("Twój czas to: {0}", string.Join(" ms\r\n", reactionTime)) + " ms";
            MessageBox.Show(wyniki);
        }
        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            this.PodajNazweUzytkownika = new nickname();
            this.PodajNazweUzytkownika.Show();
        }
        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
            Environment.Exit(1);
        }
    }

}
