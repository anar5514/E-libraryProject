using ELibraryProject.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ELibraryProject.Security
{
    public class Helper
    {
        public string GetHashPassword (string password)
        {
            var data = Encoding.ASCII.GetBytes(password);
            var sha1 = new SHA1CryptoServiceProvider();
            var sha1data = sha1.ComputeHash(data);
            var asci = new ASCIIEncoding();
            var result = asci.GetString(sha1data);

            return result;
        }
    }
}
