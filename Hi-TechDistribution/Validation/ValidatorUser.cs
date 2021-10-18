using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hi_TechDistribution.Validation
{
    public static class ValidatorUser
    {
        public static bool IsValidId(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{5}$"))
            {

                MessageBox.Show("The UserId or Password you’ve entered doesn’t match any account", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;

        }
        public static bool IsValidPassword(string input)
        {
            string error = "The Password entered must only be Caracters and Spaces";
            if (input.Length == 0)
            {
                MessageBox.Show(error, "The UserId or Password you’ve entered doesn’t match any account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
                
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {

                    MessageBox.Show(error, "The UserId you’ve entered doesn’t match any account", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;

        }

    }
}
