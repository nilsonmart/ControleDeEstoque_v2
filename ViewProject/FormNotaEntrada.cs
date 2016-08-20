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

        private NotaEntradaController controller;
        private FornecedorController fornecedorController;
        private ProdutoController produtoController;
        private NotaEntrada notaAtual;

        public FormNotaEntrada(NotaEntradaController controller, FornecedorController fornecedorController, 
            ProdutoController produtoController)
        {
            InitializeComponent();
            this.controller = controller;
            this.fornecedorController = fornecedorController;
            this.produtoController = produtoController;
            InicializaComboBoxs();
        }

        private void InicializaComboBoxs()
        {
            cbxFornecedor.Items.Clear();
            cbxProduto.Items.Clear();

            foreach(Fornecedor fornecedor in this.fornecedorController.GetAll())
            {
                //var fornecedorLegivel = Convert.ToString(fornecedor.Nome);
                cbxFornecedor.Items.Add(fornecedor.Nome);
            }

            foreach(Produto produto in this.produtoController.GetAll())
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


        //Botão Novo
        private void button1_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        //Método que limpa e atualiza os controles do formulário.
        private void ClearControlsNota()
        {
            dgvNotasEntrada.ClearSelection();
            dgvProdutos.ClearSelection();
            txtIDNotaEntrada.Text = string.Empty;
            cbxFornecedor.SelectedIndex = -1;
            txtNumero.Text = string.Empty;
            dtpEmissao.Value = DateTime.Now;
            dtpEntrada.Value = DateTime.Now;
            cbxFornecedor.Focus();
        }

        //Botão gravar.
        private void button2_Click(object sender, EventArgs e)
        {
            var notaEntrada = new NotaEntrada()
            {
                Id = (txtIDNotaEntrada.Text == string.Empty ? Guid.NewGuid() : new Guid(txtIDNotaEntrada.Text)),
                DataEmissao = dtpEmissao.Value,
                DataEntrada = dtpEntrada.Value,
                FornecedorNota = (Fornecedor)cbxFornecedor.SelectedItem,
                Numero = txtNumero.Text
            };

            notaEntrada = (txtIDNotaEntrada.Text == string.Empty ? this.controller.Insert(notaEntrada) :
                this.controller.Update(notaEntrada));
            AtualizaGridViewNotaEntrada();
            ClearControlsNota();
        }

        private void AtualizaGridViewNotaEntrada()
        {
            dgvNotasEntrada.DataSource = null;
            dgvNotasEntrada.DataSource = this.controller.GetAll();
        }

        //Botão cancelar
        private void button3_Click(object sender, EventArgs e)
        {
            ClearControlsNota();
        }

        //Botão remover
        private void button4_Click(object sender, EventArgs e)
        {
            if(txtIDNotaEntrada.Text == string.Empty)
            {
                MessageBox.Show("Selecione a NOTA a ser removida no GRID.");
            }
            else
            {
                this.controller.Remove(new NotaEntrada()
                {
                    Id = new Guid(txtIDNotaEntrada.Text)
                });
                AtualizaGridViewNotaEntrada();
                ClearControlsNota();
            }
        }

        //Carrega os dados no GridView.
        private void dgvNotasEntrada_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                this.notaAtual = this.controller.GetNotaEntradaById((Guid)dgvNotasEntrada.CurrentRow.Cells[0].Value);
                txtIDNotaEntrada.Text = notaAtual.Id.ToString();
                txtNumero.Text = notaAtual.Numero;
                cbxFornecedor.SelectedItem = notaAtual.FornecedorNota;
                dtpEmissao.Value = notaAtual.DataEmissao;
                dtpEntrada.Value = notaAtual.DataEntrada;
                UpdateProdutosGrid();
            }
            catch(Exception exception)
            {
                this.notaAtual = new NotaEntrada();
                
            }
        }

        private void UpdateProdutosGrid()
        {
            throw new NotImplementedException();
        }
    }
}
