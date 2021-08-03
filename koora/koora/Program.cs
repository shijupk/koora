using KooraLex;
using System;
using System.Collections.Generic;
using System.IO;
namespace koora
{
    class Program
    {
        static void Main(string[] args)
        {
            StreamReader inputFile;

            // if we passed in a filename, read code from that, else
            // read code from stdin
            if (args.Length > 0)
            {
                string path = args[0];
                try
                {
                    inputFile = new StreamReader(path);
                }
                catch (IOException)
                {
                    inputFile = new StreamReader(Console.OpenStandardInput(8192));
                }
            }
            else
            {
                inputFile = new StreamReader(Console.OpenStandardInput(8192));
            }

            string code = inputFile.ReadToEnd();

            // strip windows line endings out
            code = code.Replace("\r", "");

            LexicalScanner scanner = new LexicalScanner(code);
            List<Token> tokens = scanner.Scan();

            foreach (Token token in tokens)
            {
                Console.WriteLine(token.ToString());
            }
        }
    }
}

