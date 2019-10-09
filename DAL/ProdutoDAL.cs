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
        string connectionString = "Data Source=localhost;Initial Catalog=BDSuperSistema;User ID=sa;Password=Federal@123";
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

        public Produto BuscarProduto(int codigo)
        {
            Produto p = null;
            SqlConnection conn = new SqlConnection(connectionString);
            conn.Open();

            string sql = "SELECT * FROM Produtos WHERE Codigo = @c";

            SqlCommand cmd = new SqlCommand(sql, conn);
            //Passar parametro @c

            cmd.Parameters.AddWithValue("@c", codigo);
            // Ler os dados do banco
            SqlDataReader dr = cmd.ExecuteReader();

            //Verificar se no DataReader possui linhas (registros)
            if (dr.HasRows && dr.Read())
            {
                //Instanciar obj produto
                p = new Produto();
                p.Codigo = codigo;
                p.Descricao = dr["Descricao"].ToString();
                p.ValorUnitario = Convert.ToDecimal(dr["ValorUnitario"]);
                p.DtCadastro = Convert.ToDateTime(dr["DtCadastro"]);
            }
            //Nao esquecer de sempre fechar conexao com BD
            conn.Close();
            //Retornar produtos com os parametros inseridos
            return p;
        }

        public List<Produto> ListarProdutos()
        {
            //Instancio uma lista de objetos do tipo Produto
            //Com inicialização (construtor)
            List<Produto> listaProdutos = new List<Produto>();

            SqlConnection conn = new SqlConnection(connectionString);

            conn.Open();

            string sql = "SELECT * FROM Produtos";

            SqlCommand cmd = new SqlCommand(sql, conn);

            //Executar o comando ExecuteReader e jogar no intermediário
            //SqlDataReader
            SqlDataReader dr = cmd.ExecuteReader();

            //Verificar se no resultado existem linhas
            if (dr.HasRows)
            {
                //Criar uma variável do tipo Produto
                Produto objProduto;
                //Fazer um laço de repetição enquanto tiver linhas
                //para serem lidas
                //*Read() faz a leitura da próxima retornando "verdadeiro"
                //quando não tem mais linhas retorna "falso"
                while (dr.Read())
                {
                    //Importante instanciar dentro do laço (Para criar nova ref.
                    //na memória
                    objProduto = new Produto();
                    objProduto.Codigo = Convert.ToInt32(dr["Codigo"]);
                    objProduto.Descricao = dr["Descricao"].ToString();
                    objProduto.ValorUnitario = Convert.ToDecimal(dr["ValorUnitario"]);
                    objProduto.DtCadastro = Convert.ToDateTime(dr["DtCadastro"]);

                    listaProdutos.Add(objProduto);
                }
            }

            conn.Close();

            //Retornar a lista preenchida
            return listaProdutos;
        }
    }
}