using System;
namespace ProjetoUber
{
    public class Cartao
    {
        private string numero { get; set; }
        private string titular { get; set;}
        private string bandeira { get; set;}
        private string cvv { get; set; }

        public string Cadastrar(){
            return "Cadastrado com sucesso.";
        }
        public void Excluir(){
            Console.WriteLine ("Excluído com sucesso.");
        }
    }
}