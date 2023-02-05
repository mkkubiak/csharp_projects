namespace Kabel232
{
    public partial class emitter : Form
    {
        receiver odb = new receiver();

        public emitter()
        {
            InitializeComponent();
            odb.Show();
        }

        private void convertButton_Click(object sender, EventArgs e)
        {
            binaryString = TextHandler.AsciiToBinary(ascii, ASCIITextBox, label1, label2, BinaryTextBox);
            this.button1.Text = "done";
            if (binaryString == null) this.label2.Text = "null";
            else this.label2.Text = "notnull";


        }
        private void sendButton_Click(object sender, EventArgs e)
        {
            odb.receivedBinary = binaryString;
            TextHandler.printBoolString(binaryString, odb.receiverBinaryTextBox);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.BinaryTextBox.Clear();
            this.button1.Text = "Konwertuj\r\nASCII";
            this.ASCIITextBox.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
    }
}