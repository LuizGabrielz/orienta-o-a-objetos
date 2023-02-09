using System;

namespace Course // Chamado de Course pq no Programa principal ele é chamado de Course tb
{
     class PrintService 
    {
        private int[] _values = new int[10]; // Criar uma variável interna que poderá armazenar 10 números inteiros.
        private int _count = 0; // Criar uma variável interna tb para contar quantos inteiros eu ja adicionei. 
        // Vai começar com zero pq não adicionei nenhum ainda.
        public void AddValue(int value) { // Função que adiciona o valor que eu coloquei dentro do argumento dentro do meu vetor.
            if (_count == 10) { // Se o count for igual a 10 eu posso adicionar uma excessão
                throw new InvalidOperationException("PrintService is full"); // O meu printService está cheio, vc tentou adicionar alguem mas ja tinha 10
            }
            _values[_count] = value; // Vetor na posição count, recebendo esse valor
            _count++; //Esse count++ vai adicionar valor de 1 em 1.
        }

        public int First() { //Retornar o primeiro elemento PrintService
            if (_count == 0) {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
    }

        public void Print() { // Função responsável por imprimir na tela os valores armazenados no PrintService
            Console.Write("["); // Primeiro vou imprimir o abre colchetes
            for (int i = 0; i <_count -1; i++) { // Do primeiro elemento até o ultimo eu vou imprimir um número, uma virgula e um espaço
                Console.Write(_values[i] + ", ");
            }
            if (_count > 0) { //Para imprimir o ultimo valor sem a vírgula e o espaço na frente
                Console.Write(_values[_count -1]);
            }
            Console.WriteLine("]"); // Imprimindo o fecha colchetes
        }

    }
}