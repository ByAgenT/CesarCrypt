using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CesarCrypt
{
    public partial class Key : Form
    {
        public Key()
        {
            InitializeComponent();
        }

        private void AcceptButton_Click(object sender, EventArgs e)
        {
            String keyCrypt = KeyBox.Text;
            try
            {
                MainForm.CryptStep = (int.Parse(keyCrypt[0].ToString()) * 10) + int.Parse(keyCrypt[1].ToString());
                if (int.Parse(keyCrypt[2].ToString()) > 1)
                {
                    MessageBox.Show("Incorrect direction (Use only 1 or 0)");
                }
                if (keyCrypt[2] == '0')
                {
                    MainForm.Direction = false;
                }
                else
                {
                    MainForm.Direction = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error");
            }
            Close();
        }
    }
}
