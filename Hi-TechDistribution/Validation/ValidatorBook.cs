using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Hi_TechDistribution.Validation
{
    public class ValidatorBook
    {
        public static bool IsValidIsbn(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{5}$"))
            {
                MessageBox.Show("Enter valid ISBN", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }

        public static bool IsValidName(string input)
        {
            string error = "Book Name must be of characters or Space(s) ";
            if (input.Length == 0)
            {
                MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            for (int i = 0; i < input.Length; i++)
            {
               
                if (!(Char.IsLetter(input[i])) && !(Char.IsWhiteSpace(input[i])))
                {

                    MessageBox.Show(error, "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }
            }
            return true;

        }
        public static bool IsValidUnitPrice(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{4}$"))
            {
                MessageBox.Show("Enter valid Unit Price", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
        public static bool IsValidQuantity(string input)
        {
            if (!Regex.IsMatch(input, @"^\d{6}$"))
            {
                MessageBox.Show("Enter valid ISBN", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }
            return true;
        }
    }
}
