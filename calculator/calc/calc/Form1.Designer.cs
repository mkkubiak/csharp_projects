namespace calc
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        private Form2 Okno;
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.buttonPlusMinus = new System.Windows.Forms.Button();
            this.button0 = new System.Windows.Forms.Button();
            this.buttonDecimal = new System.Windows.Forms.Button();
            this.buttonEquals = new System.Windows.Forms.Button();
            this.buttonPlus = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.buttonMinus = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.buttonMult = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.buttonClearEntry = new System.Windows.Forms.Button();
            this.buttonDiv = new System.Windows.Forms.Button();
            this.buttonRightB = new System.Windows.Forms.Button();
            this.buttonLeftB = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBoxOutput = new System.Windows.Forms.TextBox();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.button16 = new System.Windows.Forms.Button();
            this.button17 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.zakończToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.historiaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.darkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lightToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.neonToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rainbowToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonPlusMinus
            // 
            this.buttonPlusMinus.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonPlusMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlusMinus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlusMinus.Location = new System.Drawing.Point(147, 568);
            this.buttonPlusMinus.Name = "buttonPlusMinus";
            this.buttonPlusMinus.Size = new System.Drawing.Size(63, 63);
            this.buttonPlusMinus.TabIndex = 3;
            this.buttonPlusMinus.Text = "+/-";
            this.buttonPlusMinus.UseVisualStyleBackColor = false;
            this.buttonPlusMinus.Click += new System.EventHandler(this.buttonPlusMinus_Click);
            // 
            // button0
            // 
            this.button0.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button0.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button0.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button0.Location = new System.Drawing.Point(216, 568);
            this.button0.Name = "button0";
            this.button0.Size = new System.Drawing.Size(63, 63);
            this.button0.TabIndex = 4;
            this.button0.Text = "0";
            this.button0.UseVisualStyleBackColor = false;
            this.button0.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonDecimal
            // 
            this.buttonDecimal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.buttonDecimal.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDecimal.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDecimal.Location = new System.Drawing.Point(285, 568);
            this.buttonDecimal.Name = "buttonDecimal";
            this.buttonDecimal.Size = new System.Drawing.Size(63, 63);
            this.buttonDecimal.TabIndex = 5;
            this.buttonDecimal.Text = ".";
            this.buttonDecimal.UseVisualStyleBackColor = false;
            this.buttonDecimal.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonEquals
            // 
            this.buttonEquals.BackColor = System.Drawing.Color.DarkGray;
            this.buttonEquals.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonEquals.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonEquals.Location = new System.Drawing.Point(354, 568);
            this.buttonEquals.Margin = new System.Windows.Forms.Padding(1);
            this.buttonEquals.Name = "buttonEquals";
            this.buttonEquals.Size = new System.Drawing.Size(63, 63);
            this.buttonEquals.TabIndex = 6;
            this.buttonEquals.Text = "=";
            this.buttonEquals.UseVisualStyleBackColor = false;
            this.buttonEquals.Click += new System.EventHandler(this.buttonEqualsClick);
            // 
            // buttonPlus
            // 
            this.buttonPlus.BackColor = System.Drawing.Color.DarkGray;
            this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonPlus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonPlus.Location = new System.Drawing.Point(354, 499);
            this.buttonPlus.Margin = new System.Windows.Forms.Padding(1);
            this.buttonPlus.Name = "buttonPlus";
            this.buttonPlus.Size = new System.Drawing.Size(63, 63);
            this.buttonPlus.TabIndex = 13;
            this.buttonPlus.Text = "+";
            this.buttonPlus.UseVisualStyleBackColor = false;
            this.buttonPlus.Click += new System.EventHandler(this.button_Click_Equ);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button3.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button3.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.Location = new System.Drawing.Point(285, 499);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(63, 63);
            this.button3.TabIndex = 12;
            this.button3.Text = "3";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button2.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.Location = new System.Drawing.Point(216, 499);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(63, 63);
            this.button2.TabIndex = 11;
            this.button2.Text = "2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button1.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.Location = new System.Drawing.Point(147, 499);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(63, 63);
            this.button1.TabIndex = 10;
            this.button1.Text = "1";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMinus
            // 
            this.buttonMinus.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMinus.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMinus.Location = new System.Drawing.Point(354, 430);
            this.buttonMinus.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMinus.Name = "buttonMinus";
            this.buttonMinus.Size = new System.Drawing.Size(63, 63);
            this.buttonMinus.TabIndex = 20;
            this.buttonMinus.Text = "-";
            this.buttonMinus.UseVisualStyleBackColor = false;
            this.buttonMinus.Click += new System.EventHandler(this.button_Click_Equ);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button6.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button6.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.Location = new System.Drawing.Point(285, 430);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(63, 63);
            this.button6.TabIndex = 19;
            this.button6.Text = "6";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button5.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button5.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.Location = new System.Drawing.Point(216, 430);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(63, 63);
            this.button5.TabIndex = 18;
            this.button5.Text = "5";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button_Click);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button4.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button4.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.Location = new System.Drawing.Point(147, 430);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(63, 63);
            this.button4.TabIndex = 17;
            this.button4.Text = "4";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonMult
            // 
            this.buttonMult.BackColor = System.Drawing.Color.DarkGray;
            this.buttonMult.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonMult.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonMult.Location = new System.Drawing.Point(354, 361);
            this.buttonMult.Margin = new System.Windows.Forms.Padding(1);
            this.buttonMult.Name = "buttonMult";
            this.buttonMult.Size = new System.Drawing.Size(63, 63);
            this.buttonMult.TabIndex = 27;
            this.buttonMult.Text = "x";
            this.buttonMult.UseVisualStyleBackColor = false;
            this.buttonMult.Click += new System.EventHandler(this.button_Click_Equ);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button9.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button9.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.Location = new System.Drawing.Point(285, 361);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(63, 63);
            this.button9.TabIndex = 26;
            this.button9.Text = "9";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.button_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button8.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button8.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.Location = new System.Drawing.Point(216, 361);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(63, 63);
            this.button8.TabIndex = 25;
            this.button8.Text = "8";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.button_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.WhiteSmoke;
            this.button7.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button7.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.Location = new System.Drawing.Point(147, 361);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(63, 63);
            this.button7.TabIndex = 24;
            this.button7.Text = "7";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonClearEntry
            // 
            this.buttonClearEntry.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClearEntry.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClearEntry.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClearEntry.Location = new System.Drawing.Point(285, 223);
            this.buttonClearEntry.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClearEntry.Name = "buttonClearEntry";
            this.buttonClearEntry.Size = new System.Drawing.Size(63, 63);
            this.buttonClearEntry.TabIndex = 39;
            this.buttonClearEntry.Text = "CE";
            this.buttonClearEntry.UseVisualStyleBackColor = false;
            this.buttonClearEntry.Click += new System.EventHandler(this.button_Click_ClearEntry);
            // 
            // buttonDiv
            // 
            this.buttonDiv.BackColor = System.Drawing.Color.DarkGray;
            this.buttonDiv.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonDiv.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDiv.Location = new System.Drawing.Point(354, 292);
            this.buttonDiv.Margin = new System.Windows.Forms.Padding(1);
            this.buttonDiv.Name = "buttonDiv";
            this.buttonDiv.Size = new System.Drawing.Size(63, 63);
            this.buttonDiv.TabIndex = 34;
            this.buttonDiv.Text = "÷";
            this.buttonDiv.UseVisualStyleBackColor = false;
            this.buttonDiv.Click += new System.EventHandler(this.button_Click_Equ);
            // 
            // buttonRightB
            // 
            this.buttonRightB.BackColor = System.Drawing.Color.DarkGray;
            this.buttonRightB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonRightB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRightB.Location = new System.Drawing.Point(285, 292);
            this.buttonRightB.Margin = new System.Windows.Forms.Padding(1);
            this.buttonRightB.Name = "buttonRightB";
            this.buttonRightB.Size = new System.Drawing.Size(63, 63);
            this.buttonRightB.TabIndex = 33;
            this.buttonRightB.Text = ")";
            this.buttonRightB.UseVisualStyleBackColor = false;
            this.buttonRightB.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonLeftB
            // 
            this.buttonLeftB.BackColor = System.Drawing.Color.DarkGray;
            this.buttonLeftB.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonLeftB.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonLeftB.Location = new System.Drawing.Point(216, 292);
            this.buttonLeftB.Margin = new System.Windows.Forms.Padding(1);
            this.buttonLeftB.Name = "buttonLeftB";
            this.buttonLeftB.Size = new System.Drawing.Size(63, 63);
            this.buttonLeftB.TabIndex = 32;
            this.buttonLeftB.Text = "(";
            this.buttonLeftB.UseVisualStyleBackColor = false;
            this.buttonLeftB.Click += new System.EventHandler(this.button_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.DarkGray;
            this.buttonClear.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.buttonClear.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonClear.Location = new System.Drawing.Point(354, 223);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(1);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(63, 63);
            this.buttonClear.TabIndex = 42;
            this.buttonClear.Text = "C";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.button_Click_Clear);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.textBoxOutput);
            this.panel1.Location = new System.Drawing.Point(9, 84);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(5);
            this.panel1.Size = new System.Drawing.Size(408, 133);
            this.panel1.TabIndex = 43;
            // 
            // textBoxOutput
            // 
            this.textBoxOutput.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxOutput.Enabled = false;
            this.textBoxOutput.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBoxOutput.Location = new System.Drawing.Point(8, 67);
            this.textBoxOutput.Multiline = true;
            this.textBoxOutput.Name = "textBoxOutput";
            this.textBoxOutput.Size = new System.Drawing.Size(392, 58);
            this.textBoxOutput.TabIndex = 44;
            this.textBoxOutput.Text = "0";
            this.textBoxOutput.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.textBoxOutput.TextChanged += new System.EventHandler(this.textBoxOutput_TextChanged);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.Color.DarkGray;
            this.button10.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button10.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.Location = new System.Drawing.Point(147, 292);
            this.button10.Margin = new System.Windows.Forms.Padding(1);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(63, 63);
            this.button10.TabIndex = 45;
            this.button10.Text = ")";
            this.button10.UseVisualStyleBackColor = false;
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.Color.DarkGray;
            this.button11.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button11.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button11.Location = new System.Drawing.Point(78, 292);
            this.button11.Margin = new System.Windows.Forms.Padding(1);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(63, 63);
            this.button11.TabIndex = 44;
            this.button11.UseVisualStyleBackColor = false;
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.Color.DarkGray;
            this.button12.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button12.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button12.Location = new System.Drawing.Point(78, 361);
            this.button12.Margin = new System.Windows.Forms.Padding(1);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(63, 63);
            this.button12.TabIndex = 46;
            this.button12.UseVisualStyleBackColor = false;
            // 
            // button15
            // 
            this.button15.BackColor = System.Drawing.Color.DarkGray;
            this.button15.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button15.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button15.Location = new System.Drawing.Point(78, 499);
            this.button15.Margin = new System.Windows.Forms.Padding(1);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(63, 63);
            this.button15.TabIndex = 48;
            this.button15.UseVisualStyleBackColor = false;
            // 
            // button16
            // 
            this.button16.BackColor = System.Drawing.Color.DarkGray;
            this.button16.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button16.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button16.Location = new System.Drawing.Point(78, 430);
            this.button16.Margin = new System.Windows.Forms.Padding(1);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(63, 63);
            this.button16.TabIndex = 47;
            this.button16.UseVisualStyleBackColor = false;
            // 
            // button17
            // 
            this.button17.BackColor = System.Drawing.Color.DarkGray;
            this.button17.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.button17.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button17.Location = new System.Drawing.Point(78, 568);
            this.button17.Margin = new System.Windows.Forms.Padding(1);
            this.button17.Name = "button17";
            this.button17.Size = new System.Drawing.Size(63, 63);
            this.button17.TabIndex = 49;
            this.button17.UseVisualStyleBackColor = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.historiaToolStripMenuItem,
            this.themeToolStripMenuItem,
            this.zakończToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(6, 6);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(413, 24);
            this.menuStrip1.TabIndex = 50;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // zakończToolStripMenuItem
            // 
            this.zakończToolStripMenuItem.Name = "zakończToolStripMenuItem";
            this.zakończToolStripMenuItem.Size = new System.Drawing.Size(48, 20);
            this.zakończToolStripMenuItem.Text = "Close";
            this.zakończToolStripMenuItem.Click += new System.EventHandler(this.zakończToolStripMenuItem_Click);
            // 
            // historiaToolStripMenuItem
            // 
            this.historiaToolStripMenuItem.Name = "historiaToolStripMenuItem";
            this.historiaToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.historiaToolStripMenuItem.Text = "History";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // themeToolStripMenuItem
            // 
            this.themeToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.darkToolStripMenuItem,
            this.lightToolStripMenuItem,
            this.neonToolStripMenuItem,
            this.rainbowToolStripMenuItem});
            this.themeToolStripMenuItem.Name = "themeToolStripMenuItem";
            this.themeToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.themeToolStripMenuItem.Text = "Theme";
            // 
            // darkToolStripMenuItem
            // 
            this.darkToolStripMenuItem.Name = "darkToolStripMenuItem";
            this.darkToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.darkToolStripMenuItem.Text = "Dark";
            this.darkToolStripMenuItem.Click += new System.EventHandler(this.darkToolStripMenuItem_Click);
            // 
            // lightToolStripMenuItem
            // 
            this.lightToolStripMenuItem.Name = "lightToolStripMenuItem";
            this.lightToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.lightToolStripMenuItem.Text = "Light";
            // 
            // neonToolStripMenuItem
            // 
            this.neonToolStripMenuItem.Name = "neonToolStripMenuItem";
            this.neonToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.neonToolStripMenuItem.Text = "Neon";
            // 
            // rainbowToolStripMenuItem
            // 
            this.rainbowToolStripMenuItem.Name = "rainbowToolStripMenuItem";
            this.rainbowToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.rainbowToolStripMenuItem.Text = "Rainbow";
            this.rainbowToolStripMenuItem.Click += new System.EventHandler(this.rainbowToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(425, 640);
            this.Controls.Add(this.button17);
            this.Controls.Add(this.button15);
            this.Controls.Add(this.button16);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.buttonClear);
            this.Controls.Add(this.buttonClearEntry);
            this.Controls.Add(this.buttonDiv);
            this.Controls.Add(this.buttonRightB);
            this.Controls.Add(this.buttonLeftB);
            this.Controls.Add(this.buttonMult);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.buttonMinus);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.buttonPlus);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonEquals);
            this.Controls.Add(this.buttonDecimal);
            this.Controls.Add(this.button0);
            this.Controls.Add(this.buttonPlusMinus);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Padding = new System.Windows.Forms.Padding(6);
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Button button0;
        private System.Windows.Forms.Button buttonDecimal;
        private System.Windows.Forms.Button buttonEquals;
        private System.Windows.Forms.Button buttonPlus;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonMinus;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button buttonMult;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button buttonClearEntry;
        private System.Windows.Forms.Button buttonDiv;
        private System.Windows.Forms.Button buttonRightB;
        private System.Windows.Forms.Button buttonLeftB;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBoxOutput;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button17;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem zakończToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem historiaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem darkToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lightToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem neonToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rainbowToolStripMenuItem;
    }
}

