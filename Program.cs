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

            }else{
                Console.WriteLine("Acesso negado.");
            }


        }
    }
}
