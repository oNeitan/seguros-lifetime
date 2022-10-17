using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class Conexao
    {
        SqlConnection cnx = new SqlConnection();

        public Conexao()
        {
            cnx.ConnectionString = @"Data Source=.;Initial Catalog=Teste;Integrated Security=True";
        }

        public SqlConnection conectar()
        {
            if (cnx.State == System.Data.ConnectionState.Closed)
            {
                cnx.Open();
            }

            return cnx;
        }

        public void desconectar()
        {
            if (cnx.State == System.Data.ConnectionState.Open)
            {
                cnx.Close();
            }
        }
    }
}