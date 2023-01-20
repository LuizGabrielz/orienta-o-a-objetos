namespace Course.Entities.Enums
{
     enum WorkerLevel : int // Vai derivar do tipo Int, por isso são valores numéricos
     // Se vc nomes seriam strings
    {
        Junior = 0,
        MidLevel = 1,
        Senior = 2
    }
}

// Em orientação a objetos, um enumerado (ou "enum") é um tipo de dados que permite definir uma lista de valores constantes. Ele é usado para representar um conjunto finito de opções, como dias da semana, cores, etc. Cada valor no enumerado é chamado de enumerador. Os enumeradores são geralmente representados como constantes inteiras, mas algumas linguagens de programação, como C# e Java, permitem que os enumeradores sejam representados como objetos.