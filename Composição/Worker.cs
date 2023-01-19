using System.Collections.Generic;
using Course.Entities.Enums;

namespace Course.Entities
{
     class Worker
    {
            public string Name {get; set; }
            public WorkerLevel Level {get; set; }
            public double BaseSalary { get; set; }
            public Departament Departament { get; set; } // É asism que a gente faz uma assosiações entre duas classes diferentes
            public List<HourContract> Contracts { get; set; } = new List<HourContract>(); // Colocamos uma lista pq o trabalhador tem varios contratos, e estamos pegando o nome Contracts da regra das tabelas

            public Worker () // Consutor vazio
            {
            }

            public Worker(string name, WorkerLevel level, double baseSalary, Department department)
            // Recebendo só esses dados.
            {
                Name = name;
                Level = level;
                BaseSalary = baseSalary;
                Department = department;
            }

            public void AddContract(HourContract contract)
            {
                Contracts.Add(contract);
            }

            public void RemoveContract(HourContract contract)
            {
                Contracts.Remove(contract);
            }
            // Muito utilizado quando a gente faz assosiação de objetos
            // Se vc tem uma lista, vc vai adicionar um add ou remove

            public double Income(int year, int month) // Métodos
            {
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