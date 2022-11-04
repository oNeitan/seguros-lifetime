using DataAccessLayer;

namespace Model
{
    public class Controle
    {
        public bool AcessoOk;
        public string mensagem = "";

        public bool acessar(string email, string senha)
        {
            ComandosBanco cmdLogin = new ComandosBanco();

            AcessoOk = cmdLogin.verificarLogin(email, senha);

            if (cmdLogin.mensagem.Equals(""))
            {
                this.mensagem = cmdLogin.mensagem;
            }

            return AcessoOk;
        }

        public string cadastrar(string nome, string CPF, string email, string telefone, string senha, string confSenha)
        {
            AcessoOk = false;

            ComandosBanco cmdCad = new ComandosBanco();

            this.mensagem = cmdCad.cadastrar(nome, CPF, email, telefone, senha, confSenha);

            if (cmdCad.validacao)
            {
                this.AcessoOk = true;
            }

            return mensagem;
        }

    }
}


