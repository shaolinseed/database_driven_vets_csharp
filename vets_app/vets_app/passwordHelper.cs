using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace vets_app
{
    class passwordHelper
    {

        
        public string validatePassword(string password1, string password2)
        {
            //if password length is less than 8 characters
            if (password1.Length < 8)
            {
                return "Minumum password length of 8 characters long";
            }
            //if passwords are not equal
            if (password1 != password2)
            {
                return "Passwords do not match";
            }
            //if password does not contain a digit
            if (!password1.Any(char.IsDigit))
            {
                return "Password must contain a number";

            }
            //if password does not contain a letter
            if (password1.Any(char.IsLetter))
            {
                return "Password must contain a letter";
            }
            //if password does not contain an upper case letter
            if (password1.Any(char.IsUpper)){
                return "Password must contain an uppercase letter";
            }
            return "valid";
            
        }

        public string computeMd5Hash(string input)
        {
            //   MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();

            MD5 md5Hasher = MD5.Create();

            // Convert the input string to a byte array and compute the hash.
            byte[] data = md5Hasher.ComputeHash(Encoding.Default.GetBytes(input));

            // Create a new Stringbuilder to collect the bytes
            // and create a string.
            StringBuilder sBuilder = new StringBuilder();

            // Loop through each byte of the hashed data 
            // and format each one as a hexadecimal string.
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            // Return the hexadecimal string.
            return sBuilder.ToString();


        }
    }
}
