using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace programcriptareincercare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("CEZAR ::");
            Console.WriteLine();
            TextReader load = new StreamReader(@"..\..\Cezar.txt");
            string CezarNecriptat = load.ReadLine();
            Cezar.Criptare(CezarNecriptat, 3);
            load = new StreamReader(@"..\..\CezarCriptat.txt");
            string CezarCriptat = load.ReadLine();
            Cezar.Decriptare(CezarCriptat, 3);


            Console.WriteLine("ROT13 ::");
            Console.WriteLine();
            ROT13.Crypt(CezarNecriptat);
            load = new StreamReader(@"..\..\ROT13.txt");
            string CriptatROT13 = load.ReadLine();
            ROT13.Decriptare(CriptatROT13);


            Console.WriteLine("Monoalfabetic :: ");
            Console.WriteLine();
            string key = SubstMono.Generate();
            SubstMono.Criptare(CezarNecriptat, key);
            load = new StreamReader(@"../../MonoalfabeticCriptat.txt");
            string Monoalfabetic = load.ReadLine();
            SubstMono.Decriptare(Monoalfabetic, key);
            
            Console.ReadKey();
        }
    }
}
