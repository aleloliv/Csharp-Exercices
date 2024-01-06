using System;
using System.IO;
using System.Collections.Generic;
using ExercicioArquivos.Entities;
using System.Xml;
using System.Globalization;

namespace ExercicioArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\ExercicioArquivos\myfolder\solditems.csv";

            try
            {
                List<Product> products = new List<Product>();
                using (StreamReader sr = File.OpenText(path))
                {
                    while (!sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        string[] splitlines = line.Split(',');
                        Product product = new Product(splitlines[0], double.Parse(splitlines[1], CultureInfo.InvariantCulture), int.Parse(splitlines[2]));
                        products.Add(product);
                    }
                }

                Directory.CreateDirectory(@"C:\Users\alelo\OneDrive\Curso\Cursos\C#\ExercicioArquivos\myfolder\out");
                string outputPath = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\ExercicioArquivos\myfolder\out\summary.csv";

                using (StreamWriter sw = File.AppendText(outputPath))
                {
                    foreach (Product product1 in products)
                    {
                        sw.WriteLine(product1);
                    }
                }
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
        }
    }
}