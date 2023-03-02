using System.Globalization;

namespace Course {   
    class Produto { 

        public string Nome;
        public double Preco;
        public int Quantidade;

        public Produto(string nome, double preco, int quantidade) { // Construtor tem que ter o mesmo nome da classe
            Nome = nome; // Nome em maiusculo recebe o minusculos   
            Preco = preco; // Preco maiusculo recebe minusculo
            Quantidade = quantidade; // Quantidade maiusculo recebe quantidade minusculo
        }

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
                return Nome
                + ", $ "
                + Preco.ToString("F2", CultureInfo.InvariantCulture)
                + ", "
                + Quantidade
                + " unidades, Total: $ "
                + ValorTotalEmEstoque().ToString("F2", CultureInfo.InvariantCulture);
            }
        }
    }