using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programcriptareincercare
{
    public class ROT13
    {
        public static void Crypt(string s)
        {
            s = s.ToLower();
            string sol = "";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    if (s[i] <= 'z' - (char)13)
                        sol += (char)((int)s[i] + 13);
                    else
                        sol += (char)((int)s[i] - 13);
                else
                    sol += s[i];
            Console.WriteLine(s + " ==> Criptare ==> " + sol);
            File.WriteAllText(@"../../ROT13.txt", sol);
            Console.WriteLine();
        }
        public static void Decriptare(string s)
        {
            s = s.ToLower();
            string sol = "";
            for (int i = 0; i < s.Length; i++)
                if (Char.IsLetter(s[i]))
                    if (s[i] <= 'z' - (char)13)
                        sol += (char)((int)s[i] + 13);
                    else
                        sol += (char)((int)s[i] - 13);
                else
                    sol += s[i];
            Console.WriteLine(s + " ==> Decriptare ==> " + sol);
            Console.WriteLine();
        }
    }
}
