using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Models;
using DAL;

namespace GUI
{
    public partial class frmCadastroProdutos : Form
    {
        public frmCadastroProdutos()
        {
            InitializeComponent();
        }

        public void LimparCampos()
        {
            txt_codigo.Text = string.Empty;
            txt_descricao.Text = string.Empty;
            txt_valorUnitario.Text = string.Empty;
            dtpDtCadastro.Value = DateTime.Now;
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Btn_Cadastrar_Click(object sender, EventArgs e)
        {
            Produto objProduto = new Produto();
            objProduto.Descricao = txt_descricao.Text;
            objProduto.ValorUnitario = Convert.ToDecimal(txt_valorUnitario.Text);
            objProduto.DtCadastro = dtpDtCadastro.Value;

            ProdutoDAL pDal = new ProdutoDAL();
            pDal.InserirProduto(objProduto);

            MessageBox.Show("Produto Inserido Com Sucesso!!!");
        }

        private void Btn_buscar_Click(object sender, EventArgs e)
        {
            int codigo = Convert.ToInt32(txt_codigo.Text);

            ProdutoDAL pDAL = new ProdutoDAL();
            Produto objProduto = pDAL.BuscarProduto(codigo);

            if (objProduto != null)
            {
                txt_descricao.Text = objProduto.Descricao;
                txt_valorUnitario.Text = objProduto.ValorUnitario.ToString();
                dtpDtCadastro.Value = objProduto.DtCadastro;
            }
            else
            {
                MessageBox.Show("Produto não foi encontrado!");
                LimparCampos();
            }

            pDAL.BuscarProduto(codigo);
        }
    }
}
