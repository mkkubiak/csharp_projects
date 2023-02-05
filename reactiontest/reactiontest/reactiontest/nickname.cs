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
    public partial class nickname : Form
    {
        public nickname()
        {
            InitializeComponent();
            this.label3.Visible = false;
        }

        private void podajnick_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            NickGracza = this.textBox1.Text;
            this.label3.Text = "Wprowadzono!";
            this.label3.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (NickGracza == null)
            {
                MessageBox.Show("Wprowadz nick!");
            }
            else
            {
                this.OknoGlowne = new mainokno(NickGracza);
                this.OknoGlowne.Show();
                this.Close();
            }
        }
    

        private void button3_Click(object sender, EventArgs e)
        {
            if(NickGracza == null)
            {
                MessageBox.Show("Wprowadz nick!");
            }
            else
            {
                this.OknoGlowne2 = new mainokno2(NickGracza);
                this.OknoGlowne2.Show();
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (NickGracza == null)
            {
                MessageBox.Show("Wprowadz nick!");
            }
            else
            {
                this.OknoGlowne3 = new mainokno3(NickGracza);
                this.OknoGlowne3.Show();
                this.Close();
            }
        }
    }
}
