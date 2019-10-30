using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RelativityConnectTest
{
    public static class Helpers
    {
        public static string GetBase64Header(string username, string password)
        {
            string unencodedUsernameAndPassword = string.Format("{0}:{1}", username, password);
            byte[] unencodedBytes = ASCIIEncoding.ASCII.GetBytes(unencodedUsernameAndPassword);
            string base64UsernameAndPassword = string.Format("Basic {0}", System.Convert.ToBase64String(unencodedBytes));
            return base64UsernameAndPassword;
        }

    }
}
