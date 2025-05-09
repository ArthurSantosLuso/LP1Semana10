using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace CharSets
{
    public class Program
    {
        private static void Main(string[] args)
        {

            HashSet<char> caracteres = new HashSet<char>();

            foreach (string nomeFicheiro in args)
            {
                using (StreamReader sr = new StreamReader(nomeFicheiro))
                {
                    string linha;
                    while ((linha = sr.ReadLine()) != null)
                    {

                        if (linha.Length != 1)
                        {
                            Console.Error.WriteLine("Erro");
                        }

                        caracteres.Add(linha[0]);
                    }
                }
            }

            List<char> ordenados = caracteres.ToList();
            ordenados.Sort();

            foreach (char c in ordenados)
            {
                Console.WriteLine(c);
            }
        }
    }
}
