using ControllerProject;
using ModelProject;
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
    public partial class FormNotaEntrada : Form
    {

        private NotaEntradaController notaEntradacontroller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;
        private NotaEntrada notaAtual;

        public FormNotaEntrada(NotaEntradaController notaEntradacontroller, FornecedorController fornecedorController, 
            ProdutoController produtoController)
        {
            InitializeComponent();
            this.notaEntradacontroller = notaEntradacontroller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicializaComboBoxs();
        }

        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();

            foreach(var fornecedor in this.fornecedorController.GetAll())
            {
                cbxFornecedor.Items.Add(fornecedor);
            }

            foreach(var produto in this.produtoController.GetAll())
            {
                cbxProduto.Items.Add(produto);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormNotaEntrada_Load(object sender, EventArgs e)
        {

        }
    }
}
