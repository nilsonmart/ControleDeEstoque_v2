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
            this.controller.Insert(new Fornecedor()
            {
                Id = Guid.NewGuid(),
                Nome = txtNome.Text,
                CNPJ = txtCNPJ.Text
            });
        }

        private void FormFornecedor_Load(object sender, EventArgs e)
        {

        }
    }
}
