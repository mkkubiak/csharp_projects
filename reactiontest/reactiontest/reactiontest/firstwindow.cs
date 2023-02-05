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

    public partial class firstwindow : Form
    {
        public firstwindow()
        {
            InitializeComponent();
            OknoPomoc = null;
            GlowneOkno = null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.PodajNazweUzytkownika = new nickname();
            this.PodajNazweUzytkownika.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            
        }

        private void label1_MouseHover(object sender, EventArgs e)
        {
            this.OknoPomoc = new oknohelp("dddd help");
            this.OknoPomoc.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Prosty test czasu reakcji: Kliknij Start, następnie kliknij w czerwony guzik gdy zmieni kolor na zielony. Kolejne podejście rozpoczyna się \r\n" +
                "kliknięciem w Naciśnij ponownie. Test do 3 powtórzeń\r\n" +
                "Złożony test czasu reakcji: kliknij w przycisk, gdy pojawi się na planszy. Test do 3 powtórzeń\r\n" +
                "Test akustyczny: kliknij szary przycisk, gdy usłyszysz dźwięk. Test do 3 powtórzeń");
        }
    }
}
