using System.Text;

namespace Kabel232
{
    internal class TextHandler
    {
        private static bool[] binaryConverter(int dec, Label label)
        {
            int sumDec = 0;
            label.Text = "";
            bool[] binaryString = new bool[10];             //znak ASCII bedzie mial 7 bitow dlugosci, plus 3 bity daje 10 bitowa ramke
            sumDec += dec;
            binaryString[0] = false;//bit startu to logiczne 0
            binaryString[8] = true;//dwa bity stopu to logiczne 1
            binaryString[9] = true;
            for (int j = 1; j < 8; j++)
            {               
                binaryString[j] = (dec % 2 == 1) ? true : false;                
                dec /= 2;
            }
            return binaryString;
        }

        public static char[] ASCIIConverter(ASCIIEncoding ascii, bool[][] receivedBinary, Label label, Label label2, Label label3, TextBox textbox)
        {
            bool[] transformed = new bool[8];
            byte[] bajt = new byte[receivedBinary.Length];
            char[] asciiChar = new char[receivedBinary.Length];
            for(int i = 0;i<receivedBinary.Length;i++)
            {
                label2.Text = "";
                for (int j = 0; j < 7; j++)
                {
                    transformed[j] = receivedBinary[i][j+1];
                    label2.Text += transformed[j].ToString();
                }
                bajt[i] = (byte)byteConverter(transformed, label3);
                label.Text = bajt[i].ToString();

            }
            asciiChar = ascii.GetChars(bajt);
            
            //label2.Text = transformed.Length.ToString();
            //label3.Text = receivedBinary.Length.ToString();
            textbox.Text = new string(asciiChar);

            return asciiChar;
        }

        private static int byteConverter(bool[] boolString, Label label)
        {
            int value = 0;
            label.Text = boolString.Length.ToString();
            byte[] converted = Array.ConvertAll(boolString, value => value ? (byte)1 : (byte)0);
            for (int i = 0; i < boolString.Length; i++)
            {
                value += ((int)(Math.Pow(2,i)) * converted[i]);
                label.Text += converted[i].ToString();
            }  
            return value;
        }

        private static string reverse(string s)
        {
            string r = "";
            for (int i = s.Length; i > 0; i--) r += s[i - 1];
            return r;
        }


        public static void printBoolString(bool[][] binaryString, TextBox textbox)
        {
            string text = "";
            for (int i = 0; i < binaryString.Length; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    text += (binaryString[i][j] == true ? "1" : "0");
                }
            }
            //text = reverse(text);
            textbox.Text = text;
        }

        public static bool[][] AsciiToBinary(ASCIIEncoding ascii, TextBox textbox, Label label1, Label label2, TextBox textbox2)
        {
            string text = textbox.Text;
            int byteCount = ascii.GetByteCount(text);

            Byte[] bytes = new Byte[byteCount];
            bool[][] binaryString = new bool[byteCount][];

            bytes = ascii.GetBytes(text);
            int[] decarray = new int[byteCount];
            for (int i = 0; i < byteCount; i++)
            {
                //decarray[i] = (int)bytes[i];
                binaryString[i] = binaryConverter((int)bytes[i], label2);
            }
            printBoolString(binaryString, textbox2);
            label1.Text = binaryString.Length.ToString();
            return binaryString;
        }

    }
}
