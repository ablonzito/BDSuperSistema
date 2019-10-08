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
    }
}
