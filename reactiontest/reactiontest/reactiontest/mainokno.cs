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
    public partial class mainokno : Form
    {
        Random rnd = new Random();
        Stopwatch stopw = new Stopwatch();
        List<long> timeTested = new List<long>();
        string message;
        int clicks;
        int attempts;


        public mainokno(string NickGracza)
        {
            InitializeComponent();
            this.label1.Text = "Nick: " + NickGracza;
            attempts = 0;
            clicks = 0;
            this.groupBox1.Text = "Witaj!";
        }

        private void mainokno_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stopw.Reset();
            this.button2.Text = "Naciśnij guzik niżej, gdy zmieni kolor na zielony";
            this.groupBox1.Text = "Podejście: " + attempts.ToString();
            if (attempts == 0)
            {
                MessageBox.Show("PODEJSCIE TESTOWE");
                Task.Delay(rnd.Next(700, 2100)).Wait();
                this.button1.BackColor = Color.Green;
                this.button2.Enabled = false;
                stopw.Start();
            }
            else
            {
                Task.Delay(rnd.Next(700, 2100)).Wait();
                this.button1.BackColor = Color.Green;
                this.button2.Enabled = false;
                stopw.Start();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (stopw.IsRunning & button1.BackColor == Color.Green)
            {
                stopw.Stop();
                timeTested.Add(stopw.ElapsedMilliseconds);
                button1.BackColor = Color.Red;
                clicks++;
                textBox1.Text += string.Format("Twój czas wyniósł {0} ms\n", timeTested[clicks-1]);
                button2.Enabled = true;
                this.button2.Text = "Naciśnij ponownie";
                if (clicks == 3)
                {
                    message = "Twoje wyniki to: " + String.Join(" ms, ", timeTested) + " ms";
                    MessageBox.Show(message);
                    button2.Text = "KONIEC";
                    timesTested = 0;
                    this.textBox1.Text = "";
                    timeTested.Clear();

                }

            }
            else {
                this.button2.Text = "Kliknąłeś za szybko, spróbuj ponownie";
                stopw.Reset();
                this.button1.BackColor = Color.Red;
                this.button2.Text = "Start";
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show(message);
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
