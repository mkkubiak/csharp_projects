using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace reactiontest
{
    public partial class mainokno3 : Form
    {
        public mainokno3()
        {
            InitializeComponent();
        }
        public mainokno3(string NickGracza)
        {
            InitializeComponent();
            this.label1.Text = "Nick: " + NickGracza;
            this.groupBox1.Text = "Witaj!";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (flag == false & attempts == 0)
            {
                flag = true;
                message = "";
                this.textBox1.Text = "";
                attempts++;
                MessageBox.Show("PODEJSCIE TESTOWE");
                this.groupBox1.Text = "Podejście: " + (attempts - 1).ToString();
                this.button2.Enabled = false;
                Task.Delay(rnd.Next(500, 1000)).Wait();
                init_test_ac(rnd);
                stopw.Start();

            }
            else if (flag != false | attempts != 0)
            {
                flag = true;
                message = "";
                this.textBox1.Text = "";
                attempts++;
                this.groupBox1.Text = "Podejście: " + (attempts - 1).ToString();
                this.button2.Enabled = false;
                Task.Delay(rnd.Next(500, 1000)).Wait();
                init_test_ac(rnd);
                stopw.Start();
            }
            else MessageBox.Show("Cos poszlo nie tak");
        }
        private void init_test_ac(Random rnd)
        {
            stopw.Reset();
            timesButtonPressed = 0;
            Task.Delay(rnd.Next(450, 800)).Wait();
            Console.Beep(1000,250);
        }
        private void next_beep(Random rnd)
        {
            if (timesButtonPressed != 3)
            {
                stopw.Reset();
                Task.Delay(rnd.Next(450, 800)).Wait();
                Console.Beep(1000,250);
                stopw.Start();
            }
            else
            {
                flag = false;
                MessageBox.Show("Gratulacje! Wyniki zobaczysz po kliknięciu przycisku 'Wyniki'");
                this.button1.Enabled = true;
                this.button2.Enabled = true;
            }


        }
        private void button1_Click(object sender, EventArgs e)
        {
            stopw.Stop();
            reactionTime.Add(stopw.ElapsedMilliseconds);
            timesButtonPressed++;
            this.textBox1.Text += string.Format("czas reakcji: {0}", reactionTime[timesButtonPressed-1]).ToString() + " ms\r\n";
            Task.Delay(rnd.Next(150, 450)).Wait();
            next_beep(rnd);


        }

        private void button3_Click(object sender, EventArgs e)
        {
            string wyniki;
            wyniki = string.Format("Twój czas to: {0}", string.Join(" ms\r\n", reactionTime)) + " ms";
            MessageBox.Show(wyniki);
        }

        private void mainokno3_Load(object sender, EventArgs e)
        {

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
