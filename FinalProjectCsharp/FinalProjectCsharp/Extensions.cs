using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;

namespace FinalProjectCsharp
{
    static class Extensions
    {

        public static string HashMe(this string password)
        {
            byte[] byteArray = new ASCIIEncoding().GetBytes(password);
            byte[] hashedArray = new SHA256Managed().ComputeHash(byteArray);
            string hashedPassword = new ASCIIEncoding().GetString(hashedArray);

            return hashedPassword;
        }
    }
}
