using System;
using System.IO;
using System.Collections.Generic;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = "/home/thiago/curso_csharp/Course/Course/myfolder/file1.txt";

            System.Console.WriteLine( "DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
            System.Console.WriteLine("PathSeparator:" + Path.PathSeparator);
            Console.WriteLine("GetDirectoryName; " + Path.GetDirectoryName(path));

            Console.WriteLine("GetFileName: " + Path.GetFileName(path));
            Console.WriteLine("GetExtension: " + Path.GetExtension(path));
            Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
            Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
            Console.WriteLine("GetTempPath: " + Path.GetTempPath());

            /*
            string path = "/home/thiago/curso_csharp/Course/Course/myfolder";
 

            try
            {
                var folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FOLDERS:");
                foreach (string s in folders) {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("FILES:");
                foreach (string s in files) {
                    Console.WriteLine(s);
                }

                Directory.CreateDirectory(path + "/newfolder");
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }
            */


            /*
            string sourcePath = @"C:\Users\Notebook\Documents\curso_csharp\Course\Course\file1.txt";
            string targetPath = @"C:\Users\Notebook\Documents\curso_csharp\Course\Course\file2.txt";

            try
            {
                string[] lines = File.ReadAllLines(sourcePath);

                using (StreamWriter sw = File.AppendText(targetPath))

                    foreach (string line in lines)
                    {
                        sw.WriteLine(line.ToUpper());
                    }
            }
            catch
            {

            }
            */

            /*
            string path = @"C:\Users\Notebook\Documents\curso_csharp\Course\Course\file1.txt";

            using (FileStream fs = new FileStream(path, FileMode.Open))
            {
                using( StreamReader sr = new StreamReader(fs) )
                {
                    while (! sr.EndOfStream)
                    {
                        string line = sr.ReadLine();
                        Console.WriteLine(line);
                
                    }
                }
            }
            */


            /*
            string path = @"C:\Users\Notebook\Documents\curso_csharp\Course\Course\file1.txt";

            FileStream fs = null;
            StreamReader sr = null;

            try
            {
                sr = File.OpenText(path);
                while (!sr.EndOfStream)
                {
                    string line = sr.ReadLine();
                    Console.WriteLine(line);
                }
            }
            catch(IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            } 

            Console.ReadLine();
            */




            /*
            string sourcePath = @"C:\Users\Notebook\Documents\curso_csharp\Course\Course\file1.txt";
            string targetPath = @"C:\Users\Notebook\Documents\curso_csharp\Course\Course\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);

                string[] lines = File.ReadAllLines(sourcePath);

                foreach( string line in lines)
                {
                    Console.WriteLine(line);
                    
                }
            }
            catch (IOException e)
            {               
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();

    */


        }
    }
}
