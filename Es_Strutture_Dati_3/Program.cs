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
            string s = Console.ReadLine();
            Console.WriteLine("Inserisci il nome del file di destinazione");
            string d = Console.ReadLine();
            if (File.Exists(s))
            {
                using (StreamReader sr = new StreamReader("file.txt", Encoding.UTF8))
                {
                    string line;
                    while ((line = sr.ReadLine())!= null)
                    {
                        double n = double.Parse(line );
                    }
                }
                
            }
            if (File.Exists(d))
            {
                
            }
                
        }
    }
}
