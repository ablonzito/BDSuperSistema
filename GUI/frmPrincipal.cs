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

namespace GUI
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void ProdutosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroProdutos tela = new frmCadastroProdutos();
            tela.MdiParent = this;
            tela.Show();
        }

        private void FilmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCadastroFilmes tela = new frmCadastroFilmes();
            tela.MdiParent = this;
            tela.Show();
        }  
    }
}
