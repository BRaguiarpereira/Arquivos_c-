using System;
using System.IO;
namespace ArquivosC
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"E:\C#\Projetos02\ArquivosC\file1.txt";
            string targetPath = @"E:\C#\Projetos02\ArquivosC\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);

                // Faz a copia do arquivo file1
                fileInfo.CopyTo(targetPath);

                //Ler todas as linhas do arquivo e guardar no vetor 
                string[] lines = File.ReadAllLines(sourcePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            } catch(IOException e)
            {
                Console.WriteLine("Erro ocorru !");
                Console.WriteLine(e.Message);
            }
        }
    }
}
