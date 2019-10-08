using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Models;
using System.Data.SqlClient;

namespace DAL
{
    public class ProdutoDAL
    {
        //Conexão com o SqlServer ( dados de Login )
        string connectionString = "Data Source=localhost;Initial Catalog=BDSuperSistema;User ID=**;Password=**";
        public void InserirProduto(Produto objProduto)
        {
           

            //Instanciar um objeto do tipo SqlConnection (conexão)
            //Passar a string de conexão na contrução
            SqlConnection conn = new SqlConnection(connectionString);

            //Abrir a conexão (contato com o banco de dados)
            conn.Open();

            //Escrever o comando SQL a ser execultado
            string sql = "INSERT INTO Produtos VALUES (@desc, @valor, @data)";

            //Instanciar um obj do tipo SqlCommando (Comando do SQL em si)
            //Pssar o texto do comando , e a conexão na construção
            SqlCommand cmd = new SqlCommand(sql, conn);

            //Trocar os parametros @@
            cmd.Parameters.AddWithValue("@desc", objProduto.Descricao);
            cmd.Parameters.AddWithValue("@valor", objProduto.ValorUnitario);
            cmd.Parameters.AddWithValue("@data", objProduto.DtCadastro);

            //Mandar execultar o programa no servidor
            //NonQuery - Não Retorna Valor (Caso do Insert, update, delete)
            cmd.ExecuteNonQuery();

            //Fechar Conexão (Evitar sobrecarga)
            conn.Close();
        }
        public void AlterarProduto(Produto objProduto, int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "UPDATE Produtos SET Descricao=@desc, VlUnitario=@valor, DtCadastro=@data WHERE Codigo = @c";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@desc", objProduto.Descricao);
            cmd.Parameters.AddWithValue("@valor", objProduto.ValorUnitario);
            cmd.Parameters.AddWithValue("@data", objProduto.DtCadastro);
            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();
            conn.Close();
        }

        public void ExcluirProduto(int codigo)
        {
            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "DELETE FROM Produtos WHERE Codigo = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@c", codigo);

            cmd.ExecuteNonQuery();

            conn.Close();
        }

        
    }
}
