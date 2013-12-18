using System;
using System.Windows.Forms;
using CesarCrypt.CryptsAndDecrypts;

namespace CesarCrypt
{
    public partial class MainForm : Form
    {
        public static int CryptStep = 13;
        public static bool Direction = true;
        public MainForm()
        {
            InitializeComponent();
        }

        private void CryptButton_Click(object sender, EventArgs e)
        {
            Crypts crypts = new Crypts();
            String msg = InputTextBox.Text;
            OutputTextBox.Text = crypts.CesarCrypt(msg, CryptStep, Direction).ToString();
        }

        private void DecryptButton_Click(object sender, EventArgs e)
        {
            Decrypts decrypts = new Decrypts();
            String msg = InputTextBox.Text;
            OutputTextBox.Text = decrypts.CesarCrypt(msg, CryptStep, Direction).ToString();
        }

        private void AdvancedButton_Click(object sender, EventArgs e)
        {
            new Key().Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            new Key().Show();
        }
    }
}
