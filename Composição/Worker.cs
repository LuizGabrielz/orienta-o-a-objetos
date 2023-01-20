using System.Collections.Generic; // namespace da classe List
using Course.Entities.Enums; // vai usar o namespace do enum pra conseguir pegar o valor

namespace Course.Entities
{
     class Worker
    {
            public string Name {get; set; } // Tudo que tem na classe worker
            public WorkerLevel Level {get; set; }
            public double BaseSalary { get; set; }
            public Department Department { get; set; } // É asism que a gente faz uma assosiações entre duas classes diferentes
            public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Colocamos uma lista pq o trabalhador tem varios contratos, e estamos pegando o nome Contracts da regra das tabelas
            // O trabalhador tem vários contratos, por isso criamos uma lista. new List para instanciar a lista para garantir que ela não seja nula
            public Worker () // Consutor vazio
            {
            }

            public Worker(string name, WorkerLevel level, double baseSalary, Department department) // Consutor com argumentos
            // Recebendo só esses dados.
            {
                Name = name;
                Level = level;
                BaseSalary = baseSalary;
                Department = department;
            } // Não colocamos a lista pq não é usual vc passar uma lista instanciado a um consutor do objeto. Essa lista vai começar vazia depois vou adicionando os objetos conforme minha nescessicade. Então via de regra, sempre que tiver uma formação para muitos vc não vai adicionar ela  
            // Então o consutor ele ta recebendo apenas esses quatro dados
            public void AddContract(HourContract contract) // void pq ele não retorna nenhum valor, se retornasse ia ser algum tipo.
            {
                Contracts.Add(contract); // Esse método vai receber o HourContract
            } // Ele vai receber um contrato como parametro de entrada e ele vai adicionar esse contrato como parametro de entrada dentro da lista contrato do trabalhador
            // Adiconar itens na lista contract
            public void RemoveContract(HourContract contract) 
            {   // Método para remover o contrato do trabalhador, através da lista tambem
                Contracts.Remove(contract);
            }
            // Muito utilizado quando a gente faz assosiação de objetos
            // Se vc tem uma lista, vc vai adicionar um add ou remove

            public double Income(int year, int month) // Métodos. Income siginifica ganho, quanto o trabalhador vai ganhar 
            { // Quanto ele ganhou em um dado ano e um dado mes
                double sum = BaseSalary;
                foreach (HourContract contract in Contracts)
                {
                    if (contract.Date.Year == year && contract.Date.Month == month)
                    {
                        sum += contract.TotalValue();
                    }
                }
                return sum;
            }
    }
}