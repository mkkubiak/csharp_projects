using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cpu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region init commands
            AXHTB.Text = "00000000";
            AXLTB.Text = "00000000";
            BXHTB.Text = "00000000";
            BXLTB.Text = "00000000";
            CXHTB.Text = "00000000";
            CXLTB.Text = "00000000";
            DXHTB.Text = "00000000";
            DXLTB.Text = "00000000";
            dirLB1.Enabled = false;
            dirLB2.Enabled = false;
            dirLB3.Enabled = false;
            registerLB1.Enabled = false;
            registerArgLB1.Enabled = false;
            registerLB2.Enabled = false;
            registerArgLB2.Enabled = false;
            registerLB3.Enabled = false;
            registerArgLB3.Enabled = false;
            varTB1.Enabled = false;
            varTB2.Enabled = false;
            varTB3.Enabled = false;
            varCB1.Enabled = false;
            varCB2.Enabled = false;
            varCB3.Enabled = false;
            directives.Add("MOV");
            directives.Add("ADD");
            directives.Add("SUB");
            #endregion
        }

        private void krokCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (stepCB.Checked) SF = true;
            else SF = false;
        }

        private void dirCB1_CheckedChanged(object sender, EventArgs e)
        {
            dirLB1.Enabled = true;
            registerLB1.Enabled = true;
            registerArgLB1.Enabled = true;
            //varTB1.Enabled = true;
            varCB1.Enabled = true;
            //varTB1.Text = "0000000000000000";
        }

        private void dirLB2_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void varTB1_TextChanged(object sender, EventArgs e)
        {
            //variableFromTB1 = CPU.string2int(varTB1.Text);
            //instruction.Add(new instr() { Name = "variable", ID = variableFromTB1 });
            //directiveTB.Text = variableFromTB1.ToString() + "\r\n" + varTB1.Text.Length;

            //List<instr> sublist = instruction.FindAll(EndsWithVariable);
            //instruction.RemoveAll(s => EndsWithVariable());
            
        }
        private static bool EndsWithVariable(String s)
        {
            return s.ToLower().EndsWith("Variable");
        }
        private void varTB1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar) | 
                (char.IsDigit(e.KeyChar) && (e.KeyChar == '1' | e.KeyChar == '0'))) e.Handled = false;
            else e.Handled = true;
        }

        private void dirLB1_SelectedIndexChanged(object sender, EventArgs e)
        { 
            if (dirLB1.SelectedItem != null)
            {
                selectedDirective = dirLB1.SelectedItem.ToString();
                //overflowFlagTB4.Text = dirLB1.SelectedItem.ToString();
                //instruction.Add(new instr() { Name = selectedRegister, ID = 2 });
            }
            else selectedDirective = "";

            //instruction.Add(new instr() { Name = selectedDirective, ID = 1 });
        }

        private void registerCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registerLB1.SelectedItem != null) selectedRegister = registerLB1.SelectedItem.ToString();
            else selectedRegister = "";
            varTB1.Enabled = true;
            varCB1.Checked = true;
            varCB1.Enabled = true;

        }

        private void registerArgCB1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (registerArgLB1.SelectedItem != null) selectedRegisterArg = registerArgLB1.SelectedItem.ToString();
            else selectedRegisterArg = "";

            if (dirLB1.SelectedItem.ToString() == "ADD" | dirLB1.SelectedItem.ToString() == "SUB")
            {
                varTB1.Enabled = false;
                varTB1.Text = "";
                varCB1.Checked = false;
                varCB1.Enabled = false;
            }
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            directiveTB.Text = "";
            
            instruction.Add(new instr() { Name = selectedRegister, ID = 2 });
            instruction.Add(new instr() { Name = selectedDirective, ID = 1 });
            instruction.Add(new instr() { Name = selectedRegisterArg, ID = 3 });
            if (varCB1.Checked)
            {
                variableFromTB1 = CPU.string2int(varTB1.Text);
                overflowFlagTB1.Text = variableFromTB1.ToString();
                instruction.Add(new instr() { Name = "Variable", ID = variableFromTB1+3 });     //+3 poniewaz sa 3 inne ID zajete
            }
            instruction.Sort();
            directives = CPU.instructionHandler(instruction, directives, directiveTB);
            CPU.refreshReg(AXHTB, AXLTB, BXHTB, BXLTB, CXHTB, CXLTB, DXHTB, DXLTB);
            foreach (string s in directives)
            {
                //directiveTB.Text += s + "\r\n";
            }
            instruction.Clear();
        }

        private void varCB1_CheckedChanged(object sender, EventArgs e)
        {
            varTB1.Enabled = true;
            varTB1.Text = "0000000000000000";
        }

        private void wczytajToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
    }
}
