using System;
using System.Windows.Forms;
using ControllerProject;
using ModelProject;

namespace ViewProject
{
    public partial class FormFornecedor : Form
    {
        private FornecedorController controller = new FornecedorController();
        public FormFornecedor()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }


        //Botão gravar
        private void button2_Click(object sender, EventArgs e)
        {
            var fornecedor = new Fornecedor()
            {
                Id = (txtId.Text == string.Empty ? Guid.NewGuid() : new Guid(txtId.Text)),
                Nome = txtNome.Text,
                CNPJ = txtCNPJ.Text
            };
            fornecedor = (txtId.Text == string.Empty ? this.controller.Insert(fornecedor) :
                this.controller.Update(fornecedor));
            dgvFornecedores.DataSource = null;
            dgvFornecedores.DataSource = this.controller.GetAll();
            ClearControls();
        }

        //Método que limpa seleção do gridview e dos controles
        private void ClearControls()
        {
            dgvFornecedores.ClearSelection();
            txtId.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtCNPJ.Text = string.Empty;
            txtNome.Focus();
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {

        }

        //Botão Novo
        private void button1_Click(object sender, EventArgs e)
        {
            ClearControls();
        }

        private void dgvFornecedores_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvFornecedores.CurrentRow.Cells[0].Value.ToString();
            txtNome.Text = dgvFornecedores.CurrentRow.Cells[1].Value.ToString();
            txtCNPJ.Text = dgvFornecedores.CurrentRow.Cells[2].Value.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtId.Text == string.Empty)
            {
                MessageBox.Show("Selecione o FORNECEDOR a ser removido no GRID");
            }
            else
            {
                this.controller.Remove(new Fornecedor()
                {
                    Id = new Guid(txtId.Text)
                });
                dgvFornecedores.DataSource = null;
                dgvFornecedores.DataSource = this.controller.GetAll();
                ClearControls();
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ClearControls();
        }
    }
}
