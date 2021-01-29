using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Security.Cryptography;
using System.IO;

namespace Plantenhotel
{
    // Encryptie & Decryptie met Advanced Encryption Standard
    class AEScrypto
    {
        //16 willekeurig gegenereerde chars (128 bits)
        public static string IV = "7w!z$C&F)J@NcRfU";
        //32 willekeurig gegenereerde chars (256 bits)
        public static string Key = "mYq3s6v9y$B&E)H@McQfTjWnZr4u7w!z";

        /// <summary>
        /// Klasse die gebruikersnaam en wachtwoord encrypteert
        /// </summary>
        /// <param name="decrypted">ongeëncrypteerde gebruikersnaam en wachtwoord</param>
        /// <returns>zet de array terug om naar een string</returns>
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
        /// <summary>
        /// Klasse die gebruikersnaam en wachtwoord decrypteert
        /// </summary>
        /// <param name="encrypted">geëncrypteerde gebruikersnaam en wachtwoord</param>
        /// <returns></returns>
        public static string Decryptie(string encrypted)
        {
            byte[] encryptiebytes = Convert.FromBase64String(encrypted);

            AesCryptoServiceProvider aes = new AesCryptoServiceProvider();
            aes.BlockSize = 128;
            aes.KeySize = 256;
            aes.IV = ASCIIEncoding.ASCII.GetBytes(IV);
            aes.Key = ASCIIEncoding.ASCII.GetBytes(Key);
            aes.Mode = CipherMode.CBC;
            aes.Padding = PaddingMode.PKCS7;

            ICryptoTransform icrypto = aes.CreateDecryptor(aes.Key, aes.IV);
             
            byte[] dec = icrypto.TransformFinalBlock(encryptiebytes, 0, encryptiebytes.Length);
            icrypto.Dispose();

            return ASCIIEncoding.ASCII.GetString(dec);
        }
    }
}
        