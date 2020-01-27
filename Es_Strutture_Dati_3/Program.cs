using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Es_Strutture_Dati_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Inserisci il nome del file sorgente");
            string s = $"{ Console.ReadLine() }";
            Console.WriteLine("Inserisci il nome del file di destinazione");
            string d = $"{ Console.ReadLine() }";
            if (File.Exists(s))
            {
                try
                {
                    using (StreamReader sr = new StreamReader(s))
                    {
                        using (StreamWriter sw = new StreamWriter(d))
                        {
                            string line;
                            while ((line = sr.ReadLine()) != null)
                            {
                                sw.WriteLine(line);
                            }
                        }
                    }
                }
                catch { }
            }
            else
            {
                Console.WriteLine("Manca il file sorgente!");
                Console.ReadLine();
            }
        }
    }
}
    

