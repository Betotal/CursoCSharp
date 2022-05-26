using System;
using System.IO;

namespace Exer_Fixacao_189 {
    class Program {
        static void Main(string[] args) {
            string fileData = @"D:\Meus Documentos\Cursos\Visual Studio\Arquivo\Entrada.csv";
            string Diretorio = Path.GetDirectoryName(fileData);
            string DiretorioOut = Directory.CreateDirectory(Diretorio + @"\out").ToString();
            string outFile = DiretorioOut + @"\Summary.csv";

            try {
                using (StreamReader SR = File.OpenText(fileData)) {
                    using (StreamWriter SW = File.AppendText(outFile)) {
                        while (!SR.EndOfStream) {
                            string[] line = SR.ReadLine().Split(";");

                            string Produto = line[0];
                            double Preco = double.Parse(line[1]);
                            int qtd = int.Parse(line[2]);

                            double precoOut = Preco * qtd;

                            string L = Produto + ";" + precoOut.ToString("F2");
                            SW.WriteLine(L);
                        }
                    }
                }
            }
            catch (IOException e) {
                Console.Write("Erro: " + e.Message);
                Console.ReadLine();
            }
        }
    }
}
