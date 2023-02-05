using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace calc
{
    public partial class Form1 : Form
    {
        private string currentCalc = "";
        private int calculated = 0;
        
        public Form1()
        {
            InitializeComponent();
            this.BackColor = Color.FromArgb(255, 232, 232);
        }
        private void button_Click(object sender, EventArgs e)
        {
            if (calculated == 1) {
                currentCalc = "";
                textBoxOutput.Text = "0";
                calculated = 0;
            }
            currentCalc += (sender as Button).Text;
            textBoxOutput.Text = currentCalc;
        }

        private void button_Click_Equ(object sender, EventArgs e)
        {
            
            currentCalc += Environment.NewLine + (sender as Button).Text + " ";
            textBoxOutput.Text = currentCalc;
            
        }

        private void buttonEqualsClick(object sender, EventArgs e)
        {
            string formattedCalc = currentCalc.ToString().Replace("x", "*").ToString().Replace("÷", "/");
            try
            {
                textBoxOutput.Text = new DataTable().Compute(formattedCalc, null).ToString();
                currentCalc = textBoxOutput.Text;
                calculated = 1;
            }
            catch (Exception ex)
            {
                textBoxOutput.Text = "0";
                currentCalc = "";
                MessageBox.Show(ex.Message);
            }
       
        }

        private void button_Click_ClearEntry(object sender, EventArgs e)
        {
            currentCalc = "";
            textBoxOutput.Text = "0";
        }
        private void button_Click_Clear(object sender, EventArgs e)
        {
            if (currentCalc.Length > 0)
            {
                currentCalc = currentCalc.Remove(currentCalc.Length - 1, 1);
            }
            textBoxOutput.Text = currentCalc;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void textBoxOutput_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonpp_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            currentCalc = "-" + currentCalc;
            textBoxOutput.Text = currentCalc;

        }

        private void darkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.FormBackground = Color.Gray;
            Properties.Settings.Default.Save();
            this.BackColor = Color.DimGray;
            colorchange_digits(Color.DarkGray);
            colorchange_operands(Color.LightGray);

        }

        private void colorchange_digits(Color backcolor)
        {
            this.buttonPlusMinus.BackColor = backcolor;
            this.buttonDecimal.BackColor = backcolor;
            this.button0.BackColor = backcolor;
            this.button1.BackColor = backcolor;
            this.button2.BackColor = backcolor;
            this.button3.BackColor = backcolor;
            this.button4.BackColor = backcolor;
            this.button5.BackColor = backcolor;
            this.button6.BackColor = backcolor;
            this.button7.BackColor = backcolor;
            this.button8.BackColor = backcolor;
            this.button9.BackColor = backcolor;
        }

        private void colorchange_operands(Color backcolor)
        {
            this.buttonPlus.BackColor = backcolor;
            this.buttonMinus.BackColor = backcolor;
            this.buttonDiv.BackColor = backcolor;
            this.buttonMult.BackColor = backcolor;
            this.buttonEquals.BackColor = backcolor;
            this.buttonClear.BackColor = backcolor;
            this.buttonClearEntry.BackColor = backcolor;
            this.buttonLeftB.BackColor = backcolor;
            this.buttonRightB.BackColor = backcolor;
        }
        private void zakończToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rainbowToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDlg = new ColorDialog();
            if (colorDlg.ShowDialog() == DialogResult.OK)
            {
                int arr;
                Properties.Settings.Default.FormBackground = colorDlg.Color;
                Properties.Settings.Default.Save();
                this.BackColor = colorDlg.Color;
                arr = colorDlg.Color.ToArgb();
                this.Okno = new Form2(arr);
                this.Okno.Show();
                this.textBoxOutput.BackColor = Color.FromArgb(arr -22);
            }
        }
    }
}
