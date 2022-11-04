using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace DataAccessLayer
{
    public class ComandosBanco
    {

        public bool validacao = false;
        public string mensagem = "";

        SqlCommand cmd = new SqlCommand();
        Conexao cnx = new Conexao();
        SqlDataReader dataR;
     

        string comandoLogin = "select email, senha from Pessoa where Email = @email and Senha = @senha";
        string comandoCadastro = "insert Pessoa (Nome,CPF,Email,Telefone,senha) values (@Nome,@CPF,@Email,@Telefone,@Senha)";

        public bool verificarLogin(string email, string senha)
        {
            cmd.CommandText = comandoLogin;

            cmd.Parameters.AddWithValue("@email", email);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = cnx.conectar();

                dataR = cmd.ExecuteReader();

                if (dataR.HasRows)
                {
                    validacao = true;
                }

                cnx.desconectar();

                dataR.Close();
            }
            catch(SqlException e)
            {
                this.mensagem = "Erro ao se conectar com o banco\n" + e;
            }


            return validacao;
        }

        public string cadastrar(string nome, string CPF, string email, string telefone, string senha, string confSenha)
        {
            validacao = false;


            if (senha.Equals(confSenha))
            {

                cmd.CommandText = comandoCadastro;

                cmd.Parameters.AddWithValue("@Nome", nome);
                cmd.Parameters.AddWithValue("@CPF", CPF);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Telefone", telefone);
                cmd.Parameters.AddWithValue("@Senha", senha);
       


                try
                {
                    cmd.Connection = cnx.conectar();

                    cmd.ExecuteNonQuery();

                    cnx.desconectar();

                    this.mensagem = "Cadastrado com sucesso!";

                    validacao = true;
                }
                catch (SqlException er)
                {
                    this.mensagem = "Erro ao se conectar com o banco\n" + er;
                }
            }
            else
            {
                this.mensagem = "As senhas digitadas não são iguais";
            }

            return mensagem;
        } 
    }
}
