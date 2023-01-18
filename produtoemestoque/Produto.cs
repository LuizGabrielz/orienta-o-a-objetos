using System.Globalization;

namespace Course
{
    public class Produto
    {
        public string Nome;
        public double Preco;
        public int Quantidade;

        public double ValorTotalEmEstoque() {
            return Preco * Quantidade;
        }

        public void AdicionarProdutos(int quantidade) { // quando vc coloca o padrão de uma variável, tem que iniciar com letra minuscula 
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
/* O que é uma ToString
Toda classe em C# é uma subclasse da classe Object

Object possui os seguintes métodos:
- GetType - retorna o tipo do objeto
- Equals - compara se o objeto é igual a outro
- GetHashCode - retorna um código hash do objeto
- ToString - Converte o objeto para string*/