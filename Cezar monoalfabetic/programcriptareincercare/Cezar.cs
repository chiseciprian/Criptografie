using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programcriptareincercare
{
    public class Cezar
    {
        public static void Criptare(string s, int key)
        {
            s = s.ToLower();
            string sol = "";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    if (s[i] <= 'z' - (char)key)
                        sol += (char)((int)s[i] + key);
                    else
                        sol += (char)((int)s[i] + key - 26);
                else
                    sol += s[i];
            Console.WriteLine(s + " ==> Criptare ==> " + sol);
            File.WriteAllText(@"../../CezarCriptat.txt", sol);
            Console.WriteLine();
        }
        public static void Decriptare(string s, int key)
        {
            s = s.ToLower();
            string sol = "";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    if (s[i] >= 'a' + (char)key)
                        sol += (char)((int)s[i] - key);
                    else
                        sol += (char)((int)s[i] - key + 26);
                else
                    sol += s[i];
            Console.WriteLine(s + " ==> Decriptare ==> " + sol);
            Console.WriteLine();
        }
    }
}
