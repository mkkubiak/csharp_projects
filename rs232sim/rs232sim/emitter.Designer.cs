using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Kabel232
{
    partial class emitter
    {
        /// <summary>
        ///  Required designer variable.
        ASCIIEncoding ascii = new ASCIIEncoding();
        public bool[][] binaryString;
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.ASCIITextBox = new System.Windows.Forms.TextBox();
            this.BinaryTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ASCIITextBox
            // 
            this.ASCIITextBox.Location = new System.Drawing.Point(12, 12);
            this.ASCIITextBox.Multiline = true;
            this.ASCIITextBox.Name = "ASCIITextBox";
            this.ASCIITextBox.Size = new System.Drawing.Size(460, 160);
            this.ASCIITextBox.TabIndex = 0;
            // 
            // BinaryTextBox
            // 
            this.BinaryTextBox.BackColor = System.Drawing.SystemColors.Control;
            this.BinaryTextBox.Location = new System.Drawing.Point(12, 218);
            this.BinaryTextBox.Multiline = true;
            this.BinaryTextBox.Name = "BinaryTextBox";
            this.BinaryTextBox.Size = new System.Drawing.Size(460, 160);
            this.BinaryTextBox.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(115, 422);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 50);
            this.button1.TabIndex = 2;
            this.button1.Text = "Konwertuj\r\nASCII";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.convertButton_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(281, 422);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 50);
            this.button2.TabIndex = 3;
            this.button2.Text = "Wyślij\r\nDane";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.sendButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(57, 517);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(152, 556);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(281, 509);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 6;
            this.button3.Text = "clear";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // Nadajnik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 621);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.BinaryTextBox);
            this.Controls.Add(this.ASCIITextBox);
            this.Name = "Nadajnik";
            this.Text = "Nadajnik";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox ASCIITextBox;
        private TextBox BinaryTextBox;
        private Button button1;
        private Button button2;
        private Label label1;
        private Label label2;
        private Button button3;
    }
}