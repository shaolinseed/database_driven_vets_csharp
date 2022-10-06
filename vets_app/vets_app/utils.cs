using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace vets_app
{
    static class utils
    {

        public static bool validatePassword(string password1, string password2)
        {
            if (password1 == password2)
            {
                return true;
            } else
            {
                return false;
            }
        }
        

        public static bool checkIfTextBoxEmpty(TextBox userInput)
        {
            if (userInput.Text == "")
            {
                return true;
            } else
            {
                return false;
            }
        }

        /// <summary>
        ///  method to convert a camelcase string to a human readable sentence 
        ///  eg. 
        ///  
        public static string RemoveFromEnd(string s, string suffix)
        {
            if (s.EndsWith(suffix))
            {
                return s.Substring(0, s.Length - suffix.Length);
            }
            else
            {
                return s;
            }
        }
        /// <summary>
        /// https://stackoverflow.com/questions/323314/best-way-to-convert-pascal-case-to-a-sentence
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>

        public static string ToSentenceCase(this string str)
        {
            return Regex.Replace(str, "[a-z][A-Z]", m => $"{m.Value[0]} {char.ToLower(m.Value[1])}");
        }

        public static string FirstLetterCapital(string str)
        {
            return Char.ToUpper(str[0]) + str.Remove(0, 1);
        }

    }
}
