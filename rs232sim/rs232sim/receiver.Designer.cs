using System.Text;
using System.Windows.Forms.VisualStyles;

namespace Kabel232
{
    partial class receiver
    {
        /// <summary>
        /// Required designer variable.
        ASCIIEncoding ascii = new ASCIIEncoding();
        public bool[][] receivedBinary;
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.clearTextBoxesButton = new System.Windows.Forms.Button();
            this.asciiCountLabel = new System.Windows.Forms.Label();
            this.receiverASCIITextBox = new System.Windows.Forms.TextBox();
            this.receiverBinaryTextBox = new System.Windows.Forms.TextBox();
            this.closeReceiverButton = new System.Windows.Forms.Button();
            this.convertBinaryButton = new System.Windows.Forms.Button();
            this.transformedCountLabel = new System.Windows.Forms.Label();
            this.receivedByteCountLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // clearTextBoxesButton
            // 
            this.clearTextBoxesButton.Location = new System.Drawing.Point(281, 509);
            this.clearTextBoxesButton.Name = "clearTextBoxesButton";
            this.clearTextBoxesButton.Size = new System.Drawing.Size(75, 23);
            this.clearTextBoxesButton.TabIndex = 13;
            this.clearTextBoxesButton.Text = "clear";
            this.clearTextBoxesButton.UseVisualStyleBackColor = true;
            this.clearTextBoxesButton.Click += new System.EventHandler(this.clearTextBoxesButton_Click);
            // 
            // asciiCountLabel
            // 
            this.asciiCountLabel.AutoSize = true;
            this.asciiCountLabel.Location = new System.Drawing.Point(23, 524);
            this.asciiCountLabel.Name = "asciiCountLabel";
            this.asciiCountLabel.Size = new System.Drawing.Size(38, 15);
            this.asciiCountLabel.TabIndex = 12;
            this.asciiCountLabel.Text = "label2";
            // 
            // receiverASCIITextBox
            // 
            this.receiverASCIITextBox.BackColor = System.Drawing.SystemColors.Control;
            this.receiverASCIITextBox.Location = new System.Drawing.Point(12, 218);
            this.receiverASCIITextBox.Multiline = true;
            this.receiverASCIITextBox.Name = "receiverASCIITextBox";
            this.receiverASCIITextBox.Size = new System.Drawing.Size(460, 160);
            this.receiverASCIITextBox.TabIndex = 8;
            // 
            // receiverBinaryTextBox
            // 
            this.receiverBinaryTextBox.Location = new System.Drawing.Point(12, 12);
            this.receiverBinaryTextBox.Multiline = true;
            this.receiverBinaryTextBox.Name = "receiverBinaryTextBox";
            this.receiverBinaryTextBox.Size = new System.Drawing.Size(460, 160);
            this.receiverBinaryTextBox.TabIndex = 7;
            // 
            // closeReceiverButton
            // 
            this.closeReceiverButton.Location = new System.Drawing.Point(281, 422);
            this.closeReceiverButton.Name = "closeReceiverButton";
            this.closeReceiverButton.Size = new System.Drawing.Size(75, 50);
            this.closeReceiverButton.TabIndex = 15;
            this.closeReceiverButton.Text = "Zamknij\r\nOkno";
            this.closeReceiverButton.UseVisualStyleBackColor = true;
            this.closeReceiverButton.Click += new System.EventHandler(this.closeReceiverButton_Click);
            // 
            // convertBinaryButton
            // 
            this.convertBinaryButton.Location = new System.Drawing.Point(115, 422);
            this.convertBinaryButton.Name = "convertBinaryButton";
            this.convertBinaryButton.Size = new System.Drawing.Size(75, 50);
            this.convertBinaryButton.TabIndex = 14;
            this.convertBinaryButton.Text = "Konwertuj\rBinary";
            this.convertBinaryButton.UseVisualStyleBackColor = true;
            this.convertBinaryButton.Click += new System.EventHandler(this.convertBinaryButton_Click);
            // 
            // transformedCountLabel
            // 
            this.transformedCountLabel.AutoSize = true;
            this.transformedCountLabel.Location = new System.Drawing.Point(23, 509);
            this.transformedCountLabel.Name = "transformedCountLabel";
            this.transformedCountLabel.Size = new System.Drawing.Size(38, 15);
            this.transformedCountLabel.TabIndex = 16;
            this.transformedCountLabel.Text = "label1";
            // 
            // receivedByteCountLabel
            // 
            this.receivedByteCountLabel.AutoSize = true;
            this.receivedByteCountLabel.Location = new System.Drawing.Point(23, 539);
            this.receivedByteCountLabel.Name = "receivedByteCountLabel";
            this.receivedByteCountLabel.Size = new System.Drawing.Size(38, 15);
            this.receivedByteCountLabel.TabIndex = 17;
            this.receivedByteCountLabel.Text = "label2";
            // 
            // Odbiornik
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 621);
            this.Controls.Add(this.receivedByteCountLabel);
            this.Controls.Add(this.transformedCountLabel);
            this.Controls.Add(this.closeReceiverButton);
            this.Controls.Add(this.convertBinaryButton);
            this.Controls.Add(this.clearTextBoxesButton);
            this.Controls.Add(this.asciiCountLabel);
            this.Controls.Add(this.receiverASCIITextBox);
            this.Controls.Add(this.receiverBinaryTextBox);
            this.Name = "Odbiornik";
            this.Text = "Odbiornik";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button clearTextBoxesButton;
        public Label asciiCountLabel;
        private TextBox receiverASCIITextBox;
        public TextBox receiverBinaryTextBox;
        private Button closeReceiverButton;
        private Button convertBinaryButton;
        private Label transformedCountLabel;
        private Label receivedByteCountLabel;
    }
}