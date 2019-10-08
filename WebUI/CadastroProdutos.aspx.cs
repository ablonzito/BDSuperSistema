using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Models;
using DAL;

namespace WebUI
{
    public partial class CadastroProdutos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btn_inserir_Click(object sender, EventArgs e)
        {
            Produto objProduto = new Produto();
            objProduto.Descricao = txt_descricao.Text;
            objProduto.ValorUnitario = Convert.ToDecimal(txt_vlUnitario.Text);
            objProduto.DtCadastro = Convert.ToDateTime(txt_dtCadastro.Text);

            ProdutoDAL pDal = new ProdutoDAL();
            pDal.InserirProduto(objProduto);

            lbl_msg.Text = "Produto Cadastrado com sucesso!!";
        }

        protected void btn_excluir_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_Codigo.Text);

            ProdutoDAL pDal = new ProdutoDAL();
            pDal.ExcluirProduto(codigo);

            lbl_msg.Text = "Produto excluido com sucesso!";
        }

        protected void btn_atualizar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_Codigo.Text);
            Produto objProduto = new Produto();
            objProduto.Descricao = txt_descricao.Text;
            objProduto.ValorUnitario = Convert.ToDecimal(txt_vlUnitario.Text);
            objProduto.DtCadastro = Convert.ToDateTime(txt_dtCadastro.Text);

            ProdutoDAL pDal = new ProdutoDAL();
            pDal.AlterarProduto(objProduto, codigo);

            lbl_msg.Text = "Produto alterado com sucesso!!";

        }
    }
}