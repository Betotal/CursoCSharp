using System;
using System.IO;
using System.Collections.Generic;
using Course_IComparable.Entities;

namespace Course_IComparable {
    class Program {
        static void Main(string[] args) {

            string path = @"D:\Meus Documentos\Cursos\Nomes.txt";
    //        string path = @"D:\Meus Documentos\Cursos\Funcionarios.txt";

            try {
                using (StreamReader sr = File.OpenText(path)) {
                    List<string> List = new List<string>();
     //               List<Funcionario> List = new List<Funcionario>();
                    while (!sr.EndOfStream) {
                        List.Add(sr.ReadLine());
     //                   List.Add(new Funcionario(sr.ReadLine()));
                    }
                    List.Sort();
                    foreach (string str in List) {
                    Console.WriteLine(str);
     //               foreach (Funcionario Func in List) {
     //                   Console.WriteLine(Func);
                    }
                }
            } catch (IOException e) {
                Console.WriteLine("Ocorreu um erro!");
                Console.WriteLine(e.Message);
            }

            Console.ReadLine();
        }
    }
}
