namespace BertTlv
{
    public partial class Form1 : Form
    {
        Tlv tlv = new();
        public Form1()
        {
            InitializeComponent();
        }

        private void decodeBtn_Click(object sender, EventArgs e)
        {
           
            if (outputText.Text != null)
            {
                outputText.Text = tlv.TlvParser(inputText.Text.Replace(" ", ""));
            }

        }

        private void decToHexBtn_Click(object sender, EventArgs e)
        {
            if(hexText.Text != null)
            {
                decText.Text= int.Parse(hexText.Text, System.Globalization.NumberStyles.HexNumber).ToString();
            }
        }

        private void hexToDec_Click(object sender, EventArgs e)
        {
            if(decText.Text != null)
            {
                hexText.Text = int.Parse(decText.Text).ToString("x").ToUpper();
            }
        }
    }
}