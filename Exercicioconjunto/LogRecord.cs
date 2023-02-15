using System;
 
namespace Course.Entities {

    class LogRecord {

        public string Username { get; set; } // Atributo Username da classe

        public DateTime Instant { get; set; } // Atributo Instant da classe

        public override int GetHashCode() // GetHashCode apenas do Username
        {
            return Username.GetHashCode();
        }

        public override bool Equals(object obj) { // Quando um registro de Log vai ser igual a outro objeto
                 if (!(obj is LogRecord)) { // Testar se o objeto é realmente do tipo LogRecord
                    return false; // Retorna falso logo de cara
                }
                LogRecord other = obj as LogRecord;
                return Username.Equals(other.Username); // Ele vai comparar um Username com outro pra ver se vai ser igual
            } 
        }
    } // Implemenação do nosso LogRecord