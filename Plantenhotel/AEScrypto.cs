using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;

namespace Plantenhotel
{

    class AEScrypto
    {
        public static string IV = "7w!z$C&F)J@NcRfU";                                                       //16 Willekeurige chars (128 bytes)
        public static string Key = "mYq3s6v9y$B&E)H@McQfTjWnZr4u7w!z";                                      //32 Willekeurige chars (256 bytes)

        public static string Encryptie(string decrypted)
        {
            byte[] textbytes = ASCIIEncoding.ASCII.GetBytes(decrypted);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            ICryptoTransform icrypto = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] enc = icrypto.TransformFinalBlock(textbytes, 0, textbytes.Length);
            icrypto.Dispose();

            return Convert.ToBase64String(enc);
        }
        private string Decryptie(string encrypted)
        {
            byte[] encryptiebytes = Convert.FromBase64String(encrypted);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.IV = ASCIIEncoding.ASCII.GetBytes(Key);
            aes.Key = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            ICryptoTransform icrypto = aes.CreateEncryptor(aes.Key, aes.IV);

            byte[] dec = icrypto.TransformFinalBlock(encryptiebytes, 0, encryptiebytes.Length);
            icrypto.Dispose();

            return ASCIIEncoding.ASCII.GetString(dec);
        }
    }
}
        