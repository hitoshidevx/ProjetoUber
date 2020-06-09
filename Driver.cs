namespace ProjetoUber
{
    public class Driver : User
    {
        private string Carro { get; set; }
        private string Placa { get; set; }

        public string AceitarPassageiro(){
            return "Passageiro aceito.";
        }
    }
}