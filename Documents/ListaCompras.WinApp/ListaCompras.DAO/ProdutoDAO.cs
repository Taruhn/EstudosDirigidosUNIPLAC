using ListaCompra.Dominio;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListaCompras.DAO
{
    public class ProdutoDAO
    {
        public SqlConnection _conexao;
        private SqlCommand _comando;
        private SqlDataReader _leitor;
        public string _connectionString = @"Server=localhost;Database=ListaComprasDB;User Id=sa;Password=localhost;";

        public ProdutoDAO()
        {
            _conexao = new SqlConnection(_connectionString);
            _comando = new SqlCommand();


        }

        public void AdicionarProduto(Produto produto)
        {
            Abreconexao();


            _comando.Connection = _conexao;


            string sql = @" INSERT INTO [dbo].[TB_Protduto]
                                   ([Nome]
                                   ,[Preco]
                                   ,[Unidade]
                                   ,[Qnt_Mes])
                             VALUES
                                   (@Nome
                                   ,@preco
                                   ,@Unidade
                                   ,@Qnt_Mes)";
            _comando.Parameters.AddWithValue("@Nome", produto.Nome);
            _comando.Parameters.AddWithValue("@Preco", produto.Preco);
            _comando.Parameters.AddWithValue("@Unidade", produto.Unidade);
            _comando.Parameters.AddWithValue("@Qnt_Mes", produto.QuantidadeMes);

            _comando.CommandText = sql;

            _comando.ExecuteNonQuery();


            Fechaconexao();
        }

        public List<Produto> ListarProdutos()
        {
            List<Produto> listaProdutos = new List<Produto>();

            Abreconexao();

            _comando.Connection = _conexao;

            string sql = @"SELECT TOP (1000) [IdProduto]
                                            ,[Nome]
                                            ,[Preco]
                                            ,[Unidade]
                                            ,[Qnt_Mes]
                         FROM [ListaComprasDB].[dbo].[TB_Protduto]";
            _comando.CommandText = "";
            _comando.CommandText = sql;
            _leitor = _comando.ExecuteReader();

            while (_leitor.Read())
            {
                Produto produto = new Produto();

                produto.Nome = _leitor["Nome"].ToString();
                produto.Preco = double.Parse(_leitor["Preco"].ToString());
                produto.Unidade = _leitor["Unidade"].ToString();
                produto.QuantidadeMes = int.Parse(_leitor["Qnt_Mes"].ToString());

                listaProdutos.Add(produto);
            }

            Fechaconexao();


            return listaProdutos;
        }

        private void Abreconexao()
        {

            _conexao.Open();

        }
        private void Fechaconexao()
        {

            _conexao.Close();

        }
    }
}
