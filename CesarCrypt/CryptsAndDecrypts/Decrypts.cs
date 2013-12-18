using System;
using System.Text;

namespace CesarCrypt.CryptsAndDecrypts
{
    public class Decrypts
    {
        public StringBuilder CesarCrypt(String input, int decryptStep, bool direction)
        {
            StringBuilder decryptMsg = new StringBuilder();
            foreach (char c in input)
            {
                if (direction)
                {
                    decryptMsg.Append(Convert.ToChar(c - decryptStep));   
                }
                else
                {
                    decryptMsg.Append(Convert.ToChar(c + decryptStep));
                }
                
            }
            return decryptMsg;
        }
    }
}
