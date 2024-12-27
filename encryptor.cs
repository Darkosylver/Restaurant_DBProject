using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace Restaurant_DB
{
    public class encryptor
    {
        public encryptor()
        {
            
        }
        public string HashText(string input)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(input);
                byte[] hashBytes = sha256.ComputeHash(inputBytes);
                //System.Windows.Forms.Clipboard.SetText(Convert.ToBase64String(hashBytes));
                return Convert.ToBase64String(hashBytes);
            }
        }
    }
};

