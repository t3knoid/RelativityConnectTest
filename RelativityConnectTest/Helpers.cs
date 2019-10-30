using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
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

        /// <summary>
        /// Encodes a given string and encyrpts it
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static string Encrypt(string strData)
        {
            return Convert.ToBase64String(Encrypt(Encoding.UTF8.GetBytes(strData)));
            // reference https://msdn.microsoft.com/en-us/library/ds4kkd55(v=vs.110).aspx
        }

        /// <summary>
        /// Decodes a given string decrypts it
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static string Decrypt(string strData)
        {
            return Encoding.UTF8.GetString(Decrypt(Convert.FromBase64String(strData)));
            // reference https://msdn.microsoft.com/en-us/library/system.convert.frombase64string(v=vs.110).aspx
        }
        /// <summary>
        /// Encrypts a set of bytes
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static byte[] Encrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(Global.strPermutation,
            new byte[] { Global.bytePermutation1,
                         Global.bytePermutation2,
                         Global.bytePermutation3,
                         Global.bytePermutation4
            });

            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateEncryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }

        /// <summary>
        /// Decrypts a given set of bytes
        /// </summary>
        /// <param name="strData"></param>
        /// <returns></returns>
        public static byte[] Decrypt(byte[] strData)
        {
            PasswordDeriveBytes passbytes =
            new PasswordDeriveBytes(Global.strPermutation,
            new byte[] { Global.bytePermutation1,
                         Global.bytePermutation2,
                         Global.bytePermutation3,
                         Global.bytePermutation4
            });

            MemoryStream memstream = new MemoryStream();
            Aes aes = new AesManaged();
            aes.Key = passbytes.GetBytes(aes.KeySize / 8);
            aes.IV = passbytes.GetBytes(aes.BlockSize / 8);

            CryptoStream cryptostream = new CryptoStream(memstream,
            aes.CreateDecryptor(), CryptoStreamMode.Write);
            cryptostream.Write(strData, 0, strData.Length);
            cryptostream.Close();
            return memstream.ToArray();
        }

    }
    public static class Global
    {
        public const String strPermutation = "ouiveyxaqtd";
        public const Int32 bytePermutation1 = 0x19;
        public const Int32 bytePermutation2 = 0x59;
        public const Int32 bytePermutation3 = 0x17;
        public const Int32 bytePermutation4 = 0x41;
    }
 

}
