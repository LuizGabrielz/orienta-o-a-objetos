using System;
using System.Collections.Generic;
using System.Text;

namespace Course.Entities {

    class Client {

        public string Name { get; set; }
        public string Email {get; set; }

        public override bool Equals(object obj) { //Estou comparando o cliente com esse cliente aqui
            if (!(obj is Client)) { //Se não for um objeto do tipo Client, ele vai retornar Falso, então eles não são iguais
                return false;
            }
            Client other = obj as Client; // Se o cliente for igual da True
            return Email.Equals(other.Email); // Quero comparar os dois clientes pelo Email, se forem iguais ele são clientes iguais

            }

            public override int GetHashCode() { // O HashCode do email vai ser pra mim o HashCode do cliente 
                return Email.GetHashCode();
            }
        }
    }