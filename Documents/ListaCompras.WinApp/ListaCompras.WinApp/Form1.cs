using ListaCompras.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using ListaCompra.Dominio;

namespace ListaCompras.WinApp
{
    public partial class Form1 : Form
    {

        private ProdutoDAO _produtoDao;

        public Form1()
        {
            _produtoDao = new ProdutoDAO();

            InitializeComponent();
        }

        private void ListBox_lista_compras_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

     

        private void Txt_nome_produto_TextChanged(object sender, EventArgs e)
        {

        }

        private void Btn_confirmar_teste_Click(object sender, EventArgs e)
        {

           
        }

        private void btnSalvarProduto_Click(object sender, EventArgs e)
        {
            Produto novoProduto = new Produto();

            novoProduto.Nome = Txt_nome_produto.Text;
            novoProduto.Preco = double.Parse(Txt_preco_produto.Text);
            novoProduto.Unidade = cmb_unidade_produto.Text;


            _produtoDao.AdicionarProduto(novoProduto);

            LimparCampos();

            var lista = _produtoDao.ListarProdutos();
            MessageBox.Show("Produto Salvo com sucesso!");
            listaProdutos.Items.Clear();
            foreach (var item in lista)
            {
                listaProdutos.Items.Add(item);
            }
        }
        private void LimparCampos() {

            Txt_nome_produto.Clear();
            Txt_preco_produto.Clear();
            cmb_unidade_produto.SelectedItem = -1;
        
        
        
        }
    }
}
