using System;
using System.Globalization;

namespace Course.Entities {

    class Product : IComparable {

        public string Name { get; set; }

        public double Price { get; set; }

        public Product(string name, double price) {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name
                + ", "
                + Price.ToString("F2", CultureInfo.InvariantCulture);
        }

        public int CompareTo(object obj) { // Métodos para incrementar
            if (!(obj is Product)) { // Testar se esse objeto é um objeto da classe Product
                throw new ArgumentException("Comparing erro: argument is not a Product");
            } // Se passar desse if com certeza vai ser produto
            Product other = obj as Product;
            return Price.CompareTo(other.Price); // Comparar o preço do produto com o other 
        }
    }
}