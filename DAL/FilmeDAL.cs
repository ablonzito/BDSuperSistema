using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class FilmeDAL
    {
        public void InserirFilme(Filme objFilme)
        {
            string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\201180111\source\repos\SuperSistema\DAL\BDSuperSistema.mdf;Integrated Security=True";

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "INSERT INTO Filmes VALUES (@nome, @Diretor, @Data)";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@nome", objFilme.Nome);
            cmd.Parameters.AddWithValue("@Diretor", objFilme.Diretor);
            cmd.Parameters.AddWithValue("@Data", objFilme.DtLancamento);

            cmd.ExecuteNonQuery();

            conn.Close();

        }
    }
}
