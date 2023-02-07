namespace Course.Devices {
    abstract class Device { // O device é uma classe abstrata 
        public int SerialNumber { get; set; } // Ele tem o serial Number 

        public abstract void ProcessDoc(string document); // Declaração do método ProcessDoc
    }
}