using System;

namespace Course.Entities.Enums
{
    enum OrderStatus : int // Tipo de dados que o enum vai receber 
    // enum é um tipo valor, não um tipo referencia. Ou seja, o vaor é int
    {
        PendingPayment = 0, // Valor do PendingPayment é zero
        Processing = 1, // Valor do Processing é 1
        Shipped = 2, // Valor do Shipped é 2
        Delivered = 3 // Valor do Delivered é 3
    }
}