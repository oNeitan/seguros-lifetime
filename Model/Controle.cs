using DataAccessLayer;

namespace Model
{
    public class Controle
    {
        public bool loginOK;
        public string mensagem = "";

        public bool acessar(string email, string senha)
        {
            ComandosBanco cmdLogin = new ComandosBanco();

            loginOK = cmdLogin.verificarLogin(email, senha);

            if (cmdLogin.mensagem.Equals(""))
            {
                this.mensagem = cmdLogin.mensagem;
            }

            return loginOK;
        }

    }
}


