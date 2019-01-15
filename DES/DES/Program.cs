using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CryptoUtilsConsole
{
    class Program
    {
        public enum Mode
        {
            ENCRYPT,
            DECRYPT
        };

        static void Main(string[] args)
        {
            string message =Console.ReadLine();
            var random = new Random();
            byte[] IV = new byte[8];
            random.NextBytes(IV);
            byte[] key = new byte[8];
            random.NextBytes(key);
            byte[] encrypted = DESCrypto(Mode.ENCRYPT, IV, key, Encoding.UTF8.GetBytes(message));
            Console.WriteLine("Encrypted Text :" + BitConverter.ToString(encrypted).Replace("-", ""));
            byte[] decrypted = DESCrypto(Mode.DECRYPT, IV, key, encrypted);
            Console.WriteLine("Decrypted Text :" + Encoding.UTF8.GetString(decrypted));
            Console.ReadLine();

        }

        static byte[] DESCrypto(Mode mode, byte[] IV, byte[] key, byte[] message)
        {

            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = IV;
                DES.Key = key;
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;


                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = null;

                    if (mode == Mode.ENCRYPT)
                        cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
                    else if (mode == Mode.DECRYPT)
                        cryptoStream = new CryptoStream(memStream, DES.CreateDecryptor(), CryptoStreamMode.Write);

                    if (cryptoStream == null)
                        return null;

                    cryptoStream.Write(message, 0, message.Length);
                    cryptoStream.FlushFinalBlock();
                    return memStream.ToArray();
                }
            }
        }
    }
}