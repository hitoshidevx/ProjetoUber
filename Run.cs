namespace ProjetoUber
{
    public class Run
    {
        public string localInicio { get; set; }
        public string localChegada { get; set; }
        public string statusCorrida { get; set; }
        public string motorista { get; set; }
        public string passageiro { get; set; }

        public string Cancelar(){
            return "A corrida foi cancelada pois os atributos que deviam ser preenchidos não foram completados corretamente.";
        }
    }
}