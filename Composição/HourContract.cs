using System;

namespace Course.Entities
{
    class HourContract // Cria a classe e coloca tudo que vai estar dentro dela
    {
        
            public DateTime Date { get; set; }
            public double ValuePerHour { get; set; }
            public int Hours { get; set; }

            public HourContract () // Construtor padrão 
            {    
            }

            public HourContract(DateTime date, double valuePerHour, int hours) // Construtor
            {
                Date = date;
                ValuePerHour = valuePerHour;
                Hours = hours;
            }

            public double TotalValue() // Essa classe tem um método.É double pq o valor total é um double
            {   // Multiplica o valor horas por horas
                return Hours * ValuePerHour;
            }
        }
        
    }

    // Em orientação a objetos, um construtor padrão é um método especial que é chamado automaticamente quando uma nova instância de uma classe é criada. Ele é usado para inicializar os atributos da classe. Em algumas linguagens de programação, como Java e C#, se um construtor não é explicitamente definido, o compilador cria automaticamente um construtor padrão sem parâmetros. Em outras linguagens, como C++, é necessário definir explicitamente um construtor padrão se nenhum outro construtor é definido.