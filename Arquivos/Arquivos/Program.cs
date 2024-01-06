using System.IO;
using System;
//using System.Collections.Generic;

namespace Arquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            //string path = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\file1.txt";
            //FileStream fs = null;
            //StreamReader sr = null;

            //try
            //{
            //    sr = File.OpenText(path);
            //    while (!sr.EndOfStream)
            //    {
            //        string line = sr.ReadLine();
            //        Console.WriteLine(line);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}
            //finally
            //{
            //    if (sr != null) sr.Close();
            //    if (fs != null) fs.Close();
            //}

            //string path = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\file1.txt";

            //try
            //{
            //    using (StreamReader sr = File.OpenText(path))
            //    {
            //        while (!sr.EndOfStream)
            //        {
            //            string line = sr.ReadLine();
            //            Console.WriteLine(line);
            //        }
            //    }

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //string sourcePath = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\file1.txt";
            //string targetPath = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\file2.txt";

            //try
            //{
            //    string[] lines = File.ReadAllLines(sourcePath);

            //    using (StreamWriter sw = File.AppendText(targetPath))
            //    {
            //        foreach (string line in lines)
            //        {
            //            sw.WriteLine(line.ToUpper());
            //        }
            //    }

            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //string sourcePath = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\myfolder";

            //try
            //{
            //    /*IEnumerable<string>*/var folders = Directory.EnumerateDirectories(sourcePath, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FOLDERS: ");
            //    foreach (string s in folders)
            //    {
            //        Console.WriteLine(s);
            //    }
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            //try
            //{
            //    /*IEnumerable<string>*/
            //    var files = Directory.EnumerateFiles(sourcePath, "*.*", SearchOption.AllDirectories);
            //    Console.WriteLine("FILES: ");
            //    foreach (string s in files)
            //    {
            //        Console.WriteLine(s);
            //    }

            //    Directory.CreateDirectory(sourcePath + @"\newfolder");
            //}
            //catch (IOException e)
            //{
            //    Console.WriteLine("An error occurred");
            //    Console.WriteLine(e.Message);
            //}

            string path = @"C:\Users\alelo\OneDrive\Curso\Cursos\C#\file1.txt";

            Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            Console.WriteLine("PathSeparator: " + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());
        }
    }
}