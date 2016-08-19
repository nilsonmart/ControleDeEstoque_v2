using ControllerProject;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ViewProject
{
    public partial class FormJanelaPrincipal : Form
    {
        //Instancia os Forms atraves do controller para independencia dos mesmos.
        private FornecedorController fornecedorController = new FornecedorController();
        private ProdutoController produtoController = new ProdutoController();
        private NotaEntradaController notaEntradacontroller = new NotaEntradaController();
        public FormJanelaPrincipal()
        {
            InitializeComponent();
        }

        private void JanelaPrincipal_Load(object sender, EventArgs e)
        {

        }

        //Método que chama Form do fornecedor
        private void fornecedorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormFornecedor(fornecedorController).ShowDialog();
        }

        //Método que chama Form do produto
        private void produtoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormProduto(produtoController).ShowDialog();
        }

        private void compraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new FormNotaEntrada(notaEntradacontroller, fornecedorController, produtoController).ShowDialog();
        }
    }
}
