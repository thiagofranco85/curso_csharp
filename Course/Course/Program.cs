using System;
using System.IO;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {

            string path = @"C:\Users\Notebook\Documents\curso_csharp\Course\Course\myfolder";

            try
            {
                Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
            }
            catch (IOException e)
            {
                Console.WriteLine("An error occurred");
                Console.WriteLine(e.Message);
            }



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
