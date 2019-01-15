using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programcriptareincercare
{
     public class SubstMono
    {
        public static void Criptare(string s, string key)
        {
            s = s.ToLower();
            string sol = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    sol += key[alphabet.IndexOf(s[i])];
                else
                    sol += s[i];
            Console.WriteLine(s + " ==> Criptare ==> " + sol);
            File.WriteAllText(@"../../MonoalfabeticCriptat.txt", sol);
            Console.WriteLine();
        }
        public static void Decriptare(string s, string key)
        {
            s = s.ToLower();
            string sol = "";
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    sol += alphabet[key.IndexOf(s[i])];
                else
                    sol += s[i];
            Console.WriteLine(s + " ->Decrypt-> " + sol);
            Console.WriteLine();
        }
        public static  string Generate()
        {
            string alphabet = "abcdefghijklmnopqrstuvwxyz";
            Random r = new Random();
            char[] shuffle = new char[alphabet.Length];
            for (int i = 0; i < alphabet.Length; i++)
                shuffle[i] = alphabet[i];
            for (int i = 0; i < shuffle.Length; i++)
            {
                char aux = shuffle[i];
                int aux2 = r.Next(26);
                shuffle[i] = shuffle[aux2];
                shuffle[aux2] = aux;
            }
            string sol = "";
            for (int i = 0; i < alphabet.Length; i++)
                sol += shuffle[i];
            Console.WriteLine("New Key generated: " + sol + "");
            Console.WriteLine();
            return sol;
        }
    }
}
