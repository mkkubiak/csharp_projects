using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace cpu
{
    internal class CPU
    {
        private static bool[] rejestr = new bool[64];   //complete register array
        public const byte AH = 0;
        public const byte AL = 8;

        public const byte BH = 16;
        public const byte BL = 24;

        public const byte CH = 32;
        public const byte CL = 40;

        public const byte DH = 48;
        public const byte DL = 56;

        private static bool CF = false;     //clear flag
        private static bool SF = false;     //step flag
        private static bool OF = false;     //overflow flag

        private static string currentDirective = "";
        private static byte currentDestination = 0;
        private static byte currentDestArgument = 0;
        private static int currentValue = 0;

        public static bool[] int2bool(int x)
        {
            bool[] arr = new bool[16];
            for (int i = 15; i >=0; i--)
            {
                arr[i] = (x % 2 == 0) ? false : true;
                x /= 2;
            }
            return arr;
        }
        public static int bool2int(bool[] val)
        {
            int value = 0;
            for (int i = val.Length - 1; i >= 0; i--)
            {
                if (val[i] == false) value += 0;
                else value += (int)Math.Pow(2, val.Length - i - 1);
            }
            return value;
        }
        public static string bool2string(bool[] val)
        {
            string ss = "";
            if (val != null)
            {
                foreach (bool b in val)
                {
                    ss += (b == true ? "1" : "0");
                }
            }
            else return "pusty bool";
            return ss;
        }
        public static string bool2string(bool val)
        {
            string ss = "";
            ss = (val == true ? "1" : "0");

            return ss;
        }

        public static int string2int(string str)
        {
            int val = 0;
            if (str.Length > 16) MessageBox.Show("za dlugi string");
            else if (str.Length == 0) MessageBox.Show("pusty string");
            else
            {
                bool[] arr = new bool[str.Length];
                for (int i = str.Length - 1; i >= 0; i--)
                {
                    arr[i] = (str[i] == '1') ? true : false;
                }
                val = bool2int(arr);
            }
            return val;
        }
        public static void MOV(byte RD, byte RS)        //adresowanie rejestrowe - bajt RS zawiera adres rejestru z argumentem
        {
            for (int i = 0; i < 16; i++)
            {
                rejestr[i + RD] = rejestr[i + RS];
            }
        }
        public static void MOV(byte RD, bool[] C)       //adresowanie natychmiastowe - bool to argument bezposrednio w rozkazie
        {
            for (int i = 0; i < 16; i++)
            {
                rejestr[i + RD] = C[i];
            }
        }
        public static List<string> instructionHandler(List<instr> ins, List<string> directives, TextBox tb)
        {
            #region clear
            directives.Clear();
            currentDestArgument= 0; 
            currentDestination= 0;
            currentDirective = "";
            currentValue= 0;
            #endregion
            foreach (instr i in ins)
            {
                switch (i.ID)
                {
                    case 1:
                        directives.Add(i.Name);
                        currentDirective = i.Name;
                        break;
                    case 3: 
                        directives.Add(i.Name);
                        if (i.Name == null)
                            currentDestArgument = 0;
                        else
                            currentDestArgument = (byte)string2int(i.Name);
                        break;
                    case 2:
                        directives.Add(i.Name);
                            switch (i.Name)
                            {
                                case "AX":
                                    currentDestination = 0;
                                    break;
                                case "BX":
                                    currentDestination = 16;
                                    break;
                                case "CX":
                                    currentDestination = 32;
                                    break;
                                case "DX":
                                    currentDestination = 48;
                                    break;
                            }
                            break;
                    default:
                        directives.Add(i.ID.ToString());
                        currentValue = i.ID - 3;
                        break;
                }
            }
            directives.RemoveAll(item => item == null);
            switch(currentDirective)
            {
                case "MOV":
                    if (currentValue != 0)
                        MOV(currentDestination, int2bool(currentValue));
                    else
                        MOV(currentDestination, currentDestArgument);
                    break;
                case "ADD":
                    if (currentValue != 0)
                        tb.Text = bool2string(ADDINT(currentDestination, currentValue));
                    else
                        ADDINT(currentDestination, currentDestArgument);
                    break;
                case "SUB":
                    if (currentValue != 0)
                        // SUB(currentDestination, int2bool(currentValue));
                        currentValue = 1;
                    else
                        //SUB(currentDestination, currentDestArgument);
                        currentValue = 2;
                        break;

            }
           // tb.Text = "/" + bool2string(rejestr) + "/";



            return directives;
            
        }
        public static void refreshReg(TextBox AXH, TextBox AXL, TextBox BXH, TextBox BXL, TextBox CXH, TextBox CXL,
            TextBox DXH, TextBox DXL)
        {
            AXH.Clear();
            AXL.Clear();
            BXH.Clear();
            BXL.Clear();
            CXH.Clear();
            CXL.Clear();
            DXH.Clear();
            DXL.Clear();
            for (int i = 0; i <= 7; i++)
            {
                AXH.Text += bool2string(rejestr[i]);
                AXL.Text += bool2string(rejestr[i + 8]);
                BXH.Text += bool2string(rejestr[i + 16]);
                BXL.Text += bool2string(rejestr[i + 24]);
                CXH.Text += bool2string(rejestr[i + 32]);
                CXL.Text += bool2string(rejestr[i + 40]);
                DXH.Text += bool2string(rejestr[i + 48]);
                DXL.Text += bool2string(rejestr[i + 56]);
            }
        }
        public static void ADD(byte RS)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (rejestr[i + AH] || rejestr[i + RS]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && rejestr[i + RS]) //gry 1+1
                        {
                            rejestr[i + AH] = true; //1+1+1=11, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = false; //1+0+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = true; //0+0+1=1, więc 1 (true) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
                else
                {
                    if (rejestr[i + AH] || rejestr[i + RS]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && rejestr[i + RS]) //gry 1+1
                        {
                            rejestr[i + AH] = false; //1+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = true; //1+0=1, więc 1 (true) wyniku i przeniesienie 0
                            CF = false;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = false; //0+0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
            }
            if (CF)
            {
                CF = false;
                for (int i = 15; i >= 0; i--)
                {
                    rejestr[i + AH] = true;
                }
            }
        }
        public static void ADD2(byte regN, int arg)
        {
            for (int i = 15; i >= 0; i--)
            {
                
            }
        }

        public static bool[] ADDINT(byte regN, int arg)
        {
            int value = 0;
            bool[] tempReg = new bool[16];

            for (int i = 15; i >= 0; i--)
            {
                tempReg[i] = rejestr[regN + i];
            }
            value = bool2int(tempReg);
            value += arg;
            if (value >= 63556)
            {
                OF = true;
                value = 0;
            }
            else OF = false;
            tempReg = int2bool(value);
            for (int j = 15; j >= 0; j--)
            {
                rejestr[regN + j] = tempReg[j];
            }
            return tempReg;
        }

        public static int ADDINT(byte regN, byte regDest)
        {
            int valueN = 0;
            int valueDest = 0;
            bool[] tempRegN = new bool[16];
            bool[] tempRegDest = new bool[16];

            for (int i = 15; i >= 0; i--)
            {
                tempRegN[i] = rejestr[regN + i];
                tempRegDest[i] = rejestr[regDest + i];
            }
            valueN = bool2int(tempRegN);
            valueDest = bool2int(tempRegDest);

            valueN += valueDest;

            return valueN;
        }

        public static void ADD(bool[] liczba)
        {
            for (int i = 15; i >= 0; i--)
            {
                if (CF)
                {
                    if (rejestr[i + AH] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && liczba[i]) //gry 1+1
                        {
                            rejestr[i + AH] = true; //1+1+1=11, więc 1 (true) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = false; //1+0+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = true; //0+0+1=1, więc 1 (true) wyniku i przeniesienie 0
                        CF = false;
                    }
                }
                else
                {
                    if (rejestr[i + AH] || liczba[i]) //gdy jest chociaz jedna 1
                    {
                        if (rejestr[i + AH] && liczba[i]) //gry 1+1
                        {
                            rejestr[i + AH] = false; //1+1=10, więc 0 (false) wyniku i przeniesienie 1
                            CF = true;
                        }
                        else
                        {
                            rejestr[i + AH] = true; //1+0=1, więc 1 (true) wyniku i przeniesienie 0
                            CF = false;
                        }
                    }
                    else
                    {
                        rejestr[i + AH] = false; //0+0=0, więc 0 (false) wyniku i przeniesienie 0
                        CF = false;
                    }
                }




            }
            if (CF)
            {
                CF = false;
                for (int i = 15; i >= 0; i--)
                {
                    rejestr[i + AH] = true;
                }

            }
        }


    }
}
