namespace Course
{
    public class Triangulo // Classe é a definição de um tipo
    {
        
        public double A;
        public double B;
        public double C;
        // Atributos que poderão ser acessados em outros arquivos
        public double Area() {
            double p = (A + B + C) / 2.0;
            return Math.Sqrt(p * (p - A) * (p- B) * (p - C));

        }
   
    }
} 
// Objeto: são instancias da classe, eles são classes particulares da minha classe
// Cada letra tem um dado e são chamados de atributos
// Public indica que o atributo ou método pode ser usado em outros arquivos
// Se o método não retorna nada, usa-se a palavra "void"
// Double é o tipo de dado que o método retorna
// using System = Importação de dependencias
// Namespace da classe 
// class = nome da classe
// Depois do public vem os atributos da classe 

/* Discursão
Quais são os beneficios de se calcular a área de um triangulo por meio de um MÉTODO dentro da CLASSE triangulo?

1) Reaproveitamento de código: nós eliminamos o código repetido (cálculo das áreas dos triangulos x e y) no programa principal

2) Delegação de responsabilidades: quem deve ser responsável por saber como calcular a área de um triangulo é o própio triangulo. A lógica do cálculo da área não deve estar em outro lugar.

*/