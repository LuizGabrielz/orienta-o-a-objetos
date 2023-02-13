namespace Course.Services {

    class CalculationService {

        public T Max<T>(List<T> list) where T : IComparable { // Vou colocar que ele vai receber um valor do tipp T
            if (list.Count == 0) { // Se a quantidade de números na minha lista for igual a zero, quer dizer que a lista está vazia
                throw new ArgumentException("The list can not be empty"); // Lançar uma excessão mostrando que a lista esta vazia
            }

            T max = list[0]; // Salvei na variável o primeiro elemento da lista que esta na posição zero
            for (int i = 1; i < list.Count; i++) { // Vou varrer os elementos da posição 1 em diante
                if (list[i].CompareTo(max) > 0) { // Se o elemento da posição i for maior do que o máximo que eu salvei
                    max = list[i]; // Eu vou salvar no Max o elemento da posição i
                } // No final do for eu vou ter o maior elemento da posição "i"
            }
            return max; // E retorna
        }
    }
}