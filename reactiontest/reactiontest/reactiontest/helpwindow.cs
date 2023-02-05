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
    public partial class oknohelp : Form
    {
        public oknohelp(string Tekst1)
        {
            InitializeComponent();
            this.label1.Text = Tekst1;
        }

        private void oknohelp_Load(object sender, EventArgs e)
        {
            
        }
    }
}
