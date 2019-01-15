using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using Timer = System.Timers.Timer;
using System.Security.Cryptography;

namespace RSA
{
    public class RsaEnc
    {
        public static byte[] Encrypt(byte[] data,RSAParameters rsakey,bool doPadding)
        {
            try
            {
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(rsakey);
                    var endData = rsa.Encrypt(data, doPadding);
                    return endData;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return null;
            }
        }
        public static byte[] Decrypt(byte[] data , RSAParameters rsaKey,bool doPadding)
        {
            try
            {
                byte[] decryptData;
                using (RSACryptoServiceProvider rsa = new RSACryptoServiceProvider())
                {
                    rsa.ImportParameters(rsaKey);
                    decryptData = rsa.Decrypt(data, doPadding);
                    return decryptData;
                }

            }
            catch (Exception e)
            {

                Console.WriteLine(e.Message);
                return null;
            }
        }
    } 

    class Program
    {
        static void Main(string[] args)
        {
            Encoding encoding = new UTF8Encoding();
            RSACryptoServiceProvider rsa = new RSACryptoServiceProvider();

            byte[] plainText;
            byte[] cypherText;

            Console.WriteLine("Textul pentru criptare");
            var text = Console.ReadLine();
            if(!string.IsNullOrEmpty(text))
            {
                plainText = encoding.GetBytes(text);

                var rsaParam = rsa.ExportParameters(false);
                cypherText = RsaEnc.Encrypt(plainText, rsa.ExportParameters(false), false);
                var encryptedText = encoding.GetString(cypherText);
                Console.WriteLine("Text Criptat: "+encryptedText);

                Console.WriteLine("Enter pentru decriptare");
                Console.ReadLine();
                byte[] decryptedText = RsaEnc.Decrypt(cypherText, rsa.ExportParameters(true), false);
                Console.WriteLine("Text decriptat: "+encoding.GetString(decryptedText));
                Console.ReadLine();
            }
        }
    }
}
