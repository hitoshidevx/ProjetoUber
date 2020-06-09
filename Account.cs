using System;
namespace ProjetoUber
{
    public class Conta
    {
        private string agencia { get; set; }
        private string conta { get; set; }

        public string Cadastrar(){
            return "Cadastrado com sucesso.";
        }
        public void Excluir(){
            Console.WriteLine ("Excluído com sucesso.");
        }
    }
}