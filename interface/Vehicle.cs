namespace Course.Entities
{
    class Vehicle
    {
        public string Model {get; set; } // Opcional mas vou colocar pq tenho uma preferencia de implementar o construtor pra forçar a instanciação do jeito que eu preciso

        public Vehicle(string model) {
            Model = model;
        }
    }
}