using System;
using System.Text;

namespace CesarCrypt.CryptsAndDecrypts
{
    public class Crypts
    {
        public StringBuilder CesarCrypt(String input, int cryptStep, bool direction)
        {
            StringBuilder resultStringBuilder = new StringBuilder();
            foreach (char element in input)
            {
                if (direction)
                {
                    resultStringBuilder.Append(Convert.ToChar(element + cryptStep)); 
                }
                else
                {
                    resultStringBuilder.Append(Convert.ToChar(element - cryptStep));
                }
            }
            return resultStringBuilder;
        }
    }
}
