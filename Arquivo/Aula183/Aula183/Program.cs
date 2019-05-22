using System;
using System.IO;

namespace Aula183 {
    class Program {
        static void Main(string[] args) {
            string arqPath = @"D:\VisualStudio\MyFiles\File1.txt";

            try {
                //   aula 187
                //     var Folders = Directory.EnumerateDirectories(arqPath, "*.*", SearchOption.AllDirectories);
                //     Console.WriteLine("Pastas:");
                //     foreach(string f in Folders) {
                //         Console.WriteLine(f);
                //     }
                //     
                //     var Files = Directory.EnumerateFiles(arqPath, "*.*", SearchOption.AllDirectories);
                //     Console.WriteLine("Arquivos:");
                //     foreach (string f in Files) {
                //         Console.WriteLine(f);
                //     }
                //     
                //     Directory.CreateDirectory(arqPath + @"\Teste");
                Console.WriteLine("" + Path.DirectorySeparatorChar);
                Console.WriteLine("" + Path.PathSeparator);
                Console.WriteLine("" + Path.GetDirectoryName(arqPath));
                Console.WriteLine("" + Path.GetFileName(arqPath));
                Console.WriteLine("" + Path.GetExtension(arqPath));
                Console.WriteLine("" + Path.GetFileNameWithoutExtension(arqPath));
                Console.WriteLine("" + Path.GetFullPath(arqPath));
                Console.WriteLine("" + Path.GetTempPath());






            } catch (IOException e) {
                Console.Write("Algum erro ocorreu: ");
                Console.WriteLine(e.Message);
            }
        }
    }
}
