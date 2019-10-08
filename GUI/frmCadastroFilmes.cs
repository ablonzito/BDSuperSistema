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
    public partial class frmCadastroFilmes : Form
    {
        public frmCadastroFilmes()
        {
            InitializeComponent();
        }

        private void Btn_Confirmar_Click(object sender, EventArgs e)
        {
            Filme objFilme = new Filme();
            objFilme.Nome = txt_nomeFilme.Text;
            objFilme.Diretor = txt_diretor.Text;
            objFilme.DtLancamento = dtpDtLancamento.Value;



            FilmeDAL fDAL = new FilmeDAL();
            fDAL.InserirFilme(objFilme);
            MessageBox.Show("Produto Inserido Com Sucesso!!!");
        }

        private void Btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
