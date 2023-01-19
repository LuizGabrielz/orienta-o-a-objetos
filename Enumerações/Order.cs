using System;
using Course.Entities.Enums;

namespace Course.Entities
{
     class Order
    {

        public int Id {get; set; } // Pega o Id int do programa principal
        public DateTime Moment { get; set; } // Pega o DateTime do programa principal    
        public OrderStatus Status { get; set; } // Pega o OrderStstus do programa principal
        // valor status é uma enumeração, onde cada valor dessa enumeração vai ser do tipo inteiro
        public override string ToString()
        {
            return Id
            + ", "
            + Moment
            + ", "
            + Status;
        }
    }
}