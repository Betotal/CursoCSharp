using System.Globalization;
namespace Course {
    class Produto {
        /*  Programa Base  
        public string Nome;
        public double Preco;
        public int Quantidade;
        */

        /*   ENCAPSULAMENTO - Properties  */
        private string _nome;
        //   private double _preco; dispensável por conta auto Properties
        //   private int _quantidade; dispensável por conta auto Properties
        public double Preco { get; private set; }
        public int Quantidade { get; private set; }

        public Produto() { } // para permitir o uso do construtor padrão (sem argumentos)
        public Produto(string nome, double preco, int qtde) {
            _nome = nome;
            Preco = preco;
            Quantidade = qtde;
        }

        public string Nome {
            get { return _nome; }
            set {
                if (value != null && value.Length > 3) {
                    _nome = value;
                }
            }
        }

        /* dispensável por conta auto Properties
        public double Preco {
            get { return _preco; }
        }

        public int Quantidade {
            get { return _quantidade; }
        }*/
 
        /* Encapsulaamento
        public string GetNome() {
            return _nome;
        }

        public void SetNome(string N) {
            if (N != null && N.Length > 3) {
                _nome = N;
            }
        }

        public double GetPreco() {
            return _preco;
        }
        public int GetQtde() {
            return _quantidade;
        }   */


        /*    uso do this   
        public Produto() {
            Quantidade = 15; 
        }

        public Produto(string nome, double preco) : this() {
            Nome = nome;
            Preco = preco;
        }

        public Produto(string nome, double preco, int qtde) : this(nome, preco) {
            Quantidade = qtde;
        }

        /* Melhoria Construtor  
        public Produto(string nome, double preco, int qtde) {
            Nome = nome;
            Preco = preco;
            Quantidade = qtde;
        }

         Sobrecarga no Construtor  
        public Produto(string nome, double preco) {
            Nome = nome;
            Preco = preco;
            Quantidade = 5;  //Sendo zero não há necessidade, mas apenas para saber que é possível
        }*/

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }
        public void AdicionarProdutos(int quantidade) {
            Quantidade += quantidade;
        }
        public void RemoverProdutos(int quantidade) {
            Quantidade -= quantidade;
        }
        public override string ToString() {
            return _nome
            + ", $ "
            + Preco.ToString("F2", CultureInfo.InvariantCulture)
            + ", "
            + Quantidade
            + " unidades, Total: $ "
            + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
        }
    }
}