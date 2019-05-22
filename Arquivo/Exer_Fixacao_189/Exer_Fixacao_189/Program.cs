using System;
using System.IO

namespace Exer_Fixacao_189 {
    class Program {
        static void Main(string[] args) {
            string fileData = @"D:\VisualStudio\MyFiles\Entrada.csv";
            string Diretorio = Path.GetDirectoryName(fileData);
            string DiretorioOut = Directory.CreateDirectory(Diretorio + @"\out").ToString();
            string outFile = File.Create(DiretorioOut + @"\Summary.csv").ToString();

            try {
                using (StreamReader SR = File.OpenText(fileData)) {
                    using (StreamWriter SW = File.AppendText(outFile)) {
                        while (!SR.EndOfStream) {
                            string[] line = SR.ReadLine().Split(",");

                            string Produto = line[01];
                            double Preco = double.Parse(line[02]);
                            int qtd = int.Parse(line[03]);

                            double precoOut = Preco * qtd;

                            SW.WriteLine(Produto + "," + precoOut.ToString());
                        }
                    }
                }
            }
            catch (IOException e) {
                Console.Write("Erro: " + e.Message);
            }

            using
            


            Console.WriteLine("Hello World!");
        }
    }
}
