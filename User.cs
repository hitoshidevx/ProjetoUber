namespace ProjetoUber
{
    public class User
    {
        public string Nome { get; set; }
        private string login = "gabriel@gmail.com";
        private string senha = "12345678";
        public string Foto { get; set; }
        public string LocalizacaoAtual { get; set; }
        public string TokenLogin { get; set; }

        /// <summary>
        /// Login.false
        /// </summary>
        /// <param name="login"></param>
        /// <returns>O retorno depende do insert do usuário, caso esteja nas conformidades citadas acima, ele obtém acesso.</returns>
        public bool Login(string login, string senha){

            if(this.login == login && this.senha == senha){
                
                TokenLogin = "iquwqieiu823827uqwyiuq";
                return true;
            }

            return false;
        }
        /// <summary>
        /// Logout.
        /// Retorna o logout.
        /// </summary>
        public void Logout(){
            TokenLogin = "";
        }
        
    }
}