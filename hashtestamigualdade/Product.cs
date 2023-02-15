namespace Course.Entities {

    class Product { // Classe tipo referencia
                    // Classe Product

        public string Name { get; set; }
        // Atributo Name 
        public double Price { get; set; }
        // Atributo Price 
        public Product(string name, double price) { // Construtor
            Name = name;
            Price = price;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() + Price.GetHashCode(); // Pegar o GetHashCode dos dois e somar
        }   // Muito provavelmente se eles forem iguais, eles vão bater 


        public override bool Equals(object obj) // Se for um objeto de outro tipo, vai dar falsa
        {
            if (!(obj is Product)) {
                return false;
            }
            Product other = obj as Product;
            return Name.Equals(other.Name) && Price.Equals(other.Price);
           // O nome tem que ser igual a outro nome e o preço tem que ser igual a outro preço
        }
    }
} 