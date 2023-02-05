namespace Kabel232
{
    public partial class receiver : Form
    {
        public receiver()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void convertBinaryButton_Click(object sender, EventArgs e)
        {
            TextHandler.ASCIIConverter(ascii, receivedBinary, transformedCountLabel, asciiCountLabel, receivedByteCountLabel, receiverASCIITextBox);

        }

        private void closeReceiverButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clearTextBoxesButton_Click(object sender, EventArgs e)
        {
            this.receiverASCIITextBox.Clear();
            this.receiverBinaryTextBox.Clear();
        }
    }
}
