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

                Console.WriteLine("Acesso liberado!\nO seu token é este: "+usuario.TokenLogin);
            
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

                Console.WriteLine ();

                if(localInicio != "" && localChegada != ""){
                    Console.WriteLine ("Qual o status da corrida? Digite i para ínicio, a para em andamento e c para concluída.\n ps: você só pode efetuar um pagamente após uma corrida ser concluida.");
                    string statusCorrida = Console.ReadLine();
                    
                    switch (statusCorrida){
                        case "i": 
                        Console.WriteLine("Você não pode efetuar o pagamento.");
                        break;
                        
                        case "a":
                        Console.WriteLine("Você ainda não pode efetuar o pagamento, deve esperar a corrida ser finalizada.");
                        break;

                        case "c":
                        Console.WriteLine("Você já pode efetuar o pagamento!");
                        break;

                        default:
                        Console.WriteLine ("O valor inserido é inválido.");
                        break;
                    }

                }else{
                    System.Console.WriteLine(corrida.Cancelar());
                }




            }else{
                Console.WriteLine("Acesso negado.");
            }


        }
    }
}
