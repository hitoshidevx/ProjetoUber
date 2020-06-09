using System;

namespace ProjetoUber
{
    class Program
    {
        static void Main(string[] args)
        {
            User usuario = new User();

            System.Console.WriteLine("Digite o seu email de login: ");
            string login = Console.ReadLine();

            System.Console.WriteLine("Digite a sua senha: ");
            string senha = Console.ReadLine();

            usuario.Login(login, senha);

            if(usuario.TokenLogin != "" && usuario.TokenLogin != null){

                Console.WriteLine("Acesso liberado!");
                Console.WriteLine("Seu token de login é este: "+usuario.TokenLogin);

                Console.WriteLine ();

                Console.WriteLine("O que deseja fazer? ");
                
                Console.WriteLine ();

                Passenger passageiro = new Passenger();
                System.Console.WriteLine(passageiro.SolicitarMotorista());

                Console.WriteLine ();
                
                System.Console.WriteLine("Corrida aceita pelo motorista!");

                Console.WriteLine ();

                Run corrida = new Run();
                System.Console.WriteLine("Digite o local de ínicio: ");
                string localInicio = Console.ReadLine();

                Console.WriteLine ();

                System.Console.WriteLine("Digite o local de chegada: ");
                string localChegada = Console.ReadLine();

                if(localInicio != "" && localChegada != ""){
                    Console.WriteLine ("Qual o status da corrida? ");
                    string statusCorrida = Console.ReadLine();

                }else{
                    System.Console.WriteLine(corrida.Cancelar());
                }




            }else{
                Console.WriteLine("Acesso negado.");
            }


        }
    }
}
