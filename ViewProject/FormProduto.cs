﻿using ControllerProject;
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
    public partial class FormProduto : Form
    {

        private ProdutoController controller = new ProdutoController();
        public FormProduto(ProdutoController controller)
        {
            this.controller = controller;
            InitializeComponent();
        }
    }
}
