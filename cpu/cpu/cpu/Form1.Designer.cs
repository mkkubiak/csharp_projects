using System.Collections.Generic;

namespace cpu
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        private static string selectedDirective;
        private static string selectedRegister;
        private static string selectedRegisterArg;
        private static int variableFromTB1;
        private static int variableFromTB2;
        private static int variableFromTB3;
        public static List<string> directives = new List<string>();
        private static List<instr> instruction = new List<instr>();
        public static bool SF;
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextStepButton = new System.Windows.Forms.Button();
            this.stepCB = new System.Windows.Forms.CheckBox();
            this.overflowFlagTB4 = new System.Windows.Forms.TextBox();
            this.overflowFlagTB3 = new System.Windows.Forms.TextBox();
            this.overflowFlagTB2 = new System.Windows.Forms.TextBox();
            this.overflowFlagTB1 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.varCB1 = new System.Windows.Forms.CheckBox();
            this.registerArgLB1 = new System.Windows.Forms.ListBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dirCB1 = new System.Windows.Forms.CheckBox();
            this.varTB1 = new System.Windows.Forms.TextBox();
            this.registerLB1 = new System.Windows.Forms.ListBox();
            this.dirLB1 = new System.Windows.Forms.ListBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.DXHTB = new System.Windows.Forms.TextBox();
            this.DXLTB = new System.Windows.Forms.TextBox();
            this.CXHTB = new System.Windows.Forms.TextBox();
            this.CXLTB = new System.Windows.Forms.TextBox();
            this.BXHTB = new System.Windows.Forms.TextBox();
            this.BXLTB = new System.Windows.Forms.TextBox();
            this.AXLTB = new System.Windows.Forms.TextBox();
            this.AXHTB = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.varCB2 = new System.Windows.Forms.CheckBox();
            this.registerArgLB2 = new System.Windows.Forms.ListBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dirCB2 = new System.Windows.Forms.CheckBox();
            this.varTB2 = new System.Windows.Forms.TextBox();
            this.registerLB2 = new System.Windows.Forms.ListBox();
            this.dirLB2 = new System.Windows.Forms.ListBox();
            this.label14 = new System.Windows.Forms.Label();
            this.varCB3 = new System.Windows.Forms.CheckBox();
            this.registerArgLB3 = new System.Windows.Forms.ListBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dirCB3 = new System.Windows.Forms.CheckBox();
            this.varTB3 = new System.Windows.Forms.TextBox();
            this.registerLB3 = new System.Windows.Forms.ListBox();
            this.dirLB3 = new System.Windows.Forms.ListBox();
            this.directiveTB = new System.Windows.Forms.TextBox();
            this.directiveList = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.wczytajToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextStepButton
            // 
            this.nextStepButton.Location = new System.Drawing.Point(244, 426);
            this.nextStepButton.Name = "nextStepButton";
            this.nextStepButton.Size = new System.Drawing.Size(75, 23);
            this.nextStepButton.TabIndex = 98;
            this.nextStepButton.Text = "Dalej";
            this.nextStepButton.UseVisualStyleBackColor = true;
            // 
            // stepCB
            // 
            this.stepCB.AutoSize = true;
            this.stepCB.Location = new System.Drawing.Point(30, 426);
            this.stepCB.Name = "stepCB";
            this.stepCB.Size = new System.Drawing.Size(97, 17);
            this.stepCB.TabIndex = 97;
            this.stepCB.Text = "praca krokowa";
            this.stepCB.UseVisualStyleBackColor = true;
            this.stepCB.CheckedChanged += new System.EventHandler(this.krokCheckBox_CheckedChanged);
            // 
            // overflowFlagTB4
            // 
            this.overflowFlagTB4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.overflowFlagTB4.Location = new System.Drawing.Point(201, 121);
            this.overflowFlagTB4.MaxLength = 8;
            this.overflowFlagTB4.Name = "overflowFlagTB4";
            this.overflowFlagTB4.ReadOnly = true;
            this.overflowFlagTB4.Size = new System.Drawing.Size(57, 20);
            this.overflowFlagTB4.TabIndex = 96;
            this.overflowFlagTB4.Text = "0";
            // 
            // overflowFlagTB3
            // 
            this.overflowFlagTB3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.overflowFlagTB3.Location = new System.Drawing.Point(201, 95);
            this.overflowFlagTB3.MaxLength = 8;
            this.overflowFlagTB3.Name = "overflowFlagTB3";
            this.overflowFlagTB3.ReadOnly = true;
            this.overflowFlagTB3.Size = new System.Drawing.Size(57, 20);
            this.overflowFlagTB3.TabIndex = 95;
            this.overflowFlagTB3.Text = "0";
            // 
            // overflowFlagTB2
            // 
            this.overflowFlagTB2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.overflowFlagTB2.Location = new System.Drawing.Point(201, 69);
            this.overflowFlagTB2.MaxLength = 8;
            this.overflowFlagTB2.Name = "overflowFlagTB2";
            this.overflowFlagTB2.ReadOnly = true;
            this.overflowFlagTB2.Size = new System.Drawing.Size(57, 20);
            this.overflowFlagTB2.TabIndex = 94;
            this.overflowFlagTB2.Text = "0";
            // 
            // overflowFlagTB1
            // 
            this.overflowFlagTB1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.overflowFlagTB1.Location = new System.Drawing.Point(201, 43);
            this.overflowFlagTB1.MaxLength = 8;
            this.overflowFlagTB1.Name = "overflowFlagTB1";
            this.overflowFlagTB1.ReadOnly = true;
            this.overflowFlagTB1.Size = new System.Drawing.Size(57, 20);
            this.overflowFlagTB1.TabIndex = 93;
            this.overflowFlagTB1.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(216, 23);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(21, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "OF";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(142, 426);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(75, 23);
            this.startButton.TabIndex = 91;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // varCB1
            // 
            this.varCB1.AutoSize = true;
            this.varCB1.Enabled = false;
            this.varCB1.Location = new System.Drawing.Point(251, 196);
            this.varCB1.Name = "varCB1";
            this.varCB1.Size = new System.Drawing.Size(52, 17);
            this.varCB1.TabIndex = 84;
            this.varCB1.Text = "Stała";
            this.varCB1.UseVisualStyleBackColor = true;
            this.varCB1.CheckedChanged += new System.EventHandler(this.varCB1_CheckedChanged);
            // 
            // registerArgLB1
            // 
            this.registerArgLB1.Enabled = false;
            this.registerArgLB1.FormattingEnabled = true;
            this.registerArgLB1.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.registerArgLB1.Location = new System.Drawing.Point(193, 169);
            this.registerArgLB1.Name = "registerArgLB1";
            this.registerArgLB1.Size = new System.Drawing.Size(49, 56);
            this.registerArgLB1.TabIndex = 83;
            this.registerArgLB1.SelectedIndexChanged += new System.EventHandler(this.registerArgCB1_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(126, 153);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(56, 13);
            this.label8.TabIndex = 82;
            this.label8.Text = "rejestr doc";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 153);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 81;
            this.label7.Text = "rozkaz";
            // 
            // dirCB1
            // 
            this.dirCB1.AutoSize = true;
            this.dirCB1.Location = new System.Drawing.Point(30, 186);
            this.dirCB1.Name = "dirCB1";
            this.dirCB1.Size = new System.Drawing.Size(15, 14);
            this.dirCB1.TabIndex = 68;
            this.dirCB1.UseVisualStyleBackColor = true;
            this.dirCB1.CheckedChanged += new System.EventHandler(this.dirCB1_CheckedChanged);
            // 
            // varTB1
            // 
            this.varTB1.Enabled = false;
            this.varTB1.Location = new System.Drawing.Point(251, 169);
            this.varTB1.MaxLength = 16;
            this.varTB1.Name = "varTB1";
            this.varTB1.Size = new System.Drawing.Size(120, 20);
            this.varTB1.TabIndex = 67;
            this.varTB1.TextChanged += new System.EventHandler(this.varTB1_TextChanged);
            this.varTB1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.varTB1_KeyPress);
            // 
            // registerLB1
            // 
            this.registerLB1.Enabled = false;
            this.registerLB1.FormattingEnabled = true;
            this.registerLB1.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.registerLB1.Location = new System.Drawing.Point(129, 169);
            this.registerLB1.Name = "registerLB1";
            this.registerLB1.Size = new System.Drawing.Size(49, 56);
            this.registerLB1.TabIndex = 66;
            this.registerLB1.SelectedIndexChanged += new System.EventHandler(this.registerCB1_SelectedIndexChanged);
            // 
            // dirLB1
            // 
            this.dirLB1.Enabled = false;
            this.dirLB1.FormattingEnabled = true;
            this.dirLB1.Items.AddRange(new object[] {
            "MOV",
            "ADD",
            "SUB"});
            this.dirLB1.Location = new System.Drawing.Point(62, 169);
            this.dirLB1.Name = "dirLB1";
            this.dirLB1.Size = new System.Drawing.Size(49, 56);
            this.dirLB1.TabIndex = 65;
            this.dirLB1.SelectedIndexChanged += new System.EventHandler(this.dirLB1_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(153, 23);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(13, 13);
            this.label6.TabIndex = 64;
            this.label6.Text = "L";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Control;
            this.label5.Location = new System.Drawing.Point(82, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "H";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(30, 124);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 62;
            this.label4.Text = "DX";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(30, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(21, 13);
            this.label3.TabIndex = 61;
            this.label3.Text = "CX";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(30, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 60;
            this.label2.Text = "BX";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(30, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(21, 13);
            this.label1.TabIndex = 59;
            this.label1.Text = "AX";
            // 
            // DXHTB
            // 
            this.DXHTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DXHTB.Location = new System.Drawing.Point(57, 121);
            this.DXHTB.MaxLength = 8;
            this.DXHTB.Name = "DXHTB";
            this.DXHTB.ReadOnly = true;
            this.DXHTB.Size = new System.Drawing.Size(70, 20);
            this.DXHTB.TabIndex = 58;
            // 
            // DXLTB
            // 
            this.DXLTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DXLTB.Location = new System.Drawing.Point(130, 121);
            this.DXLTB.MaxLength = 8;
            this.DXLTB.Name = "DXLTB";
            this.DXLTB.ReadOnly = true;
            this.DXLTB.Size = new System.Drawing.Size(68, 20);
            this.DXLTB.TabIndex = 57;
            // 
            // CXHTB
            // 
            this.CXHTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CXHTB.Location = new System.Drawing.Point(57, 95);
            this.CXHTB.MaxLength = 8;
            this.CXHTB.Name = "CXHTB";
            this.CXHTB.ReadOnly = true;
            this.CXHTB.Size = new System.Drawing.Size(70, 20);
            this.CXHTB.TabIndex = 56;
            // 
            // CXLTB
            // 
            this.CXLTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.CXLTB.Location = new System.Drawing.Point(130, 95);
            this.CXLTB.MaxLength = 8;
            this.CXLTB.Name = "CXLTB";
            this.CXLTB.ReadOnly = true;
            this.CXLTB.Size = new System.Drawing.Size(68, 20);
            this.CXLTB.TabIndex = 55;
            // 
            // BXHTB
            // 
            this.BXHTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BXHTB.Location = new System.Drawing.Point(57, 69);
            this.BXHTB.MaxLength = 8;
            this.BXHTB.Name = "BXHTB";
            this.BXHTB.ReadOnly = true;
            this.BXHTB.Size = new System.Drawing.Size(70, 20);
            this.BXHTB.TabIndex = 54;
            // 
            // BXLTB
            // 
            this.BXLTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.BXLTB.Location = new System.Drawing.Point(130, 69);
            this.BXLTB.MaxLength = 8;
            this.BXLTB.Name = "BXLTB";
            this.BXLTB.ReadOnly = true;
            this.BXLTB.Size = new System.Drawing.Size(68, 20);
            this.BXLTB.TabIndex = 53;
            // 
            // AXLTB
            // 
            this.AXLTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AXLTB.Location = new System.Drawing.Point(130, 43);
            this.AXLTB.MaxLength = 8;
            this.AXLTB.Name = "AXLTB";
            this.AXLTB.ReadOnly = true;
            this.AXLTB.Size = new System.Drawing.Size(68, 20);
            this.AXLTB.TabIndex = 52;
            // 
            // AXHTB
            // 
            this.AXHTB.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AXHTB.Location = new System.Drawing.Point(57, 43);
            this.AXHTB.MaxLength = 8;
            this.AXHTB.Name = "AXHTB";
            this.AXHTB.ReadOnly = true;
            this.AXHTB.Size = new System.Drawing.Size(70, 20);
            this.AXHTB.TabIndex = 51;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(192, 153);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(53, 13);
            this.label10.TabIndex = 99;
            this.label10.Text = "rejestr arg";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(192, 238);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 13);
            this.label11.TabIndex = 108;
            this.label11.Text = "rejestr arg";
            // 
            // varCB2
            // 
            this.varCB2.AutoSize = true;
            this.varCB2.Enabled = false;
            this.varCB2.Location = new System.Drawing.Point(251, 281);
            this.varCB2.Name = "varCB2";
            this.varCB2.Size = new System.Drawing.Size(52, 17);
            this.varCB2.TabIndex = 107;
            this.varCB2.Text = "Stała";
            this.varCB2.UseVisualStyleBackColor = true;
            // 
            // registerArgLB2
            // 
            this.registerArgLB2.Enabled = false;
            this.registerArgLB2.FormattingEnabled = true;
            this.registerArgLB2.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.registerArgLB2.Location = new System.Drawing.Point(193, 254);
            this.registerArgLB2.Name = "registerArgLB2";
            this.registerArgLB2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.registerArgLB2.Size = new System.Drawing.Size(49, 56);
            this.registerArgLB2.TabIndex = 106;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(126, 238);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(56, 13);
            this.label12.TabIndex = 105;
            this.label12.Text = "rejestr doc";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(59, 238);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(38, 13);
            this.label13.TabIndex = 104;
            this.label13.Text = "rozkaz";
            // 
            // dirCB2
            // 
            this.dirCB2.AutoSize = true;
            this.dirCB2.Location = new System.Drawing.Point(30, 271);
            this.dirCB2.Name = "dirCB2";
            this.dirCB2.Size = new System.Drawing.Size(15, 14);
            this.dirCB2.TabIndex = 103;
            this.dirCB2.UseVisualStyleBackColor = true;
            // 
            // varTB2
            // 
            this.varTB2.Enabled = false;
            this.varTB2.Location = new System.Drawing.Point(251, 254);
            this.varTB2.MaxLength = 16;
            this.varTB2.Name = "varTB2";
            this.varTB2.Size = new System.Drawing.Size(120, 20);
            this.varTB2.TabIndex = 102;
            this.varTB2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.varTB1_KeyPress);
            // 
            // registerLB2
            // 
            this.registerLB2.Enabled = false;
            this.registerLB2.FormattingEnabled = true;
            this.registerLB2.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.registerLB2.Location = new System.Drawing.Point(129, 254);
            this.registerLB2.Name = "registerLB2";
            this.registerLB2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.registerLB2.Size = new System.Drawing.Size(49, 56);
            this.registerLB2.TabIndex = 101;
            // 
            // dirLB2
            // 
            this.dirLB2.Enabled = false;
            this.dirLB2.FormattingEnabled = true;
            this.dirLB2.Items.AddRange(new object[] {
            "MOV",
            "ADD",
            "SUB"});
            this.dirLB2.Location = new System.Drawing.Point(62, 254);
            this.dirLB2.Name = "dirLB2";
            this.dirLB2.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.dirLB2.Size = new System.Drawing.Size(49, 56);
            this.dirLB2.TabIndex = 100;
            this.dirLB2.SelectedIndexChanged += new System.EventHandler(this.dirLB2_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(192, 329);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(53, 13);
            this.label14.TabIndex = 117;
            this.label14.Text = "rejestr arg";
            // 
            // varCB3
            // 
            this.varCB3.AutoSize = true;
            this.varCB3.Enabled = false;
            this.varCB3.Location = new System.Drawing.Point(251, 372);
            this.varCB3.Name = "varCB3";
            this.varCB3.Size = new System.Drawing.Size(52, 17);
            this.varCB3.TabIndex = 116;
            this.varCB3.Text = "Stała";
            this.varCB3.UseVisualStyleBackColor = true;
            // 
            // registerArgLB3
            // 
            this.registerArgLB3.Enabled = false;
            this.registerArgLB3.FormattingEnabled = true;
            this.registerArgLB3.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.registerArgLB3.Location = new System.Drawing.Point(193, 345);
            this.registerArgLB3.Name = "registerArgLB3";
            this.registerArgLB3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.registerArgLB3.Size = new System.Drawing.Size(49, 56);
            this.registerArgLB3.TabIndex = 115;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(126, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(56, 13);
            this.label15.TabIndex = 114;
            this.label15.Text = "rejestr doc";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(59, 329);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(38, 13);
            this.label16.TabIndex = 113;
            this.label16.Text = "rozkaz";
            // 
            // dirCB3
            // 
            this.dirCB3.AutoSize = true;
            this.dirCB3.Location = new System.Drawing.Point(30, 362);
            this.dirCB3.Name = "dirCB3";
            this.dirCB3.Size = new System.Drawing.Size(15, 14);
            this.dirCB3.TabIndex = 112;
            this.dirCB3.UseVisualStyleBackColor = true;
            // 
            // varTB3
            // 
            this.varTB3.Enabled = false;
            this.varTB3.Location = new System.Drawing.Point(251, 345);
            this.varTB3.MaxLength = 16;
            this.varTB3.Name = "varTB3";
            this.varTB3.Size = new System.Drawing.Size(120, 20);
            this.varTB3.TabIndex = 111;
            this.varTB3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.varTB1_KeyPress);
            // 
            // registerLB3
            // 
            this.registerLB3.Enabled = false;
            this.registerLB3.FormattingEnabled = true;
            this.registerLB3.Items.AddRange(new object[] {
            "AX",
            "BX",
            "CX",
            "DX"});
            this.registerLB3.Location = new System.Drawing.Point(129, 345);
            this.registerLB3.Name = "registerLB3";
            this.registerLB3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.registerLB3.Size = new System.Drawing.Size(49, 56);
            this.registerLB3.TabIndex = 110;
            // 
            // dirLB3
            // 
            this.dirLB3.Enabled = false;
            this.dirLB3.FormattingEnabled = true;
            this.dirLB3.Items.AddRange(new object[] {
            "MOV",
            "ADD",
            "SUB"});
            this.dirLB3.Location = new System.Drawing.Point(62, 345);
            this.dirLB3.Name = "dirLB3";
            this.dirLB3.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.dirLB3.Size = new System.Drawing.Size(49, 56);
            this.dirLB3.TabIndex = 109;
            // 
            // directiveTB
            // 
            this.directiveTB.Location = new System.Drawing.Point(381, 169);
            this.directiveTB.Multiline = true;
            this.directiveTB.Name = "directiveTB";
            this.directiveTB.Size = new System.Drawing.Size(128, 232);
            this.directiveTB.TabIndex = 118;
            // 
            // directiveList
            // 
            this.directiveList.AutoSize = true;
            this.directiveList.Location = new System.Drawing.Point(381, 150);
            this.directiveList.Name = "directiveList";
            this.directiveList.Size = new System.Drawing.Size(73, 13);
            this.directiveList.TabIndex = 119;
            this.directiveList.Text = "lista rozkazów";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.wczytajToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(534, 24);
            this.menuStrip1.TabIndex = 120;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // wczytajToolStripMenuItem
            // 
            this.wczytajToolStripMenuItem.Name = "wczytajToolStripMenuItem";
            this.wczytajToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.wczytajToolStripMenuItem.Text = "Wczytaj";
            this.wczytajToolStripMenuItem.Click += new System.EventHandler(this.wczytajToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 484);
            this.Controls.Add(this.directiveList);
            this.Controls.Add(this.directiveTB);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.varCB3);
            this.Controls.Add(this.registerArgLB3);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.dirCB3);
            this.Controls.Add(this.varTB3);
            this.Controls.Add(this.registerLB3);
            this.Controls.Add(this.dirLB3);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.varCB2);
            this.Controls.Add(this.registerArgLB2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dirCB2);
            this.Controls.Add(this.varTB2);
            this.Controls.Add(this.registerLB2);
            this.Controls.Add(this.dirLB2);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.nextStepButton);
            this.Controls.Add(this.stepCB);
            this.Controls.Add(this.overflowFlagTB4);
            this.Controls.Add(this.overflowFlagTB3);
            this.Controls.Add(this.overflowFlagTB2);
            this.Controls.Add(this.overflowFlagTB1);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.varCB1);
            this.Controls.Add(this.registerArgLB1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dirCB1);
            this.Controls.Add(this.varTB1);
            this.Controls.Add(this.registerLB1);
            this.Controls.Add(this.dirLB1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.DXHTB);
            this.Controls.Add(this.DXLTB);
            this.Controls.Add(this.CXHTB);
            this.Controls.Add(this.CXLTB);
            this.Controls.Add(this.BXHTB);
            this.Controls.Add(this.BXLTB);
            this.Controls.Add(this.AXLTB);
            this.Controls.Add(this.AXHTB);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "CPU";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button nextStepButton;
        private System.Windows.Forms.CheckBox stepCB;
        private System.Windows.Forms.TextBox overflowFlagTB4;
        private System.Windows.Forms.TextBox overflowFlagTB3;
        private System.Windows.Forms.TextBox overflowFlagTB2;
        private System.Windows.Forms.TextBox overflowFlagTB1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.CheckBox varCB1;
        private System.Windows.Forms.ListBox registerArgLB1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox dirCB1;
        private System.Windows.Forms.TextBox varTB1;
        private System.Windows.Forms.ListBox registerLB1;
        private System.Windows.Forms.ListBox dirLB1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox DXHTB;
        private System.Windows.Forms.TextBox DXLTB;
        private System.Windows.Forms.TextBox CXHTB;
        private System.Windows.Forms.TextBox CXLTB;
        private System.Windows.Forms.TextBox BXHTB;
        private System.Windows.Forms.TextBox BXLTB;
        private System.Windows.Forms.TextBox AXLTB;
        private System.Windows.Forms.TextBox AXHTB;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.CheckBox varCB2;
        private System.Windows.Forms.ListBox registerArgLB2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox dirCB2;
        private System.Windows.Forms.TextBox varTB2;
        private System.Windows.Forms.ListBox registerLB2;
        private System.Windows.Forms.ListBox dirLB2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox varCB3;
        private System.Windows.Forms.ListBox registerArgLB3;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.CheckBox dirCB3;
        private System.Windows.Forms.TextBox varTB3;
        private System.Windows.Forms.ListBox registerLB3;
        private System.Windows.Forms.ListBox dirLB3;
        private System.Windows.Forms.TextBox directiveTB;
        private System.Windows.Forms.Label directiveList;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem wczytajToolStripMenuItem;
    }
}

